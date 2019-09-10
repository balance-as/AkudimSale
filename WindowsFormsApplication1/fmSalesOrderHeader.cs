using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    using WSSalesOrderHeader;
    using WSSalesOrderLine;
    using WSSalesCommentLines;
    using WarehouseService;
    using WSShipMethodCodes;

    public partial class fmSalesOrderHeader : Form
    {
        private SalesOrderHeader newOrder;
        private string orderno = "";
        private string customerno = "";
        private bool isneworder = false;
        private SalesOrderLine[] LineResult = null;
        private DataTable dtItems = new DataTable();
        private DataTable dtSearchItems = new DataTable();

        public fmSalesOrderHeader()
        {
            InitializeComponent();
        }

        public fmSalesOrderHeader(string OrderNo)
        {
            InitializeComponent();
            orderno = OrderNo;
        }

        public fmSalesOrderHeader(string CustomerNo, bool b_NewOrder)
        {
            InitializeComponent();
            customerno = CustomerNo;
            isneworder = b_NewOrder;
            if (b_NewOrder)
            {
                CreateNewOrder(customerno);    
            }
        }

        public fmSalesOrderHeader(string OrderNo, DataTable datatableitems, DataTable datasearchitems)
        {
            InitializeComponent();
            orderno = OrderNo;
            dtItems = datatableitems;
            dtSearchItems = datasearchitems;

        }

        public fmSalesOrderHeader(string CustomerNo, bool b_NewOrder, DataTable datatableitems, DataTable datasearchitems)
        {
            InitializeComponent();
            customerno = CustomerNo;
            isneworder = b_NewOrder;
            dtItems = datatableitems;
            dtSearchItems = datasearchitems;

            if (b_NewOrder)
            {
                CreateNewOrder(customerno);    
            }
        }

        public void GetSaletOrderHeaderData()
        {
            // Create Service Reference 
            var service = new SalesOrderHeader_Service();
            service.UseDefaultCredentials = true;

            // Create the Order header 
            newOrder = new SalesOrderHeader();
            newOrder = service.Read(orderno);

            orderno = newOrder.No;
            tbName.Text = newOrder.Sell_to_Customer_No;
            tbName2.Text = newOrder.Sell_to_Customer_Name;
            tbAddress.Text = newOrder.Sell_to_Address;
            tbAddress2.Text = newOrder.Sell_to_Address_2;
            tbPostCode.Text = newOrder.Sell_to_Post_Code;
            tbCity.Text = newOrder.Sell_to_City;
            tbPhone.Text = newOrder.Sell_to_Contact_Phone_No;
            tbEmail.Text = newOrder.Sell_to_Contact_E_Mail;
            tbExternalDoc.Text = newOrder.External_Document_No;
            mtbShipmentDate.Text = newOrder.Shipment_Date.ToShortDateString();
            cbDeliverycode.Text = newOrder.Shipment_Method_Code;
        }

        public void GetSalesOrderLineData()
        {
            SalesOrderLine_Service salesorderlineservice = new SalesOrderLine_Service();
            salesorderlineservice.UseDefaultCredentials = true;

            List<SalesOrderLine_Filter> SalesOrderLineFilterArray = new List<SalesOrderLine_Filter>();

            SalesOrderLine_Filter DocumentNoFilter = new SalesOrderLine_Filter();
            DocumentNoFilter.Field = SalesOrderLine_Fields.Document_No;
            DocumentNoFilter.Criteria = orderno;
            SalesOrderLineFilterArray.Add(DocumentNoFilter);

            LineResult = salesorderlineservice.ReadMultiple(SalesOrderLineFilterArray.ToArray(), "", 1000);

            dataGridView1.DataSource = LineResult;
            dataGridView1.Update();

            if (LineResult.Count() > 0)
            {
                dataGridView1.CurrentCell = dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells[0];
            }
        }

        public void CreateNewOrder(string CustomerNo)
        {
            // Create Service Reference 
            var service = new SalesOrderHeader_Service();
            service.UseDefaultCredentials = true;

            // Create the Order header 
            newOrder = new SalesOrderHeader();
            service.Create(ref newOrder);

            // Update Order header 
            newOrder.Sell_to_Customer_No = CustomerNo;
            newOrder.Salesperson_Code = Globals.theSalesPersonCode;
            newOrder.Location_Code = Globals.theLocation;
            newOrder.External_Document_No = GetDefaultExtDocNo();
            service.Update(ref newOrder);

            orderno = newOrder.No;

            tbName.Text = newOrder.Sell_to_Customer_No;
            tbName2.Text = newOrder.Sell_to_Customer_Name;
            tbAddress.Text = newOrder.Sell_to_Address;
            tbAddress2.Text = newOrder.Sell_to_Address_2;
            tbPostCode.Text = newOrder.Sell_to_Post_Code;
            tbCity.Text = newOrder.Sell_to_City;
            tbPhone.Text = newOrder.Sell_to_Contact_Phone_No;
            tbEmail.Text = newOrder.Sell_to_Contact_E_Mail;
            
            tbExternalDoc.Text = newOrder.External_Document_No;
            mtbShipmentDate.Text = newOrder.Shipment_Date.ToShortDateString();

        }

        public void CreateOrderLine(string ItemNo, decimal Qty)
        {
            // Create Service Reference 
            var service = new SalesOrderHeader_Service();
            service.UseDefaultCredentials = true;

            // Update Order lines 
            int linecounter = newOrder.SalesLines.Count();
            newOrder.SalesLines = new Sales_Order_Line[200];
            newOrder.SalesLines[linecounter] = new Sales_Order_Line();

            service.Update(ref newOrder);

            var line1 = newOrder.SalesLines[linecounter];
            line1.Type = WSSalesOrderHeader.Type.Item;
            line1.No = ItemNo;
            line1.Quantity = Qty;

            try
            {
                service.Update(ref newOrder);
            }
            catch (Exception ex)
            {
                MessageBoxExample.MyMessageBox.ShowBox(ex.Message);
            }
        }

        public void GetShipmentMethodCode()
        {
            var service = new ShipmentMethodCode_Service();
            service.UseDefaultCredentials = true;

            ShipmentMethodCode[] Result = service.ReadMultiple(null, "", 50);

            if (Result.Count() > 0)
            {
                foreach (var item in Result)
	            {
                    cbDeliverycode.Items.Add(string.Format("{0}", item.Code));
	            }
            }
        }

        public string GetDefaultExtDocNo()
        {
            var service = new BalanceWarehouse();
            service.UseDefaultCredentials = true;

            return service.WSReturnSalespersonExtDocNo();
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if ((keyData == Keys.Enter) && (dataGridView1.Focused))
            {
                if (dataGridView1.CurrentRow == null)
                {
                    return true;
                }

                int CurIndex = dataGridView1.CurrentRow.Index;

                // kald edit formen med linjen som ref param.

                var salesline = newOrder.SalesLines[CurIndex];
                decimal antal = newOrder.SalesLines[CurIndex].Quantity;
                decimal pris = newOrder.SalesLines[CurIndex].Unit_Price;
                decimal percent = newOrder.SalesLines[CurIndex].Line_Discount_Percent;

                fmEditSalesLine editsalesline = new fmEditSalesLine();
                editsalesline.ShowDialog(ref antal, ref pris, ref percent, salesline.Description);

                // Create Service Reference 
                var service = new SalesOrderHeader_Service();
                service.UseDefaultCredentials = true;

                if (antal == 0)
                {
                    if (MessageBox.Show("Vil du slette 0 linjen", "Slet Linjen?", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                    {
                        service.Delete_SalesLines(newOrder.SalesLines[CurIndex].Key);
                        newOrder = service.Read(orderno);
                    }
                }
                else
                {
                    salesline.Quantity = antal;
                    if (salesline.Unit_Cost_LCY > pris)
                    {
                        if (MessageBox.Show(string.Format("Købsprisen på {0}kr. ligger under den angivende salgspris på {1}kr. Vil du fortsætte med den pris?", salesline.Unit_Cost_LCY, pris),"Prisadvarsel", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == System.Windows.Forms.DialogResult.Yes)
                        {
                            salesline.Unit_Price = pris;
                        }
                    }
                    else
                    {
                        salesline.Unit_Price = pris;
                        salesline.Line_Discount_Percent = percent;
                    }
                }

                service.Update(ref newOrder);

                GetSalesOrderLineData();

                if (dataGridView1.Rows.Count <= CurIndex)
                {
                    CurIndex = dataGridView1.Rows.Count - 1;
                }
                if (dataGridView1.Rows.Count > 0)
                {
                    dataGridView1.CurrentCell = dataGridView1.Rows[CurIndex].Cells[0];
                }
                else
                    tbDescription.Text = "";

                return true;
            }

            if (keyData == Keys.Escape)
            {
                //this.Close();
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void fmSalesOrderHeader_Load(object sender, EventArgs e)
        {
            if (!isneworder)
            {
                GetSaletOrderHeaderData();
                GetSalesOrderLineData();
            }
            GetShipmentMethodCode();
        }

        private void btSaveAndClose_Click(object sender, EventArgs e)
         {
             // Create Service Reference 
             var service = new SalesOrderHeader_Service();
             service.UseDefaultCredentials = true;

             // Update Order header 
             newOrder.Shipment_Date = DateTime.Parse(mtbShipmentDate.Text.ToString());
             newOrder.External_Document_No = tbExternalDoc.Text;
             service.Update(ref newOrder);
             
             this.Close();
         }

        private void btAddItem_Click(object sender, EventArgs e)
         {
             decimal antal = 1;
             string itemno = "";
             fmItemOrderAdd itemadd = new fmItemOrderAdd(dtItems, dtSearchItems);
             itemadd.ShowDialog(ref itemno, ref antal);
             if ((itemno != "") && (antal > 0))
             {
                 CreateOrderLine(itemno, antal);
                 GetSalesOrderLineData();
             }
         }

        private void btDeleteOrder_Click(object sender, EventArgs e)
         {
             // Create Service Reference 
             var service = new SalesOrderHeader_Service();
             service.UseDefaultCredentials = true;

             if (MessageBox.Show("Vil du slette ordren?", "Slet", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == System.Windows.Forms.DialogResult.Yes)
             {
                 if (MessageBox.Show("Er du hel sikker?!!!!", "Sletter ordren", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == System.Windows.Forms.DialogResult.Yes)
                 {
                     // Delete Order header 
                     try
                     {
                         service.Delete(newOrder.Key);
                     }
                     catch (Exception ex)
                     {
                         MessageBoxExample.MyMessageBox.ShowBox(ex.Message);
                     }
                     this.Close();
                 }
             }
         }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.CurrentRow.Cells[6].Value != null)
            {
                tbDescription.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            } 
        }

        private void btComment_Click(object sender, EventArgs e)
        {
            fmComment sl = new fmComment(Document_Type.Order, newOrder.No);
            sl.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            fmStatistic statistic = new fmStatistic(orderno);
            statistic.ShowDialog();
        }

        private void cbDeliverycode_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbDeliverycode.Text = this.cbDeliverycode.GetItemText(this.cbDeliverycode.SelectedItem);
            newOrder.Shipment_Method_Code = cbDeliverycode.Text;
            
            var service = new SalesOrderHeader_Service();
            service.UseDefaultCredentials = true;

            service.Update(ref newOrder);
        }
    }
}

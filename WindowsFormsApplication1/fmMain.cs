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
    using System.Security.Principal;
    using System.Threading;
    using WarehouseService;
    using WSItemList;

    public partial class fmMain : Form
    {
        private DataTable dtItems = new DataTable();
        private DataTable dtSearchItems = new DataTable("ItemList");
    
        public fmMain()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            fmSetup setup = new fmSetup();
            setup.ShowDialog();
        }

        private void DoSomeBackgroundStuffWithShowDialog()
        {
            ContinuousProgressWindow continuousProgressWindow =
                new ContinuousProgressWindow();
            BackgroundWorker backgroundWorker = new BackgroundWorker();
            backgroundWorker.DoWork += (sender, arguments) =>
            {
                //GetItemData();
                GetItemDataInterval();
            };
            backgroundWorker.RunWorkerCompleted += (sender, arguments) =>
            {
                continuousProgressWindow.DialogResult = DialogResult.OK;
                continuousProgressWindow.Close();
                continuousProgressWindow.Dispose();
            };

            backgroundWorker.RunWorkerAsync();
            continuousProgressWindow.ShowDialog(this);

        }

        public void GetItemData()
        {
            ItemListPage_Service itemlistpageservice = new ItemListPage_Service();
            itemlistpageservice.UseDefaultCredentials = true;

            List<ItemListPage_Filter> ItemFilterArray = new List<ItemListPage_Filter>();

            ItemListPage_Filter ItemBlockedFilter = new ItemListPage_Filter();
            ItemBlockedFilter.Field = ItemListPage_Fields.Blocked;
            ItemBlockedFilter.Criteria = false.ToString();
            ItemFilterArray.Add(ItemBlockedFilter);

            ItemListPage_Filter ItemSanaFilter = new ItemListPage_Filter();
            ItemSanaFilter.Field = ItemListPage_Fields.Visible_in_Webshop;
            ItemSanaFilter.Criteria = true.ToString();
            ItemFilterArray.Add(ItemSanaFilter);

            ItemListPage_Filter ItemLocationFilter = new ItemListPage_Filter();
            ItemLocationFilter.Field = ItemListPage_Fields.Location_Filter;
            ItemLocationFilter.Criteria = Globals.theLocation;
            ItemFilterArray.Add(ItemLocationFilter);

            ItemListPage[] Result = itemlistpageservice.ReadMultiple(ItemFilterArray.ToArray(), "", 5000);

            if (Result.Count() > 0)
            {
                dtSearchItems.Clear();
                dtSearchItems.Columns.Clear();
                dtSearchItems.Columns.Add(("Varedata"), typeof(string));

                dtItems.Clear();
                dtItems.Columns.Clear();
                dtItems.Columns.Add(("Varenr."), typeof(string));
                dtItems.Columns.Add(("Beskrivelse"), typeof(string));
                dtItems.Columns.Add(("Pris"), typeof(decimal));
                dtItems.Columns.Add(("Enhed"), typeof(string));
                dtItems.Columns.Add(("Lager"), typeof(string));
                dtItems.Columns.Add(("Stregkode"), typeof(string));

                dtSearchItems.Rows.Add(new object[] { string.Format("{0} {1} {2}", "","","") });
                foreach (var item in Result)
                {
                    dtItems.Rows.Add(new object[] { item.No, item.Description, item.Unit_Price, item.Sales_Unit_of_Measure, item.Inventory, item.Barcode_Base_UoM });
                    dtSearchItems.Rows.Add(new object[] { string.Format("{0} {1} {2}", item.No, item.Description, item.Barcode_Base_UoM) });
                }
            }
        }

        public void GetItemDataInterval()
        {
            ItemListClass ilc = new ItemListClass();
            string no = "";
            string tempNo = "";
            ilc.InitItemDataTable(ref dtItems, ref dtSearchItems);

            no = ilc.GetItemData(no, 500, ref dtItems, ref dtSearchItems) + "..";
            while ((no != "") && (tempNo != no))
            {
                tempNo = no;
                no = ilc.GetItemData(no, 500, ref dtItems, ref dtSearchItems) + "..";
                Thread.Sleep(100);
            }
        }

        private void fmMain_Load(object sender, EventArgs e)
        {
            Globals.theWinlogon = WindowsIdentity.GetCurrent().Name.ToUpper();
            Globals.theUserID = Globals.theWinlogon.Substring(Globals.theWinlogon.IndexOf('\\') + 1).ToUpper();
            Globals.theSalesPersonCode = Globals.theUserID + "*";
            EmployeeTool et = new EmployeeTool();
            et.GetEmployeeSettings(Globals.theWinlogon);

            string Sqlserver = "";
            string SqlInstance = "";
            string SqlDatabaseUser = "";
            string Company = "";
            string WebUrl = "";
            string Language = "";

            BalanceWarehouse Warehouse = new BalanceWarehouse();
            Warehouse.UseDefaultCredentials = true;

            try
            {
                Warehouse.WsReturnServerInfo(ref Sqlserver, ref SqlInstance, ref SqlDatabaseUser, ref Company, ref Language, ref WebUrl);
                //lbCompanyName.Text = Company;
            }
            catch (Exception ex)
            {
                MessageBoxExample.MyMessageBox.ShowBox(ex.Message);
            }

            try
            {
                string ErrorSound = "";
                string OkSound = "";
                bool Errormessage = false;
                Warehouse.WSReturnGeneralSetup(ref ErrorSound, ref OkSound, ref Errormessage);
                Globals.theOkSoundPath = OkSound;
                Globals.theErrorSound = ErrorSound;
                Globals.theShowMessage = Errormessage;
            }
            catch (Exception ex)
            {
                MessageBoxExample.MyMessageBox.ShowBox(ex.Message);
            }
            Warehouse.Dispose();

            DoSomeBackgroundStuffWithShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            fmSalesOrderList sol = new fmSalesOrderList(dtItems, dtSearchItems);
            sol.ShowDialog();
        }

        private void btItem_Click(object sender, EventArgs e)
        {
            fmItemList il = new fmItemList(dtItems);
            il.ShowDialog();
        }

        private void btCustomer_Click(object sender, EventArgs e)
        {
            fmCustomerList cl = new fmCustomerList(dtItems, dtSearchItems);
            cl.ShowDialog();
        }

    }
}

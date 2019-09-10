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
    using WSItemList;
    public partial class fmItemOrderAdd : Form
    {
        private string itemno = "";
        private decimal qty = 0;
        private DataTable dtItems = new DataTable();
        private DataTable dtSearchItems = new DataTable();
        private string filterField = "Varedata";

        public fmItemOrderAdd()
        {
            InitializeComponent();
        }

        public fmItemOrderAdd(DataTable datatableitems)
        {
            InitializeComponent();
            dtItems = datatableitems;
        }

        public fmItemOrderAdd(DataTable datatableitems, DataTable datasearchitems)
        {
            InitializeComponent();
            dtItems = datatableitems;
            dtSearchItems = datasearchitems;
        }

        public void ShowDialog(ref string ItemNo, ref decimal Qty)
        {
            itemno = ItemNo;
            qty = Qty;
            this.ShowDialog();
            ItemNo = itemno;
            Qty = qty;
        }

        public void ShowData()
        {
            cbSearchType.DataSource = dtSearchItems;
            cbSearchType.DisplayMember = "Varedata";
            cbSearchType.ValueMember = "Varedata";
        }

        public void FormatData()
        {
            if ((cbSearchType.Text.IndexOf(" ") > 0) && (!string.IsNullOrEmpty(cbSearchType.Text)))
            {
                itemno = cbSearchType.Text.Substring(0, (cbSearchType.Text.IndexOf(" ")));
                if (!string.IsNullOrEmpty(itemno))
                {
                    var service = new ItemListPage_Service();
                    service.UseDefaultCredentials = true;

                    ItemListPage result = service.Read(itemno);

                    tbDescription.Text = string.Format("Vare nr.: {0}{1}Beskrivelse: {2}{3}Beholdning: {4} {5}{6}Vejledende pris: {7}", result.No, Environment.NewLine, result.Description, Environment.NewLine, result.Inventory, result.Sales_Unit_of_Measure, Environment.NewLine, result.Unit_Price.ToString("N2"));
                    cbSearchType.DroppedDown = false;
                    tbQty.Focus();
                }
            }
        }

        private void fmItemOrderAdd_Load(object sender, EventArgs e)
        {
            ShowData();
            if (dtSearchItems.DefaultView.Count <= 30)
            {
                cbSearchType.DroppedDown = true;
            }
            else
                cbSearchType.DroppedDown = false;

            tbFilter.Focus();
        }

        private void tbFilter_TextChanged(object sender, EventArgs e)
        {
#region BAL6.45
            if (!string.IsNullOrEmpty(filterField))
                try
                {
                    dtSearchItems.DefaultView.RowFilter = string.Format("[{0}] LIKE '%{1}%'", filterField, tbFilter.Text);
                }
                catch (Exception ex)
                {
                    MessageBoxExample.MyMessageBox.ShowBox(ex.Message);
                }
                
            
            if (dtSearchItems.DefaultView.Count <= 30)
            {
                cbSearchType.DroppedDown = true;
            }
            else
                cbSearchType.DroppedDown = false;
#endregion
        }

        private void btOK_Click(object sender, EventArgs e)
        {
            qty = decimal.Parse(tbQty.Text);
            this.Close();
        }

        private void tbFilter_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                FormatData();
            }
        }

        private void cbSearchType_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                FormatData();
            }
        }

        private void cbSearchType_SelectionChangeCommitted(object sender, EventArgs e)
        {
            FormatData();
        }

        private void tbQty_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btOK.Focus();
            }
        }
    }
}

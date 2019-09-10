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
    using WSCustomerList;
    public partial class fmCustomerList : Form
    {
        private string filterField = "Postnr.";
        private DataTable dtCust = new DataTable();
        private DataTable dtItems = new DataTable();
        private DataTable dtSearchItems = new DataTable();

        public fmCustomerList()
        {
            InitializeComponent();
        }

        public fmCustomerList(DataTable datatableitems, DataTable datasearchitems)
        {
            InitializeComponent();
            dtItems = datatableitems;
            dtSearchItems = datasearchitems;
        }

        public void GetItemData()
        {
            CustomerListPage_Service customerlistpageservice = new CustomerListPage_Service();
            customerlistpageservice.UseDefaultCredentials = true;

            List<CustomerListPage_Filter> CustomerFilterArray = new List<CustomerListPage_Filter>();

            CustomerListPage_Filter CustomerBlockedFilter = new CustomerListPage_Filter();
            CustomerBlockedFilter.Field = CustomerListPage_Fields.Blocked;
            CustomerBlockedFilter.Criteria = Blocked._blank_.ToString();
            CustomerFilterArray.Add(CustomerBlockedFilter);

            CustomerListPage[] Result = customerlistpageservice.ReadMultiple(CustomerFilterArray.ToArray(), "", 5000);

            if (Result.Count() > 0)
            {
                dtCust.Columns.Add(("Nr."), typeof(string));
                dtCust.Columns.Add(("Navn"), typeof(string));
                dtCust.Columns.Add(("Adresse"), typeof(string));
                dtCust.Columns.Add(("Adresse2"), typeof(string));
                dtCust.Columns.Add(("Postnr."), typeof(string));
                dtCust.Columns.Add(("By"), typeof(string));
                dtCust.Columns.Add(("Telefon"), typeof(string));
                dtCust.Columns.Add(("Balance"), typeof(decimal));
                dtCust.Columns.Add(("I Ordre"), typeof(decimal));

                foreach (var item in Result)
                {
                    dtCust.Rows.Add(new object[] { item.No, item.Name, item.Address, item.Address_2, item.Post_Code, item.City, item.Phone_No, item.Balance_LCY, item.Outstanding_Orders_LCY });
                }

                dataGridView1.ReadOnly = true;
                dataGridView1.DataSource = dtCust;
                dataGridView1.RowHeadersVisible = false;
                dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                //dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dataGridView1.Columns[1].Visible = false;
                
                dataGridView1.Columns[2].DefaultCellStyle.Format = "N2";
                dataGridView1.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
                dataGridView1.Columns[2].Visible = false;

                dataGridView1.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
                dataGridView1.Columns[3].Visible = false;

                dataGridView1.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;

                dataGridView1.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                
                dataGridView1.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
                dataGridView1.Columns[6].Visible = false;
                
                dataGridView1.Columns[7].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
                dataGridView1.Columns[7].DefaultCellStyle.Format = "N2";
                
                dataGridView1.Columns[8].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
                dataGridView1.Columns[8].DefaultCellStyle.Format = "N2";
                dataGridView1.Update();
            }
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            tbInfo.Text = string.Format("{0}{1}{2}{3}{4}{5}{6}{7}Telefon: {8}", dataGridView1.CurrentRow.Cells[1].Value.ToString(), Environment.NewLine, 
                                                           dataGridView1.CurrentRow.Cells[2].Value.ToString(), Environment.NewLine,
                                                           dataGridView1.CurrentRow.Cells[3].Value.ToString(), Environment.NewLine,
                                                           dataGridView1.CurrentRow.Cells[5].Value.ToString(), Environment.NewLine,
                                                           dataGridView1.CurrentRow.Cells[6].Value.ToString());
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Enter)
            {
                if (dataGridView1.CurrentRow == null)
                {
                    return true;
                }

                int CurIndex = dataGridView1.CurrentRow.Index;

                if (MessageBox.Show(string.Format("Vil du oprette en ordre til {0} {1}", dataGridView1.CurrentRow.Cells[0].Value.ToString(), dataGridView1.CurrentRow.Cells[1].Value.ToString()), "Ny Ordre", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    fmSalesOrderHeader soh = new fmSalesOrderHeader(dataGridView1.CurrentRow.Cells[0].Value.ToString(), true, dtItems, dtSearchItems);
                    soh.ShowDialog();
                }

                dataGridView1.CurrentCell = dataGridView1.Rows[CurIndex].Cells[0];

                return true;
            }

            if (keyData == Keys.Escape)
            {
                this.Close();
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void tbFilter_TextChanged(object sender, EventArgs e)
        {
            #region BAL6.45
            if (!string.IsNullOrEmpty(filterField))
                dtCust.DefaultView.RowFilter = string.Format("[{0}] LIKE '%{1}%'", filterField, tbFilter.Text);
            #endregion

        }

        private void fmCustomerList_Load(object sender, EventArgs e)
        {
            tbFilter.Focus();
            GetItemData();
        }

        private void cbSearchType_SelectedIndexChanged(object sender, EventArgs e)
        {
            filterField = cbSearchType.Items[cbSearchType.SelectedIndex].ToString();
            tbFilter.Focus();
        }

    }
}

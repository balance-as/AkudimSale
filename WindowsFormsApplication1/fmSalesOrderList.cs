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
    using WSSalesOrderList;

    public partial class fmSalesOrderList : Form
    {
        private DataTable dtItems = new DataTable();
        private DataTable dtSearchItems = new DataTable();

        public fmSalesOrderList()
        {
            InitializeComponent();
        }

        public fmSalesOrderList(DataTable datatableitems, DataTable datasearchitems)
        {
            InitializeComponent();
            dtItems = datatableitems;
            dtSearchItems = datasearchitems;
        }

        public void GetOrderList()
        {
            SalesOrderList_Service saleslistservice = new SalesOrderList_Service();
            saleslistservice.UseDefaultCredentials = true;

            List<SalesOrderList_Filter> SalesorderListFilterArray = new List<SalesOrderList_Filter>();

            SalesOrderList_Filter SalesOrderPersonFilter = new SalesOrderList_Filter();
            SalesOrderPersonFilter.Field = SalesOrderList_Fields.Salesperson_Code;
            SalesOrderPersonFilter.Criteria = Globals.theSalesPersonCode;
            SalesorderListFilterArray.Add(SalesOrderPersonFilter);

            SalesOrderList_Filter StatusFilter = new SalesOrderList_Filter();
            StatusFilter.Field = SalesOrderList_Fields.Status;
            StatusFilter.Criteria = Status.Open.ToString();
            SalesorderListFilterArray.Add(StatusFilter);

            SalesOrderList[] Result = saleslistservice.ReadMultiple(SalesorderListFilterArray.ToArray(), "", 1000);

            //if (Result.Count() > 0)
            //{
                dataGridView1.DataSource = Result;
                dataGridView1.Update();
            //}
        }

        private void fmSalesOrderList_Load(object sender, EventArgs e)
        {
            GetOrderList();
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.CurrentRow.Cells[2].Value != null)
            {
                lbName.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            }
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Enter)
            {
                if (dataGridView1.CurrentRow == null)
                {
                    return true;
                }

                
                if (dataGridView1.CurrentRow.Cells[0].Value != null)
                {
                    int CurIndex = dataGridView1.CurrentRow.Index;

                    fmSalesOrderHeader so = new fmSalesOrderHeader(dataGridView1.CurrentRow.Cells[0].Value.ToString(), dtItems, dtSearchItems);
                    so.ShowDialog();
                    GetOrderList();

                    if ((dataGridView1.Rows.Count - 1) < CurIndex)
                    {
                        CurIndex--;
                    }
                    if (CurIndex >= 0)
                      dataGridView1.CurrentCell = dataGridView1.Rows[CurIndex].Cells[0];
                }
                return true;
            }

            if (keyData == Keys.Escape)
            {
                this.Close();
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }
    }
}

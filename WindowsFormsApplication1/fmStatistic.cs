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
    using WSSalesStatistic;

    public partial class fmStatistic : Form
    {
        private string orderno = "";

        public fmStatistic()
        {
            InitializeComponent();
        }

        public fmStatistic(string OrderNo)
        {
            InitializeComponent();
            orderno = OrderNo;
        }

        public void GetStatistic()
        {
            var service = new SalesStatistic_Service();
            service.UseDefaultCredentials = true;

            List<SalesStatistic_Filter> StatisticFilterArray = new List<SalesStatistic_Filter>();

            SalesStatistic_Filter DocTypeFilter = new SalesStatistic_Filter();
            DocTypeFilter.Field = SalesStatistic_Fields.Document_Type;
            DocTypeFilter.Criteria = Document_Type.Order.ToString();
            StatisticFilterArray.Add(DocTypeFilter);

            SalesStatistic_Filter DocNo = new SalesStatistic_Filter();
            DocNo.Field = SalesStatistic_Fields.No;
            DocNo.Criteria = orderno;
            StatisticFilterArray.Add(DocNo);

            SalesStatistic[] Result = service.ReadMultiple(StatisticFilterArray.ToArray(), "", 10);

            dataGridView1.DataSource = Result;
            dataGridView1.Update();
        }
        public decimal GetStatisticAmountExclVat()
        {
            var service = new SalesStatistic_Service();
            service.UseDefaultCredentials = true;

            List<SalesStatistic_Filter> StatisticFilterArray = new List<SalesStatistic_Filter>();

            SalesStatistic_Filter DocTypeFilter = new SalesStatistic_Filter();
            DocTypeFilter.Field = SalesStatistic_Fields.Document_Type;
            DocTypeFilter.Criteria = Document_Type.Order.ToString();
            StatisticFilterArray.Add(DocTypeFilter);

            SalesStatistic_Filter DocNo = new SalesStatistic_Filter();
            DocNo.Field = SalesStatistic_Fields.No;
            DocNo.Criteria = orderno;
            StatisticFilterArray.Add(DocNo);

            SalesStatistic[] Result = service.ReadMultiple(StatisticFilterArray.ToArray(), "", 10);

            return Result.FirstOrDefault().TotalInclVAT_Invoicing;
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Escape)
            {
                this.Close();
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void fmStatistic_Load(object sender, EventArgs e)
        {
            GetStatistic();
        }

    }
}

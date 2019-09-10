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

    public partial class fmEditSalesLine : Form
    {
        private decimal qty = 0;
        private decimal unitprice = 0;
        private decimal dscpct = 0;

        public fmEditSalesLine()
        {
            InitializeComponent();
        }

        public void ShowDialog(ref decimal Qty, ref decimal UnitPrice, ref decimal DscPct, string description)
        {
            qty = Qty;
            unitprice = UnitPrice;
            dscpct = DscPct;
            tbDescription.Text = description;
            this.ShowDialog();
            Qty = qty;
            UnitPrice = unitprice;
            DscPct = dscpct;
        }

        private void btOK_Click(object sender, EventArgs e)
        {
            qty = decimal.Parse(tbQty.Text);
            unitprice = decimal.Parse(tbUnitPrice.Text);
            dscpct = decimal.Parse(tbDiscountPct.Text);
            this.Close();
        }

        private void fmEditSalesLine_Load(object sender, EventArgs e)
        {
            tbQty.Text = qty.ToString("N2");
            tbUnitPrice.Text = unitprice.ToString("N2");
            tbDiscountPct.Text = dscpct.ToString("N2");
            tbQty.Focus();
        }
    }
}

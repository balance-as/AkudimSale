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
    public partial class fmItemList : Form
    {
        private DataTable dtItems = new DataTable();
        private string filterField = "Stregkode";
        
        public fmItemList()
        {
            InitializeComponent();
        }

        public fmItemList(DataTable ItemTable)
        {
            InitializeComponent();
            dtItems = ItemTable;
        }

        public void ShowItemData()
        {
            dataGridView1.ReadOnly = true;
            dataGridView1.DataSource = dtItems;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            //dataGridView1.Columns[1].Visible = false;
            dataGridView1.Columns[2].DefaultCellStyle.Format = "N2";
            dataGridView1.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            dataGridView1.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            dataGridView1.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            dataGridView1.Columns[5].Visible = false;
            dataGridView1.Update();
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
                // evt en form mere til yderligere data.
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
                dtItems.DefaultView.RowFilter = string.Format("[{0}] LIKE '%{1}%'", filterField, tbFilter.Text);
            #endregion

        }

        private void fmItemList_Load(object sender, EventArgs e)
        {
            tbFilter.Focus();
            ShowItemData();
        }

        private void tbFilter_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Escape)
            {
                this.Close();
            }
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            tbDescription.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
        }

        private void cbSearchType_SelectedIndexChanged(object sender, EventArgs e)
        {
            filterField = cbSearchType.Items[cbSearchType.SelectedIndex].ToString();
            tbFilter.Focus();
        }
    }
}

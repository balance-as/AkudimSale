namespace WindowsFormsApplication1
{
    partial class fmStatistic
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.totalAmount11DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vATAmountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalAmount21 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salesStatisticBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesStatisticBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeight = 60;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.totalAmount11DataGridViewTextBoxColumn,
            this.vATAmountDataGridViewTextBoxColumn,
            this.TotalAmount21});
            this.dataGridView1.DataSource = this.salesStatisticBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(0, -1);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.RowTemplate.Height = 50;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dataGridView1.Size = new System.Drawing.Size(464, 118);
            this.dataGridView1.TabIndex = 5;
            // 
            // totalAmount11DataGridViewTextBoxColumn
            // 
            this.totalAmount11DataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.totalAmount11DataGridViewTextBoxColumn.DataPropertyName = "TotalAmount11";
            this.totalAmount11DataGridViewTextBoxColumn.HeaderText = "Beløb eks. moms";
            this.totalAmount11DataGridViewTextBoxColumn.Name = "totalAmount11DataGridViewTextBoxColumn";
            this.totalAmount11DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // vATAmountDataGridViewTextBoxColumn
            // 
            this.vATAmountDataGridViewTextBoxColumn.DataPropertyName = "VATAmount";
            this.vATAmountDataGridViewTextBoxColumn.HeaderText = "Moms beløb";
            this.vATAmountDataGridViewTextBoxColumn.Name = "vATAmountDataGridViewTextBoxColumn";
            this.vATAmountDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // TotalAmount21
            // 
            this.TotalAmount21.DataPropertyName = "TotalAmount21";
            this.TotalAmount21.HeaderText = "Beløb inkl moms";
            this.TotalAmount21.Name = "TotalAmount21";
            this.TotalAmount21.ReadOnly = true;
            // 
            // salesStatisticBindingSource
            // 
            this.salesStatisticBindingSource.DataSource = typeof(WindowsFormsApplication1.WSSalesStatistic.SalesStatistic);
            // 
            // fmStatistic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 114);
            this.ControlBox = false;
            this.Controls.Add(this.dataGridView1);
            this.MaximumSize = new System.Drawing.Size(480, 130);
            this.MinimumSize = new System.Drawing.Size(480, 130);
            this.Name = "fmStatistic";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.fmStatistic_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesStatisticBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource salesStatisticBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalAmount11DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vATAmountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalAmount21;
    }
}
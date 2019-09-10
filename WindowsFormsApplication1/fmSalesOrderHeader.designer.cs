namespace WindowsFormsApplication1
{
    partial class fmSalesOrderHeader
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tbName = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lineAmountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salesOrderLineBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbName2 = new System.Windows.Forms.TextBox();
            this.tbAddress = new System.Windows.Forms.TextBox();
            this.tbAddress2 = new System.Windows.Forms.TextBox();
            this.tbPostCode = new System.Windows.Forms.TextBox();
            this.btAddItem = new System.Windows.Forms.Button();
            this.tbPhone = new System.Windows.Forms.TextBox();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.btDeleteOrder = new System.Windows.Forms.Button();
            this.btSaveAndClose = new System.Windows.Forms.Button();
            this.tbCity = new System.Windows.Forms.TextBox();
            this.tbExternalDoc = new System.Windows.Forms.TextBox();
            this.mtbShipmentDate = new System.Windows.Forms.MaskedTextBox();
            this.tbDescription = new System.Windows.Forms.TextBox();
            this.btComment = new System.Windows.Forms.Button();
            this.btStatistic = new System.Windows.Forms.Button();
            this.cbDeliverycode = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesOrderLineBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tbName
            // 
            this.tbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbName.Location = new System.Drawing.Point(2, -1);
            this.tbName.Name = "tbName";
            this.tbName.ReadOnly = true;
            this.tbName.Size = new System.Drawing.Size(371, 31);
            this.tbName.TabIndex = 10;
            this.tbName.TabStop = false;
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
            this.dataGridView1.ColumnHeadersHeight = 40;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.unitPriceDataGridViewTextBoxColumn,
            this.lineAmountDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn5,
            this.Description});
            this.dataGridView1.DataSource = this.salesOrderLineBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(0, 251);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView1.RowTemplate.Height = 30;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dataGridView1.Size = new System.Drawing.Size(462, 302);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEnter);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "No";
            this.dataGridViewTextBoxColumn1.HeaderText = "Varenr.";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Quantity";
            dataGridViewCellStyle2.Format = "N2";
            dataGridViewCellStyle2.NullValue = null;
            this.dataGridViewTextBoxColumn3.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewTextBoxColumn3.HeaderText = "Antal";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 77;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Unit_of_Measure_Code";
            this.dataGridViewTextBoxColumn4.HeaderText = "Enhed";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 75;
            // 
            // unitPriceDataGridViewTextBoxColumn
            // 
            this.unitPriceDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.unitPriceDataGridViewTextBoxColumn.DataPropertyName = "Unit_Price";
            dataGridViewCellStyle3.Format = "N2";
            dataGridViewCellStyle3.NullValue = null;
            this.unitPriceDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.unitPriceDataGridViewTextBoxColumn.HeaderText = "Pris";
            this.unitPriceDataGridViewTextBoxColumn.Name = "unitPriceDataGridViewTextBoxColumn";
            this.unitPriceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // lineAmountDataGridViewTextBoxColumn
            // 
            this.lineAmountDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.lineAmountDataGridViewTextBoxColumn.DataPropertyName = "Line_Amount";
            dataGridViewCellStyle4.Format = "N2";
            dataGridViewCellStyle4.NullValue = null;
            this.lineAmountDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle4;
            this.lineAmountDataGridViewTextBoxColumn.HeaderText = "Total";
            this.lineAmountDataGridViewTextBoxColumn.Name = "lineAmountDataGridViewTextBoxColumn";
            this.lineAmountDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Line_Discount_Percent";
            this.dataGridViewTextBoxColumn5.HeaderText = "%";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 35;
            // 
            // Description
            // 
            this.Description.DataPropertyName = "Description";
            this.Description.HeaderText = "Description";
            this.Description.Name = "Description";
            this.Description.ReadOnly = true;
            this.Description.Visible = false;
            // 
            // salesOrderLineBindingSource
            // 
            this.salesOrderLineBindingSource.DataSource = typeof(WindowsFormsApplication1.WSSalesOrderHeader.Sales_Order_Line);
            // 
            // tbName2
            // 
            this.tbName2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbName2.Location = new System.Drawing.Point(2, 30);
            this.tbName2.Name = "tbName2";
            this.tbName2.ReadOnly = true;
            this.tbName2.Size = new System.Drawing.Size(371, 31);
            this.tbName2.TabIndex = 12;
            this.tbName2.TabStop = false;
            // 
            // tbAddress
            // 
            this.tbAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbAddress.Location = new System.Drawing.Point(2, 61);
            this.tbAddress.Name = "tbAddress";
            this.tbAddress.ReadOnly = true;
            this.tbAddress.Size = new System.Drawing.Size(371, 31);
            this.tbAddress.TabIndex = 13;
            this.tbAddress.TabStop = false;
            // 
            // tbAddress2
            // 
            this.tbAddress2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbAddress2.Location = new System.Drawing.Point(2, 92);
            this.tbAddress2.Name = "tbAddress2";
            this.tbAddress2.ReadOnly = true;
            this.tbAddress2.Size = new System.Drawing.Size(460, 31);
            this.tbAddress2.TabIndex = 14;
            this.tbAddress2.TabStop = false;
            // 
            // tbPostCode
            // 
            this.tbPostCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPostCode.Location = new System.Drawing.Point(2, 123);
            this.tbPostCode.Name = "tbPostCode";
            this.tbPostCode.ReadOnly = true;
            this.tbPostCode.Size = new System.Drawing.Size(154, 31);
            this.tbPostCode.TabIndex = 15;
            this.tbPostCode.TabStop = false;
            // 
            // btAddItem
            // 
            this.btAddItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAddItem.Location = new System.Drawing.Point(234, 583);
            this.btAddItem.Name = "btAddItem";
            this.btAddItem.Size = new System.Drawing.Size(111, 42);
            this.btAddItem.TabIndex = 3;
            this.btAddItem.Text = "Tilføj vare";
            this.btAddItem.UseVisualStyleBackColor = true;
            this.btAddItem.Click += new System.EventHandler(this.btAddItem_Click);
            // 
            // tbPhone
            // 
            this.tbPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPhone.Location = new System.Drawing.Point(162, 154);
            this.tbPhone.Name = "tbPhone";
            this.tbPhone.ReadOnly = true;
            this.tbPhone.Size = new System.Drawing.Size(300, 31);
            this.tbPhone.TabIndex = 20;
            this.tbPhone.TabStop = false;
            // 
            // tbEmail
            // 
            this.tbEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbEmail.Location = new System.Drawing.Point(2, 185);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.ReadOnly = true;
            this.tbEmail.Size = new System.Drawing.Size(460, 31);
            this.tbEmail.TabIndex = 21;
            this.tbEmail.TabStop = false;
            // 
            // btDeleteOrder
            // 
            this.btDeleteOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDeleteOrder.Location = new System.Drawing.Point(0, 583);
            this.btDeleteOrder.Name = "btDeleteOrder";
            this.btDeleteOrder.Size = new System.Drawing.Size(111, 42);
            this.btDeleteOrder.TabIndex = 6;
            this.btDeleteOrder.Text = "Slet Ordre";
            this.btDeleteOrder.UseVisualStyleBackColor = true;
            this.btDeleteOrder.Click += new System.EventHandler(this.btDeleteOrder_Click);
            // 
            // btSaveAndClose
            // 
            this.btSaveAndClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSaveAndClose.Location = new System.Drawing.Point(351, 583);
            this.btSaveAndClose.Name = "btSaveAndClose";
            this.btSaveAndClose.Size = new System.Drawing.Size(111, 42);
            this.btSaveAndClose.TabIndex = 5;
            this.btSaveAndClose.Text = "Gem Ordre";
            this.btSaveAndClose.UseVisualStyleBackColor = true;
            this.btSaveAndClose.Click += new System.EventHandler(this.btSaveAndClose_Click);
            // 
            // tbCity
            // 
            this.tbCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCity.Location = new System.Drawing.Point(162, 123);
            this.tbCity.Name = "tbCity";
            this.tbCity.ReadOnly = true;
            this.tbCity.Size = new System.Drawing.Size(300, 31);
            this.tbCity.TabIndex = 23;
            this.tbCity.TabStop = false;
            // 
            // tbExternalDoc
            // 
            this.tbExternalDoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbExternalDoc.Location = new System.Drawing.Point(162, 216);
            this.tbExternalDoc.Name = "tbExternalDoc";
            this.tbExternalDoc.Size = new System.Drawing.Size(300, 35);
            this.tbExternalDoc.TabIndex = 2;
            // 
            // mtbShipmentDate
            // 
            this.mtbShipmentDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtbShipmentDate.Location = new System.Drawing.Point(2, 216);
            this.mtbShipmentDate.Mask = "00-00-0000";
            this.mtbShipmentDate.Name = "mtbShipmentDate";
            this.mtbShipmentDate.Size = new System.Drawing.Size(154, 35);
            this.mtbShipmentDate.TabIndex = 1;
            // 
            // tbDescription
            // 
            this.tbDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDescription.Location = new System.Drawing.Point(1, 553);
            this.tbDescription.Name = "tbDescription";
            this.tbDescription.ReadOnly = true;
            this.tbDescription.Size = new System.Drawing.Size(460, 29);
            this.tbDescription.TabIndex = 0;
            this.tbDescription.TabStop = false;
            // 
            // btComment
            // 
            this.btComment.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btComment.Image = global::WindowsFormsApplication1.Properties.Resources.pensil_icon;
            this.btComment.Location = new System.Drawing.Point(372, -1);
            this.btComment.Name = "btComment";
            this.btComment.Size = new System.Drawing.Size(90, 93);
            this.btComment.TabIndex = 24;
            this.btComment.Text = "Bemærkning";
            this.btComment.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btComment.UseVisualStyleBackColor = true;
            this.btComment.Click += new System.EventHandler(this.btComment_Click);
            // 
            // btStatistic
            // 
            this.btStatistic.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btStatistic.Location = new System.Drawing.Point(117, 583);
            this.btStatistic.Name = "btStatistic";
            this.btStatistic.Size = new System.Drawing.Size(111, 42);
            this.btStatistic.TabIndex = 25;
            this.btStatistic.Text = "Statistik";
            this.btStatistic.UseVisualStyleBackColor = true;
            this.btStatistic.Click += new System.EventHandler(this.button1_Click);
            // 
            // cbDeliverycode
            // 
            this.cbDeliverycode.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDeliverycode.FormattingEnabled = true;
            this.cbDeliverycode.Location = new System.Drawing.Point(2, 154);
            this.cbDeliverycode.Name = "cbDeliverycode";
            this.cbDeliverycode.Size = new System.Drawing.Size(154, 33);
            this.cbDeliverycode.TabIndex = 26;
            this.cbDeliverycode.SelectedIndexChanged += new System.EventHandler(this.cbDeliverycode_SelectedIndexChanged);
            // 
            // fmSalesOrderHeader
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(464, 624);
            this.ControlBox = false;
            this.Controls.Add(this.cbDeliverycode);
            this.Controls.Add(this.btStatistic);
            this.Controls.Add(this.btComment);
            this.Controls.Add(this.tbDescription);
            this.Controls.Add(this.mtbShipmentDate);
            this.Controls.Add(this.tbExternalDoc);
            this.Controls.Add(this.tbCity);
            this.Controls.Add(this.btSaveAndClose);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.tbPhone);
            this.Controls.Add(this.btDeleteOrder);
            this.Controls.Add(this.btAddItem);
            this.Controls.Add(this.tbPostCode);
            this.Controls.Add(this.tbAddress2);
            this.Controls.Add(this.tbAddress);
            this.Controls.Add(this.tbName2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.tbName);
            this.MaximumSize = new System.Drawing.Size(480, 640);
            this.MinimumSize = new System.Drawing.Size(480, 640);
            this.Name = "fmSalesOrderHeader";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.fmSalesOrderHeader_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesOrderLineBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox tbName2;
        private System.Windows.Forms.TextBox tbAddress;
        private System.Windows.Forms.TextBox tbAddress2;
        private System.Windows.Forms.TextBox tbPostCode;
        private System.Windows.Forms.Button btAddItem;
        private System.Windows.Forms.BindingSource salesOrderLineBindingSource;
        private System.Windows.Forms.TextBox tbPhone;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.Button btDeleteOrder;
        private System.Windows.Forms.Button btSaveAndClose;
        private System.Windows.Forms.TextBox tbCity;
        private System.Windows.Forms.TextBox tbExternalDoc;
        private System.Windows.Forms.MaskedTextBox mtbShipmentDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lineAmountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.TextBox tbDescription;
        private System.Windows.Forms.Button btComment;
        private System.Windows.Forms.Button btStatistic;
        private System.Windows.Forms.ComboBox cbDeliverycode;
    }
}
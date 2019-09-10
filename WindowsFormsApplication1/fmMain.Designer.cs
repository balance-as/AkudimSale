namespace WindowsFormsApplication1
{
    partial class fmMain
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btOpenOrder = new System.Windows.Forms.Button();
            this.btItem = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btOrder = new System.Windows.Forms.Button();
            this.btCustomer = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Image = global::WindowsFormsApplication1.Properties.Resources.NAV4Trade;
            this.pictureBox1.Location = new System.Drawing.Point(97, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(265, 63);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 69;
            this.pictureBox1.TabStop = false;
            // 
            // btOpenOrder
            // 
            this.btOpenOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btOpenOrder.Image = global::WindowsFormsApplication1.Properties.Resources.mailbox_icon;
            this.btOpenOrder.Location = new System.Drawing.Point(252, 64);
            this.btOpenOrder.Name = "btOpenOrder";
            this.btOpenOrder.Size = new System.Drawing.Size(170, 170);
            this.btOpenOrder.TabIndex = 2;
            this.btOpenOrder.Text = "Åbne ordre";
            this.btOpenOrder.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btOpenOrder.UseVisualStyleBackColor = true;
            this.btOpenOrder.Click += new System.EventHandler(this.button5_Click);
            // 
            // btItem
            // 
            this.btItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btItem.Image = global::WindowsFormsApplication1.Properties.Resources.telescope_icon;
            this.btItem.Location = new System.Drawing.Point(32, 253);
            this.btItem.Name = "btItem";
            this.btItem.Size = new System.Drawing.Size(170, 170);
            this.btItem.TabIndex = 3;
            this.btItem.Text = "Varer";
            this.btItem.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btItem.UseVisualStyleBackColor = true;
            this.btItem.Click += new System.EventHandler(this.btItem_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Image = global::WindowsFormsApplication1.Properties.Resources.lock_icon;
            this.button3.Location = new System.Drawing.Point(252, 443);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(170, 170);
            this.button3.TabIndex = 6;
            this.button3.Text = "Afslut";
            this.button3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Image = global::WindowsFormsApplication1.Properties.Resources.gear_wheel_icon;
            this.button2.Location = new System.Drawing.Point(32, 443);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(170, 170);
            this.button2.TabIndex = 5;
            this.button2.Text = "Opsætning";
            this.button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btOrder
            // 
            this.btOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btOrder.Image = global::WindowsFormsApplication1.Properties.Resources.pensil_icon;
            this.btOrder.Location = new System.Drawing.Point(252, 253);
            this.btOrder.Name = "btOrder";
            this.btOrder.Size = new System.Drawing.Size(170, 170);
            this.btOrder.TabIndex = 4;
            this.btOrder.Text = "Bemærkninger";
            this.btOrder.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btOrder.UseVisualStyleBackColor = true;
            // 
            // btCustomer
            // 
            this.btCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCustomer.Image = global::WindowsFormsApplication1.Properties.Resources.Customer_icon1;
            this.btCustomer.Location = new System.Drawing.Point(32, 64);
            this.btCustomer.Name = "btCustomer";
            this.btCustomer.Size = new System.Drawing.Size(170, 170);
            this.btCustomer.TabIndex = 1;
            this.btCustomer.Text = "Kunder";
            this.btCustomer.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btCustomer.UseVisualStyleBackColor = true;
            this.btCustomer.Click += new System.EventHandler(this.btCustomer_Click);
            // 
            // fmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(464, 624);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btOpenOrder);
            this.Controls.Add(this.btItem);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btOrder);
            this.Controls.Add(this.btCustomer);
            this.MaximumSize = new System.Drawing.Size(480, 640);
            this.MinimumSize = new System.Drawing.Size(480, 640);
            this.Name = "fmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.fmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btCustomer;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btItem;
        private System.Windows.Forms.Button btOpenOrder;
        private System.Windows.Forms.Button btOrder;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}


namespace WindowsFormsApplication1
{
    partial class ContinuousProgressWindow
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
            this.pbIndicator = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbIndicator)).BeginInit();
            this.SuspendLayout();
            // 
            // pbIndicator
            // 
            this.pbIndicator.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pbIndicator.Location = new System.Drawing.Point(26, 12);
            this.pbIndicator.Name = "pbIndicator";
            this.pbIndicator.Size = new System.Drawing.Size(65, 65);
            this.pbIndicator.TabIndex = 69;
            this.pbIndicator.TabStop = false;
            this.pbIndicator.Visible = false;
            // 
            // ContinuousProgressWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(120, 90);
            this.ControlBox = false;
            this.Controls.Add(this.pbIndicator);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Name = "ContinuousProgressWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Henter Data";
            this.Load += new System.EventHandler(this.ContinuousProgressWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbIndicator)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbIndicator;

    }
}
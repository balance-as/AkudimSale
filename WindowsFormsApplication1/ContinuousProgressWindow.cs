﻿using System;
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
    public partial class ContinuousProgressWindow : Form
    {
        public ContinuousProgressWindow()
        {
            InitializeComponent();
        }

        private void ContinuousProgressWindow_Load(object sender, EventArgs e)
        {
            this.pbIndicator.Image = WindowsFormsApplication1.Properties.Resources.animatedCircle;
            this.pbIndicator.Visible = true;
        }
    }
}

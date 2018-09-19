﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab2
{
    public partial class RGB : Form
    {
        public RGB()
        {
            InitializeComponent();
        }
        
        private void R_Click(object sender, EventArgs e)
        {
            Form1 f = this.Owner as Form1;
            if (f != null)
                f.UP_Channel(2);
        }

        private void G_Click(object sender, EventArgs e)
        {
            Form1 f = this.Owner as Form1;
            if (f != null)
                f.UP_Channel(1);
        }

        private void B_Click(object sender, EventArgs e)
        {
            Form1 f = this.Owner as Form1;
            if (f != null)
                f.UP_Channel(0);
        }
    }
}

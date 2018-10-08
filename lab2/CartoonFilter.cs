using System;
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
    public partial class CartoonFilter : Form
    {
        public CartoonFilter()
        {
            InitializeComponent();
            textBox1.Text = "3";
        }

        private void Apply_Click(object sender, EventArgs e)
        {
            Form1 f = this.Owner as Form1;
            if (f != null)
                f.UP_CartoonFilter(Convert.ToInt32(textBox1.Text));
        }
    }
}

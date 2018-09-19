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
    public partial class B_C : Form
    {
        public B_C()
        {
            InitializeComponent();
        }

        private void Scroll_Brightness_Scroll(object sender, EventArgs e)
        {
            Form1 f = this.Owner as Form1;
            label1.Text = Convert.ToString(Scroll_Brightness.Value);
            if (f != null)
                f.UP_Brightness(Scroll_Brightness.Value);
        }

        private void Scroll_Contrast_Scroll(object sender, EventArgs e)
        {
            Form1 f = this.Owner as Form1;
            label2.Text = Convert.ToString(Scroll_Contrast.Value);
            if (f != null)
                f.UP_Contrast(Scroll_Contrast.Value);
        }
    }
}

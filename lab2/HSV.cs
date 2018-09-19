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
    public partial class HSV : Form
    {
        public HSV()
        {
            InitializeComponent();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            if (Owner is Form1 f)
            {
                f.UP_Hue(trackBar1.Value);
            }
        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            if (Owner is Form1 f)
            {
                f.UP_Saturation(trackBar2.Value);
            }
        }

        private void trackBar3_Scroll(object sender, EventArgs e)
        {
            if (Owner is Form1 f)
            {
                f.UP_Value(trackBar3.Value);
            }
        }
    }
}

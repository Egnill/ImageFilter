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
    public partial class AEI : Form
    {
        public AEI()
        {
            InitializeComponent();
        }

        Manager m = new Manager();

        private void Open_Click(object sender, EventArgs e)
        {
            m.OpenI();
            imageBox1.Image = m.sourceImage;
        }

        private void Addition_Click(object sender, EventArgs e)
        {
            Form1 f = this.Owner as Form1;
            if (f != null)
                f.UP_Addition(m.sourceImage);
        }

        private void Exception_Click(object sender, EventArgs e)
        {
            Form1 f = this.Owner as Form1;
            if (f != null)
                f.UP_Exception(m.sourceImage);
        }

        private void Interseption_Click(object sender, EventArgs e)
        {
            Form1 f = this.Owner as Form1;
            if (f != null)
                f.UP_Interseption(m.sourceImage);
        }
    }
}

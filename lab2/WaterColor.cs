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
    public partial class WaterColor : Form
    {
        public WaterColor()
        {
            InitializeComponent();
        }
        Manager m = new Manager();

        private void Apply_Click(object sender, EventArgs e)
        {
            Form1 f = this.Owner as Form1;
            if (f != null)
                f.UP_WaterColor(m.sourceImage.Clone(), int.Parse(textBox1.Text), double.Parse(textBox2.Text));
        }

        private void Open_Click(object sender, EventArgs e)
        {
            m.OpenI();
            imageBox1.Image = m.sourceImage;
        }
    }
}

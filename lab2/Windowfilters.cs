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
    public partial class Window_filters : Form
    {
        public Window_filters()
        {
            InitializeComponent();
        }

        private void sharpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Text = "-1"; textBox2.Text = "-1"; textBox3.Text = "-1";
            textBox4.Text = "-1"; textBox5.Text = "9"; textBox6.Text = "-1";
            textBox7.Text = "-1"; textBox8.Text = "-1"; textBox9.Text = "-1";
        }

        private void embosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Text = "-4"; textBox2.Text = "-2"; textBox3.Text = "0";
            textBox4.Text = "-2"; textBox5.Text = "1"; textBox6.Text = "2";
            textBox7.Text = "0"; textBox8.Text = "2"; textBox9.Text = "4";
        }

        private void edgesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0"; textBox2.Text = "0"; textBox3.Text = "0";
            textBox4.Text = "-4"; textBox5.Text = "4"; textBox6.Text = "0";
            textBox7.Text = "0"; textBox8.Text = "0"; textBox9.Text = "0";
        }

        private void Apply_Click(object sender, EventArgs e)
        {
            int[,] window_filter = { { int.Parse(textBox1.Text), int.Parse(textBox2.Text), int.Parse(textBox3.Text) },
                                     { int.Parse(textBox4.Text), int.Parse(textBox5.Text), int.Parse(textBox6.Text) },
                                     { int.Parse(textBox7.Text), int.Parse(textBox8.Text), int.Parse(textBox9.Text) } };

            Form1 f = this.Owner as Form1;
            if (f != null)
                f.UP_WindowFilter(window_filter);
        }
    }
}

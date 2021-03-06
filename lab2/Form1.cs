﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.CV.UI;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;
using Emgu.CV.Util;


namespace lab2
{
    public partial class Form1 : Form
    {
        private Manager m = new Manager();
        public Form1()
        {
            InitializeComponent();
            imageBox1.FunctionalMode = ImageBox.FunctionalModeOption.Minimum;
            imageBox2.FunctionalMode = ImageBox.FunctionalModeOption.Minimum;
        }
        //-----------------------------------------
        public void UP_Channel(int channel_Index = -1)
        {
            imageBox2.Image = m.Channel(channel_Index);
        }

        public void UP_Brightness(int BC)
        {
            imageBox2.Image = m.Brightness(BC);
        }

        public void UP_Contrast(int BC)
        {
            imageBox2.Image = m.Contrast(BC);
        }

        public void UP_Addition(Image<Bgr, byte> image)
        {
            imageBox2.Image = m.Addition(image);
        }

        public void UP_Exception(Image<Bgr, byte> image)
        {
            imageBox2.Image = m.Exception(image);
        }

        public void UP_Intersection(Image<Bgr, byte> image)
        {
            imageBox2.Image = m.Intersection(image);
        }

        public void UP_Hue(int hue)
        {
            m.hue = hue;
            imageBox2.Image = m.HSV();
        }

        public void UP_Saturation(int saturation)
        {
            m.saturation = saturation;
            imageBox2.Image = m.HSV();
        }

        public void UP_Value(int value)
        {
            m.value = value;
            imageBox2.Image = m.HSV();
        }

        public void UP_WindowFilter(int[,] window_filter)
        {
            imageBox2.Image = m.WindowFilter(window_filter);
        }

        public void UP_WaterColor(Image<Bgr, byte> image, int brightness, double contrast)
        {
            imageBox2.Image = m.WaterColor(image, brightness, contrast);
        }

        public void UP_CartoonFilter(int thresholdValue)
        {
            imageBox2.Image = m.Cartoon(thresholdValue);
        }
        //-----------------------------------------
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            m.OpenI();
            imageBox1.Image = m.sourceImage;
            imageBox2.Image = m.sourceImage;
        }

        private void chanleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RGB rgb = new RGB();
            rgb.Owner = this;
            rgb.Show();
        }

        private void blackWhiteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            imageBox2.Image = m.Black_White(m.sourceImage);
        }

        private void sepiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            imageBox2.Image = m.Sepia();
        }

        private void brightnessContrastToolStripMenuItem_Click(object sender, EventArgs e)
        {
            B_C bc = new B_C();
            bc.Owner = this;
            bc.Show();
        }

        private void pEIToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AEI aei = new AEI();
            aei.Owner = this;
            aei.Show();
        }

        private void hSVToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HSV hsv = new HSV();
            hsv.Owner = this;
            hsv.Show();
        }

        private void medianBlurToolStripMenuItem_Click(object sender, EventArgs e)
        {
            imageBox2.Image = m.Median_Blur();
        }

        private void windowFilterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Window_filters wf = new Window_filters();
            wf.Owner = this;
            wf.Show();
        }

        private void watercolorFilterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WaterColor w = new WaterColor();
            w.Owner = this;
            w.Show();
        }

        private void cartoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CartoonFilter cf = new CartoonFilter();
            cf.Owner = this;
            cf.Show();
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            imageBox1.Image = m.sourceImage;
            imageBox2.Image = m.sourceImage;
        }
    }
}

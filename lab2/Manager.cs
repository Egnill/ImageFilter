using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;
using Emgu.CV.Util;


namespace lab2
{
    class Manager
    {
        public Image<Bgr, byte> sourceImage = null;
        //private Image<Bgr, byte> result = null;
        public int brightness = 0;
        public int contrast = 1;

        public Manager() { }

        public void OpenI()
        {
            var openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "File Image (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
            var result = openFileDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                string fileName = openFileDialog.FileName;
                sourceImage = new Image<Bgr, byte>(fileName).Resize(500, 500, Inter.Linear);
                //this.result = sourceImage;
            }
        }

        public Image<Gray, byte> Channel(int channel_Index)
        {
            var channel = sourceImage.Split()[channel_Index];
            return channel;
        }

        public Image<Gray, byte> Black_White()
        {
            if (sourceImage == null) { return null; }
            Image<Gray, byte> grayImage = new Image<Gray, byte>(sourceImage.Size);

            for (int x = 0; x < grayImage.Width; x++)
            {
                for (int y = 0; y < grayImage.Height; y++)
                {
                    grayImage.Data[y, x, 0] = Convert.ToByte(0.299 * sourceImage.Data[y, x, 2] + 
                                                             0.587 * sourceImage.Data[y, x, 1] + 
                                                             0.114 * sourceImage.Data[y, x, 0]);
                }
            }

            return grayImage;
        }

        public Image<Bgr, byte> Sepia()
        {
            Image<Bgr, byte> result = sourceImage.Clone();
            byte blue, green, red;

            for (int x = 0; x < result.Width; x++)
            {
                for (int y = 0; y < result.Height; y++)
                {
                    blue = result.Data[y, x, 0];
                    green = result.Data[y, x, 1];
                    red = result.Data[y, x, 2];

                    result.Data[y, x, 0] = test_color(red * 0.272 + green * 0.534 + blue * 0.131);
                    result.Data[y, x, 1] = test_color(red * 0.349 + green * 0.686 + blue * 0.168);
                    result.Data[y, x, 2] = test_color(red * 0.393 + green * 0.769 + blue * 0.189);
                }
            }

            return result;
        }

        private byte test_color(double test)
        {
            if (test > 255) return 255;
            else if (test < 0) return 0;
            else return (byte)test;
        }

        public Image<Bgr, byte> Brightness()
        {
            Image<Bgr, byte> result = sourceImage.Clone();
            int color;

            for (int channel = 0; channel < result.NumberOfChannels; channel++)
            {
                for (int x = 0; x < result.Width; x++)
                {
                    for (int y = 0; y < result.Height; y++)
                    {
                        color = result.Data[y, x, channel];
                        color += brightness;
                        result.Data[y, x, channel] = test_color(color);
                    }
                }
            }

            return result;
        }

        public Image<Bgr, byte> Contrast()
        {
            Image<Bgr, byte> result = sourceImage.Clone();
            if (contrast == 0) contrast = 1;
            int color;

            for (int channel = 0; channel < result.NumberOfChannels; channel++)
            {
                for (int x = 0; x < result.Width; x++)
                {
                    for (int y = 0; y < result.Height; y++)
                    {
                        color = result.Data[y, x, channel];
                        color *= contrast;
                        result.Data[y, x, channel] = test_color(color);
                    }
                }
            }

            return result;
        }

        public Image<Bgr, byte> Addition(Image<Bgr, byte> additional_image)
        {
            Image<Bgr, byte> result = sourceImage.Clone();
            int color;

            for (int channel = 0; channel < result.NumberOfChannels; channel++)
            {
                for (int x = 0; x < result.Width; x++)
                {
                    for (int y = 0; y < result.Height; y++)
                    {
                        color = result.Data[y, x, channel] + additional_image.Data[y, x, channel];
                        result.Data[y, x, channel] = test_color(color);
                    }
                }
            }

            return result;
        }

        public Image<Bgr, byte> Exception(Image<Bgr, byte> additional_image)
        {
            Image<Bgr, byte> result = sourceImage.Clone();
            int color;

            for (int channel = 0; channel < result.NumberOfChannels; channel++)
            {
                for (int x = 0; x < result.Width; x++)
                {
                    for (int y = 0; y < result.Height; y++)
                    {
                        color = result.Data[y, x, channel] - additional_image.Data[y, x, channel];
                        result.Data[y, x, channel] = test_color(color);
                    }
                }
            }

            return result;
        }

        public Image<Bgr, byte> Interseption(Image<Bgr, byte> additional_image)
        {
            Image<Bgr, byte> result = sourceImage.Clone();
            int color;

            for (int channel = 0; channel < result.NumberOfChannels; channel++)
            {
                for (int x = 0; x < result.Width; x++)
                {
                    for (int y = 0; y < result.Height; y++)
                    {
                        color = result.Data[y, x, channel] * (additional_image.Data[y, x, channel] + 1);
                        result.Data[y, x, channel] = test_color(color);
                    }
                }
            }

            return result;
        }

        public Image<Hsv, byte> HSV()
        {
            Image<Hsv, byte> result = sourceImage.Convert<Hsv, byte>();
            
            return result;
        }
    }
}

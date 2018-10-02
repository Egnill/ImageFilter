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
        // for function Brightnes & Contrast
        public int brightness = 0;
        public double contrast = 1;
        //------------------------
        // for HSV
        public int hue = 0;
        public int saturation = 0;
        public int value = 0;
        public int coeff = 1;
        //--------------------
        // for Cartoon Filter
        private int thresholdValue = 3;
        //-----------------------
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
                //this.result = sourceImage.Clone();
            }
        }
        // for Testing
        private byte test_color(double test, int min, int max)
        {
            if (test > max)
            {
                return (byte)max;
            }
            else
            {
                if (test < min)
                {
                    return (byte)min;
                }
                else
                {
                    return (byte)test;
                }
            }
        }
        //------------------------------------------
        private Image<Bgr, byte> DeNoise(Image<Bgr, byte> Noise_Image)
        {
            var tempImage = Noise_Image.PyrDown();
            var result = tempImage.PyrUp();

            return result;
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
            
            return grayImage.Clone();
        }
        // Sepia
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

                    result.Data[y, x, 0] = test_color(red * 0.272 + green * 0.534 + blue * 0.131, 0, 255);
                    result.Data[y, x, 1] = test_color(red * 0.349 + green * 0.686 + blue * 0.168, 0, 255);
                    result.Data[y, x, 2] = test_color(red * 0.393 + green * 0.769 + blue * 0.189, 0, 255);
                }
            }
            return result;
        }

        /*private Image<Bgr, byte> SepiaInClass(Image<Bgr, byte> result)
        {
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
        }*/
        //---------------------------------------------------------------
        // Brightness
        public Image<Bgr, byte> Brightness(int BrightnessValue)
        {
            Image<Bgr, byte> result = sourceImage.Clone();
            brightness = BrightnessValue;
            result = ContrastInClass(result);
            return BrightnessInClass(result);
        }

        private Image<Bgr, byte> BrightnessInClass(Image<Bgr, byte> result)
        {
            int color;
            
            for (int channel = 0; channel < result.NumberOfChannels; channel++)
            {
                for (int x = 0; x < result.Width; x++)
                {
                    for (int y = 0; y < result.Height; y++)
                    {
                        color = result.Data[y, x, channel];
                        color += brightness;
                        result.Data[y, x, channel] = test_color(color, 0, 255);
                    }
                }
            }

            return result;
        }
        //--------------------------------------------------------------------
        // Contrast
        public Image<Bgr, byte> Contrast(int ContrastValue)
        {
            Image<Bgr, byte> result = sourceImage.Clone();
            
            if (ContrastValue == 0) contrast = 1;
            else contrast = ContrastValue;

            result = BrightnessInClass(result);
            return ContrastInClass(result);
        }

        private Image<Bgr, byte> ContrastInClass(Image<Bgr, byte> result)
        {
            double color;
            
            for (int channel = 0; channel < result.NumberOfChannels; channel++)
            {
                for (int x = 0; x < result.Width; x++)
                {
                    for (int y = 0; y < result.Height; y++)
                    {
                        color = result.Data[y, x, channel];
                        color *= contrast;
                        result.Data[y, x, channel] = test_color(color, 0, 255);
                    }
                }
            }

            return result;
        }
        //--------------------------------------------------------------------
        // Addition
        public Image<Bgr, byte> Addition(Image<Bgr, byte> additional_image)
        {
            Image<Bgr, byte> result = sourceImage.Clone();

            return AdditionInClass(result, additional_image);
        }

        private Image<Bgr, byte> AdditionInClass(Image<Bgr, byte> result, Image<Bgr, byte> additional_image)
        {
            double color;

            for (int channel = 0; channel < result.NumberOfChannels; channel++)
            {
                for (int x = 0; x < result.Width; x++)
                {
                    for (int y = 0; y < result.Height; y++)
                    {
                        color = result.Data[y, x, channel] * 0.7 + additional_image.Data[y, x, channel] * 0.3;
                        result.Data[y, x, channel] = test_color(color, 0, 255);
                    }
                }
            }

            return result;
        }
        //----------------------------------------------------------------------------------------------------
        public Image<Bgr, byte> Exception(Image<Bgr, byte> additional_image)
        {
            Image<Bgr, byte> result = sourceImage.Clone();
            double color;

            for (int channel = 0; channel < result.NumberOfChannels; channel++)
            {
                for (int x = 0; x < result.Width; x++)
                {
                    for (int y = 0; y < result.Height; y++)
                    {
                        color = result.Data[y, x, channel] * 0.7 - additional_image.Data[y, x, channel] * 0.3;
                        result.Data[y, x, channel] = test_color(color, 0, 255);
                    }
                }
            }

            return result;
        }

        public Image<Bgr, byte> Intercsection(Image<Bgr, byte> additional_image)
        {
            Image<Bgr, byte> result = sourceImage.Clone();
            return IntersectionInClass(result, additional_image);
        }

        private Image<Bgr, byte> IntersectionInClass(Image<Bgr, byte> result, Image<Bgr, byte> additional_image)
        {
            for (int channel = 0; channel < result.NumberOfChannels; channel++)
            {
                for (int x = 0; x < result.Width; x++)
                {
                    for (int y = 0; y < result.Height; y++)
                    {
                        if (additional_image.Data[y, x, channel] == 0)
                        {
                            result.Data[y, x, channel] = 0;
                        }
                    }
                }
            }

            return result;
        }

        public Image<Hsv, byte> HSV()
        {
            Image<Hsv, byte> result = sourceImage.Convert<Hsv, byte>();

            for (int x = 0; x < result.Width; x++)
            {
                for (int y = 0; y < result.Height; y++)
                {
                    result.Data[y, x, 0] = (byte)(result.Data[y, x, 0] + hue);
                    result.Data[y, x, 1] = (byte)(result.Data[y, x, 1] + saturation);
                    result.Data[y, x, 2] = (byte)(result.Data[y, x, 2] + value);
                }
            }

            return result;
        }
        // Blur
        public Image<Bgr, byte> Median_Blur()
        {
            Image<Bgr, byte> result = sourceImage.Clone();

            return Median_BlurInClass(result);
        }

        private Image<Bgr, byte> Median_BlurInClass(Image<Bgr, byte> result)
        {
            List<byte> helper_sort = new List<byte>();

            for (byte channel = 0; channel < result.NumberOfChannels; channel++)
            {
                for (int x = 1; x < result.Width - 1; x++)
                {
                    for (int y = 1; y < result.Height - 1; y++)
                    {
                        for (sbyte i = -1; i < 2; i++)
                        {
                            for (sbyte j = -1; j < 2; j++)
                            {
                                helper_sort.Add(sourceImage.Data[y + j, x + i, channel]);
                            }
                        }

                        helper_sort.Sort();
                        result.Data[y, x, channel] = helper_sort[4];

                        helper_sort.Clear();
                    }
                }
            }

            return result.Clone();

             /*sbyte[,] window_filter = { { 1, 1, 1 },
                                        { 1, 1, 1 },
                                        { 1, 1, 1 } };*/
            /*double value = 0;

            for (byte channel = 0; channel < result.NumberOfChannels; channel++)
            {
                for (int x = 1; x < result.Width - 1; x++)
                {
                    for (int y = 1; y < result.Height - 1; y++)
                    {
                        for (sbyte i = -1; i < 2; i++)
                        {
                            for (sbyte j = -1; j < 2; j++)
                            {
                                value += sourceImage.Data[y + j, x + i, channel] /** window_filter[j + 1, i + 1]*/;
                            /*}
                        }

                        result.Data[y, x, channel] = test_color(value / 9);
                        value = 0;
                    }
                }
            }

            return result;*/
        }
        //--------------------------------------------
        public Image<Bgr, byte> WindowFilter(int[,] window_filter)
        {
            Image<Gray, byte> result = Black_White(), sI = Black_White();
            double value = 0;
            for (byte channel = 0; channel < result.NumberOfChannels; channel++)
            {
                for (int x = 1; x < result.Width - 1; x++)
                {
                    for (int y = 1; y < result.Height - 1; y++)
                    {
                        
                        for (sbyte i = -1; i < 2; i++)
                        {
                            for (sbyte j = -1; j < 2; j++)
                            {
                                value += sI.Data[y + j, x + i, channel] * window_filter[i + 1, j + 1];
                            }
                        }

                        result.Data[y, x, channel] = test_color(value, 0, 255);
                        value = 0;
                    }
                }
            }
            
            return result.Convert<Bgr, byte>();
        }

        public Image<Bgr, byte> WaterColor(Image<Bgr, byte> mask, int bright, double cont)
        {
            Image<Bgr, byte> result = sourceImage.Clone();
            brightness = bright;
            contrast = cont;

            result = Median_BlurInClass(result);
            result = BrightnessInClass(result);
            result = ContrastInClass(result);
            result = AdditionInClass(result, mask);
            return result;
        }

        public Image<Bgr, byte> Cartoon(int thresholdValue)
        {
            if (thresholdValue % 2 == 1)
            {
                this.thresholdValue = thresholdValue;
            }
            Image<Gray, byte> resultBW = Black_White().Clone();
            resultBW = Median_BlurInClass(resultBW.Convert<Bgr, byte>()).Convert<Gray, byte>().Clone();
            resultBW = resultBW.ThresholdAdaptive(new Gray(100), AdaptiveThresholdType.MeanC, ThresholdType.Binary, this.thresholdValue, new Gray(0.03)).Clone();
            Image<Bgr, byte> result = IntersectionInClass(sourceImage, resultBW.Convert<Bgr, byte>()).Clone();

            return result;
        }
    }
}

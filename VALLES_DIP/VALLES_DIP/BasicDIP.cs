using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VALLES_DIP
{
    static class BasicDIP

    {

        public static void Subtraction(ref Bitmap image, ref Bitmap background, ref Bitmap subtract)
        {
            Color mygreen = Color.FromArgb(0, 0, 255);
            int greygreen = (mygreen.R + mygreen.G + mygreen.B) / 3;
            int threshold = 5;

            Color pixel, backpixel;

            subtract = new Bitmap(image.Width, image.Height);

            for(int i = 0; i < image.Width; i++)
            {
                for (int j = 0; j < image.Height; j++) { 
                    pixel = image.GetPixel(i, j);
                    backpixel = background.GetPixel(i,j);

                    int grey = (pixel.R + pixel.G + pixel.B) / 3;
                    int subtractvalue = Math.Abs(grey - greygreen);
                    if (subtractvalue > threshold) {
                        subtract.SetPixel(i, j, pixel);
                    } else
                    {
                        subtract.SetPixel(i, j, backpixel);
                    }

                }
            }
        }

        public static void Brightness(ref Bitmap loaded, ref Bitmap processed, int value)
        {
            Color pixel;
            processed = new Bitmap(loaded.Width, loaded.Height);

            for (int x = 0; x < loaded.Width; x++)
            {
                for (int y = 0; y < loaded.Height; y++)
                {
                    pixel = loaded.GetPixel(x, y);


                    if (value > 0)
                    {
                        pixel = Color.FromArgb(Math.Min(pixel.R + value, 255), Math.Min(pixel.G + value, 255), Math.Min(pixel.B + value, 255));
                    }
                    else {
                        pixel = Color.FromArgb(Math.Max(pixel.R + value, 0), Math.Max(pixel.G + value, 0), Math.Max(pixel.B + value, 0));
                    }

                    processed.SetPixel(x, y, pixel);
                }
            }


        }

        public static void Histogram(ref Bitmap loaded, ref Bitmap processed)
        {
            Color pixel;
            int grayscale;

            int[] histodata = new int[256];

            for (int x = 0; x < loaded.Width; x++)
            {
                for (int y = 0; y < loaded.Height; y++)
                {
                    pixel = loaded.GetPixel(x, y);


                    grayscale = (pixel.R + pixel.G + pixel.B) / 3;

                    histodata[grayscale]++;
                }
            }

            processed = new Bitmap(256, 200);

            for (int x = 0; x < processed.Width; x++)
            {
                for (int y = 0; y < processed.Height; y++)
                {
                    processed.SetPixel(x, y, Color.White);
                }

            }

            for (int x = 0; x < processed.Width; x++)
            {
                for (int y = 0; y < Math.Min(histodata[x] / 5 , processed.Height - 1); y++)
                {
                    processed.SetPixel(x, (processed.Height - 1) - y, Color.Black);
                }
            }




        }
    }
}

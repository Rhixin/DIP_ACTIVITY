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

        public static void Rotate(ref Bitmap a, ref Bitmap b, int value)
        {
            float angleRadians = (float)(value * Math.PI / 180);
            float sinA = (float)Math.Sin(angleRadians);
            float cosB = (float)Math.Cos(angleRadians);

            int width = a.Width;
            int height = a.Height;

            int xcenter = (int)(width / 2);
            int ycenter = (int)(height / 2);

            int xp, yp, xs, ys, x0, y0;

            b = new Bitmap(width, height);

            for (xp = 0; xp < width; xp++) {
                for (yp = 0; yp < height; yp++) { 
                    x0 = xp - xcenter;
                    y0 = yp - ycenter;

                    xs = (int)(x0 * cosB + y0 * sinA) + xcenter;
                    ys = (int)(-x0 * sinA + y0 * cosB) + ycenter;

                    b.SetPixel(xp, yp, a.GetPixel(Math.Max(Math.Min(width - 1, xs), 0),Math.Max(Math.Min(height - 1, ys), 0)));
                
                }
            }
        }

        public static void Scale(ref Bitmap a, ref Bitmap b, int nwidth, int nheight) {
            int width = a.Width;
            int height = a.Height;

            int xs, ys;

            b = new Bitmap(nwidth, nheight);
            for (int x = 0; x < nwidth; x++) {
                for (int y = 0; y < nheight; y++) { 
                    xs = (int) (x * width / nwidth);
                    ys = (int) (y * height / nheight);

                    b.SetPixel(x, y, a.GetPixel(xs,ys));

                }
            }
        
        }
    }
}

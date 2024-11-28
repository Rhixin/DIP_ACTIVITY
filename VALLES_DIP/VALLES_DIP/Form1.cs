using System.Windows.Forms;
using WebCamLib;
using ImageProcess2;

namespace VALLES_DIP
{
    public partial class Form1 : Form
    {

        Bitmap loaded, processed, image, background, subtracted;
        Device[] devices;

        public Form1()
        {
            //here
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            devices = DeviceManager.GetAllDevices();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }


        private void openToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }

        private void openFileDialog1_FileOk_1(object sender, System.ComponentModel.CancelEventArgs e)
        {
            loaded = new Bitmap(openFileDialog1.FileName);
            pictureBox1.Image = loaded;
        }

        private void pixelCopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            processed = new Bitmap(loaded.Width, loaded.Height);
            Color pixel;
            for (int x = 0; x < loaded.Width; x++)
            {
                for (int y = 0; y < loaded.Height; y++)
                {
                    pixel = loaded.GetPixel(x, y);
                    processed.SetPixel(x, y, pixel);
                }
            }

            pictureBox2.Image = processed;
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
        }

        private void saveFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {
            processed.Save(saveFileDialog1.FileName);
        }

        private void grayscaleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            processed = new Bitmap(loaded.Width, loaded.Height);
            Color pixel;
            int grayscale;

            for (int x = 0; x < loaded.Width; x++)
            {
                for (int y = 0; y < loaded.Height; y++)
                {
                    pixel = loaded.GetPixel(x, y);


                    grayscale = (pixel.R + pixel.G + pixel.B) / 3;

                    pixel = Color.FromArgb(grayscale, grayscale, grayscale);

                    processed.SetPixel(x, y, pixel);
                }
            }

            pictureBox2.Image = processed;
        }

        private void inversionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            processed = new Bitmap(loaded.Width, loaded.Height);
            Color pixel;

            for (int x = 0; x < loaded.Width; x++)
            {
                for (int y = 0; y < loaded.Height; y++)
                {
                    pixel = loaded.GetPixel(x, y);
                    pixel = Color.FromArgb(255 - pixel.R, 255 - pixel.G, 255 - pixel.B);

                    processed.SetPixel(x, y, pixel);
                }
            }

            pictureBox2.Image = processed;
        }

        private void sepiaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            processed = new Bitmap(loaded.Width, loaded.Height);
            Color pixel;
            int r, g, b;

            for (int x = 0; x < loaded.Width; x++)
            {
                for (int y = 0; y < loaded.Height; y++)
                {
                    pixel = loaded.GetPixel(x, y);

                    r = (int)Math.Min(0.393 * pixel.R + 0.769 * pixel.G + 0.189 * pixel.B, 255);
                    g = (int)Math.Min(0.349 * pixel.R + 0.686 * pixel.G + 0.168 * pixel.B, 255);
                    b = (int)Math.Min(0.272 * pixel.R + 0.534 * pixel.G + 0.131 * pixel.B, 255);


                    pixel = Color.FromArgb(r, g, b);

                    processed.SetPixel(x, y, pixel);
                }
            }

            pictureBox2.Image = processed;
        }

        private void histogramToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BasicDIP.Histogram(ref loaded, ref processed);

            pictureBox2.Image = processed;
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            BasicDIP.Brightness(ref loaded, ref processed, trackBar1.Value);
            pictureBox2.Image = processed;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog2.ShowDialog();
        }

        private void openFileDialog2_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {
            image = new Bitmap(openFileDialog2.FileName);
            pictureBox3.Image = image;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            openFileDialog3.ShowDialog();
        }

        private void openFileDialog3_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {
            background = new Bitmap(openFileDialog3.FileName);
            pictureBox4.Image = background;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            BasicDIP.Subtraction(ref image, ref background, ref subtracted);

            pictureBox5.Image = subtracted;

        }


        private void button5_Click(object sender, EventArgs e)
        {
            saveFileDialog2.ShowDialog();
        }

        private void saveFileDialog2_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {
            subtracted.Save(saveFileDialog2.FileName);
        }

        private void onToolStripMenuItem_Click(object sender, EventArgs e)
        {
            devices[0].ShowWindow(pictureBox1);
        }

        private void offToolStripMenuItem_Click(object sender, EventArgs e)
        {
            devices[0].Stop();
            timer1.Stop();
        }



        private void grayscaleToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //get 1 frame
            IDataObject data;
            Image bmap;
            devices[0].Sendmessage();
            data = Clipboard.GetDataObject();
            bmap = (Image)(data.GetData("System.Drawing.Bitmap", true));
            Bitmap b = new Bitmap(bmap);

            BitmapFilter.GrayScale(b);

            pictureBox2.Image = b;


        }


        private void smoothingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            processed = new Bitmap(loaded);
            BitmapFilter.Smooth(processed, 1);
            pictureBox2.Image = processed;
        }

        private void gaussianBlurToolStripMenuItem_Click(object sender, EventArgs e)
        {
            processed = new Bitmap(loaded);
            BitmapFilter.GaussianBlur(processed, 20);
            pictureBox2.Image = processed;
        }

        private void sharpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            processed = new Bitmap(loaded);
            BitmapFilter.Sharpen(processed, 11);
            pictureBox2.Image = processed;
        }

        private void meanRemovalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            processed = new Bitmap(loaded);
            BitmapFilter.MeanRemoval(processed, 9);
            pictureBox2.Image = processed;
        }

        private void embossingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            processed = new Bitmap(loaded);
            BitmapFilter.EmbossLaplacian(processed);
            pictureBox2.Image = processed;
        }

        private void edgeDetectQuickToolStripMenuItem_Click(object sender, EventArgs e)
        {
            processed = new Bitmap(loaded);
            BitmapFilter.EdgeDetectQuick(processed);
            pictureBox2.Image = processed;
        }

        private void edgeDetectHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            processed = new Bitmap(loaded);
            BitmapFilter.EdgeDetectHorizontal(processed);
            pictureBox2.Image = processed;
        }

        private void edgeDetectVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            processed = new Bitmap(loaded);
            BitmapFilter.EdgeDetectVertical(processed);
            pictureBox2.Image = processed;
        }

        private void coinsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.ShowDialog();
        }
    }
}

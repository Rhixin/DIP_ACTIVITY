using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ImageProcess2;

namespace VALLES_DIP
{
    public partial class Form2 : Form
    {
        Bitmap loaded, processed;
        List<int> coinsArea = new List<int>();
        bool[,] visited_pixels;
        double TotalValue = 0;
        int peso_5 = 0, peso_1 = 0, cent_25 = 0, cent_10 = 0, cent_5 = 0;

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            loaded = new Bitmap(openFileDialog1.FileName);
            pictureBox1.Image = loaded;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {   
            //step 1 kay gaussian
            BitmapFilter.GaussianBlur(loaded, 10);

            //step 2 kay grayscale
            BitmapFilter.GrayScale(loaded);

            //step 3 kay binary or threshold
            BitmapFilter.Binary(loaded, 200);

            //step 4 initialize before mag bfs lezgo
            visited_pixels = new bool[loaded.Width, loaded.Height];

            //step 5 visit each pixel nya if kakitag black kay bfs to get Area
            for(int x =0; x < loaded.Width; x++)
            {
                for(int y = 0; y < loaded.Height; y++)
                {

                    Color current_pixel = loaded.GetPixel(x, y);
                    Point current_point = new Point(x, y);

                    //if black then we can start the bfs
                    if (isBlack(current_pixel) && !visited_pixels[current_point.X, current_point.Y])
                    {
                        //this is the area of the coin
                        int new_coin_area = getCoinArea(current_point);

                        //validate this coin area, basin diay dot rani or smudge
                        if (new_coin_area > 50)
                        {
                            //add the new area entry to the global list
                            coinsArea.Add(new_coin_area);
                        }
                        
                        
                    }
                }
            }

            //this determines ang threshold size of each coin
            int coinSizeThreshold = 300;
            getCoinAreaValue(coinSizeThreshold);
        }


        private int getCoinArea(Point start_point)
        {
            int area = 1;

            //ignite the bfs start sa given point
            Queue<Point> myQueue = new Queue<Point>();
            myQueue.Enqueue(start_point);
            visited_pixels[start_point.X, start_point.Y] = true;

            //directions para easy ang pag get sa neighbors
            int[] dx = { 1, -1, 0, 0 };
            int[] dy = { 0, 0, 1, -1 };

            while (myQueue.Count > 0)
            {
                Point currentPoint = myQueue.Dequeue();


                for (int i = 0; i < 4; i++)
                {
                    int newX = currentPoint.X + dx[i];
                    int newY = currentPoint.Y + dy[i];

                    // Check if the neighbor is within bounds and not visited
                    if (newX >= 0 && newX < loaded.Width && newY >= 0 && newY < loaded.Height && !visited_pixels[newX, newY])
                    {
                        //Check if BLACK pixeeel
                        Color pixelColor = loaded.GetPixel(newX, newY);
                        if (isBlack(pixelColor))
                        {
                            // If the pixel is black, mark it as visited and enqueue it
                            visited_pixels[newX, newY] = true;
                            myQueue.Enqueue(new Point(newX, newY));

                            //add area to this specific coin
                            area++;
                        }
                    }
                }
                

            }

            return area;
        }


        private bool isBlack(Color p)
        {
            return p.R == 0 && p.G == 0 && p.B == 0;
        }


        private void getCoinAreaValue(int coinSizeThreshold)
        {
            coinsArea.Sort();

            List<List<int>> groupedCoins = new List<List<int>>();
            List<int> currentGroup = new List<int> { coinsArea[0] };


            for (int i = 1; i < coinsArea.Count; i++)
            {
                if (coinsArea[i] - currentGroup[0] <= coinSizeThreshold)
                {
                    // Add to the current group if within threshold
                    currentGroup.Add(coinsArea[i]);
                }
                else
                {
                    // Start a new group
                    groupedCoins.Add(new List<int>(currentGroup));
                    currentGroup.Clear();
                    currentGroup.Add(coinsArea[i]);
                }
            }


            groupedCoins.Add(new List<int>(currentGroup));



            peso_5 = groupedCoins[4].Count;
            peso_1 = groupedCoins[3].Count;
            cent_25 = groupedCoins[2].Count;
            cent_10 = groupedCoins[1].Count;
            cent_5 = groupedCoins[0].Count;

            label1.Text = "Total 5 Peso coins (" + peso_5.ToString() + " pcs): ₱" + (5 * peso_5).ToString();
            label2.Text = "Total 1 Peso coins (" + peso_1.ToString() + " pcs): ₱" + peso_1.ToString();
            label3.Text = "Total 25 Cent coins (" + cent_25.ToString() + " pcs): ₱" + (0.25 * cent_25).ToString();
            label4.Text = "Total 10 Cent coins (" + cent_10.ToString() + " pcs): ₱" + (0.10 * cent_10).ToString();
            label5.Text = "Total 5 Cent coins (" + cent_5.ToString() + " pcs): ₱" + (0.05 * cent_5).ToString();

            TotalValue = 5 * peso_5 + peso_1 + 0.25 * cent_25 + 0.10 * cent_10 + 0.05 * cent_5;
            label6.Text = "Total Amount: ₱" + TotalValue.ToString();
        }


    }   
}

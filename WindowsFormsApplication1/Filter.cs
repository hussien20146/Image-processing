using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Filter : Form
    {
        public Filter()
        {
            InitializeComponent();
        }
        //The Enhancement Filter
        private void button4_Click(object sender, EventArgs e)
        {
            Bitmap bmp = new Bitmap(pictureBox3.Image);
            Bitmap lablacin = new Bitmap((bmp.Width) + 1, (bmp.Height) + 1);
            Color p1; double sum;
            int[] mask = { -1, -1, -1, -1, 9, -1, -1, -1, -1 };
            for (int x = 1; x < (bmp.Width) - 1; x++)
            {
                for (int y = 1; y < (bmp.Height) - 1; y++)
                {
                    sum = 0.0;
                    int d = 0;
                    for (int m = x - 1; m <= x + 1; m++)
                    {
                        for (int n = y - 1; n <= y + 1; n++)
                        {
                            p1 = bmp.GetPixel(m, n);
                            sum += (p1.R * mask[d]);
                            d++;
                        }
                    }
                    if (sum < 0)
                        sum = 0;
                    else if (sum > 255)
                        sum = 255;

                    lablacin.SetPixel(x, y, Color.FromArgb((int)sum, (int)sum, (int)sum));

                }
            }
            pictureBox2.Image = lablacin;

        }
        //Add Image
        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Add Image";
            ofd.Filter = "Image |*.jpg";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(ofd.FileName);
            }
        }
        //Mean Filter
        private void button2_Click(object sender, EventArgs e)
        {
            Bitmap bmp = new Bitmap(pictureBox3.Image);
            Bitmap bmp3 = new Bitmap((bmp.Width) + 1, (bmp.Height) + 1);
            Color p1; double avg1;
            for (int  i = 1; i < (bmp.Width) - 1; i++)
            {
                for (int  j = 1; j < (bmp.Height) - 1; j++)
                {
                    avg1 = 0.0;
                    for (int k1 = i - 1; k1 < i + 1; k1++)
                    {
                        for (int k2 = j - 1; k2 < j + 1; k2++)
                        {
                            p1 = bmp.GetPixel(k1, k2);
                            avg1 += p1.R *(0.11);                 
		                }
                    }
                    bmp3.SetPixel(i, j, Color.FromArgb((int)avg1, (int)avg1, (int)avg1));
                }
            }
            pictureBox2.Image = bmp3;

        }
        //Median Filter
        private void button3_Click(object sender, EventArgs e)
        {
            Bitmap bmp = new Bitmap(pictureBox3.Image);
            Bitmap meadin = new Bitmap(bmp.Width + 1, bmp.Height + 1);
            int[] a = new int[9];
            Color q; int s = 0;
            for (int i = 1; i < bmp.Width - 1; i++)
            {
                for (int j = 1; j < bmp.Height - 1; j++)
                {
                    s = 0;
                    for (int m = i - 1; m <= i + 1; m++)
                    {
                        for (int n = j - 1; n <= j + 1; n++)
                        {
                            q = bmp.GetPixel(m, n);
                            a[s] = q.R;
                            s++;
                        }
                    }
                    Array.Sort(a);
                    int avg = a[4];
                    meadin.SetPixel(i, j, Color.FromArgb(avg, avg, avg));
                }
            }
            pictureBox2.Image = meadin;

        }
        //Edge detection Filter
        private void button5_Click(object sender, EventArgs e)
        {
            Bitmap bmp = new Bitmap(pictureBox3.Image);
            Bitmap edg = new Bitmap(bmp.Width + 1, bmp.Height + 1);
            Color o; double avg;
            int[] mask = { -1, -1, -1, -1, 8, -1, -1, -1, -1 };
            for (int i = 1; i < bmp.Width - 1; i += 1)
            {
                for (int j = 1; j < bmp.Height - 1; j += 1)
                {
                    int x = 0; avg = 0.0;
                    for (int m = i - 1; m <= i + 1; m++)
                    {
                        for (int n = j - 1; n <= j + 1; n++)
                        {
                            o = bmp.GetPixel(m, n);
                            avg += (o.R * mask[x]);
                            x++;
                        }
                    }
                    if (avg < 0)
                        avg = 0;
                    if (avg > 255)
                        avg = 255;
                    edg.SetPixel(j, i, Color.FromArgb((int)avg, (int)avg, (int)avg));
                }
            }
            pictureBox2.Image = edg;

        }
        //To_Gray
        private void button6_Click(object sender, EventArgs e)
        {
            Bitmap bmp = new Bitmap(pictureBox1.Image);
            int width = bmp.Width;
            int height = bmp.Height;
            Bitmap gray = new Bitmap(width, height);
            Color p;
            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < height; j++)
                {
                    p = bmp.GetPixel(i, j);
                    int a = p.A;
                    int r = p.R;
                    int b = p.B;
                    int g = p.G;
                    int avg = (r + b + g) / 3;
                    gray.SetPixel(i, j, Color.FromArgb(a, avg, avg, avg));
                }
            }
            pictureBox3.Image = gray;
        }
        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);
            Application.Exit();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            this.Hide();
        }
    }
}

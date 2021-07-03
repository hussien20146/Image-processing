using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class zoom : Form
    {
        public zoom()
        {
            InitializeComponent();
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
        //To_Gray
        private void button2_Click(object sender, EventArgs e)
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
            pictureBox2.Image = gray;
        }
        //Zoom Zero-Order hold
        private void button19_Click(object sender, EventArgs e)
        {
            Bitmap bmp = new Bitmap(pictureBox1.Image);
            Bitmap zoom = new Bitmap((bmp.Width * 2), (bmp.Height * 2));
            int s = 0, u = 0;
            Color p;
            for (int x = 0; x < bmp.Width - 1; x++)
            {
                s = 0;
                for (int y = 0; y < bmp.Height - 1; y++)
                {
                    p = bmp.GetPixel(x,y);
                    zoom.SetPixel(u, s, p);
                    zoom.SetPixel(u, s + 1, p);
                    zoom.SetPixel(u + 1, s, p);
                    zoom.SetPixel(u + 1, s + 1, p);
                    s += 2;
                }
                u += 2;
            }
            pictureBox7.Image = zoom;
        }
        //zoom first order
        private void button20_Click(object sender, EventArgs e)
        {
            Bitmap bmp = new Bitmap(pictureBox2.Image);
            Bitmap zoom = new Bitmap((bmp.Width * 2) - 1, (bmp.Height * 2) - 1);
            Color p1, p2, p3, p4;
            int s = 0, u = 0;
            for (int x = 0; x < bmp.Width - 1; x++)
            {
                s = 0;
                for (int y = 0; y < bmp.Height - 1; y++)
                {
                    p1 = bmp.GetPixel(x, y);
                    p3 = bmp.GetPixel(x + 1, y);
                    p2 = bmp.GetPixel(x, y + 1);
                    p4 = bmp.GetPixel(x + 1, y + 1);
                    int av1 = (p1.R + p3.R) / 2;
                    int av2 = (p1.R + p2.R) / 2;
                    int av = (p3.R + p4.R) / 2;
                    int av3 = (av2 + av) / 2;
                    zoom.SetPixel(u, s, p1);
                    zoom.SetPixel(u + 1, s, Color.FromArgb(av1, av1, av1));
                    zoom.SetPixel(u, s + 1, Color.FromArgb(av2, av2, av2));
                    zoom.SetPixel(u + 1, s + 1, Color.FromArgb(av3, av3, av3));
                    s += 2;
                }
                u += 2;
            }
            pictureBox7.Image = zoom;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Bitmap bmp = new Bitmap(pictureBox1.Image);
            Bitmap zoom = new Bitmap((bmp.Width * 2) - 1, (bmp.Height * 2) - 1);
            Color p1, p2, p3, p4;
            int s = 0, u = 0;
            for (int x = 0; x < bmp.Width - 1; x++)
            {
                s = 0;
                for (int y = 0; y < bmp.Height - 1; y++)
                {
                    p1 = bmp.GetPixel(x, y);
                    p3 = bmp.GetPixel(x + 1, y);
                    p2 = bmp.GetPixel(x, y + 1);
                    p4 = bmp.GetPixel(x + 1, y + 1);
                    int av1 = (p1.R + p3.R) / 2;
                    int av11 = (p1.G + p3.G) / 2;
                    int av111 = (p1.B + p3.B) / 2;

                    int av2 = (p1.R + p2.R) / 2;
                    int av22 = (p1.G + p2.G) / 2;
                    int av222 = (p1.B + p2.B) / 2;

                    int av = (p3.R + p4.R) / 2;
                    int aav = (p3.G + p4.G) / 2;
                    int aaav = (p3.B + p4.B) / 2;

                    int av3 = (av2 + av) / 2;
                    int av33 = (av2 + aav) / 2;
                    int av333 = (av2 + aaav) / 2;

                    zoom.SetPixel(u, s, p1);
                    zoom.SetPixel(u + 1, s, Color.FromArgb(av1, av11, av11));

                    zoom.SetPixel(u, s + 1, Color.FromArgb(av2, av22, av22));

                    zoom.SetPixel(u + 1, s + 1, Color.FromArgb(av3, av33, av333));
                    s += 2;
                }
                u += 2;
            }
            pictureBox7.Image = zoom;
        }
        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);
            Application.Exit();
        }
        //Convolution (Gray)
        private void button5_Click(object sender, EventArgs e)
        {
            Bitmap bmp = new Bitmap(pictureBox2.Image);
            Bitmap zoom = new Bitmap((bmp.Width * 2) + 1, (bmp.Height * 2) + 1);
            Color p, r;
            int m = 0, n = 0;
            for (int x = 0; x < bmp.Height; x++)
            {
                m = 0;
                for (int y = 0; y < bmp.Width; y++)
                {
                    p = bmp.GetPixel(y, x);
                    zoom.SetPixel(m, n, p);
                    zoom.SetPixel(m, n + 1, Color.FromArgb(0, 0, 0));
                    zoom.SetPixel(m + 1, n, Color.FromArgb(0, 0, 0));
                    zoom.SetPixel(m + 1, n + 1, Color.FromArgb(0, 0, 0));
                    m += 2;
                }
                n += 2;
            }
            //pictureBox7.Image = zoom;

            double[] mask = { 0.25, 0.5, 0.25, 0.5, 1, 0.5, 0.25, 0.5, 0.25 };
            int d = 0; double sum;
            Bitmap conf = new Bitmap((bmp.Width * 2), (bmp.Height * 2));
            for (int i = 1; i < (bmp.Width * 2) - 1; i++)
            {
                for (int j = 1; j < (bmp.Height * 2) - 1; j++)
                {
                    sum = 0.0; d = 0;
                    for (int k1 = i - 1; k1 <= i + 1; k1++)
                    {
                        for (int k2 = j - 1; k2 <= j + 1; k2++)
                        {
                            r = zoom.GetPixel(k1, k2);
                            sum += (r.R * mask[d]);
                            d++;
                        }
                    }
                    conf.SetPixel(i, j, Color.FromArgb((int)sum, (int)sum, (int)sum));
                }
            } 
            pictureBox7.Image = conf;
        }
        //Convolution (Color)
        private void button6_Click(object sender, EventArgs e)
        {
            Bitmap bmp = new Bitmap(pictureBox1.Image);
            Bitmap zoom = new Bitmap((bmp.Width * 2) + 1, (bmp.Height * 2) + 1);
            Color p, r;
            int m = 0, n = 0;
            for (int x = 0; x < bmp.Height; x++)
            {
                m = 0;
                for (int y = 0; y < bmp.Width; y++)
                {
                    p = bmp.GetPixel(y, x);
                    zoom.SetPixel(m, n, p);
                    zoom.SetPixel(m, n + 1, Color.FromArgb(0, 0, 0));
                    zoom.SetPixel(m + 1, n, Color.FromArgb(0, 0, 0));
                    zoom.SetPixel(m + 1, n + 1, Color.FromArgb(0, 0, 0));
                    m += 2;
                }
                n += 2;
            }
            //pictureBox7.Image = zoom;

            double[] mask = { 0.25, 0.5, 0.25, 0.5, 1, 0.5, 0.25, 0.5, 0.25 };
            int d = 0; double sum1, sum2, sum3;
            Bitmap conf = new Bitmap((bmp.Width * 2), (bmp.Height * 2));
            for (int i = 1; i < (bmp.Width * 2) - 1; i++)
            {
                for (int j = 1; j < (bmp.Height * 2) - 1; j++)
                {
                    sum1 = 0.0; sum2 = 0.0; sum3 = 0.0; d = 0;
                    for (int k1 = i - 1; k1 <= i + 1; k1++)
                    {
                        for (int k2 = j - 1; k2 <= j + 1; k2++)
                        {
                            r = zoom.GetPixel(k1, k2);
                            sum1 += (r.R * mask[d]);
                            sum2 += (r.G * mask[d]);
                            sum3 += (r.B * mask[d]);
                            d++;
                        }
                    }
                    conf.SetPixel(i, j, Color.FromArgb((int)sum1, (int)sum2, (int)sum3));
                }
            }
            pictureBox7.Image = conf;
        }

        private void button21_Click(object sender, EventArgs e)
        {
            SaveFileDialog s = new SaveFileDialog();
            s.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
            s.RestoreDirectory = true;
            s.DefaultExt = ".jpg";
            if (s.ShowDialog() == DialogResult.OK)
            {
                string fileName = s.FileName;

                FileStream fstream = new FileStream(fileName, FileMode.Create);
                pictureBox7.Image.Save(fstream, System.Drawing.Imaging.ImageFormat.Jpeg);
                fstream.Close();
                MessageBox.Show("Save");

            }
        }
    }
}

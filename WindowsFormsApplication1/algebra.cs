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
    public partial class algebra : Form
    {
        public algebra()
        {
            InitializeComponent();
        }
        //Add Image 1
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
        //Add Image 2
        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Add Image";
            ofd.Filter = "Image |*.jpg";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pictureBox2.Image = Image.FromFile(ofd.FileName);
            }
        }
        //NOT
        private void button5_Click(object sender, EventArgs e)
        {
            Bitmap bmp = new Bitmap(pictureBox1.Image);
            Bitmap bmp2 = new Bitmap(pictureBox2.Image);
            Bitmap bm = new Bitmap(bmp.Width, bmp.Height);
            Color p, p2;
            for (int y = 0; y < bmp.Height; y++)
            {
                for (int x = 0; x < bmp.Width; x++)
                {
                    p = bmp.GetPixel(x, y);
                    p2 = bmp2.GetPixel(x, y);
                    int a = p.A;
                    int r = p.R;
                    int res1 = 255 - r;
                    int g = p.G;
                    int res2 = 255 - g;
                    int b = p.B;
                    int res3 = 255 - b;
                    bm.SetPixel(x, y, Color.FromArgb(a, res1, res2, res3));
                }
            }
            pictureBox3.Image = bm;
        }
        //AND
        private void button3_Click(object sender, EventArgs e)
        {
            Bitmap bmp = new Bitmap(pictureBox1.Image);
            Bitmap bmp2 = new Bitmap(pictureBox2.Image);
            Bitmap bm = new Bitmap(bmp.Width, bmp.Height);
            Color p, p2;
            for (int y = 0; y < bmp.Height; y++)
            {
                for (int x = 0; x < bmp.Width; x++)
                {
                    p = bmp.GetPixel(x, y);
                    p2 = bmp2.GetPixel(x, y);
                    int a = p.A;
                    int r = p.R;
                    int r2 = p2.R;
                    int res1 = r & r2;
                    int g = p.G;
                    int g2 = p2.G;
                    int res2 = g & g2;
                    int b = p.B;
                    int b2 = p.B;
                    int res3 = b & b2;
                    bm.SetPixel(x, y, Color.FromArgb(a, res1, res2, res3));
                }
            }
            pictureBox3.Image = bm;

        }
        //OR
        private void button4_Click(object sender, EventArgs e)
        {
            Bitmap bmp = new Bitmap(pictureBox1.Image);
            Bitmap bmp2 = new Bitmap(pictureBox2.Image);
            Bitmap bm = new Bitmap(bmp.Width, bmp.Height);
            Color p, p2;
            for (int y = 0; y < bmp.Height; y++)
            {
                for (int x = 0; x < bmp.Width; x++)
                {
                    p = bmp.GetPixel(x, y);
                    p2 = bmp2.GetPixel(x, y);
                    int a = p.A;
                    int r = p.R;
                    int r2 = p2.R;
                    int res1 = r | r2;
                    int g = p.G;
                    int g2 = p2.G;
                    int res2 = g | g2;
                    int b = p.B;
                    int b2 = p.B;
                    int res3 = b | b2;
                    bm.SetPixel(x, y, Color.FromArgb(a, res1, res2, res3));
                }
            }
            pictureBox3.Image = bm;
        }
        //Addition
        private void button6_Click(object sender, EventArgs e)
        {
            Bitmap bmp1 = new Bitmap(pictureBox1.Image);
            Bitmap bmp2 = new Bitmap(pictureBox2.Image);
            Bitmap bmp3 = new Bitmap(bmp1.Width, bmp1.Height);
            Color p1, p2;
            for (int y = 0; y < bmp1.Height; y++)
            {
                for (int x = 0; x < bmp1.Width; x++)
                {
                    p1 = bmp1.GetPixel(x, y);
                    p2 = bmp2.GetPixel(x, y);
                    int r = p1.R + p2.R;
                    if (r > 255)
                        r = 255;
                    int g = p1.G + p2.G;
                    if (g > 255)
                        g = 255;
                    int b = p1.B + p2.B;
                    if (b > 255)
                        b = 255;
                    bmp3.SetPixel(x, y, Color.FromArgb(255, r, g, b));
                }
            }
            pictureBox4.Image = bmp3;

        }
        //Subtraction
        private void button7_Click(object sender, EventArgs e)
        {
            Bitmap bmp1 = new Bitmap(pictureBox1.Image);
            Bitmap bmp2 = new Bitmap(pictureBox2.Image);
            Bitmap bmp3 = new Bitmap(bmp1.Width, bmp1.Height);
            Color p1, p2;
            for (int y = 0; y < bmp1.Height; y++)
            {
                for (int x = 0; x < bmp1.Width; x++)
                {
                    p1 = bmp1.GetPixel(x, y);
                    p2 = bmp2.GetPixel(x, y);
                    int r = p1.R - p2.R;
                    if (r < 0)
                        r = 0;
                    int g = p1.G - p2.G;
                    if (g < 0)
                        g = 0;
                    int b = p1.B - p2.B;
                    if (b < 0)
                        b = 0;
                    bmp3.SetPixel(x, y, Color.FromArgb(r, g, b));
                }
            }
            pictureBox4.Image = bmp3;

        }
        //Multiplication
        private void button8_Click(object sender, EventArgs e)
        {
            Bitmap bmp1 = new Bitmap(pictureBox1.Image);
            Bitmap bmp3 = new Bitmap(bmp1.Width, bmp1.Height);
            Color p1;
            for (int y = 0; y < bmp1.Height; y++)
            {
                for (int x = 0; x < bmp1.Width; x++)
                {
                    p1 = bmp1.GetPixel(x, y);
                    int r = p1.R * 2;
                    if (r > 255)
                        r = 255;
                    int g = p1.G * 2;
                    if (g > 255)
                        g = 255;
                    int b = p1.B * 2;
                    if (b > 255)
                        b = 255;

                    bmp3.SetPixel(x, y, Color.FromArgb(255, r, g, b));
                }
            }
            pictureBox4.Image = bmp3;

        }
        //Division
        private void button9_Click(object sender, EventArgs e)
        {
            Bitmap bmp1 = new Bitmap(pictureBox1.Image);
            Bitmap bmp3 = new Bitmap(bmp1.Width, bmp1.Height);
            Color p1;
            for (int y = 0; y < bmp1.Height; y++)
            {
                for (int x = 0; x < bmp1.Width; x++)
                {
                    p1 = bmp1.GetPixel(x, y);
                    int r = p1.R / 2;
                    int g = p1.G / 2;
                    int b = p1.B / 2;
                    bmp3.SetPixel(x, y, Color.FromArgb(255, r, g, b));
                }
            }
            pictureBox4.Image = bmp3;
        }
        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);
            Application.Exit();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            this.Hide();
        }
    }
}

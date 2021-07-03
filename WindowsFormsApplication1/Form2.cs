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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            this.Hide();
        }

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
        //Segmentation
        //upper_left
        private void button3_Click(object sender, EventArgs e)
        {
            Bitmap bmp = new Bitmap(pictureBox1.Image);
            int wid = bmp.Width;
            int hei = bmp.Height;
            Bitmap bm = new Bitmap(wid, hei);
            Color p;
            for (int x = 0; x < wid / 2; x++)
            {
                for (int y = 0; y < hei / 2; y++)
                {
                    p = bmp.GetPixel(x, y);
                    bm.SetPixel(x, y, p);
                }
            }
            pictureBox3.Image = bm;
        }
        //upper_right
        private void button4_Click(object sender, EventArgs e)
        {
            Bitmap bmp = new Bitmap(pictureBox1.Image);
            int wid = bmp.Width;
            int hei = bmp.Height;
            Bitmap bm = new Bitmap(wid, hei);
            Color p;
            for (int x = wid / 2; x < wid; x++)
            {
                for (int y = 0; y < hei / 2; y++)
                {
                    p = bmp.GetPixel(x, y);
                    bm.SetPixel(x, y, p);
                }
            }
            pictureBox3.Image = bm;
        }
        //lower_left
        private void button5_Click(object sender, EventArgs e)
        {
            Bitmap bmp = new Bitmap(pictureBox1.Image);
            int wid = bmp.Width;
            int hei = bmp.Height;
            Bitmap bm = new Bitmap(wid, hei);
            Color p;
            for (int x = 0; x < wid / 2; x++)
            {
                for (int y = hei / 2; y < hei; y++)
                {
                    p = bmp.GetPixel(x, y);
                    bm.SetPixel(x, y, p);
                }
            }
            pictureBox3.Image = bm;
        }
        //lower_right
        private void button6_Click(object sender, EventArgs e)
        {
            Bitmap bmp = new Bitmap(pictureBox1.Image);
            int wid = bmp.Width;
            int hei = bmp.Height;
            Bitmap bm = new Bitmap(wid, hei);
            Color p;
            for (int x = wid / 2; x < wid; x++)
            {
                for (int y = hei / 2; y < hei; y++)
                {
                    p = bmp.GetPixel(x, y);
                    bm.SetPixel(x, y, p);
                }
            }
            pictureBox3.Image = bm;
        }
        //Transformation
        //to_upper_left
        private void button7_Click(object sender, EventArgs e)
        {
            Bitmap bmp = new Bitmap(pictureBox1.Image);
            int wid = bmp.Width;
            int hei = bmp.Height;
            Bitmap bm = new Bitmap(wid, hei);
            Color p;
            for (int x = 0; x < wid / 2; x++)
            {
                for (int y = 0; y < hei / 2; y++)
                {
                    p = bmp.GetPixel(x, y);
                    bm.SetPixel(x, y, p);
                }
            }
            pictureBox4.Image = bm;
        }
        //upper_right
        private void button8_Click(object sender, EventArgs e)
        {
            Bitmap bmp = new Bitmap(pictureBox1.Image);
            int wid = bmp.Width;
            int hei = bmp.Height;
            Bitmap bm = new Bitmap(wid, hei);
            Color p;
            for (int x = wid / 2; x < wid; x++)
            {
                for (int y = 0; y < hei / 2; y++)
                {
                    p = bmp.GetPixel(x, y);
                    bm.SetPixel(x - wid / 2, y, p);
                }
            }
            pictureBox4.Image = bm;
        }
        //lower_left
        private void button9_Click(object sender, EventArgs e)
        {
            Bitmap bmp = new Bitmap(pictureBox1.Image);
            int wid = bmp.Width;
            int hei = bmp.Height;
            Bitmap bm = new Bitmap(wid, hei);
            Color p;
            for (int x = 0; x < wid / 2; x++)
            {
                for (int y = hei / 2; y < hei; y++)
                {
                    p = bmp.GetPixel(x, y);
                    bm.SetPixel(x, y - (hei / 2), p);
                }
            }
            pictureBox4.Image = bm;
        }
        //lower_right
        private void button10_Click(object sender, EventArgs e)
        {
            Bitmap bmp = new Bitmap(pictureBox1.Image);
            int wid = bmp.Width;
            int hei = bmp.Height;
            Bitmap bm = new Bitmap(wid, hei);
            Color p;
            for (int x = wid / 2; x < wid; x++)
            {
                for (int y = hei / 2; y < hei; y++)
                {
                    p = bmp.GetPixel(x, y);
                    bm.SetPixel(x - (wid / 2), y - (hei / 2), p);
                }
            }
            pictureBox4.Image = bm;
        }
        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);
            Application.Exit();
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

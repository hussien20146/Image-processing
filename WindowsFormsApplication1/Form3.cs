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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            this.Hide();
        }
        //+90
        private void button11_Click(object sender, EventArgs e)
        {
            int max;
            Color p;
            Bitmap b = new Bitmap(pictureBox1.Image);
            int wid = b.Width;
            int hei = b.Height;
            if (wid > hei)
                max = wid + 1;
            else
                max = hei + 1;
            Bitmap b2 = new Bitmap(max, max);
            for (int y = 0; y < hei; y++)
            {
                for (int x = 0; x < wid; x++)
                {

                    p = b.GetPixel(x, y);
                    b2.SetPixel(hei - 1 - y, x, p);
                }
            }
            pictureBox5.Image = b2;
        }
        //+180
        private void button12_Click(object sender, EventArgs e)
        {
            int max;
            Color p;
            Bitmap b = new Bitmap(pictureBox1.Image);
            int wid = b.Width;
            int hei = b.Height;
            if (wid > hei)
                max = wid + 1;
            else
                max = hei + 1;
            Bitmap b2 = new Bitmap(max, max);
            for (int y = 0; y < hei; y++)
            {
                for (int x = 0; x < wid; x++)
                {

                    p = b.GetPixel(x, y);
                    b2.SetPixel(wid - 1 - x, hei - 1 - y, p);
                }
            }
            pictureBox5.Image = b2;
        }
        //+270
        private void button13_Click(object sender, EventArgs e)
        {
            int max;
            Color p;
            Bitmap b = new Bitmap(pictureBox1.Image);
            int wid = b.Width;
            int hei = b.Height;
            if (wid > hei)
                max = wid + 1;
            else
                max = hei + 1;
            Bitmap b2 = new Bitmap(max, max);
            for (int y = 0; y < hei; y++)
            {
                for (int x = 0; x < wid; x++)
                {

                    p = b.GetPixel(x, y);
                    b2.SetPixel(y, wid - 1 - x, p);
                }
            }
            pictureBox5.Image = b2;
        }
        //+360
        private void button14_Click(object sender, EventArgs e)
        {
            int max;
            Color p;
            Bitmap b = new Bitmap(pictureBox1.Image);
            int wid = b.Width;
            int hei = b.Height;
            if (wid > hei)
                max = wid + 1;
            else
                max = hei + 1;
            Bitmap b2 = new Bitmap(max, max);
            for (int y = 0; y < hei; y++)
            {
                for (int x = 0; x < wid; x++)
                {

                    p = b.GetPixel(x, y);
                    b2.SetPixel(x, y, p);
                }
            }
            pictureBox5.Image = b2;
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
        //-90
        private void button15_Click(object sender, EventArgs e)
        {
            int max;
            Color p;
            Bitmap b = new Bitmap(pictureBox1.Image);
            int wid = b.Width;
            int hei = b.Height;
            if (wid > hei)
                max = wid + 1;
            else
                max = hei + 1;
            Bitmap b2 = new Bitmap(max, max);
            for (int y = 0; y < hei; y++)
            {
                for (int x = 0; x < wid; x++)
                {

                    p = b.GetPixel(x, y);
                    b2.SetPixel(y, wid - 1 - x, p);
                }
            }
            pictureBox6.Image = b2;
        }
        //-180
        private void button16_Click(object sender, EventArgs e)
        {
            int max;
            Color p;
            Bitmap b = new Bitmap(pictureBox1.Image);
            int wid = b.Width;
            int hei = b.Height;
            if (wid > hei)
                max = wid + 1;
            else
                max = hei + 1;
            Bitmap b2 = new Bitmap(max, max);
            for (int y = 0; y < hei; y++)
            {
                for (int x = 0; x < wid; x++)
                {

                    p = b.GetPixel(x, y);
                    b2.SetPixel(wid - 1 - x, hei - 1 - y, p);
                }
            }
            pictureBox6.Image = b2;
        }
        //-270
        private void button17_Click(object sender, EventArgs e)
        {
            int max;
            Color p;
            Bitmap b = new Bitmap(pictureBox1.Image);
            int wid = b.Width;
            int hei = b.Height;
            if (wid > hei)
                max = wid + 1;
            else
                max = hei + 1;
            Bitmap b2 = new Bitmap(max, max);
            for (int y = 0; y < hei; y++)
            {
                for (int x = 0; x < wid; x++)
                {

                    p = b.GetPixel(x, y);
                    b2.SetPixel(hei - 1 - y, x, p);
                }
            }
            pictureBox6.Image = b2;
        }
        //-360
        private void button18_Click(object sender, EventArgs e)
        {
            int max;
            Color p;
            Bitmap b = new Bitmap(pictureBox1.Image);
            int wid = b.Width;
            int hei = b.Height;
            if (wid > hei)
                max = wid + 1;
            else
                max = hei + 1;
            Bitmap b2 = new Bitmap(max, max);
            for (int y = 0; y < hei; y++)
            {
                for (int x = 0; x < wid; x++)
                {

                    p = b.GetPixel(x, y);
                    b2.SetPixel(x, y, p);
                }
            }
            pictureBox6.Image = b2;
        }
        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);
            Application.Exit();
        }
    }
}

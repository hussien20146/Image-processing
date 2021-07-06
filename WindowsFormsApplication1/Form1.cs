using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        //Add Image
        private void button1_Click_1(object sender, EventArgs e)
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
            for (int i = 0; i < width;i++ ) 
            {
                for (int j = 0; j < height;j++ )
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
        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            
        }
        private void button7_Click(object sender, EventArgs e)
        {
            
        }

        private void button8_Click(object sender, EventArgs e)
        {
            
        }

        private void button9_Click(object sender, EventArgs e)
        {
            
        }

        private void button10_Click(object sender, EventArgs e)
        {
            
        }
        private void button11_Click(object sender, EventArgs e)
        {
           
        }
        private void button12_Click(object sender, EventArgs e)
        {
            
        }
        private void button13_Click(object sender, EventArgs e)
        {
            
        }
        private void button14_Click(object sender, EventArgs e)
        {
           
        }
        private void button19_Click(object sender, EventArgs e)
        {
           
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        private void button20_Click(object sender, EventArgs e)
        {
           
        }
        //Save Image
        private void button21_Click(object sender, EventArgs e)
        {
            SaveFileDialog s = new SaveFileDialog();
            s.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
            s.RestoreDirectory = true;
            s.DefaultExt = ".jpg";
            if (s.ShowDialog()==DialogResult.OK)
            {
                string fileName = s.FileName;

                FileStream fstream = new FileStream(fileName,FileMode.Create);
                pictureBox2.Image.Save(fstream,System.Drawing.Imaging.ImageFormat.Jpeg);
                fstream.Close();
                MessageBox.Show("Save");
                
            }
        }

        private void button22_Click(object sender, EventArgs e)
        {
            zoom f = new zoom();
            f.Show();
            this.Hide();
        }

        private void button19_Click_1(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.Show();
            this.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Form3 f = new Form3();
            f.Show();
            this.Hide();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            algebra f = new algebra();
            f.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        //////////////////////////////////////////////////////////
        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);
            Application.Exit();
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            Filter f = new Filter();
            f.Show();
            this.Hide();
        }
    }
}

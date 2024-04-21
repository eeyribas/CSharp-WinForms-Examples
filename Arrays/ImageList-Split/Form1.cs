using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageList_Split
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            imageList1.ImageSize = new Size(30, 40);
            imageList1.Images.AddStrip(Image.FromFile("okey.gif"));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random random = new Random((int)(DateTime.Now.Ticks % Int32.MaxValue));
            int count = random.Next(imageList1.Images.Count);
            pictureBox1.Image = imageList1.Images[count];
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pictureBox2.Width = 30 * 14;
            Graphics graphics = pictureBox2.CreateGraphics();
            Random random = new Random((int)(DateTime.Now.Ticks % Int32.MaxValue));

            for (int i = 0; i <= 13; i++)
            {
                int count = random.Next(imageList1.Images.Count);
                imageList1.Draw(graphics, i * 30, 0, count);
            }

            graphics.Dispose();
        }
    }
}

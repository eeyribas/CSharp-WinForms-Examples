using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Picture_AutoZoom
{
    public partial class Form1 : Form
    {
        Bitmap bmp;
        int x, y, M, N, L = 150;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            bmp = new Bitmap(pictureBox1.Image);
            M = bmp.Width;
            N = bmp.Height;
            timer1.Interval = 250;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Rectangle rec = new Rectangle(x, y, L, L);
            pictureBox2.Image = bmp.Clone(rec, bmp.PixelFormat);
        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            pictureBox2.Image = null;
            timer1.Enabled = false;
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            x = e.X - L / 2;
            y = e.Y - L / 2;

            if (x < 0)
                x = 0;
            else if (x > M - L)
                x = M - L;

            if (y < 0)
                y = 0;
            else if (y > N - L)
                y = N - L;

            Text = e.X.ToString() + " , " + e.Y.ToString();
        }
    }
}

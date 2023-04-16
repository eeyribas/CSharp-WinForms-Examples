using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageAlpha
{
    public partial class Form1 : Form
    {
        Bitmap bmp;
        int M, N;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            bmp = new Bitmap(pictureBox1.Image);
            M = bmp.Width;
            N = bmp.Height;
            hScrollBar1.Value = 100;
        }

        private void hScrollBar1_ValueChanged(object sender, EventArgs e)
        {
            Color c;
            int k = hScrollBar1.Value;
            label1.Text = "Alpha = " + k.ToString();
            for (int m = 0; m < M; m++)
            {
                for (int n = 0; n < N; n++)
                {
                    c = bmp.GetPixel(m, n);
                    c = Color.FromArgb(k, c.R, c.G, c.B);
                    bmp.SetPixel(m, n, c);
                }
            }
            pictureBox1.Image = bmp;
        }
    }
}

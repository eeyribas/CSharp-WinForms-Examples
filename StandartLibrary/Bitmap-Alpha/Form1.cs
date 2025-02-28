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
        private Bitmap bitmap;
        private int M, N;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            bitmap = new Bitmap(pictureBox1.Image);
            M = bitmap.Width;
            N = bitmap.Height;

            hScrollBar1.Value = 100;
        }

        private void hScrollBar1_ValueChanged(object sender, EventArgs e)
        {
            int len = hScrollBar1.Value;
            label1.Text = "Alpha = " + len.ToString();

            for (int m = 0; m < M; m++)
            {
                for (int n = 0; n < N; n++)
                {
                    Color color = bitmap.GetPixel(m, n);
                    color = Color.FromArgb(len, color.R, color.G, color.B);
                    bitmap.SetPixel(m, n, color);
                }
            }

            pictureBox1.Image = bitmap;
        }
    }
}

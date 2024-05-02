using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bitmap_Negative
{
    public partial class Form1 : Form
    {
        private Bitmap bitmap, hsnBitmap;
        private Color color;
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
            hsnBitmap = new Bitmap(M, N);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox2.Image = bitmap;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            for (int m = 0; m < M; m++)
            {
                for (int n = 0; n < N; n++)
                {
                    color = bitmap.GetPixel(m, n);
                    color = Color.FromArgb(color.A, 255 - color.R, 255 - color.G, 255 - color.B);
                    hsnBitmap.SetPixel(m, n, color);
                }
            }

            pictureBox2.Image = hsnBitmap;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            for (int m = 0; m < M; m++)
            {
                for (int n = 0; n < N; n++)
                {
                    color = bitmap.GetPixel(m, n);
                    int value = (byte)Math.Round(0.28 * color.R + 0.57 * color.G + 0.15 * color.B);
                    color = Color.FromArgb(color.A, value, value, value);
                    hsnBitmap.SetPixel(m, n, color);
                }
            }

            pictureBox2.Image = hsnBitmap;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            for (int m = 0; m < M; m++)
            {
                for (int n = 0; n < N; n++)
                {
                    color = bitmap.GetPixel(m, n);
                    int value = 255 - (byte)Math.Round(0.28 * color.R + 0.57 * color.G + 0.15 * color.B);
                    color = Color.FromArgb(color.A, value, value, value);
                    hsnBitmap.SetPixel(m, n, color);
                }
            }

            pictureBox2.Image = hsnBitmap;
        }
    }
}

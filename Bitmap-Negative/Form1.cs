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
        Bitmap bmp, hsn;
        Color c;
        int M, N;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            bmp = new Bitmap(Pic1.Image);
            M = bmp.Width;
            N = bmp.Height;
            hsn = new Bitmap(M, N);
        }

        private void Btn1_Click(object sender, EventArgs e)
        {
            Pic2.Image = bmp;
        }

        private void Btn2_Click(object sender, EventArgs e)
        {
            for(int m = 0; m < M; m++) {
                for(int n = 0; n < N; n++) {
                    c = bmp.GetPixel(m, n);
                    c = Color.FromArgb(c.A, 255 - c.R, 255 - c.G, 255 - c.B);
                    hsn.SetPixel(m, n, c);
                }
            }
            Pic2.Image = hsn;
        }

        private void Btn3_Click(object sender, EventArgs e)
        {
            for(int m = 0; m < M; m++) {
                for(int n = 0; n < N; n++) {
                    c = bmp.GetPixel(m, n);
                    int k = (byte)Math.Round(0.28 * c.R + 0.57 * c.G + 0.15 * c.B);
                    c = Color.FromArgb(c.A, k, k, k);
                    hsn.SetPixel(m, n, c);
                }
            }
            Pic2.Image = hsn;
        }

        private void Btn4_Click(object sender, EventArgs e)
        {
            for(int m = 0; m < M; m++) {
                for(int n = 0; n < N; n++) {
                    c = bmp.GetPixel(m, n);
                    int k = 255 - (byte)Math.Round(0.28 * c.R + 0.57 * c.G + 0.15 * c.B);
                    c = Color.FromArgb(c.A, k, k, k);
                    hsn.SetPixel(m, n, c);
                }
            }
            Pic2.Image = hsn;
        }
    }
}

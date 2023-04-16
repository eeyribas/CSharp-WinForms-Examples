using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bitmap_Graphics_ChangeImageColor
{
    public partial class Form1 : Form
    {
        Graphics graphics;
        Bitmap bmp, hsn;
        Color color;
        int M, N, i, j, k;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            graphics = CreateGraphics();
            bmp = new Bitmap("image.jpg");
            M = bmp.Width;
            N = bmp.Height;
            hsn = new Bitmap(M, N);
            i = (ClientSize.Width - M) / 2;
            j = (ClientSize.Height - N) / 2;
            timer1.Interval = 1000;
            timer1.Enabled = true;
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            graphics.DrawImage(bmp, i, j);
            Text = "Mix = " + k.ToString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            k = (++k) % 6;

            for (int m = 0; m < M; m++)
            {
                for (int n = 0; n < N; n++)
                {
                    color = bmp.GetPixel(m, n);
                    switch (k)
                    {
                        case 1:
                            color = Color.FromArgb(color.A, color.R, color.B, color.G);
                            break;
                        case 2:
                            color = Color.FromArgb(color.A, color.G, color.R, color.B);
                            break;
                        case 3:
                            color = Color.FromArgb(color.A, color.G, color.B, color.R);
                            break;
                        case 4:
                            color = Color.FromArgb(color.A, color.B, color.R, color.G);
                            break;
                        case 5:
                            color = Color.FromArgb(color.A, color.B, color.G, color.R);
                            break;
                    }
                    hsn.SetPixel(m, n, color);
                }
            }
            graphics.DrawImage(hsn, i, j);
            Text = "Mix = " + k.ToString();
        }
    }
}

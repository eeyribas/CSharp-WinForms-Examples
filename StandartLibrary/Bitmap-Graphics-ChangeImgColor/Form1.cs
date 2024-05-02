using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bitmap_Graphics_ChangeImgColor
{
    public partial class Form1 : Form
    {
        private Graphics graphics;
        private Bitmap bitmap, hsnBitmap;
        private Color color;
        private int M, N, i, j, k;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            graphics = CreateGraphics();
            bitmap = new Bitmap("image.jpg");

            M = bitmap.Width;
            N = bitmap.Height;
            hsnBitmap = new Bitmap(M, N);
            i = (ClientSize.Width - M) / 2;
            j = (ClientSize.Height - N) / 2;

            timer1.Interval = 1000;
            timer1.Enabled = true;
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            graphics.DrawImage(bitmap, i, j);
            Text = "Mix = " + k.ToString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            k = (++k) % 6;

            for (int m = 0; m < M; m++)
            {
                for (int n = 0; n < N; n++)
                {
                    color = bitmap.GetPixel(m, n);
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

                    hsnBitmap.SetPixel(m, n, color);
                }
            }

            graphics.DrawImage(hsnBitmap, i, j);
            Text = "Mix = " + k.ToString();
        }
    }
}

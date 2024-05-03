using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PictureBox_GetSetPixel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Bitmap bitmap = new Bitmap(pictureBox1.Image);
            progressBar1.Maximum = bitmap.Width * bitmap.Height;
            progressBar1.Visible = true;

            for (int i = 0; i <= bitmap.Width - 1; i++)
            {
                for (int j = 0; j <= bitmap.Height - 1; j++)
                {
                    Color color = bitmap.GetPixel(i, j);
                    color = Color.FromArgb(color.A, (byte)~color.R, (byte)~color.G, (byte)~color.B);
                    bitmap.SetPixel(i, j, color);

                    if ((i % 10) == 0)
                    {
                        progressBar1.Value = i * bitmap.Height + j;
                        Application.DoEvents();
                    }
                }

                pictureBox2.Image = bitmap;
            }

            progressBar1.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Bitmap bitmap = new Bitmap(pictureBox1.Image);
            progressBar1.Maximum = bitmap.Width * bitmap.Height;
            progressBar1.Visible = true;

            for (int i = 0; i <= bitmap.Width - 2; i++)
            {
                for (int j = 0; j <= bitmap.Height - 2; j++)
                {
                    Color color1 = bitmap.GetPixel(i, j);
                    Color color2 = bitmap.GetPixel(i + 1, j + 1);

                    int r = Math.Abs((int)(color1.R) - color2.R) + 128;
                    if (r > 255) 
                        r = 255;

                    int g = Math.Abs((int)(color1.G) - color2.G) + 128;
                    if (g > 255) 
                        g = 255;

                    int b = Math.Abs((int)(color1.B) - color2.B) + 128;
                    if (b > 255) 
                        b = 255;

                    Color color3 = Color.FromArgb(r, g, b);
                    bitmap.SetPixel(i, j, color3);

                    if ((i % 10) == 0)
                    {
                        progressBar1.Value = i * bitmap.Height + j;
                        Application.DoEvents();
                    }
                }

                pictureBox2.Image = bitmap;
            }

            progressBar1.Visible = false;
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrackBar_EnlargeImage
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            trackBar1.Value = 2;
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            double[] coefficients = { 0.25, 0.5, 1, 2, 4 };
            pictureBox1.Width = (int)(pictureBox1.Image.Width * coefficients[trackBar1.Value]);
            pictureBox1.Height = (int)(pictureBox1.Image.Height * coefficients[trackBar1.Value]);
        }
    }
}

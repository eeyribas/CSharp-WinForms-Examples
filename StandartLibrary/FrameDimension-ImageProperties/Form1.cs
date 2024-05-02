using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrameDimension_ImageProperties
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Image Directories|" + "*.bmp;*.jpg;*.gif;*.wmf;*.tif;*.png";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
                Image image = pictureBox1.Image;
                label2.Text = image.PhysicalDimension.Width + "x" + image.PhysicalDimension.Height;
                label4.Text = image.PixelFormat.ToString();
                label6.Text = image.HorizontalResolution.ToString();
                label8.Text = image.VerticalResolution.ToString();

                Guid[] guid = image.FrameDimensionsList;
                FrameDimension frameDimension = new FrameDimension(guid[0]);
                label10.Text = image.GetFrameCount(frameDimension).ToString();
            }
        }
    }
}

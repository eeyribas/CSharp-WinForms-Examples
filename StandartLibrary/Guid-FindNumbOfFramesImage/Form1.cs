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

namespace Guid_FindNumbOfFramesImage
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Image Directory|" + "*.bmp;*.jpg;*.gif;*.wmf;*.tif;*.png";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
                Image image = pictureBox1.Image;
                Guid[] guid = image.FrameDimensionsList;
                FrameDimension frameDimension = new FrameDimension(guid[0]);

                this.Width = (int)image.PhysicalDimension.Width * image.GetFrameCount(frameDimension);
                Application.DoEvents();
                this.Height = (int)image.PhysicalDimension.Height + pictureBox1.Bottom + 50;
                Application.DoEvents();

                label2.Text = image.GetFrameCount(frameDimension).ToString();
                if (image.GetFrameCount(frameDimension) == 1)
                {
                    MessageBox.Show("This image contains only 1 frame. \r\n" +
                                    "Select Animated GIF type images, for example, to see its effect.");
                }

                Graphics graphics = this.CreateGraphics();
                this.Invalidate();
                Application.DoEvents();

                for (int i = 0; i <= image.GetFrameCount(frameDimension) - 1; i++)
                {
                    image.SelectActiveFrame(frameDimension, i);
                    graphics.DrawImage(image, i * image.Width, pictureBox1.Bottom + 10);
                }
                graphics.Dispose();
            }
        }
    }
}

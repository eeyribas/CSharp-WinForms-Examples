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
using Encoder = System.Drawing.Imaging.Encoder;

namespace SavingImageInDifferentFormats
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            numericUpDown1.Minimum = 1;
            numericUpDown1.Maximum = 100;
            numericUpDown1.Value = 50;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Image Directory|" + "*.bmp;*.jpg;*.gif;*.wmf;*.tif;*.png";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
                }
                catch
                {
                    MessageBox.Show(openFileDialog1.FileName + " not a valid image file.");
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "Jpeg Directory|*.jpg;*.jpeg";
            saveFileDialog1.DefaultExt = "jpg";

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Image image = pictureBox1.Image;
                ImageCodecInfo imageCodecInfo = Find("image/jpeg");

                long quality = (long)numericUpDown1.Value;
                EncoderParameter parameter1 = new EncoderParameter(Encoder.Quality, quality);

                EncoderParameter parameter2;
                if (radioButton1.Checked)
                    parameter2 = new EncoderParameter(Encoder.RenderMethod, (int)EncoderValue.RenderNonProgressive);
                else
                    parameter2 = new EncoderParameter(Encoder.RenderMethod, (int)EncoderValue.RenderProgressive);
                
                EncoderParameters parameters = new EncoderParameters(2);
                parameters.Param[0] = parameter1;
                parameters.Param[1] = parameter2;

                image.Save(saveFileDialog1.FileName, imageCodecInfo, parameters);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "Bmp Directory|*.bmp";
            saveFileDialog1.DefaultExt = "bmp";

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Image image = pictureBox1.Image;
                ImageCodecInfo imageCodecInfo = Find("image/bmp");

                EncoderParameter parameter;
                if (radioButton3.Checked)
                    parameter = new EncoderParameter(Encoder.Compression, (int)EncoderValue.CompressionNone);
                else
                    parameter = new EncoderParameter(Encoder.Compression, (int)EncoderValue.CompressionRle);

                EncoderParameters parameters = new EncoderParameters(1);
                parameters.Param[0] = parameter;

                image.Save(saveFileDialog1.FileName, imageCodecInfo, parameters);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "Tiff Directory|*.tif;*.tiff";
            saveFileDialog1.DefaultExt = "tif";

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Bitmap bitmap = (Bitmap)pictureBox1.Image;
                ImageCodecInfo imageCodecInfo = Find("image/tiff");

                EncoderParameter parameter = null;
                if (radioButton5.Checked)
                    parameter = new EncoderParameter(Encoder.Compression, (long)EncoderValue.CompressionNone);
                if (radioButton6.Checked)
                    parameter = new EncoderParameter(Encoder.Compression, (long)EncoderValue.CompressionCCITT3);
                if (radioButton7.Checked)
                    parameter = new EncoderParameter(Encoder.Compression, (long)EncoderValue.CompressionLZW);
                
                EncoderParameters parameters;
                if (radioButton6.Checked == false)
                {
                    parameters = new EncoderParameters(1);
                    parameters.Param[0] = parameter;
                }
                else
                {
                    parameters = new EncoderParameters(2);
                    parameters.Param[0] = parameter;
                    EncoderParameter parameter2 = new EncoderParameter(Encoder.ColorDepth, (long)1);
                    parameters.Param[1] = parameter2;
                }

                bitmap.Save(saveFileDialog1.FileName, imageCodecInfo, parameters);
            }
        }

        private ImageCodecInfo Find(string mimeType)
        {
            for (int i = 0; i <= ImageCodecInfo.GetImageEncoders().Length - 1; i++)
            {
                if (ImageCodecInfo.GetImageEncoders()[i].MimeType == mimeType)
                    return ImageCodecInfo.GetImageEncoders()[i];
            }

            return null;
        }
    }
}

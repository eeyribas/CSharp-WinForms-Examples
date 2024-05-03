using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PictureBox_DisplayModes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            radioButton2.CheckedChanged += new EventHandler(radioButton1_CheckedChanged);
            radioButton3.CheckedChanged += new EventHandler(radioButton1_CheckedChanged);
            radioButton4.CheckedChanged += new EventHandler(radioButton1_CheckedChanged);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Image Files|" + "*.bmp;*.jpg;*.gif;*.wmf;*.tif;*.png";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
                pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            IDataObject iDataObject = Clipboard.GetDataObject();

            if (iDataObject.GetDataPresent(DataFormats.Bitmap))
                pictureBox1.Image = (Bitmap)iDataObject.GetData(DataFormats.Bitmap);
            else
                MessageBox.Show("There is no suitable image in the clipboard.");
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if ((sender as RadioButton).Checked)
            {
                switch ((sender as RadioButton).Text)
                {
                    case "Normal":
                        pictureBox1.SizeMode = PictureBoxSizeMode.Normal;
                        break;
                    case "Fit Into":
                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                        break;
                    case "Automatic":
                        pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
                        break;
                    case "Center":
                        pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
                        break;
                }

                pictureBox1.Width = ClientSize.Width;
                pictureBox1.Height = ClientSize.Height - pictureBox1.Top;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
                pictureBox1.BackgroundImage = pictureBox1.Image;
            else
                pictureBox1.BackgroundImage = null;
        }
    }
}

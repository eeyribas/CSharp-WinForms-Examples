using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OpenFileDialog_MultiSelect
{
    public partial class Form1 : Form
    {
        private int count = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            timer1.Interval = 1000;
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;

            openFileDialog1.ShowHelp = true;
            openFileDialog1.Filter = "Images|*.GIF;*.BMP;*.JPG;*.WMF;*.PNG;*.ICO";
            openFileDialog1.Title = "Please select the images to be displayed.";
            openFileDialog1.Multiselect = true;

            openFileDialog2.ShowHelp = true;
            openFileDialog2.Filter = "Tmp Files|*.TMP;*.~*;~*.*|" + "All Files|*.*";
            openFileDialog2.Title = "Please select the files to delete.";
            openFileDialog2.Multiselect = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
                timer1.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (openFileDialog2.ShowDialog() == DialogResult.OK)
            {
                DialogResult dialogResult = MessageBox.Show("Warning! All selected files will be deleted.", "Warning!", MessageBoxButtons.OKCancel, 
                                                            MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
                if (dialogResult == DialogResult.OK)
                {
                    for (int i = 0; i <= openFileDialog2.FileNames.Length - 1; i++)
                    {
                        FileInfo fileInfo = new FileInfo(openFileDialog2.FileNames[i]);
                        fileInfo.Delete();
                    }
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            count++;
            count %= openFileDialog1.FileNames.Length;

            pictureBox1.Image = Image.FromFile(openFileDialog1.FileNames[count]);
            this.Text = openFileDialog1.FileNames[count];
        }

        private void openFileDialog1_HelpRequest(object sender, EventArgs e)
        {
            MessageBox.Show("Please select the images to be displayed.\r\n" + "To select multiple images, hold down the Shift or Ctrl keys.");
        }

        private void openFileDialog2_HelpRequest(object sender, EventArgs e)
        {
            MessageBox.Show("Select the files to be deleted.\r\n" + "To select multiple images, hold down the Shift or Ctrl keys.");
        }
    }
}

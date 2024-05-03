using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OpenFileDialog_RichTextBox_Filter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Multiline = true;
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "Please select the file to open.";
            openFileDialog1.Filter = "Text Files|*.TXT|" + "RTF Files|*.RTF|" + "Images|*.GIF;*.BMP;*.JPG;*.WMF;*PNG;*.TIF|" +
                                     "Programs|*.EXE";
            openFileDialog1.FilterIndex = 1;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                switch (openFileDialog1.FilterIndex)
                {
                    case 1:
                        textBox1.Text = "";
                        TextReader textReader = File.OpenText(openFileDialog1.FileName);
                        string row;
                        while ((row = textReader.ReadLine()) != null)
                            textBox1.Text += row + (char)13 + (char)10;
                        textReader.Close();
                        break;
                    case 2:
                        richTextBox1.LoadFile(openFileDialog1.FileName);
                        break;
                    case 3:
                        pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
                        break;
                    case 4:
                        Process.Start(openFileDialog1.FileName);
                        break;
                }
            }
        }
    }
}

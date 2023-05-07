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

namespace FileStream_EncryptDecrypt
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            byte k, c;
            long size;
            button1.Enabled = false;
            openFileDialog1.Title = "Selection File";
            saveFileDialog1.Title = "Create file.";
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if(saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    label1.Text = "Original File : " + openFileDialog1.FileName;
                    FileStream fileStream = new FileStream(openFileDialog1.FileName, FileMode.Open);
                    BinaryReader binaryReader = new BinaryReader(fileStream);
                    label2.Text = "Creating File : " + saveFileDialog1.FileName;
                    FileStream fileStream2 = new FileStream(saveFileDialog1.FileName, FileMode.CreateNew);
                    BinaryWriter binaryWriter = new BinaryWriter(fileStream2);
                    size = (new FileInfo(openFileDialog1.FileName)).Length;
                    progressBar1.Maximum = (int)size / 100;
                    label3.Text = "File Size :" + size.ToString();
                    for (long i = 1; i <= size; i++)
                    {
                        c = binaryReader.ReadByte();
                        if ((i % 3) == 0)
                            k = (byte)~c;
                        else
                            k = c;
                        if ((i % 100) == 0)
                        {
                            progressBar1.Value = (int)i / 100;
                            Application.DoEvents();
                        }
                        binaryWriter.Write(k);
                    }
                    binaryReader.Close();
                    binaryWriter.Close();
                    fileStream.Close();
                    fileStream2.Close();
                }
            }             
            button1.Enabled = true;
        }
    }
}

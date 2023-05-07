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

namespace BinaryReader_ReadGifts
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "GIF Files |*.gif";
            openFileDialog1.Title = "Open GIF File";
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                FileStream fileStream = new FileStream(openFileDialog1.FileName, FileMode.Open);
                BinaryReader binaryReader = new BinaryReader(fileStream);
                byte[] bytes = new byte[6];
                bytes = binaryReader.ReadBytes(6);
                ASCIIEncoding aSCIIEncoding = new ASCIIEncoding();
                string asciiToString = aSCIIEncoding.GetString(bytes);
                label2.Text = asciiToString;
                binaryReader.Close();
                fileStream.Close();
                pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
            }
        }
    }
}

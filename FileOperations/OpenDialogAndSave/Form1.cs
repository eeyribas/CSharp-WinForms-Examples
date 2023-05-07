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

namespace OpenDialogAndSave
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Text Files |*.txt|" + "All Files |*.*";
            openFileDialog1.Title = "Selection";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string fileName = openFileDialog1.FileName;
                TextReader textReader = File.OpenText(fileName);
                string x = textReader.ReadToEnd();
                textReader.Close();
                textBox1.Text = x;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Title = "Enter name : ";
            saveFileDialog1.Filter = "Text Files |*.txt|" + "All Files |*.*";
            saveFileDialog1.DefaultExt = "txt";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string fileName = saveFileDialog1.FileName;
                TextWriter textReader = File.CreateText(fileName);
                textReader.Write(textBox1.Text);
                textReader.Close();
            }
        }
    }
}

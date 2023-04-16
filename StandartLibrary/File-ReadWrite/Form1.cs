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

namespace File_ReadWrite
{
    public partial class Form1 : Form
    {
        string file = "file.txt";
        int i;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (File.Exists(file))
                label1.Text = "File exists.";
            else 
                label1.Text = "No file.";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "File exists.";
            TextWriter textWriter = File.AppendText(file);
            textWriter.WriteLine("CSharp Programming Language");
            textWriter.WriteLine("OK {0}", ++i);
            textWriter.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!File.Exists(file))
                return;
            TextReader textReader = File.OpenText(file);
            textBox1.Text = textReader.ReadToEnd();
            textReader.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (File.Exists(file))
            {
                File.Delete(file);
                textBox1.Clear();
                label1.Text = "No file.";
                i = 0;
            }
        }
    }
}

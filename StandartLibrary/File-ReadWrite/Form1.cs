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
                Lbl.Text = "File exists.";
            else 
                Lbl.Text = "No file.";
        }

        private void Btn1_Click(object sender, EventArgs e)
        {
            Lbl.Text = "File exists.";
            TextWriter f = File.AppendText(file);
            f.WriteLine("CSharp Programming Language");
            f.WriteLine("OK {0}", ++i);
            f.Close();
        }

        private void Btn2_Click(object sender, EventArgs e)
        {
            if (!File.Exists(file)) 
                return;
            TextReader f = File.OpenText(file);
            Txt.Text = f.ReadToEnd();
            f.Close();
        }

        private void Btn3_Click(object sender, EventArgs e)
        {
            if (File.Exists(file))
            {
                File.Delete(file);
                Txt.Clear();
                Lbl.Text = "No file.";
                i = 0;
            }
        }
    }
}

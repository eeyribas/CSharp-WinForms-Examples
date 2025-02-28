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

namespace DirectorySearcher
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Text = "*.jpg";
            textBox2.Text = "c:\\";
            this.AcceptButton = button1;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Directory.Exists(textBox2.Text))
            {
                listBox1.Items.Clear();
                Search(textBox2.Text);
            }
            else
            {
                MessageBox.Show(textBox2.Text + " not find.");
            }          
        }

        private void Search(string path)
        {
            string[] files = Directory.GetFiles(path, textBox1.Text);
            listBox1.Items.AddRange(files);
            string[] directorys = Directory.GetDirectories(path);
 
            for (int i = 0; i <= directorys.Length - 1; i++)
            {
                Search(directorys[i]);
                label3.Text = directorys[i];
                Application.DoEvents();
            }
        }
    }
}

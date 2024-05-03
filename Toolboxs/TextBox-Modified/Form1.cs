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

namespace TextBox_Modified
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Text = "";

            TextReader textReader = File.OpenText("info.dat");
            string row;
            while ((row = textReader.ReadLine()) != null)
                textBox1.Text += row + (char)13 + (char)10;

            textReader.Close();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (textBox1.Modified == true)
            {
                DialogResult dialogResult = MessageBox.Show("Would you like to save the changes?", "Exit", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    TextWriter textWriter = File.CreateText("info.dat");
                    textWriter.Write(textBox1.Text);
                    textWriter.Close();
                }
            }
        }
    }
}

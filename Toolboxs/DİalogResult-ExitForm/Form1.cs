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

namespace DİalogResult_ExitForm
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
            TextReader file = File.OpenText("info.dat");
            string row;
            while((row = file.ReadLine()) != null)
                textBox1.Text += row + (char)13 + (char)10;
            file.Close();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form2 form2 = new Form2();           
            form2.Text = "Exit";
            DialogResult dialogResult = form2.ShowDialog();

            switch(dialogResult)
            {
                case DialogResult.Yes:
                    TextWriter file = File.CreateText("info.dat");
                    file.Write(textBox1.Text);
                    file.Close();
                    break;
                case DialogResult.No:
                    break;
                case DialogResult.Cancel:
                    e.Cancel = true;
                    break;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Text = "Delete";
            form2.label1.Text = "Delete the content of the text box?";
            form2.button3.Visible = false;

            DialogResult dialogResult = form2.ShowDialog();
            if(dialogResult == DialogResult.Yes) 
                textBox1.Text = "";
        }
    }
}

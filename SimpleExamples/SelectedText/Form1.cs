using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SelectedText
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
            textBox1.ScrollBars = ScrollBars.Vertical;
            textBox1.HideSelection = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.SelectAll();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.SelectionLength > 0)
                textBox1.SelectedText = textBox1.SelectedText.ToUpper();
            else
                textBox1.Text = textBox1.Text.ToUpper();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.SelectionLength > 0)
                textBox1.SelectedText = textBox1.SelectedText.ToLower();
            else
                textBox1.Text = textBox1.Text.ToLower();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string search = textBox2.Text;
            int tmp;
            if (textBox1.SelectionLength > 0)
                tmp = textBox1.SelectionStart + textBox1.SelectedText.IndexOf(search);
            else
                tmp = textBox1.Text.IndexOf(search);

            if (tmp != 0)
            {
                textBox1.Select(tmp, search.Length);
                textBox1.ScrollToCaret();
            }
            else
            {
                MessageBox.Show("Not find.");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (textBox1.SelectionLength > 0)
                textBox1.SelectedText = "";
            else
                textBox1.Text = "";
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WordApp
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            this.TopMost = true;
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int local = Form1.richTextBox.Find(textBox1.Text, 0, SearchMode());
            if (local < 0)
                MessageBox.Show("Not find.");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int local = Form1.richTextBox.Find(textBox1.Text, Form1.richTextBox.SelectionStart + 1,
                        SearchMode());
            if (local < 0)
                MessageBox.Show("Not find.");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (Form1.richTextBox.SelectedText == textBox1.Text)
            {
                Form1.richTextBox.SelectedText = textBox2.Text;
            }
            else
            {
                int local = Form1.richTextBox.Find(textBox1.Text, 0, SearchMode());
                if (local < 0)
                    MessageBox.Show("Not find.");
                else
                    Form1.richTextBox.SelectedText = textBox2.Text;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int number = 0;
            int local = Form1.richTextBox.Find(textBox1.Text, SearchMode());
            while (local >= 0)
            {
                number++;
                Form1.richTextBox.SelectedText = textBox2.Text;
                local = local + textBox2.Text.Length - 1;
                local = Form1.richTextBox.Find(textBox1.Text, local + 1, SearchMode());
            }
            MessageBox.Show(number.ToString() + " replacement operations were performed.");
        }

        public RichTextBoxFinds SearchMode()
        {
            RichTextBoxFinds richTextBoxFinds;
            if (checkBox1.Checked == true)
                richTextBoxFinds = RichTextBoxFinds.MatchCase;
            else
                richTextBoxFinds = RichTextBoxFinds.None;

            if (checkBox2.Checked == true)
                richTextBoxFinds |= RichTextBoxFinds.WholeWord;
            else
                richTextBoxFinds |= RichTextBoxFinds.None;

            if (radioButton2.Checked == true)
                richTextBoxFinds |= RichTextBoxFinds.Reverse;
            else
                richTextBoxFinds |= RichTextBoxFinds.None;

            return richTextBoxFinds;
        }
    }
}

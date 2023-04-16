using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListBox_Records
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listBox1_SelectedIndexChanged(sender, e);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            label4.Text = listBox1.SelectedIndex.ToString();
            label2.Text = listBox1.Items.Count.ToString();
            if (listBox1.SelectedIndex >= 0)
                textBox2.Text = listBox1.SelectedItem.ToString();
            else
                textBox2.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text.Trim();
            if (textBox1.TextLength > 0)
                listBox1.Items.Add(textBox1.Text);
            textBox1.Clear();
            textBox1.Focus();
            listBox1_SelectedIndexChanged(sender, e);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox1_SelectedIndexChanged(sender, e);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex >= 0)
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int i = 0;
            if (int.TryParse(textBox3.Text, out i))
            {
                if ((i >= 0) && (i < listBox1.Items.Count))
                    textBox4.Text = listBox1.Items[i].ToString();
                else
                    MessageBox.Show("Out of Range", "Info");
            }
            else
            {
                MessageBox.Show("TextBox object\nEnter integer", "Info");
            }
            textBox3.Focus();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
                button1_Click(sender, e);
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
                button1_Click(sender, e);
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}

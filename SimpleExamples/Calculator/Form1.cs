using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.ResetText();
            textBox2.ResetText();
        }

        private void textBox_TextChanged(object sender, EventArgs e)
        {
            textBox3.ResetText();
            label2.Text = "?";
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void button_Click(object sender, EventArgs e)
        {
            double a, b, c = 0;

            if (!double.TryParse(textBox1.Text, out a))
            {
                MessageBox.Show("Enter real number", "Info");
                textBox1.Focus();
                textBox1.SelectAll();
                return;
            }

            if (!double.TryParse(textBox2.Text, out b))
            {
                MessageBox.Show("Enter real number", "Info");
                textBox2.Focus();
                textBox2.SelectAll();
                return;
            }

            if (sender == button1)
            {
                c = a + b; label2.Text = "+";
            }
            else if (sender == button2)
            {
                c = a - b; label2.Text = "-";
            }
            else if (sender == button3)
            {
                c = a * b; label2.Text = "*";
            }
            else if (sender == button4)
            {
                c = a / b; label2.Text = "/";
            }

            textBox3.Text = c.ToString();
        }
    }
}

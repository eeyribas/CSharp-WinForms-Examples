using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DivideResult
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button1_Click(sender, e);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int value1, value2;

            if (!int.TryParse(textBox1.Text, out value1))
            {
                MessageBox.Show("Enter integer", "Info");
                textBox1.Focus();
                return;
            }

            if (!int.TryParse(textBox2.Text, out value2))
            {
                MessageBox.Show("Enter integer", "Info");
                textBox2.Focus();
                return;
            }

            textBox3.Text = (value1 / value2).ToString();
            textBox4.Text = (value1 % value2).ToString();
        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {
            textBox3.Clear();
            textBox4.Clear();
        }

        private void textBox34_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}

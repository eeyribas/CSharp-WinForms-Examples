using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XOREncrypt
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int number, password;
            try
            {
                number = int.Parse(textBox1.Text);
                password = int.Parse(textBox2.Text);
            }
            catch
            {
                MessageBox.Show("Error number!");
                return;
            }

            int passwordNumber = number ^ password;
            MessageBox.Show(passwordNumber.ToString());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int number, password;
            try
            {
                number = int.Parse(textBox1.Text);
                password = int.Parse(textBox2.Text);
            }
            catch
            {
                MessageBox.Show("Error number!");
                return;
            }

            int passwordNumber = number ^ password;
            MessageBox.Show(passwordNumber.ToString());
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SwitchCase_SelectedTextBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    textBox1.Focus();
                    textBox1.SelectAll();
                    break;
                case 1:
                    textBox2.Focus();
                    textBox2.SelectAll();
                    break;
                case 2:
                    textBox3.Focus();
                    textBox3.SelectAll();
                    break;
                case 3:
                    textBox4.Focus();
                    textBox4.SelectAll();
                    break;
            }
        }

        private void textBox_Enter(object sender, EventArgs e)
        {
            switch ((sender as Control).Name)
            {
                case "1.TextBox":
                    comboBox1.SelectedIndex = 0;
                    break;
                case "2.TextBox":
                    comboBox1.SelectedIndex = 1;
                    break;
                case "3.TextBox":
                    comboBox1.SelectedIndex = 2;
                    break;
                case "4.TextBox":
                    comboBox1.SelectedIndex = 3;
                    break;
            }
        }

        private void comboBox1_Enter(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = -1;
        }

        private void comboBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}

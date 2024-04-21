using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KeyPress_EnterText
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            string[] numbers = {"zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine"};
            if (e.KeyChar >= '0' && e.KeyChar <= '9')
            {
                textBox1.SelectedText = numbers[e.KeyChar - (char)'0'];
                e.Handled = true;
            }
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.F1:
                    textBox1.SelectedText = DateTime.Now.ToLongTimeString();
                    break;
                case Keys.F2:
                    textBox1.SelectedText = DateTime.Now.ToLongDateString();
                    break;
                case Keys.F3:
                    textBox1.SelectedText = DateTime.Now.ToString();
                    break;
            }
        }
    }
}

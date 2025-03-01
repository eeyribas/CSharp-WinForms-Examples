﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sender_SimpleCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double number1 = double.Parse(textBox1.Text);
            double number2 = double.Parse(textBox2.Text);
            double result = 0;

            if ((sender as Button).Text == "Sum")
                result = number1 + number2;
            if ((sender as Button).Text == "Multiply")
                result = number1 * number2;
            if ((sender as Button).Text == "Subtract")
                result = number1 - number2;
            if ((sender as Button).Text == "Divide")
                result = number1 / number2;

            MessageBox.Show("Result : " + result.ToString());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button1_Click(sender, e);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button1_Click(sender, e);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button1_Click(sender, e);
        }
    }
}

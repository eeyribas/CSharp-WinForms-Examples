﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace String_Reverse
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
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox2.Text = textBox1.Text;
            string s = null;
            int n = textBox1.TextLength;
            label2.Text = n.ToString();
            for (int i = 0; i < n; i++)
                s += textBox1.Text[n - 1 - i];
            textBox3.Text = s;
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            Console.Beep(1000, 25);
        }

        private void textBox23_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
            Console.Beep(250, 25);
        }
    }
}

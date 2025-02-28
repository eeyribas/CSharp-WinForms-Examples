﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConvertDecimalToHexaDecimal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            long value = long.Parse(textBox1.Text);
            textBox2.Text = value.ToString("X16");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            long value = long.Parse(textBox2.Text, NumberStyles.HexNumber);
            textBox1.Text = value.ToString();
        }
    }
}

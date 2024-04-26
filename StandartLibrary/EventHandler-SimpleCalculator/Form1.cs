using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EventHandler_SimpleCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.button2.Click += new System.EventHandler(this.button1_Click);
            this.button3.Click += new System.EventHandler(this.button1_Click);
            this.button4.Click += new System.EventHandler(this.button1_Click);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double result = 0;
            double number1 = double.Parse(textBox1.Text);
            double number2 = double.Parse(textBox2.Text);

            if ((sender as Button).Name == "button1")
                result = number1 + number2;
            if ((sender as Button).Name == "button2")
                result = number1 * number2;
            if ((sender as Button).Name == "button3")
                result = number1 - number2;
            if ((sender as Button).Name == "button4")
                result = number1 / number2;

            MessageBox.Show("Result : " + result.ToString());
        }
    }
}

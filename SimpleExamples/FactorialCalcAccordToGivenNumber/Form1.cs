using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FactorialCalcAccordToGivenNumber
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (byte i = 1; i <= 20; i++)
                listBox1.Items.Add(Factorial(i).ToString());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                byte n = byte.Parse(textBox2.Text);
                byte r = byte.Parse(textBox3.Text);
                double result = Factorial(n) / (Factorial(r) * Factorial((byte)(n - r)));
                MessageBox.Show("n-r combination : " + result.ToString());
            }
            catch
            {
                MessageBox.Show("The number is invalid or too large.");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                byte number = byte.Parse(textBox1.Text);
                double result = Factorial(number);
                label1.Text = result.ToString();
            }
            catch
            {
                MessageBox.Show("The number is invalid or too large.");
            }
        }

        private double Factorial(byte x)
        {
            double result = 1;
            for (int i = 1; i <= x; i++)
                result *= i;

            return result;
        }
    }
}

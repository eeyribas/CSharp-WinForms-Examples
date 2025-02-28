using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UnitPriceCalculation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            decimal price = decimal.Parse(textBox2.Text) * decimal.Parse(textBox3.Text);
            label5.Text = price.ToString("C0");
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            decimal price = decimal.Parse(textBox2.Text);
            textBox2.Text = price.ToString("N");
            textBox2.SelectionStart = textBox2.Text.Length; 
        }
    }
}

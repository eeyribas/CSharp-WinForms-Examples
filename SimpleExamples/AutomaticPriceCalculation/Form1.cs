using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutomaticPriceCalculation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox2.ReadOnly = true;
            textBox1.TextChanged += new EventHandler(numericUpDown1_TextChanged);
        }

        private void numericUpDown1_TextChanged(object sender, System.EventArgs e)
        {
            try
            {
                textBox2.Text = (int.Parse(numericUpDown1.Text) * int.Parse(textBox2.Text)).ToString();
            }
            catch
            {
                textBox2.Text = "Error numbers!";
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RadioButton_TextBoxEnableDisable
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox3.TextChanged += new EventHandler(textBox2_TextChanged);
            textBox4.TextChanged += new EventHandler(textBox2_TextChanged);
            radioButton1.CheckedChanged += new EventHandler(textBox2_TextChanged);
            radioButton2.CheckedChanged += new EventHandler(textBox2_TextChanged);
            radioButton3.CheckedChanged += new EventHandler(textBox2_TextChanged);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            try
            {
                decimal value2 = decimal.Parse(textBox2.Text);
                decimal value3 = decimal.Parse(textBox3.Text);
                decimal result = value2 * value3;
                decimal ratio = 0;

                if (radioButton1.Checked == true) 
                    ratio = result * (decimal)0.25;
                if (radioButton2.Checked == true) 
                    ratio = result * (decimal)0.20;
                if (radioButton3.Checked == true) 
                    ratio = result * (decimal)0.15;
                result += ratio;

                textBox4.Text = ratio.ToString();
                textBox5.Text = result.ToString();
            }
            catch
            {
            }
        }
    }
}

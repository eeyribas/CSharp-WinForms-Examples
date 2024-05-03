using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextBox_TextChanged_EnterNumbers
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
            int intNumber;
            double doubleNumber;
            string str;

            if (int.TryParse(textBox1.Text, out intNumber))
                str = "Integer";
            else
                str = "Not Integer";
            label1.Text = str + " ( " + intNumber.ToString() + " ) ";

            if (double.TryParse(textBox1.Text, out doubleNumber))
                str = "Real Number";
            else
                str = "Not Real Number";
            label2.Text = str + " ( " + doubleNumber.ToString() + " ) ";
        }
    }
}

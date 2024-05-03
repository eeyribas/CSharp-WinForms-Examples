using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextBox_Validating
{
    public partial class Form1 : Form
    {
        private int count1, count2;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            StateCount();
        }

        private void textBox1_Validating(object sender, CancelEventArgs e)
        {
            int output;
            if (int.TryParse(textBox1.Text, out output))
            {
                count1 = 0;
            }
            else
            {
                count1++;
                e.Cancel = true;
            }

            StateCount();
        }

        private void textBox2_Validating(object sender, CancelEventArgs e)
        {
            double output;
            if (double.TryParse(textBox2.Text, out output))
            {
                count2 = 0;
            }
            else
            {
                count2++;
                e.Cancel = true;
            }

            StateCount();
        }

        private void StateCount()
        {
            string str1 = count1.ToString();
            string str2 = count2.ToString();
            Text = "Validating ---> " + str1 + " / " + str2;
        }
    }
}

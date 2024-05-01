using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculateFactorial
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int number = int.Parse(textBox1.Text);
            decimal factorial = 1;

            for (int i = 1; i <= number; i++)
            {
                try
                {
                    factorial *= i;
                }
                catch
                {
                    MessageBox.Show(i.ToString() + " calculate large numbers.");
                    number = i - 1;
                    break;
                }
            }

            MessageBox.Show(number.ToString() + "!=" + factorial.ToString());
        }
    }
}

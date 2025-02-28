using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrimeNumberCheck
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            long number = long.Parse(textBox1.Text);
            if (Check(number) == true)
                MessageBox.Show(number.ToString() + " = Prime");
            else
                MessageBox.Show(number.ToString() + " = Not Prime");
        }

        private bool Check(long x)
        {
            bool state = false;

            if ((x % 2) == 0)
            {
                state = true;
                if (x == 2)
                    state = false;
            }
            else
            {
                for (int i = 2; i <= x - 1; i++)
                {
                    if ((x % i) == 0)
                    {
                        state = true;
                        break;
                    }
                }
            }

            return !state;
        }
    }
}

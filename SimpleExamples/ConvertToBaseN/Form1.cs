using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConvertToBaseN
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                long x = int.Parse(textBox1.Text);
                int n = int.Parse(textBox2.Text);
                label3.Text = n.ToString() + " base " + x.ToString() + " = ";
                label4.Text = ConvertToBase(x, n);
            }
            catch
            {
                MessageBox.Show("Error number!");
            }
        }

        private string ConvertToBase(long x, int n)
        {
            if (n < 2)
                return "-1";

            string str = "";
            while (x >= n)
            {
                long binary = x % n;
                x /= n;
                if (binary > 9)
                    str += (char)(55 + binary);
                else
                    str += binary;
            }

            if (x > 9)
                str += (char)(55 + x);
            else
                str += x;

            return str;
        }
    }
}

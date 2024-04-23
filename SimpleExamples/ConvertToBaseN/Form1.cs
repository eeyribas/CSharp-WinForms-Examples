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
                label3.Text = n.ToString() + " base " + x.ToString() + "=";
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

            long b;
            string s = "";
            while (x >= n)
            {
                b = x % n;
                x /= n;
                if (b > 9)
                    s = (char)(55 + b) + s;
                else
                    s = b + s;
            }

            if (x > 9)
                s = (char)(55 + x) + s;
            else
                s = x + s;

            return s;
        }
    }
}

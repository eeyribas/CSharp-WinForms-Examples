using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SeparateNumberIntoDecimalAndInteger
{
    public partial class Form1 : Form
    {
        struct Number
        {
            public long integ;
            public double dec;
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double x = 145.39;
            Number number = Splitter(x);
            MessageBox.Show("Integer : " + number.integ.ToString() + " Decimal : " + number.dec.ToString());
        }

        Number Splitter(double x)
        {
            Number number;
            number.integ = (int)x;
            number.dec = x - number.integ;
            return number;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double x, z = 0;
            int y = 0;
            x = 145.39;
            Splitter2(x, ref y, ref z);
            MessageBox.Show("Integer : " + y.ToString() + " Decimal : " + z.ToString());
        }

        private void Splitter2(double x, ref int integ, ref double dec)
        {
            integ = (int)x;
            dec = x - integ;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double z;
            int y;
            double x = 145.39;
            Splitter3(x, out y, out z);
            MessageBox.Show("Integer : " + y.ToString() + " Decimal : " + z.ToString());
        }

        void Splitter3(double x, out int integ, out double dec)
        {
            integ = (int)x;
            dec = x - integ;
        }
    }
}

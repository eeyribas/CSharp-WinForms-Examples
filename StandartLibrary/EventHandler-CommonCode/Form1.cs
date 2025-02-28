using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EventHandler_CommonCode
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
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            long dayOfSalary = long.Parse(textBox2.Text);
            long day = long.Parse(textBox3.Text);
            long advancePayment = long.Parse(textBox4.Text);

            this.Text = "Salary Account";
            long grossSalary = dayOfSalary * day;
            label5.Text = String.Format("{0:0,0. TL}", grossSalary);
            long premium = grossSalary * 20 / 100;
            label8.Text = String.Format("{0:0,0. TL}", premium);
            long sskPremium = grossSalary * 15 / 100;
            label10.Text = String.Format("{0:0,0. TL}", sskPremium);
            long netSalary = grossSalary - advancePayment - premium - sskPremium;
            label12.Text = String.Format("{0:0,0. TL}", netSalary);
        }
    }
}

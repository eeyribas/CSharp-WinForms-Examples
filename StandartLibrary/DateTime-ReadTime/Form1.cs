using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DateTime_ReadTime
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button1_Click(sender, e);
            button2_Click(sender, e);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int value = Environment.TickCount;
            string str = (value % 1000).ToString() + " microsecond";
            value = value / 1000;
            str = (value % 60).ToString() + " second, " + str;
            value = value / 60;
            str = (value % 60).ToString() + " minute, " + str;
            value = value / 60;
            str = (value % 24).ToString() + " hour, " + str;
            str = (value / 24).ToString() + " day, " + str;
            label1.Text = str;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            label2.Text = dt.ToString();
            label3.Text = dt.ToShortDateString();
            label4.Text = dt.ToLongTimeString();
            label5.Text = dt.ToOADate().ToString();
            label6.Text = dt.Ticks.ToString();
        }
    }
}

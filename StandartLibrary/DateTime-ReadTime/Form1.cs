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
            Btn1_Click(sender, e);
            Btn2_Click(sender, e);
        }

        private void Btn1_Click(object sender, EventArgs e)
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
            Lbl1.Text = str;
        }

        private void Btn2_Click(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            Lbl2.Text = dt.ToString();
            Lbl3.Text = dt.ToShortDateString();
            Lbl4.Text = dt.ToLongTimeString();
            Lbl5.Text = dt.ToOADate().ToString();
            Lbl6.Text = dt.Ticks.ToString();
        }
    }
}

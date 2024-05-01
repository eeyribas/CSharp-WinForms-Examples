using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScrollingText
{
    public partial class Form1 : Form
    {
        private string str;
        private int strLen;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            str = "Esen EYRIBAS             ";
            strLen = str.Length;
            label1.Text = str;
            label1.BackColor = Color.Yellow;
            label1.ForeColor = Color.Red;
            timer1.Interval = 250;
            timer1.Enabled = true;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = !timer1.Enabled;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            str = str.Substring(1, strLen - 1) + str[0];
            label1.Text = str;
        }
    }
}

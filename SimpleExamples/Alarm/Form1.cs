using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Alarm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Text = DateTime.Now.ToShortDateString();
            textBox2.Text = DateTime.Now.ToLongTimeString();

            timer2.Enabled = false;
            timer1.Enabled = false;
            timer2.Interval = 100;
            timer1.Interval = 1000;
            textBox3.Text = "Close Alarm";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (textBox1.Text == DateTime.Now.ToShortDateString() && textBox2.Text == DateTime.Now.ToLongTimeString())
            {
                timer2.Enabled = true;
                MessageBox.Show(textBox3.Text);
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            Color color = textBox3.BackColor;
            textBox3.BackColor = textBox3.ForeColor;
            textBox3.ForeColor = color;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            textBox3.Text = "Open Alarm";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer2.Enabled = false;
            timer1.Enabled = false;
            textBox3.Text = "Close Alarm";
        }
    }
}

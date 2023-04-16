using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DateTime_Loop
{
    public partial class Form1 : Form
    {
        long t1, t2;
        int count;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button1.Text = "Count";
            button2.Text = "Refresh";
            label1.Text = count.ToString();
            button2_Click(sender, e);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (button1.Text == "Stop")
            {
                e.Cancel = true;
                MessageBox.Show("Exit Loop First", "Info");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Focus();
            if (button1.Text == "Count")
                button1.Text = "Stop";
            else
                button1.Text = "Count";

            t1 = DateTime.Now.Ticks;
            while (true)
            {
                if (button1.Text == "Count")
                    return;

                t2 = DateTime.Now.Ticks - t1;
                if (t2 > 1000000)
                {
                    t1 = DateTime.Now.Ticks;
                    label1.Text = (++count).ToString();
                    Application.DoEvents();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label2.Text = DateTime.Now.Ticks.ToString();
        }
    }
}

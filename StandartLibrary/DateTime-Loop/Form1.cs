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
            Btn1.Text = "Count";
            Btn2.Text = "Refresh";
            Lbl1.Text = count.ToString();
            Btn2_Click(sender, e);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Btn1.Text == "Stop")
            {
                e.Cancel = true;
                MessageBox.Show("Exit Loop First", "Info");
            }
        }

        private void Btn1_Click(object sender, EventArgs e)
        {
            Lbl1.Focus();
            if (Btn1.Text == "Count") 
                Btn1.Text = "Stop";
            else 
                Btn1.Text = "Count";

            t1 = DateTime.Now.Ticks;
            while (true)
            {
                if (Btn1.Text == "Count") 
                    return;

                t2 = DateTime.Now.Ticks - t1;
                if (t2 > 1000000)
                {
                    t1 = DateTime.Now.Ticks;
                    Lbl1.Text = (++count).ToString();
                    Application.DoEvents();
                }
            }
        }

        private void Btn2_Click(object sender, EventArgs e)
        {
            Lbl2.Text = DateTime.Now.Ticks.ToString();
        }
    }
}

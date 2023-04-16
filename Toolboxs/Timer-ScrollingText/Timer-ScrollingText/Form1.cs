using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Timer_ScrollingText
{
    public partial class Form1 : Form
    {
        string lesson = "C# Programming";
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            button2.Enabled = true;
            timer1.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button1.Enabled = true;
            button2.Enabled = false;
            timer1.Stop();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lesson = lesson.Substring(1) + lesson.Substring(0, 1);
            label1.Text = lesson;
        }
    }
}

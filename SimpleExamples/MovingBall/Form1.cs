using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovingBall
{
    public partial class Form1 : Form
    {
        private int sX = 5, sY = 5;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            radioButton1.Text = "";
            radioButton1.Width = 10;

            timer1.Interval = 50;
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (radioButton1.Top <= 0 || radioButton1.Bottom >= this.ClientSize.Height)
                sY = -sY;
            if (radioButton1.Left <= 0 || radioButton1.Right >= this.ClientSize.Width)
                sX = -sX;

            radioButton1.Left += sX;
            radioButton1.Top += sY;
        }
    }
}

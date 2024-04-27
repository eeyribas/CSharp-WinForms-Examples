using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Timer_TextAnimation
{
    public partial class Form1 : Form
    {
        private int x = 0, count = -1;
        private string str = "Version 1.0 - This is a program.";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Interval = 100;
            timer1.Enabled = true;
            this.Text = "Program";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (x == str.Length) 
                count = -count;
            if (x <= 0) 
                count = -count;
            x += count;
  
            if (count > 0) 
                this.Text = "Program " + str.Substring(0, x - 1);
            if (count < 0) 
                this.Text = "Program " + str.Substring(str.Length - x);
        }
    }
}

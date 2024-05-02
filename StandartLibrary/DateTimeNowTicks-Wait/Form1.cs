using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DateTimeNowTicks_Wait
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Text = "Hello";
            Wait(3);

            this.Text = "How are you?";
            Wait(5);

            this.Text = "What is your name?";
            Wait(4);

            this.Text = "Finish.";
        }

        private void Wait(long time)
        {
            long calc = DateTime.Now.Ticks + time * 10000000;
            while (DateTime.Now.Ticks < calc)
                this.Update();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ButtonCaptureGame
{
    public partial class Form1 : Form
    {
        int value = 2;
        int value2 = 2;
        bool value3 = true;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label3.Text = "Middle 600 ms";
            label4.Text = "Middle 400x400";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 newform = new Form2(value, value2, value3);
            newform.Show();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            value = trackBar1.Value;
            if (value == 0)
                label3.Text = "Very Hard 100 ms";
            if (value == 1)
                label3.Text = "Hard 300 ms";
            if (value == 2)
                label3.Text = "Medium 600 ms";
            if (value == 3)
                label3.Text = "Easy 900 ms";
            if (value == 4)
                label3.Text = "Very Easy 1200 ms";
        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            value2 = trackBar2.Value;
            if (value2 == 0)
                label4.Text = "Very Small 200x200";
            if (value2 == 1)
                label4.Text = "Small 300x300";
            if (value2 == 2)
                label4.Text = "Medium 400x400";
            if (value2 == 3)
                label4.Text = "Big 500x500";
            if (value2 == 4)
                label4.Text = "Very Big 600x600";
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            value3 = checkBox1.Checked;
        }
    }
}

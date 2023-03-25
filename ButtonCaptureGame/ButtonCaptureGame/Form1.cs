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
            Lbl1.Text = "Middle 600 ms";
            Lbl6.Text = "Middle 400x400";
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            Form2 newform = new Form2(value, value2, value3);
            newform.Show();
        }

        private void Trb1_Scroll(object sender, EventArgs e)
        {
            value = Trb1.Value;
            if (value == 0)
                Lbl1.Text = "Very Hard 100 ms";
            if (value == 1)
                Lbl1.Text = "Hard 300 ms";
            if (value == 2)
                Lbl1.Text = "Medium 600 ms";
            if (value == 3)
                Lbl1.Text = "Easy 900 ms";
            if (value == 4)
                Lbl1.Text = "Very Easy 1200 ms";
        }

        private void Trb2_Scroll(object sender, EventArgs e)
        {
            value2 = Trb2.Value;
            if (value2 == 0)
                Lbl6.Text = "Very Small 200x200";
            if (value2 == 1)
                Lbl6.Text = "Small 300x300";
            if (value2 == 2)
                Lbl6.Text = "Medium 400x400";
            if (value2 == 3)
                Lbl6.Text = "Big 500x500";
            if (value2 == 4)
                Lbl6.Text = "Very Big 600x600";
        }

        private void Chk_CheckedChanged(object sender, EventArgs e)
        {
            value3 = Chk.Checked;
        }
    }
}

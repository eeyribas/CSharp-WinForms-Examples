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

        private void StrtBtn_Click(object sender, EventArgs e)
        {
            StrtBtn.Enabled = false;
            StpBtn.Enabled = true;
            Tmr.Start();
        }

        private void StpBtn_Click(object sender, EventArgs e)
        {
            StrtBtn.Enabled = true;
            StpBtn.Enabled = false;
            Tmr.Stop();
        }

        private void Tmr_Tick(object sender, EventArgs e)
        {
            lesson = lesson.Substring(1) + lesson.Substring(0, 1);
            InfoLbl.Text = lesson;
        }
    }
}

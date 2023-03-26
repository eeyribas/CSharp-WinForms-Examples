using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScrollingText
{
    public partial class Form1 : Form
    {
        string s;
        int n;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            s = "Esen EYRIBAS             ";
            n = s.Length;
            Lbl.Text = s;
            Lbl.BackColor = Color.Yellow;
            Lbl.ForeColor = Color.Blue;
            Tmr.Interval = 250;
            Tmr.Enabled = true;
        }

        private void Tmr_Tick(object sender, EventArgs e)
        {
            s = s.Substring(1, n - 1) + s[0];
            Lbl.Text = s;
        }

        private void Lbl_Click(object sender, EventArgs e)
        {
            Tmr.Enabled = !Tmr.Enabled;
        }
    }
}

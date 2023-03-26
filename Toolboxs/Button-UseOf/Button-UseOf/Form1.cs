using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Button_UseOf
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Btn1_Click(object sender, EventArgs e)
        {
            Btn1.Enabled = false;
        }

        private void Btn2_Click(object sender, EventArgs e)
        {
            if (!Btn1.Enabled)
                Btn2.ForeColor = Color.Red;
            else
                Btn2.ForeColor = Color.Black;
            Btn1.Enabled = true;
        }
    }
}

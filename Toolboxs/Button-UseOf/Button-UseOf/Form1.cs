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

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!button1.Enabled)
                button2.ForeColor = Color.Red;
            else
                button2.ForeColor = Color.Black;
            button1.Enabled = true;
        }
    }
}

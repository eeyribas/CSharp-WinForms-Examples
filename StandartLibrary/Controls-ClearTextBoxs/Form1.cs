using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Controls_ClearTextBoxs
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for(int i = 0; i <= this.Controls.Count - 1; i++)
            {
                if (this.Controls[i] is TextBox)
                    this.Controls[i].Text = "";
            }
        }
    }
}

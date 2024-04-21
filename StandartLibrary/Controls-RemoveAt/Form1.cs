using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Controls_RemoveAt
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for(int i = 0; i < this.Controls.Count; i++)
                this.Controls.RemoveAt(0);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int i = 0;
            while (i < this.Controls.Count)
            {
                if(this.Controls[i] is TextBox)
                    this.Controls.RemoveAt(i);
                else
                    i += 1;
            }
        }
    }
}

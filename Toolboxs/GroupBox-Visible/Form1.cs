using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GroupBox_Visible
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (int.Parse(textBox2.Text) > 20)
                    groupBox1.Visible = true;
                else
                    groupBox1.Visible = false;

                this.Text = "";
            }
            catch
            {
                this.Text = "Error. Age > 20";
            }
        }
    }
}

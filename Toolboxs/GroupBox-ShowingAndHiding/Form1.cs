using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GroupBox_ShowingAndHiding
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            radioButton2.CheckedChanged += new EventHandler(radioButton1_CheckedChanged);
            radioButton3.CheckedChanged += new EventHandler(radioButton1_CheckedChanged);
            radioButton4.CheckedChanged += new EventHandler(radioButton1_CheckedChanged);
            radioButton5.CheckedChanged += new EventHandler(radioButton1_CheckedChanged);
            radioButton6.CheckedChanged += new EventHandler(radioButton1_CheckedChanged);
            radioButton7.CheckedChanged += new EventHandler(radioButton1_CheckedChanged);
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
                groupBox4.Visible = false; 
            else                  
                groupBox4.Visible = true; 

            if (radioButton7.Checked == true)
                groupBox5.Visible = true;  
            else                     
                groupBox5.Visible = false;
        }
    }
}

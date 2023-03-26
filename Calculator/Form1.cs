using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Txt1.ResetText();
            Txt2.ResetText();
        }

        private void Txt12_TextChanged(object sender, EventArgs e)
        {
            Txt3.ResetText();
            Lbl1.Text = "?";
        }

        private void Txt3_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            double a, b, c = 0;

            if(!double.TryParse(Txt1.Text, out a)) {
                MessageBox.Show("Enter real number", "Info");
                Txt1.Focus();
                Txt1.SelectAll();
                return;
            }

            if(!double.TryParse(Txt2.Text, out b)) {
                MessageBox.Show("Enter real number", "Info");
                Txt2.Focus();
                Txt2.SelectAll();
                return;
            }

            if(sender == Btn1) { 
                c = a + b; Lbl1.Text = "+"; 
            } else if(sender == Btn2) { 
                c = a - b; Lbl1.Text = "-"; 
            } else if(sender == Btn3) { 
                c = a * b; Lbl1.Text = "*"; 
            } else if(sender == Btn4) { 
                c = a / b; Lbl1.Text = "/"; 
            }

            Txt3.Text = c.ToString();
        }
    }
}

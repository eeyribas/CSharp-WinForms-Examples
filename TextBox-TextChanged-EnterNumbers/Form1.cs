using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextBox_TextChanged_EnterNumbers
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ContentTxt.ResetText();
        }

        private void ContentTxt_TextChanged(object sender, EventArgs e)
        {
            int i;
            double d;
            string s;

            if (int.TryParse(ContentTxt.Text, out i)) 
                s = "Integer";
            else 
                s = "Not Integer";
            Lbl1.Text = s + " ( " + i.ToString() + " ) ";

            if (double.TryParse(ContentTxt.Text, out d)) 
                s = "Real Number";
            else 
                s = "Not Real Number";
            Lbl2.Text = s + " ( " + d.ToString() + " ) ";
        }
    }
}

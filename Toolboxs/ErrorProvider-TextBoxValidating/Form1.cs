using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ErrorProvider_TextBoxValidating
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_Validating(object sender, CancelEventArgs e)
        {
            if (textBox1.Text.IndexOf(" ") < 0)
                errorProvider1.SetError(textBox1, "Error Text 1");
            else
                errorProvider1.SetError(textBox1, "");
        }

        private void textBox2_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                DateTime.Parse(textBox2.Text);
                errorProvider1.SetError(textBox2, "");
            }
            catch 
            {
                errorProvider1.SetError(textBox2, "Error Text 2");
            }
        }

        private void textBox3_Validating(object sender, CancelEventArgs e)
        {
            if (int.Parse(textBox3.Text) < 0 || int.Parse(textBox3.Text) > 100)
                errorProvider1.SetError(textBox3, "Error Text 3");
            else
                errorProvider1.SetError(textBox3, "");
        }
    }
}

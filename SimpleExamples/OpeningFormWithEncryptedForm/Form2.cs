using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OpeningFormWithEncryptedForm
{
    public partial class Form2 : Form
    {
        int count;

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            AcceptButton = button1;
            CancelButton = button2;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            count++;

            if (textBox1.Text == "esen")
            {
                DialogResult = DialogResult.OK;
            }
            else
            {
                textBox1.ResetText();
                textBox1.Focus();
                Text = "Error Password";
                if (count == 3)
                {
                    DialogResult = DialogResult.Cancel;
                    MessageBox.Show("Unauthorized Persons Cannot Use the Program", "Info");
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}

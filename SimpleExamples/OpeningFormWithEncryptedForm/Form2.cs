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
            AcceptButton = Btn1;
            CancelButton = Btn2;
        }

        private void Btn1_Click(object sender, EventArgs e)
        {
            count++;
            if (Txt.Text == "esen")
            {
                DialogResult = DialogResult.OK;
            }
            else
            {
                Txt.ResetText();
                Txt.Focus();
                Text = "Error Password";
                if (count == 3)
                {
                    DialogResult = DialogResult.Cancel;
                    MessageBox.Show("Unauthorized Persons Cannot Use the Program", "Info");
                }
            }
        }

        private void Btn2_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}

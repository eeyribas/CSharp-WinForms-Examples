using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EncryptedScreen
{
    public partial class Form2 : Form
    {
        private int count = 0;

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            this.CancelButton = button2;
            this.AcceptButton = button1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            count++;
            if (textBox1.Text == "1234")
            {
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                textBox1.Text = "";
                this.Text = "Error password";
                if (count == 3)
                {
                    this.DialogResult = DialogResult.Cancel;
                    MessageBox.Show("Unauthorized individuals cannot use the program.");
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}

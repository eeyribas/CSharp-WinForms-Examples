using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Button_DeleteContent
{
    public partial class Form1 : Form
    {
        bool state = true;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            KeyPreview = true;
            DeleteBtn_Click(sender, e);
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            ContentText.ResetText();
            ContentText.Focus();
        }

        private void ContentText_TextChanged(object sender, EventArgs e)
        {
            Lbl.Text = ContentText.Text;
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)27) {
                state = false;
                Close();
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = state;
            if(state) {
                MessageBox.Show("Exit just by pressing\n the ESC key",
                    "Message Box");
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DeleteBtn_Click(sender, e);
        }

        private void OkBtn_Click(object sender, EventArgs e)
        {
            Lbl.Text = ContentTxt.Text;
            ContentTxt.Focus();
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            ContentTxt.ResetText();
            ContentTxt.Focus();
        }

        private void ContentTxt_TextChanged(object sender, EventArgs e)
        {
            Lbl.ResetText();
        }

        private void ContentTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
                OkBtn_Click(sender, e);
        }
    }
}

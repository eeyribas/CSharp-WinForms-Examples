using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ActiveToolboxsWithPassword
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.PasswordChar = '*';

            foreach (Control control in this.Controls)
            {
                if (control.GetType().Name == "TextBox")
                    ((TextBox)control).ReadOnly = true;
            }
            textBox1.ReadOnly = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool state;
            if (textBox1.Text == "1234")
                state = false;
            else
                state = true;

            foreach (Control control in this.Controls)
            {
                if (control.GetType().Name == "TextBox")
                    ((TextBox)control).ReadOnly = state;
            }
            textBox1.ReadOnly = false;
        }
    }
}

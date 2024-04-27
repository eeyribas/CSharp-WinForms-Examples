using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XORAdvancedEncrypt
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string passwordText = "";
            char c;
            string text= textBox1.Text;
            string password = textBox2.Text;

            for (int j = 0; j <= password.Length - 1; j++)
            {
                passwordText = "";
                for (int i = 0; i <= text.Length - 1; i++)
                {
                    c = (char)(text[i] ^ password[j]);
                    if (c == '0')
                        c = password[j];
                    passwordText += (char)c;
                }
                text = passwordText;
            }
            textBox3.Text = passwordText;
        }
    }
}

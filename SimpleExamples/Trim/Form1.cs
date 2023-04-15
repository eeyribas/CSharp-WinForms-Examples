using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trim
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.ResetText();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string str = textBox1.Text;
            label1.Text = "Character Length = " + str.Length.ToString();
            label3.Text = "\"" + str + "\"";
            label5.Text = "\"" + str.Trim() + "\"";
            label7.Text = "\"" + str.TrimStart() + "\"";
            label9.Text = "\"" + str.TrimEnd() + "\"";
        }
    }
}

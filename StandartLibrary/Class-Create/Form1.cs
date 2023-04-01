using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Class_Create
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Password passw = new Password();
            passw.Text = textBox1.Text;
            passw.Passwd = textBox2.Text;
            textBox3.Text = passw.Encrypt();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Password passw = new Password();
            passw.Text = textBox1.Text;
            passw.Passwd = textBox2.Text;
            textBox3.Text = passw.Solve();
        }
    }
}

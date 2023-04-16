using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Button_AcceptCancel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "1234")
                MessageBox.Show("Password = True");
            else
                MessageBox.Show("Password = False");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

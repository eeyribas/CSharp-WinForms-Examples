using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GetNextControl
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox2.KeyDown += new KeyEventHandler(textBox1_KeyDown);
            textBox3.KeyDown += new KeyEventHandler(textBox1_KeyDown);
            textBox4.KeyDown += new KeyEventHandler(textBox1_KeyDown);
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
                this.GetNextControl((sender as Control), true).Focus();
        }
    }
}

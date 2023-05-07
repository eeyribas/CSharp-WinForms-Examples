using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextBox_EnterLeave
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox2.Enter += new EventHandler(textBox_Enter);
            textBox3.Enter += new EventHandler(textBox_Enter);

            textBox2.Leave += new EventHandler(textBox_Leave);
            textBox3.Leave += new EventHandler(textBox_Leave);
        }

        private void textBox_Enter(object sender, System.EventArgs e)
        {
            (sender as Control).BackColor = Color.Red;
        }

        private void textBox_Leave(object sender, System.EventArgs e)
        {
            (sender as Control).BackColor = Color.White;
        }
    }
}

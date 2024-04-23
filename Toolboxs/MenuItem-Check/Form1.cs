using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MenuItem_Check
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void menuItem1_Click(object sender, EventArgs e)
        {
            (sender as MenuItem).Checked = !(sender as MenuItem).Checked;
            if (menuItem1.Checked)
                textBox1.Font = new Font(textBox1.Font, textBox1.Font.Style | FontStyle.Bold);
            else
                textBox1.Font = new Font(textBox1.Font, textBox1.Font.Style ^ FontStyle.Bold);
        }

        private void menuItem2_Click(object sender, EventArgs e)
        {
            (sender as MenuItem).Checked = !(sender as MenuItem).Checked;
            if (menuItem2.Checked)
                textBox1.Font = new Font(textBox1.Font, textBox1.Font.Style | FontStyle.Italic);
            else
                textBox1.Font = new Font(textBox1.Font, textBox1.Font.Style ^ FontStyle.Italic);
        }

        private void menuItem3_Click(object sender, EventArgs e)
        {
            (sender as MenuItem).Checked = !(sender as MenuItem).Checked;
            if (menuItem3.Checked)
                textBox1.Font = new Font(textBox1.Font, textBox1.Font.Style | FontStyle.Underline);
            else
                textBox1.Font = new Font(textBox1.Font, textBox1.Font.Style ^ FontStyle.Underline);
        }
    }
}

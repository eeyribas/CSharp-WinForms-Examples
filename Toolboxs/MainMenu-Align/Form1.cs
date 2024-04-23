using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainMenu_Align
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
            menuItem2.Checked = false;
            menuItem3.Checked = false;
            textBox1.TextAlign = HorizontalAlignment.Left;
        }

        private void menuItem2_Click(object sender, EventArgs e)
        {
            (sender as MenuItem).Checked = !(sender as MenuItem).Checked;
            menuItem1.Checked = false;
            menuItem3.Checked = false;
            textBox1.TextAlign = HorizontalAlignment.Center;
        }

        private void menuItem3_Click(object sender, EventArgs e)
        {
            (sender as MenuItem).Checked = !(sender as MenuItem).Checked;
            menuItem2.Checked = false;
            menuItem3.Checked = false;
            textBox1.TextAlign = HorizontalAlignment.Right;
        }
    }
}

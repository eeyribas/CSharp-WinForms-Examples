using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelpButton
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.HelpButton = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            Help.ShowPopup(textBox1, "This box enter your first and last name", hlpevent.MousePos);
        }

        private void button1_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            Help.ShowPopup(button1, "To exit the program, click this button", hlpevent.MousePos);
        }
    }
}

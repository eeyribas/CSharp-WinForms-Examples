using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainMenu_AddRemove
{
    public partial class Form1 : Form
    {
        private int count, y;

        public Form1()
        {
            InitializeComponent();
        }

        private void menuItem1_Click(object sender, EventArgs e)
        {
            Button button1 = new Button();
            button1.Top = y;
            button1.Left = 0;
            button1.Width = 150;

            count++;
            button1.Text = "Add " + count.ToString();
            y += button1.Height + 5;
            button1.Click += new EventHandler(Click);
            this.Controls.Add(button1);
        }

        private void menuItem2_Click(object sender, EventArgs e)
        {
            this.Controls.Remove(this.ActiveControl);
        }

        private void Click(object sender, System.EventArgs e)
        {
            MessageBox.Show((sender as Button).Text + " clicked.");
        }
    }
}

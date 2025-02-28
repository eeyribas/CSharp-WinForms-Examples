using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChangeBackgrndColorOfTextBoxes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            foreach (Control control in this.Controls)
            {
                if (control.GetType().Name == "TextBox")
                {
                    control.BackColor = Color.FromArgb(random.Next(255), random.Next(255), random.Next(255));
                    control.ForeColor = Color.FromArgb(random.Next(255), random.Next(255), random.Next(255));
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (Control control in this.Controls)
            {
                if (control.GetType().Name == "TextBox")
                {
                    control.ResetBackColor();
                    control.ResetForeColor();
                }
            }
        }
    }
}

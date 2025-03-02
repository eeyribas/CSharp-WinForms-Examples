using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextBox_SelectionRandomColor
{
    public partial class Form1 : Form
    {
        private Random random = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (Control control in Controls)
            {
                if (control.GetType().Name == "TextBox")
                {
                    control.BackColor = SelectionColor();
                    control.ForeColor = SelectionColor();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (Control control in Controls)
            {
                if (control.GetType().Name == "TextBox")
                {
                    control.ResetBackColor();
                    control.ResetForeColor();
                }
            }
        }

        private Color SelectionColor()
        {
            int r = random.Next(256);
            int g = random.Next(256);
            int b = random.Next(256);

            return Color.FromArgb(r, g, b);
        }
    }
}

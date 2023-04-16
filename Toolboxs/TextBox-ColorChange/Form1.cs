using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextBox_ColorChange
{
    public partial class Form1 : Form
    {
        Random random = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (Control kont in Controls)
            {
                if (kont.GetType().Name == "TextBox")
                {
                    kont.BackColor = SelectionColor();
                    kont.ForeColor = SelectionColor();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (Control kont in Controls)
            {
                if (kont.GetType().Name == "TextBox")
                {
                    kont.ResetBackColor();
                    kont.ResetForeColor();
                }
            }
        }

        Color SelectionColor()
        {
            int r = random.Next(256);
            int g = random.Next(256);
            int b = random.Next(256);
            return Color.FromArgb(r, g, b);
        }
    }
}

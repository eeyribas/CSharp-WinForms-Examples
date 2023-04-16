using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScrollBar_RandomColor
{
    public partial class Form1 : Form
    {
        Random random;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            random = new Random();
            button1_Click(sender, e);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            vScrollBar1.Value = random.Next(256);
            vScrollBar2.Value = random.Next(256);
            vScrollBar3.Value = random.Next(256);
        }

        private void vScrollBar_ValueChanged(object sender, EventArgs e)
        {
            int r = 255 - vScrollBar1.Value;
            int g = 255 - vScrollBar2.Value;
            int b = 255 - vScrollBar3.Value;
            label2.Text = r.ToString("D3");
            label5.Text = g.ToString("D3");
            label8.Text = b.ToString("D3");
            label3.Text = r.ToString("X2");
            label6.Text = g.ToString("X2");
            label9.Text = b.ToString("X2");
            panel1.BackColor = Color.FromArgb(r, g, b);
        }
    }
}

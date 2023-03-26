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
            Btn_Click(sender, e);
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            Vsc1.Value = random.Next(256);
            Vsc2.Value = random.Next(256);
            Vsc3.Value = random.Next(256);
        }

        private void Vsc_ValueChanged(object sender, EventArgs e)
        {
            int r = 255 - Vsc1.Value;
            int g = 255 - Vsc2.Value;
            int b = 255 - Vsc3.Value;
            Lbl1.Text = r.ToString("D3");
            Lbl2.Text = g.ToString("D3");
            Lbl3.Text = b.ToString("D3");
            Lbl4.Text = r.ToString("X2");
            Lbl5.Text = g.ToString("X2");
            Lbl6.Text = b.ToString("X2");
            Pnl.BackColor = Color.FromArgb(r, g, b);
        }
    }
}

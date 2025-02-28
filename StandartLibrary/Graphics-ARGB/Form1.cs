using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Graphics_ARGB
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Graphics graphics = this.CreateGraphics();
            graphics.FillRectangle(new SolidBrush(Color.FromArgb(100, 255, 0, 0)), 10, 10, 100, 100);
            graphics.FillRectangle(new SolidBrush(Color.FromArgb(100, 0, 255, 0)), 90, 80, 100, 100);
            graphics.FillRectangle(new SolidBrush(Color.FromArgb(100, 0, 0, 255)), 170, 10, 100, 100);
            graphics.FillRectangle(new SolidBrush(Color.FromArgb(100, 255, 255, 0)), 10, 160, 100, 100);
            graphics.FillRectangle(new SolidBrush(Color.FromArgb(100, 255, 255, 255)), 170, 160, 100, 100);
            graphics.Dispose();
        }
    }
}

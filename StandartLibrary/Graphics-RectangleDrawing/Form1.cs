using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Graphics_RectangleDrawing
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
            Random random = new Random();
            int mx = random.Next(Width);
            int my = random.Next(Height / 2);

            for (int i = 1; i <= 10; i++)
                graphics.DrawRectangle(new Pen(Color.Blue, i), mx - i * 10, my - i * 10, i * 20, i * 20);
            graphics.Dispose();
        }
    }
}

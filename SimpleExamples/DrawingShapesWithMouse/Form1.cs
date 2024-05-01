using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DrawingShapesWithMouse
{
    public partial class Form1 : Form
    {
		private Graphics graphics;
		private int x, y;

		public Form1()
        {
            InitializeComponent();
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
			if(e.Button == MouseButtons.Left)
			{
				x = e.X;
				y = e.Y;
			}

			if(e.Button == MouseButtons.Right)
			{
				graphics = this.CreateGraphics();
				graphics.Clear(Color.Blue);
				graphics.Dispose();
			}
		}

		private void Form1_MouseMove(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				graphics = this.CreateGraphics();
				graphics.DrawEllipse(new Pen(Color.Yellow),
				x - Math.Abs(x - e.X) / 2,
				y - Math.Abs(y - e.Y) / 2,
				Math.Abs(x - e.X),
				Math.Abs(y - e.Y));
				graphics.Dispose();
			}
		}
	}
}

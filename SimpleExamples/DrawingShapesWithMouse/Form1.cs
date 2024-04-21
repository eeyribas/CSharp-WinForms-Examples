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
		Graphics g;
		int x, y;

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
				g = this.CreateGraphics();
				g.Clear(Color.Blue);
				g.Dispose();
			}
		}

		private void Form1_MouseMove(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				g = this.CreateGraphics();
				g.DrawEllipse(new Pen(Color.Yellow),
				x - Math.Abs(x - e.X) / 2,
				y - Math.Abs(y - e.Y) / 2,
				Math.Abs(x - e.X),
				Math.Abs(y - e.Y));
				g.Dispose();
			}
		}
	}
}

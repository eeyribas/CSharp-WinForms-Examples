using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DrawGraphics
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            int xMiddle = this.ClientSize.Width / 2;
            int yMiddle = this.ClientSize.Height / 2;
            int xMax = this.ClientSize.Width;
            int yMax = this.ClientSize.Height;

            e.Graphics.Clear(this.BackColor);
            e.Graphics.DrawLine(new Pen(Color.Blue, 2), xMiddle, 0, xMiddle, yMax);
            e.Graphics.DrawLine(new Pen(Color.Blue, 2), 0, yMiddle, xMax, yMiddle);

            for (float x = -this.ClientSize.Width / 2; x <= this.ClientSize.Width / 2; x += 0.1F)
            {
                float y = Calculation(x);
                float x1 = x + xMiddle;
                float y1 = -y + yMiddle;
                e.Graphics.DrawLine(new Pen(Color.Red, 1), x1, y1, x1, yMiddle);
            }
        }

        private float Calculation(float x)
        {
            return (float)(x * Math.Sin(5 * x * Math.PI / 180));
        }
    }
}

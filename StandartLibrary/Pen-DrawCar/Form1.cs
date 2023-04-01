using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pen_DrawCar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Pen pen = new Pen(Color.Blue, 2);
            e.Graphics.DrawLine(pen, 10, 50, 90, 50);
            e.Graphics.DrawLine(pen, 90, 50, 130, 20);
            e.Graphics.DrawLine(pen, 130, 20, 170, 20);
            e.Graphics.DrawLine(pen, 170, 20, 210, 50);
            e.Graphics.DrawLine(pen, 210, 50, 300, 50);
            e.Graphics.DrawLine(pen, 300, 50, 300, 90);
            e.Graphics.DrawLine(pen, 300, 90, 10, 90);
            e.Graphics.DrawLine(pen, 10, 90, 10, 50);
            e.Graphics.DrawEllipse(pen, 220, 70, 40, 40);
            e.Graphics.DrawEllipse(pen, 50, 70, 40, 40);
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FindMouseCoordinaats
{
    public partial class Form1 : Form
    {
        private Graphics graphics;
        private Pen pen;
        private Random random;
        private bool draw;
        private int x, y, r, g, b;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            graphics = CreateGraphics();
            random = new Random();
            SelectionRandomColor();
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                draw = true;
            else
                SelectionRandomColor();
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left) 
                draw = false;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            Text = String.Format("{0} : {1}", e.X, e.Y);

            if (draw) 
                graphics.DrawLine(pen, x, y, e.X, e.Y);

            x = e.X;
            y = e.Y;
        }

        private void SelectionRandomColor()
        {
            r = random.Next(256);
            g = random.Next(256);
            b = random.Next(256);
            pen = new Pen(Color.FromArgb(r, g, b), 5);
        }
    }
}

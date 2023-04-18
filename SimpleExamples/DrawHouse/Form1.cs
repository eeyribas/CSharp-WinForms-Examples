using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DrawHouse
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Point[] point1 = new Point[3];
            point1[0] = new Point(100, 100);
            point1[1] = new Point(450, 100);
            point1[2] = new Point(150, 150);
            e.Graphics.DrawImage(pictureBox2.Image, point1);

            Point[] point2 = new Point[3];
            point2[0] = new Point(125, 75);
            point2[1] = new Point(470, 75);
            point2[2] = new Point(60, 130);
            e.Graphics.DrawImage(pictureBox2.Image, point2);

            Point[] point3 = new Point[3];
            point3[0] = new Point(100, 100);
            point3[1] = new Point(150, 150);
            point3[2] = new Point(100, 300);
            e.Graphics.DrawImage(pictureBox1.Image, point3);

            Point[] point4 = new Point[3];
            point4[0] = new Point(150, 150);
            point4[1] = new Point(500, 150);
            point4[2] = new Point(150, 350);
            e.Graphics.DrawImage(pictureBox1.Image, point4);

            Point[] point5 = new Point[3];
            point5[0] = new Point(125, 75);
            point5[1] = new Point(160, 180);
            point5[2] = new Point(500, 75);
            e.Graphics.DrawImage(pictureBox1.Image, point5);
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Point_StarDrawing
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Point[] point = new Point[10];
            point[0] = new Point(14, 149);
            point[1] = new Point(100, 114);
            point[2] = new Point(105, 14);
            point[3] = new Point(178, 93);
            point[4] = new Point(267, 65);
            point[5] = new Point(221, 144);
            point[6] = new Point(280, 242);
            point[7] = new Point(181, 209);
            point[8] = new Point(103, 266);
            point[9] = new Point(95, 182);

            e.Graphics.FillPolygon(new TextureBrush(pictureBox1.Image), point);
        }
    }
}

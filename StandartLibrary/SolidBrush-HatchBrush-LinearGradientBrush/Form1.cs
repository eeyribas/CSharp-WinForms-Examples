using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SolidBrush_HatchBrush_LinearGradientBrush
{
    public partial class Form1 : Form
    {
        Brush brush;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("SolidBrush");
            comboBox1.Items.Add("HatchBrush");
            comboBox1.Items.Add("LinearGradientBrush");
            comboBox1.Items.Add("PathGradientBrush");
            comboBox1.Items.Add("TextureBrush");
            comboBox1.SelectedIndex = 0;
            pictureBox1.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Graphics graphics = this.CreateGraphics();
            Random random = new Random();
            graphics.FillRectangle(brush, random.Next(200), random.Next(200), random.Next(200), random.Next(200));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Graphics graphics = this.CreateGraphics();
            Random random = new Random();
            graphics.FillEllipse(brush, random.Next(200), random.Next(200), random.Next(200), random.Next(200));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Graphics graphics = this.CreateGraphics();
            Random random = new Random();
            graphics.DrawString("Visual C# .NET", new Font("Tahoma", 30, FontStyle.Bold), 
            brush, random.Next(200), random.Next(200));
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Random random = new Random();
            Color color = Color.FromArgb(random.Next(255), random.Next(255), random.Next(255));
            Color color2 = Color.FromArgb(random.Next(255), random.Next(255), random.Next(255));

            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    brush = new SolidBrush(color);
                    break;
                case 1: 
                    brush = new System.Drawing.Drawing2D.HatchBrush((System.Drawing.Drawing2D.HatchStyle)random.Next(50), color);
                    break;
                case 2: 
                    brush = new System.Drawing.Drawing2D.LinearGradientBrush(new Point(random.Next(200),
                     random.Next(200)), new Point(random.Next(200), random.Next(200)), color, color2);
                    break;
                case 3:
                    Point[] point = new Point[2];
                    point[0] = new Point(random.Next(200), random.Next(200));
                    point[1] = new Point(random.Next(200), random.Next(200));
                    brush = new System.Drawing.Drawing2D.PathGradientBrush(point);
                    ((System.Drawing.Drawing2D.PathGradientBrush)brush).CenterColor = color;
                    ((System.Drawing.Drawing2D.PathGradientBrush)brush).CenterPoint = new PointF(random.Next(200), random.Next(200));
                    break;
                case 4:
                    brush = new TextureBrush(pictureBox1.Image);
                    break;
            }
        }
    }
}

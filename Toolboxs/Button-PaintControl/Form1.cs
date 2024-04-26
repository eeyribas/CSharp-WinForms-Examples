using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Button_PaintControl
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Drawing.Drawing2D.GraphicsPath graphicsPath = new System.Drawing.Drawing2D.GraphicsPath();
            graphicsPath.AddEllipse(0, 0, (sender as Control).Width, (sender as Control).Height);
            (sender as Control).Region = new Region(graphicsPath);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.Drawing.Drawing2D.GraphicsPath graphicsPath = new System.Drawing.Drawing2D.GraphicsPath();
            graphicsPath.AddRectangle(new Rectangle(0, 0, (sender as Control).Width, (sender as Control).Height));
            graphicsPath.AddEllipse(10, 10, (sender as Control).Width - 20, (sender as Control).Height - 20);
            (sender as Control).Region = new Region(graphicsPath);
        }
    }
}

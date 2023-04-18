using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DrawRotateTransform
{
    public partial class Form1 : Form
    {
        int degree = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Interval = 100;
            timer1.Enabled = true;
            this.WindowState = FormWindowState.Maximized;
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Font font = new Font("Tahoma", 20, FontStyle.Bold);
            StringFormat stringFormat = new StringFormat();
            stringFormat.Alignment = StringAlignment.Center;

            string text = "Visual C# .NET is a very powerful and very useful programming language.";
            e.Graphics.FillRectangle(new SolidBrush(Color.Yellow), 100, 10, 200, 200);
            e.Graphics.DrawString(text, font, new SolidBrush(Color.Brown), new RectangleF(100, 10, 200, 200), stringFormat);
            e.Graphics.RotateTransform(30);
            e.Graphics.FillRectangle(new SolidBrush(Color.Brown), 100, 10, 200, 200);
            e.Graphics.DrawString(text, font, new SolidBrush(Color.Yellow), new RectangleF(100, 10, 200, 200), stringFormat);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Random random = new Random();
            degree += 10 % 360;
            Color color1 = Color.FromArgb(random.Next(255), random.Next(255), random.Next(255));
            Color color2 = Color.FromArgb(random.Next(255), random.Next(255), random.Next(255));
            Graphics graphics = this.CreateGraphics();

            Font font = new Font("Tahoma", 20, FontStyle.Bold);
            StringFormat stringFormat = new StringFormat();
            stringFormat.Alignment = StringAlignment.Center;

            string text = "Visual C# .NET is a very powerful and very useful programming language.";
            graphics.RotateTransform(degree);
            int xMiddle = this.ClientSize.Width / 2;
            int yMiddle = this.ClientSize.Height / 2;
            graphics.FillRectangle(new SolidBrush(color1), xMiddle, yMiddle, 200, 200);
            graphics.DrawString(text, font, new SolidBrush(color2), new RectangleF(xMiddle, yMiddle, 200, 200), stringFormat);
            graphics.Dispose();
        }
    }
}

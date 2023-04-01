using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bitmap_Draw
{
    public partial class Form1 : Form
    {
        public Graphics graphics;
        public Bitmap bitmap;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Rectangle rectangle = new Rectangle();
            rectangle = Screen.GetBounds(rectangle);
            bitmap = new Bitmap(rectangle.Width, rectangle.Height, System.Drawing.Imaging.PixelFormat.Format32bppArgb);
            graphics = Graphics.FromImage(bitmap);
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(bitmap, e.ClipRectangle,
                         e.ClipRectangle.Left, e.ClipRectangle.Top,
                         e.ClipRectangle.Width, e.ClipRectangle.Height,
                         GraphicsUnit.Pixel);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            graphics.FillEllipse(new SolidBrush(Color.Red), 10, 10, 200, 30);
            graphics.DrawString("Visual C# .NET", new Font("Tahoma", 12, FontStyle.Regular), new SolidBrush(Color.Blue), 50, 15);
            this.Invalidate();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bitmap.Save("c:\\temp.bmp");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            bitmap = (Bitmap)Image.FromFile("c:\\temp.bmp");
            this.Invalidate();
        }
    }
}

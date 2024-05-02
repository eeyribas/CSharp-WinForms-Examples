using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Graphics_Bitmap_DrawPaintMemory
{
    public partial class Form1 : Form
    {
        private Bitmap bitmap;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Rectangle rectangle = new Rectangle();
            rectangle = Screen.GetBounds(rectangle);
            bitmap = new Bitmap(rectangle.Width, rectangle.Height, PixelFormat.Format24bppRgb);

            this.Show();
            Draw();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(bitmap, e.ClipRectangle, e.ClipRectangle.Left, e.ClipRectangle.Top,
                                 e.ClipRectangle.Width, e.ClipRectangle.Height, GraphicsUnit.Pixel);
        }

        private void Draw()
        {
            Graphics graphics = Graphics.FromImage(bitmap);
            Random random = new Random();

            for (int i = 1; i <= 10000; i++)
            {
                graphics.DrawEllipse(new Pen(Color.FromArgb(random.Next(255), random.Next(255), random.Next(255))),
                                     random.Next(1000), random.Next(1000), random.Next(1000), random.Next(1000));
                graphics.DrawRectangle(new Pen(Color.FromArgb(random.Next(255), random.Next(255), random.Next(255))),
                                       random.Next(1000), random.Next(1000), random.Next(1000), random.Next(1000));
            }

            for (int i = 1; i <= 10; i++)
            {
                graphics.DrawString("Visual C# .Net", new Font("Tahoma", 18, FontStyle.Bold), new SolidBrush(Color.Yellow), 
                                    random.Next(300), random.Next(300));
            }
        }
    }
}

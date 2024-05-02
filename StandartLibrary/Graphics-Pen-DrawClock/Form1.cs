using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Graphics_Pen_DrawClock
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Interval = 1000;
            timer1.Enabled = true;
            this.Height = this.Width + this.ClientSize.Width - this.ClientSize.Height;
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.Clear(this.BackColor);
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            Graphics graphics = this.CreateGraphics();
            graphics.Clear(this.BackColor);
            graphics.Dispose();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Graphics graphics = this.CreateGraphics();

            float r;
            if (this.ClientSize.Width > this.ClientSize.Height)
                r = this.ClientSize.Height / 2;
            else
                r = this.ClientSize.Width / 2;

            graphics.SmoothingMode = SmoothingMode.AntiAlias;
            graphics.DrawEllipse(new Pen(Color.Red), 0, 0, 2 * r, 2 * r);
            graphics.DrawEllipse(new Pen(Color.Red), 8, 8, 2 * r - 16, 2 * r - 16);
            graphics.FillEllipse(new SolidBrush(this.BackColor), 9, 9, 2 * r - 18, 2 * r - 18);

            float xMiddle = r;
            float yMiddle = r;
            r -= 8;

            float sX, sY;
            int kX1, kY1, kX2, kY2, i, hour, minute, second;
            for (i = 0; i <= 360; i += 6)
            {
                kX1 = (int)(xMiddle + (r + 8) * Math.Cos(i * 3.1415 / 180));
                kY1 = (int)(yMiddle - (r + 8) * Math.Sin(i * 3.1415 / 180));
                kX2 = (int)(xMiddle + (r) * Math.Cos(i * 3.1415 / 180));
                kY2 = (int)(yMiddle - (r) * Math.Sin(i * 3.1415 / 180));

                if ((i % 30) == 0)
                    graphics.DrawLine(new Pen(Color.Red, 4), kX1, kY1, kX2, kY2);
                else
                    graphics.DrawLine(new Pen(Color.Blue, 2), kX1, kY1, kX2, kY2);
            }

            kX1 = (int)(xMiddle - (graphics.MeasureString("Clock", new Font("Tahoma", 8, FontStyle.Regular)).Width) / 2);
            kY1 = 30;
            graphics.DrawString("Clock", new Font("Tahoma", 8, FontStyle.Regular), new SolidBrush(Color.Blue), kX1, kY1);

            GraphicsPath graphicsPath = new GraphicsPath();
            hour = DateTime.Now.TimeOfDay.Hours;
            i = -hour * 30 + 90;  
                                  
            sX = (int)(xMiddle + r * 2 / 3 * Math.Cos(i * 3.1415 / 180));
            sY = (int)(yMiddle - r * 2 / 3 * Math.Sin(i * 3.1415 / 180));
            kX1 = (int)(xMiddle - 8 * Math.Cos(i * 3.1415 / 180 + Math.PI / 2));
            kX2 = (int)(xMiddle + 8 * Math.Cos(i * 3.1415 / 180 + Math.PI / 2));
            kY1 = (int)(yMiddle + 8 * Math.Sin(i * 3.1415 / 180 + Math.PI / 2));
            kY2 = (int)(yMiddle - 8 * Math.Sin(i * 3.1415 / 180 + Math.PI / 2));
  
            graphicsPath.AddLine(kX1, kY1, sX, sY);
            graphicsPath.AddLine(kX2, kY2, sX, sY);
            graphicsPath.AddLine(kX1, kY1, kX2, kY2);

            minute = DateTime.Now.TimeOfDay.Minutes; 
            i = -minute * 6 + 90;
            sX = (float)(xMiddle + r * Math.Cos(i * 3.1415 / 180));
            sY = (float)(yMiddle - r * Math.Sin(i * 3.1415 / 180));
            kX1 = (int)(xMiddle - 4 * Math.Cos(i * 3.1415 / 180 + Math.PI / 2));
            kX2 = (int)(xMiddle + 4 * Math.Cos(i * 3.1415 / 180 + Math.PI / 2));
            kY1 = (int)(yMiddle + 4 * Math.Sin(i * 3.1415 / 180 + Math.PI / 2));
            kY2 = (int)(yMiddle - 4 * Math.Sin(i * 3.1415 / 180 + Math.PI / 2));
         
            graphicsPath.AddLine(kX1, kY1, sX, sY);
            graphicsPath.AddLine(kX2, kY2, sX, sY);
            graphicsPath.AddLine(kX1, kY1, kX2, kY2);

            second = DateTime.Now.TimeOfDay.Seconds;
            i = -second * 6 + 90; 
            sX = (float)(xMiddle + r * Math.Cos(i * 3.1415 / 180));
            sY = (float)(yMiddle - r * Math.Sin(i * 3.1415 / 180));
            kX1 = (int)(xMiddle - 1 * Math.Cos(i * 3.1415 / 180 + Math.PI / 2));
            kX2 = (int)(xMiddle + 1 * Math.Cos(i * 3.1415 / 180 + Math.PI / 2));
            kY1 = (int)(yMiddle + 1 * Math.Sin(i * 3.1415 / 180 + Math.PI / 2));
            kY2 = (int)(yMiddle - 1 * Math.Sin(i * 3.1415 / 180 + Math.PI / 2));
            
            graphicsPath.AddLine(kX1, kY1, sX, sY);
            graphicsPath.AddLine(kX2, kY2, sX, sY);
            graphicsPath.AddLine(kX1, kY1, kX2, kY2);
            graphicsPath.AddEllipse(xMiddle - 8, yMiddle - 8, 16, 16);
 
            graphics.DrawPath(new Pen(Color.Blue, 1), graphicsPath);
            graphics.FillPath(new SolidBrush(Color.Blue), graphicsPath);
            graphics.Dispose();
            graphicsPath.Dispose();
        }
    }
}

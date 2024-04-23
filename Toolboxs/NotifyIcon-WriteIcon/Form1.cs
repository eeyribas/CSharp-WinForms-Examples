using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NotifyIcon_WriteIcon
{
    public partial class Form1 : Form
    {
        private int i = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Interval = 1000;
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            i = (i + 1) % 100;

            Bitmap bitmap = new Bitmap(16, 16, System.Drawing.Imaging.PixelFormat.Format24bppRgb);
            Graphics graphics = Graphics.FromImage(bitmap);
            graphics.FillRectangle(Brushes.Red, 0, 0, 16, 16);
            graphics.DrawString(i.ToString(), new Font("Tahoma", 8, FontStyle.Bold), Brushes.White, 0, 0);
            notifyIcon1.Icon = Icon.FromHandle(bitmap.GetHicon());
        }
    }
}

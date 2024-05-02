using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Graphics_Idle
{
    public partial class Form1 : Form
    {
        private Graphics graphics;
        private Random random;
        private int M, N, L, count;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            L = 20;
            M = ClientSize.Width - L;
            N = ClientSize.Height - L;

            graphics = CreateGraphics();
            random = new Random();
            Application.Idle += new EventHandler(IdleEvent);
        }

        void IdleEvent(object sender, EventArgs e)
        {
            Text = (++count).ToString();
            Color color = Color.FromArgb(random.Next(256), random.Next(256), random.Next(256));
            Brush brush = new SolidBrush(color);
            Rectangle rectangle = new Rectangle(random.Next(M), random.Next(N), L, L);
            graphics.FillEllipse(brush, rectangle);
        }
    }
}

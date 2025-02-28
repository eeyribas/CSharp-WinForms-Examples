using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JustifyTextLeftOrRight
{
    public partial class Form1 : Form
    {
        private Graphics graphics;
        private SolidBrush solidBrush;
        private Font font;
        private bool jusf;
        private int count;
        private int[,] x = { { 6567, 583, 582, 653, 992, 15375 }, { 89253, 48, 381, 9, 7632, 677562 } };

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            graphics = CreateGraphics();
            solidBrush = new SolidBrush(Color.Green);
            font = new Font("Courier New", 12, FontStyle.Bold);
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Text = (++count).ToString();
            graphics.Clear(Color.Yellow);

            for (int i = 0; i < 2; i++) {
                for (int j = 0; j < 6; j++) {
                    string str = x[i, j].ToString();
                    if (jusf)
                        str = str.PadLeft(16, ' ');

                    graphics.DrawString(str, font, solidBrush, 40 + 200 * i, 100 + 20 * j);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (jusf)
            {
                jusf = false;
                Refresh();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (jusf)
                return;
            jusf = true;

            Refresh();
        }
    }
}

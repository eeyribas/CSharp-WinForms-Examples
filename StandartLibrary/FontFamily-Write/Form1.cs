using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FontFamily_Write
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            FontFamily[] fontFamilies = FontFamily.GetFamilies(e.Graphics);
            float x = 0, y = 0;

            for (int i = 0; i <= fontFamilies.Length - 1; i++)
            {
                Font font = new Font(fontFamilies[i].Name, 8, FontStyle.Regular);
                string str = fontFamilies[i].Name;
                e.Graphics.DrawString(str, font, Brushes.Black, x, y);
                y += font.Height;

                if (((i + 1) % 20) == 0)
                {
                    x += 200;
                    y = 0;
                }
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SolidBrush_PadLeftAndRight
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Graphics graphics = this.CreateGraphics();
            graphics.Clear(Color.Blue);

            SolidBrush solidBrush = new SolidBrush(Color.Yellow);
            Font font = new Font("Courier New", 10, FontStyle.Bold);

            int[] numbers = {5, 17, 230, 900, 40, 8000};
            for (int i = 0; i <= numbers.Length - 1; i++)
            {
                string str = numbers[i].ToString();
                graphics.DrawString(str, font, solidBrush, 10, i * 15);
            }

            graphics.Dispose();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Graphics graphics = this.CreateGraphics();
            graphics.Clear(Color.Blue);

            SolidBrush solidBrush = new SolidBrush(Color.Yellow);
            Font font = new Font("Courier New", 10, FontStyle.Bold);

            int[] numbers = { 5, 17, 230, 900, 40, 8000 };
            for (int i = 0; i <= numbers.Length - 1; i++)
            {
                string str = numbers[i].ToString();
                graphics.DrawString(str.PadLeft(7, ' '), font, solidBrush, 10, i * 15);
            }

            graphics.Dispose();
        }
    }
}

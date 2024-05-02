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

namespace Graphics_DrawStick
{
    public partial class Form1 : Form
    {
        public string[] names = new string[20];
        public int[] percentile = new int[20];
        public int orderNo, sumPercentile;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (orderNo == 20)
            {
                MessageBox.Show("Can be up to 20 percentile");
                return;
            }

            try
            {
                percentile[orderNo] = int.Parse(textBox2.Text);
            }
            catch
            {
                MessageBox.Show("Error");
                return;
            }

            names[orderNo] = textBox1.Text;
            sumPercentile += percentile[orderNo];
            orderNo += 1;

            Graphics graphics = this.CreateGraphics();
            graphics.Clear(this.BackColor);

            Random random = new Random();
            int height;
            Color color;
            HatchBrush brush;

            for (int i = 0; i <= orderNo - 1; i++)
            {
                height = 100 * percentile[i] / sumPercentile;
                color = Color.FromArgb(random.Next(255), random.Next(255), random.Next(255));
                brush = new HatchBrush((HatchStyle)random.Next(50), color);
                
                graphics.FillRectangle(brush, 0, 80 + i * 20, height, 18);
                graphics.DrawString("% " + height.ToString(), new Font("Tahoma", 8, FontStyle.Regular), new SolidBrush(Color.Red),
                                    height + 5, 80 + i * 20);

                graphics.FillRectangle(brush, 210, 80 + i * 20, 18, 18);
                graphics.DrawString(names[i] + "=" + percentile[i], new Font("Tahoma", 8, FontStyle.Regular),
                new SolidBrush(Color.Red), 230, 80 + i * 20);
            }
        }
    }
}

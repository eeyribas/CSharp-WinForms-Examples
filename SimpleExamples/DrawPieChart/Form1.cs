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

namespace DrawPieChart
{
    public partial class Form1 : Form
    {
        string[] references = new string[20];
        int[] values = new int[20];
        int orderNo, sumValue;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (orderNo == 20)
            {
                MessageBox.Show("You must have a maximum of 20 references.");
                return;
            }

            try
            {
                values[orderNo] = int.Parse(textBox2.Text);
            }
            catch
            {
                MessageBox.Show("Value errored.");
                return;
            }

            references[orderNo] = textBox1.Text;
            sumValue += values[orderNo];
            orderNo += 1;

            Graphics graphics = this.CreateGraphics();
            int firstAgree = 0, secondAgree = 0;
            Color color;
            HatchBrush hatchBrush;
            Random random = new Random();
            for (int i = 0; i <= orderNo - 1; i++)
            {
                secondAgree = 360 * values[i] / sumValue;
                color = Color.FromArgb(random.Next(255), random.Next(255), random.Next(255));
                hatchBrush = new HatchBrush((HatchStyle)random.Next(50), color);
                graphics.FillPie(hatchBrush, 0, 80, 200, 200, firstAgree, secondAgree);

                graphics.FillRectangle(hatchBrush, 210, 80 + i * 20, 18, 18);
                graphics.DrawString(references[i] + "=" + values[i].ToString(), new Font("Tahoma", 8, FontStyle.Regular),
                new SolidBrush(Color.Red), 230, 80 + i * 20);
                firstAgree += secondAgree;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ButtonCaptureGame
{
    public partial class Form2 : Form
    {
        int x, y;
        int number = 1;

        public Form2(int number1, int number2, bool checkbox)
        {
            InitializeComponent();

            number2 = (number2 + 1) * 100;
            this.ClientSize = new Size(number2, number2);
            if (number1 == 0)
                number1 = 100;
            else
                number1 = (number1) * 300;

            timer1.Interval = (number1);
            if (checkbox == false)
            {
                this.FormBorderStyle = FormBorderStyle.FixedDialog;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            MessageBox.Show("Congratulations You Won the Game \nTotal Number of Mouse Clicks = " + number, "YOU WIN");
            Close();
            Dispose();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Random random = new Random();
            int index1 = random.Next(1, x - 111);
            int index2 = random.Next(1, y - 40);

            this.button1.Location = new Point(index1, index2);
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            x = ClientSize.Width;
            y = ClientSize.Height;
        }

        private void Form2_MouseClick(object sender, MouseEventArgs e)
        {
            number++;
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Array_AddShowOrderFindReverse
{
    public partial class Form1 : Form
    {
        public string[] names = new string[10];
        public int orderNo;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            names[orderNo] = textBox1.Text;
            orderNo += 1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Array.Sort(names);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string find = textBox2.Text;
            int location = Array.IndexOf(names, find);
            while (location >= 0)
            {
                MessageBox.Show(find + " person " + location.ToString() + "th on the list");
                location = Array.IndexOf(names, find, location + 1);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Graphics graphics = this.CreateGraphics();
            graphics.Clear(this.BackColor);

            for (int i = 0; i <= names.GetLength(0) - 1; i++)
            {
                graphics.DrawString(names[i], new Font("Tahoma", 8, FontStyle.Regular), new SolidBrush(Color.Red), 10,
                                    30 + i * 10);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Array.Reverse(names);
        }
    }
}

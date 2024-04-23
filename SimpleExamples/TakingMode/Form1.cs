using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TakingMode
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.AcceptButton = button1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int number = 0, piece = 0;
            listBox1.Items.Clear();

            try
            {
                number = int.Parse(textBox1.Text);
            }
            catch
            {
                MessageBox.Show("You entered an invalid number.");
                return;
            }

            piece = (int)(number / 20000000);
            listBox1.Items.Add(piece.ToString() + " piece 20.000.000");
            number %= 20000000;

            piece = (int)(number / 10000000);
            listBox1.Items.Add(piece.ToString() + " piece 10.000.000");
            number %= 10000000;

            piece = (int)(number / 5000000);
            listBox1.Items.Add(piece.ToString() + " piece 5.000.000");
            number %= 5000000;

            piece = (int)(number / 1000000);
            listBox1.Items.Add(piece.ToString() + " piece 1.000.000");
            number %= 1000000;

            piece = (int)(number / 500000);
            listBox1.Items.Add(piece.ToString() + " piece 500.000");
            number %= 500000;

            piece = (int)(number / 250000);
            listBox1.Items.Add(piece.ToString() + " piece 250.000");
            number %= 250000;

            listBox1.Items.Add("Mode " + number.ToString());
        }
    }
}

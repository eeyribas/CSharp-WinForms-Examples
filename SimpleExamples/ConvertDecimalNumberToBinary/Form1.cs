using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConvertDecimalNumberToBinary
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
            int x;
            try
            {
                x = int.Parse(textBox1.Text);
            }
            catch
            {
                MessageBox.Show("Invalid number.");
                return;
            }

            label3.Text = "";
            for (int i = 0; i <= 15; i++)
                label3.Text = ((x >> i) & 1).ToString() + label3.Text;
        }
    }
}

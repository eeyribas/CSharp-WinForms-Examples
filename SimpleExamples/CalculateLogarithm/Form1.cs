using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculateLogarithm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int value = int.Parse(textBox1.Text);
            listBox1.Items.Clear();

            if (value <= 0)
                return;

            for (int i = 1; i <= value; i++)
                listBox1.Items.Add("Log(" + i.ToString() + ")=" + Math.Log10(i).ToString());
        }
    }
}

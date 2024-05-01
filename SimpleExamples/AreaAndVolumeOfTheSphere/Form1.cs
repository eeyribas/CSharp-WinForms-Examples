using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AreaAndVolumeOfTheSphere
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label2.Text = Math.PI.ToString();
            textBox1.ResetText();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double r = 0;
            if (!double.TryParse(textBox1.Text, out r))
            {
                MessageBox.Show("Enter real number", "Info");
                textBox1.Focus();
                return;
            }

            double area = 4 * Math.PI * r * r;
            double volume = area * r / 3;
            label5.Text = r.ToString();
            label7.Text = volume.ToString();
            label9.Text = area.ToString();
            textBox1.Focus();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            label5.ResetText();
            label7.ResetText();
            label9.ResetText();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RGBColor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            numericUpDown1.Maximum = 255;
            numericUpDown2.Maximum = 255;
            numericUpDown3.Maximum = 255;

            numericUpDown2.ValueChanged += new EventHandler(numericUpDown1_ValueChanged);
            numericUpDown3.ValueChanged += new EventHandler(numericUpDown1_ValueChanged);
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            textBox1.BackColor = Color.FromArgb((int)numericUpDown1.Value, (int)numericUpDown2.Value, (int)numericUpDown3.Value);
            textBox1.Text = textBox1.BackColor.ToString();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextBox_ChangeColor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.ResetText();
            textBox2.ResetText();
        }

        private void textBox_Changed(object sender, EventArgs e)
        {
            label1.Text = textBox1.TextLength.ToString();
            label2.Text = textBox2.TextLength.ToString();

            Color color = (textBox1.Text == textBox2.Text) ? Color.Green : Color.Red;
            for (int i = 0; i < Controls.Count; i++)
                Controls[i].ForeColor = color;
        }
    }
}

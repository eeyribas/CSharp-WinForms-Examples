using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FontProperties
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, System.EventArgs e)
        {
            switch ((sender as Button).Text)
            {
                case "Bold":
                    textBox1.Font = new Font(textBox1.Font,
                    textBox1.Font.Style ^ FontStyle.Bold);
                    break;
                case "Italic":
                    textBox1.Font = new Font(textBox1.Font,
                    textBox1.Font.Style ^ FontStyle.Italic);
                    break;
                case "Underlined":
                    textBox1.Font = new Font(textBox1.Font,
                    textBox1.Font.Style ^ FontStyle.Underline);
                    break;
                case "Strikethrough":
                    textBox1.Font = new Font(textBox1.Font,
                    textBox1.Font.Style ^ FontStyle.Strikeout);
                    break;
            }
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            textBox1.Font = new Font(textBox1.Font.Name, (float)numericUpDown1.Value, textBox1.Font.Style);
        }
    }
}

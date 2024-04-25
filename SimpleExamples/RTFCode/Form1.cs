using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RTFCode
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            richTextBox1.SelectedRtf = "{\\rtf1 \r\n" +
                             "Hello\\par \r\n" +
                             "Ali\\par \r\n" +
                             "\\b Where are you from ? \\b0 \\par \r\n" +
                             "\\ul Goodbye \\ul \r\n" +
                             "}";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = richTextBox1.Rtf;
        }
    }
}

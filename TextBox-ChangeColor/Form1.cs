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
            Txt1.ResetText();
            Txt2.ResetText();
        }

        private void Txt_Changed(object sender, EventArgs e)
        {
            Lbl1.Text = Txt1.TextLength.ToString();
            Lbl2.Text = Txt2.TextLength.ToString();
            Color color = (Txt1.Text == Txt2.Text) ? Color.Green : Color.Red;
            for(int i = 0; i < Controls.Count; i++) 
                Controls[i].ForeColor = color;
        }
    }
}

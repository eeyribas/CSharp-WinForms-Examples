using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trim
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Txt.ResetText();
        }

        private void Txt_TextChanged(object sender, EventArgs e)
        {
            string s = Txt.Text;
            Lbl1.Text = "Character Length = " + s.Length.ToString();
            Lbl2.Text = "\"" + s + "\"";
            Lbl3.Text = "\"" + s.Trim() + "\"";
            Lbl4.Text = "\"" + s.TrimStart() + "\"";
            Lbl5.Text = "\"" + s.TrimEnd() + "\"";
        }
    }
}

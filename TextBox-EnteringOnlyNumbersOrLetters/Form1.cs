using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextBox_EnteringOnlyNumbersOrLetters
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

        private void Txt1_TextChanged(object sender, EventArgs e)
        {
            Lbl1.Text = Txt1.TextLength.ToString();
        }

        private void Txt2_TextChanged(object sender, EventArgs e)
        {
            Lbl2.Text = Txt2.TextLength.ToString();
        }

        private void Txt1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(Char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back) 
                return;
            e.Handled = true;
            Console.Beep(1000, 50);
        }

        private void Txt2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(Char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back) 
                return;
            e.Handled = true;
            Console.Beep(2000, 50);
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DivideResult
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Btn_Click(sender, e);
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            int a, b;
            if (!int.TryParse(Txt1.Text, out a))
            {
                MessageBox.Show("Enter integer", "Info");
                Txt1.Focus();
                return;
            }
            if (!int.TryParse(Txt2.Text, out b))
            {
                MessageBox.Show("Enter integer", "Info");
                Txt2.Focus();
                return;
            }
            Txt3.Text = (a / b).ToString();
            Txt4.Text = (a % b).ToString();
        }

        private void Txt12_TextChanged(object sender, EventArgs e)
        {
            Txt3.Clear();
            Txt4.Clear();
        }

        private void Txt34_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}

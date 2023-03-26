using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListBox_Records
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Lst_SelectedIndexChanged(sender, e);
        }

        private void Lst_SelectedIndexChanged(object sender, EventArgs e)
        {
            Lbl1.Text = Lst.SelectedIndex.ToString();
            Lbl2.Text = Lst.Items.Count.ToString();
            if (Lst.SelectedIndex >= 0)
                Txt2.Text = Lst.SelectedItem.ToString();
            else 
                Txt2.Clear();
        }

        private void Btn1_Click(object sender, EventArgs e)
        {
            Txt1.Text = Txt1.Text.Trim();
            if (Txt1.TextLength > 0)
                Lst.Items.Add(Txt1.Text);
            Txt1.Clear();
            Txt1.Focus();
            Lst_SelectedIndexChanged(sender, e);
        }

        private void Btn2_Click(object sender, EventArgs e)
        {
            Lst.Items.Clear();
            Lst_SelectedIndexChanged(sender, e);
        }

        private void Btn3_Click(object sender, EventArgs e)
        {
            if (Lst.SelectedIndex >= 0)
                Lst.Items.RemoveAt(Lst.SelectedIndex);
        }

        private void Btn4_Click(object sender, EventArgs e)
        {
            int i = 0;
            if (int.TryParse(Txt3.Text, out i))
            {
                if ((i >= 0) && (i < Lst.Items.Count))
                    Txt4.Text = Lst.Items[i].ToString();
                else
                    MessageBox.Show("Out of Range", "Info");
            }
            else
            {
                MessageBox.Show("TextBox object\nEnter integer", "Info");
            }
            Txt3.Focus();
        }

        private void Txt1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13) 
                Btn1_Click(sender, e);
        }

        private void Txt3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13) 
                Btn4_Click(sender, e);
        }

        private void Txt24_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}

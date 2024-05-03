using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListBox_MouseDown
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Visible = false;
        }

        private void listBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Clicks == 2)
            {
                int index = listBox1.IndexFromPoint(e.X, e.Y);
                if (index < 0)
                {
                    listBox1.Items.Add("");
                    index = listBox1.Items.Count - 1;
                    listBox1.SelectedIndex = index;
                }

                Rectangle rectangle = listBox1.GetItemRectangle(index);
                listBox1.SelectedIndex = index;

                textBox1.SetBounds(listBox1.Left + rectangle.Left, listBox1.Top + rectangle.Top, 
                                                   rectangle.Width, rectangle.Height);
                textBox1.Text = listBox1.Text;
                textBox1.Visible = true;
                textBox1.BringToFront();
                textBox1.Focus();
                textBox1.SelectionStart = textBox1.Text.Length;
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)(13))
            {
                int index = listBox1.SelectedIndex;
                if (index >= 0)
                    listBox1.Items[index] = textBox1.Text;

                textBox1.Visible = false;
                e.Handled = true;
            }

            if (e.KeyChar == (char)(27))
            {
                textBox1.Text = listBox1.Text;
                textBox1.Visible = false;
                e.Handled = true;
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            int index = listBox1.SelectedIndex;
            if (index >= 0)
                listBox1.Items[index] = textBox1.Text;

            textBox1.Visible = false;
        }
    }
}

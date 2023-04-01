using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProductStockTracking
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            checkedListBox1.Items.Add(textBox1.Text);
            checkedListBox2.Items.Add(textBox2.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int ind = checkedListBox1.SelectedIndex;
            if (ind < 0)
            {
                MessageBox.Show("First select the element to delete");
            }
            else
            {
                checkedListBox1.Items.RemoveAt(ind);
                checkedListBox2.Items.RemoveAt(ind);
            }
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int ind = checkedListBox1.SelectedIndex;
            checkedListBox2.SelectedIndex = ind;
            if (ind < 0)
                return;

            checkedListBox2.SetItemChecked(ind, checkedListBox1.GetItemChecked(ind));
            int b = listBox1.Items.IndexOf(checkedListBox1.Items[ind]);
            if (b < 0)
            {
                if (checkedListBox1.GetItemChecked(ind) == true)
                {
                    listBox1.Items.Add(checkedListBox1.Items[ind]);
                    listBox2.Items.Add(checkedListBox2.Items[ind]);
                }
            }
            else
            {
                if (checkedListBox1.GetItemChecked(ind) == false)
                {
                    listBox1.Items.RemoveAt(b);
                    listBox2.Items.RemoveAt(b);
                }
            }

            int t = 0;
            for (int i = 0; i <= listBox2.Items.Count - 1; i++)
                t = t + int.Parse(listBox2.Items[i].ToString());
            label4.Text = t.ToString();
        }

        private void checkedListBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            checkedListBox1.SelectedIndex = checkedListBox2.SelectedIndex;
        }
    }
}

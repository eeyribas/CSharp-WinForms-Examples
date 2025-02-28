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
            if (ind >= 0)
            {
                checkedListBox1.Items.RemoveAt(ind);
                checkedListBox2.Items.RemoveAt(ind);
            }
            else
            {
                MessageBox.Show("First select the element to delete");
            }
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = checkedListBox1.SelectedIndex;
            checkedListBox2.SelectedIndex = index;
            if (index < 0)
                return;

            checkedListBox2.SetItemChecked(index, checkedListBox1.GetItemChecked(index));
            int indexOf = listBox1.Items.IndexOf(checkedListBox1.Items[index]);
            if (indexOf < 0)
            {
                if (checkedListBox1.GetItemChecked(index) == true)
                {
                    listBox1.Items.Add(checkedListBox1.Items[index]);
                    listBox2.Items.Add(checkedListBox2.Items[index]);
                }
            }
            else
            {
                if (checkedListBox1.GetItemChecked(index) == false)
                {
                    listBox1.Items.RemoveAt(indexOf);
                    listBox2.Items.RemoveAt(indexOf);
                }
            }

            int sum = 0;
            for (int i = 0; i <= listBox2.Items.Count - 1; i++)
                sum += int.Parse(listBox2.Items[i].ToString());
            label4.Text = sum.ToString();
        }

        private void checkedListBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            checkedListBox1.SelectedIndex = checkedListBox2.SelectedIndex;
        }
    }
}

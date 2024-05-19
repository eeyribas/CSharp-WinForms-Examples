using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListView_AddTextAndSelectedItem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ListViewItem listViewItem = new ListViewItem();
            listViewItem.Text = listBox1.Text;
            listViewItem.SubItems.Add(textBox1.Text);
            listView1.Items.Add(listViewItem);

            textBox1.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ListViewItem listViewItem = new ListViewItem();
            listViewItem.Text = listBox1.Text;
            listViewItem.SubItems.Add(textBox1.Text);
            listView2.Items.Add(listViewItem);

            textBox1.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ListViewItem listViewItem = new ListViewItem();
            listViewItem.Text = listBox1.Text;
            listViewItem.SubItems.Add(textBox1.Text);
            listView3.Items.Add(listViewItem);

            textBox1.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ListViewItem listViewItem = new ListViewItem();
            listViewItem.Text = listBox1.Text;
            listViewItem.SubItems.Add(textBox1.Text);
            listView4.Items.Add(listViewItem);

            textBox1.Clear();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            double sum = 0;
            double[] items = new double[listView1.Items.Count];

            for (int i = 0; i < listView1.Items.Count; i++)
            {
                items[i] = Convert.ToDouble(listView1.Items[i].SubItems[1].Text.ToString());
                sum += items[i];

            }

            label1.Text = Convert.ToString(sum);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            if (comboBox1.SelectedIndex == 0 || comboBox1.Text == "Group-1")
            {
                listBox1.Items.Add("Group-1 Item-1");
                listBox1.Items.Add("Group-1 Item-2");
                listBox1.Items.Add("Group-1 Item-3");
                listBox1.Items.Add("Group-1 Item-4");
                listBox1.Items.Add("Group-1 Item-5");
                listBox1.Items.Add("Group-1 Item-6");
                listBox1.Items.Add("Group-1 Item-7");
                listBox1.Items.Add("Group-1 Item-8");

            }
            else if (comboBox1.SelectedIndex == 1 || comboBox1.Text == "Group-2")
            {
                listBox1.Items.Add("Group-2 Item-1");
                listBox1.Items.Add("Group-2 Item-2");
                listBox1.Items.Add("Group-2 Item-3");
                listBox1.Items.Add("Group-2 Item-4");
                listBox1.Items.Add("Group-2 Item-5");
                listBox1.Items.Add("Group-2 Item-6");
                listBox1.Items.Add("Group-2 Item-7");

            }
            else if (comboBox1.SelectedIndex == 2 || comboBox1.Text == "Group-3")
            {
                listBox1.Items.Add("Group-3 Item-1");
                listBox1.Items.Add("Group-3 Item-2");
                listBox1.Items.Add("Group-3 Item-3");
                listBox1.Items.Add("Group-3 Item-4");
                listBox1.Items.Add("Group-3 Item-5");
                listBox1.Items.Add("Group-3 Item-6");
                listBox1.Items.Add("Group-3 Item-7");
                listBox1.Items.Add("Group-3 Item-8");
                listBox1.Items.Add("Group-3 Item-9");

            }
            else if (comboBox1.SelectedIndex == 3 || comboBox1.Text == "Group-4")
            {
                listBox1.Items.Add("Group-4 Item-1");
                listBox1.Items.Add("Group-4 Item-2");
                listBox1.Items.Add("Group-4 Item-3");
                listBox1.Items.Add("Group-4 Item-4");
                listBox1.Items.Add("Group-4 Item-5");

            }
            else
            {
                listBox1.Items.Add("Item-1");
                listBox1.Items.Add("Item-2");
                listBox1.Items.Add("Item-3");
                listBox1.Items.Add("Item-4");
                listBox1.Items.Add("Item-5");
                listBox1.Items.Add("Item-6");
                listBox1.Items.Add("Item-7");
                listBox1.Items.Add("Item-8");
            }
        }
    }
}

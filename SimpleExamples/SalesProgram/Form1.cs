using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesProgram
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Disk");
            comboBox1.Items.Add("CD");
            comboBox1.Items.Add("Monitor");
            comboBox1.Items.Add("Keyboard");
            comboBox1.Items.Add("Mouse");

            comboBox2.Items.Add("Big Icons");
            comboBox2.Items.Add("Detail");
            comboBox2.Items.Add("Small Icons");
            comboBox2.Items.Add("List");
            comboBox2.Text = "Big Icons";

            listView1.LabelEdit = true;
            listView1.HideSelection = false;

            TextReader textReader = File.OpenText("listview.txt");
            string x = textReader.ReadLine();
            int count = int.Parse(x);
            for (int i = 0; i <= count - 1; i++)
            {
                x = textReader.ReadLine();
                listView1.Items.Add(x);
                x = textReader.ReadLine();
                listView1.Items[i].ImageIndex = int.Parse(x);
                for (int j = 1; j <= listView1.Columns.Count - 1; j++)
                {
                    x = textReader.ReadLine();
                    listView1.Items[i].SubItems.Add(x);
                }
            }
            textReader.Close();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            TextWriter textWriter = File.CreateText("listview.txt");
            string x = listView1.Items.Count.ToString();
            textWriter.WriteLine(x);
            for (int i = 0; i <= listView1.Items.Count - 1; i++)
            {
                x = listView1.Items[i].Text;
                textWriter.WriteLine(x);
                x = listView1.Items[i].ImageIndex.ToString();
                textWriter.WriteLine(x);
                for (int j = 1; j <= listView1.Columns.Count - 1; j++)
                {
                    x = listView1.Items[i].SubItems[j].Text;
                    textWriter.WriteLine(x);
                }
            }
            textWriter.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listView1.Items.Add(textBox1.Text);
            int index = listView1.Items.Count - 1;
            listView1.Items[index].ImageIndex = comboBox1.SelectedIndex;
            listView1.Items[index].SubItems.Add(comboBox1.Text);
            listView1.Items[index].SubItems.Add(textBox2.Text);
            listView1.Items[index].SubItems.Add(textBox3.Text);

            try
            {
                listView1.Items[index].SubItems.Add((int.Parse(textBox2.Text) * int.Parse(textBox3.Text)).ToString());
            }
            catch
            {
                MessageBox.Show("There are errors in the numbers.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
                listView1.SelectedItems[0].Remove();
            else
                MessageBox.Show("Please select the item to be deleted first.");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please select the item to be replaced first.");
            }
            else
            {
                listView1.SelectedItems[0].Text = textBox1.Text;
                listView1.SelectedItems[0].ImageIndex = comboBox1.SelectedIndex;
                listView1.SelectedItems[0].SubItems[1].Text = comboBox1.Text;
                listView1.SelectedItems[0].SubItems[2].Text = textBox2.Text;
                listView1.SelectedItems[0].SubItems[3].Text = textBox3.Text;

                try
                {
                    listView1.SelectedItems[0].SubItems[4].Text = (int.Parse(textBox2.Text) * int.Parse(textBox3.Text)).ToString();
                }
                catch
                {
                    MessageBox.Show("There are errors in the numbers.");
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string search = textBox4.Text;
            for (int i = 0; i <= listView1.Items.Count - 1; i++)
            {
                if (listView1.Items[i].Text == search)
                {
                    listView1.Items[i].Selected = true;
                    return;
                }
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                textBox1.Text = listView1.SelectedItems[0].Text;
                comboBox1.SelectedIndex = listView1.SelectedItems[0].ImageIndex;
                textBox2.Text = listView1.SelectedItems[0].SubItems[2].Text;
                textBox3.Text = listView1.SelectedItems[0].SubItems[3].Text;
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            listView1.View = (View)comboBox2.SelectedIndex;
        }
    }
}

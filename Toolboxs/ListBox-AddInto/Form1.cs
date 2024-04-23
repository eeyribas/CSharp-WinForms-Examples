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

namespace ListBox_AddInto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listBox2.SelectedIndexChanged += new EventHandler(listBox1_SelectedIndexChanged);
            listBox3.SelectedIndexChanged += new EventHandler(listBox1_SelectedIndexChanged);

            try
            {
                TextReader textReader = File.OpenText("info.dat");
                string row;
                while ((row = textReader.ReadLine()) != null)
                {
                    listBox1.Items.Add(row);
                    row = textReader.ReadLine();
                    listBox2.Items.Add(row);
                    row = textReader.ReadLine();
                    listBox3.Items.Add(row);
                }

                textReader.Close();
            }
            catch
            {

            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            TextWriter textWriter = File.CreateText("info.dat");
            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                textWriter.WriteLine(listBox1.Items[i]);
                textWriter.WriteLine(listBox2.Items[i]);
                textWriter.WriteLine(listBox3.Items[i]);
            }
            textWriter.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox1.Text);
            listBox2.Items.Add(textBox2.Text);
            listBox3.Items.Add(textBox3.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int index = listBox1.SelectedIndex;
            if (index < 0)
            {
                MessageBox.Show("First, select the item to be deleted.");
            }
            else
            {
                listBox1.Items.RemoveAt(index);
                listBox2.Items.RemoveAt(index);
                listBox3.Items.RemoveAt(index);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            int index = (sender as ListBox).SelectedIndex;
            listBox1.SelectedIndex = index;
            listBox2.SelectedIndex = index;
            listBox3.SelectedIndex = index;

            int topIndex = (sender as ListBox).TopIndex;
            listBox1.TopIndex = topIndex;
            listBox2.TopIndex = topIndex;
            listBox3.TopIndex = topIndex;

            textBox1.Text = listBox1.Text;
            textBox2.Text = listBox2.Text;
            textBox3.Text = listBox3.Text;
        }
    }
}

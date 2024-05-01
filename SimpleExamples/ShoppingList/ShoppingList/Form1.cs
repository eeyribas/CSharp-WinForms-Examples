using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShoppingList
{
    public partial class Form1 : Form
    {
        private LinkedList<String> linkedList = new LinkedList<String>();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Trim() != "")
            {
                if (linkedList.Contains(textBox1.Text))
                    label2.Text = "On the list : Yes";
                else
                    label2.Text = "On the list : Not";

                textBox1.Focus();
            }
            else
            {
                MessageBox.Show("Do Not Leave the Search Value Blank!!!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if ((sender as Button).Name == "AddListBtn")
            {
                if (TextboxControl())
                {
                    AddList(linkedList);
                    textBox1.Text = "";
                    textBox1.Focus();
                    TransferListBox(linkedList);
                }
                else
                {
                    MessageBox.Show("Do Not Leave the Value to Add Blank!!!");
                }
            }

            if ((sender as Button).Name == "SelectionWithAddButton")
            {
                if (TextboxControl())
                {
                    if (listBox1.SelectedIndex > -1)
                    {
                        if (radioButton1.Checked)
                            linkedList.AddBefore(GetNode(listBox1.Text, linkedList), textBox1.Text);
                        else
                            linkedList.AddAfter(GetNode(listBox1.Text, linkedList), textBox1.Text);

                        textBox1.Text = "";
                        textBox1.Focus();
                        TransferListBox(linkedList);
                    }
                    else
                    {
                        MessageBox.Show("You have not selected a value from the list!!!");
                    }
                }
                else
                {
                    MessageBox.Show("Do Not Leave the Value to Add Blank!!!");
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex > 0)
            {
                linkedList.Remove(listBox1.Text);
                TransferListBox(linkedList);
            }
            else
            {
                MessageBox.Show("You have not selected a value from the list!!!");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            linkedList.Clear();
            TransferListBox(linkedList);
            label3.Text = "There are no orders on the Buy List";
        }

        private void TransferListBox(LinkedList<String> list)
        {
            listBox1.Items.Clear();
            foreach (string str in list)
                listBox1.Items.Add(str);

            label3.Text = "On the To Buy List : " + linkedList.Count + "order is have";
        }

        private void AddList(LinkedList<String> list)
        {
            if (linkedList.Count == 0)
                linkedList.AddFirst(textBox1.Text.Trim());
            else
                linkedList.AddLast(textBox1.Text.Trim());
        }

        private LinkedListNode<string> GetNode(string value, LinkedList<string> list)
        {
            LinkedListNode<string> node = list.Find(value);

            return node;
        }

        private Boolean TextboxControl()
        {
            if (textBox1.Text.Trim() == "")
                return false;
            else
                return true;
        }
    }
}

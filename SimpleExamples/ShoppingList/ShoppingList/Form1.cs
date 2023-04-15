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
        LinkedList<String> shoppingList = new LinkedList<String>();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Trim() != "")
            {
                if (shoppingList.Contains(textBox1.Text))
                {
                    label2.Text = "On the list : Yes";
                }
                else
                {
                    label2.Text = "On the list : Not";
                }

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
                    AddList(shoppingList);
                    textBox1.Text = "";
                    textBox1.Focus();
                    TransferListBox(shoppingList);
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
                        {
                            shoppingList.AddBefore(GetNode(listBox1.Text, shoppingList), textBox1.Text);
                        }
                        else
                        {
                            shoppingList.AddAfter(GetNode(listBox1.Text, shoppingList), textBox1.Text);
                        }
                        textBox1.Text = "";
                        textBox1.Focus();
                        TransferListBox(shoppingList);
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
                shoppingList.Remove(listBox1.Text);
                TransferListBox(shoppingList);
            }
            else
            {
                MessageBox.Show("You have not selected a value from the list!!!");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            shoppingList.Clear();
            TransferListBox(shoppingList);

            label3.Text = "There are no orders on the Buy List";
        }

        private void TransferListBox(LinkedList<String> list)
        {
            listBox1.Items.Clear();
            foreach (string değer in list)
            {
                listBox1.Items.Add(değer);
            }

            label3.Text = "On the To Buy List : " + shoppingList.Count + "order is have";
        }

        private void AddList(LinkedList<String> list)
        {

            if (shoppingList.Count == 0)
            {
                shoppingList.AddFirst(textBox1.Text.Trim());
            }
            else
            {
                shoppingList.AddLast(textBox1.Text.Trim());
            }
        }

        private LinkedListNode<string> GetNode(string value, LinkedList<string> list)
        {
            LinkedListNode<string> node;
            node = list.Find(value);

            return node;
        }

        private Boolean TextboxControl()
        {
            if (textBox1.Text.Trim() == "")
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}

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

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            if (AddTxt.Text.Trim() != "")
            {
                if (shoppingList.Contains(AddTxt.Text))
                {
                    SearchResultLbl.Text = "On the list : Yes";
                }
                else
                {
                    SearchResultLbl.Text = "On the list : Not";
                }

                AddTxt.Focus();
            }
            else
            {
                MessageBox.Show("Do Not Leave the Search Value Blank!!!");
            }
        }

        private void ExtractListBtn_Click(object sender, EventArgs e)
        {
            if (ListLst.SelectedIndex > 0)
            {
                shoppingList.Remove(ListLst.Text);
                TransferListBox(shoppingList);
            }
            else
            {
                MessageBox.Show("You have not selected a value from the list!!!");
            }
        }

        private void TransferListBox(LinkedList<String> list)
        {
            ListLst.Items.Clear();
            foreach (string değer in list)
            {
                ListLst.Items.Add(değer);
            }

            ListLbl.Text = "On the To Buy List : " + shoppingList.Count + "order is have";
        }

        private void ClearListBtn_Click(object sender, EventArgs e)
        {
            shoppingList.Clear();
            TransferListBox(shoppingList);

            ListLbl.Text = "There are no orders on the Buy List";
        }

        private void AddList(LinkedList<String> list)
        {

            if (shoppingList.Count == 0)
            {
                shoppingList.AddFirst(AddTxt.Text.Trim());
            }
            else
            {
                shoppingList.AddLast(AddTxt.Text.Trim());
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
            if (AddTxt.Text.Trim() == "")
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void SelectionWithAddBtn_Click(object sender, EventArgs e)
        {
            if ((sender as Button).Name == "AddListBtn")
            {
                if (TextboxControl())
                {
                    AddList(shoppingList);
                    AddTxt.Text = "";
                    AddTxt.Focus();
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
                    if (ListLst.SelectedIndex > -1)
                    {
                        if (FirstRadioBtn.Checked)
                        {
                            shoppingList.AddBefore(GetNode(ListLst.Text, shoppingList), AddTxt.Text);
                        }
                        else
                        {
                            shoppingList.AddAfter(GetNode(ListLst.Text, shoppingList), AddTxt.Text);
                        }
                        AddTxt.Text = "";
                        AddTxt.Focus();
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
    }
}

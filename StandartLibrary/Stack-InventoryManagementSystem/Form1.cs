using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stack_InventoryManagementSystem
{
    public partial class Form1 : Form
    {
        private Stack<string> stacks;

        public Form1()
        {
            InitializeComponent();

            stacks = new Stack<string>(10);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string productName = Interaction.InputBox("Enter Product Name : ", "Add Product", "", this.Location.X, this.Location.Y);
            if (stacks.Count != 10)
            {
                stacks.Push(productName);
                MessageBox.Show("Add product!");
            }
            else
            {
                MessageBox.Show("Stack is full!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (stacks.Count != 0)
            {
                MessageBox.Show(stacks.Peek() + " product remove!");
                stacks.Pop();
            }
            else
            {
                MessageBox.Show("Stack is empty!");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string productName = Interaction.InputBox("Find Product Name : ", "Find Product", "", this.Location.X, this.Location.Y);
            if (stacks.Contains(productName))
                MessageBox.Show("Product exists!");
            else
                MessageBox.Show("No Product!");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            stacks.Clear();
            MessageBox.Show("Inventory Cleared!");
        }
    }
}

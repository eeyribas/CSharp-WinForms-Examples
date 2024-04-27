using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TreeView_FactoringNumber
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            treeView1.Nodes.Clear();

            try
            {
                treeView1.Nodes.Add(int.Parse(textBox1.Text).ToString());
                MessageBox.Show("You can access the prime factors by double-clicking on the number in the list.");
            }
            catch
            {
                MessageBox.Show("Error!");
            }
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Node.GetNodeCount(true) > 0)
                return;

            for (int i = 2; i <= int.Parse(e.Node.Text) - 1; i++)
            {
                if ((int.Parse(e.Node.Text) % i) == 0)
                    e.Node.Nodes.Add(i.ToString());
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TreeView_CitiesWithCheckBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            treeView1.CheckBoxes = true;
            treeView1.Nodes.Add("Doğu Anadolu");
            treeView1.Nodes[0].Nodes.Add("Erzurum");
            treeView1.Nodes[0].Nodes[0].Nodes.Add("Tortum");
            treeView1.Nodes[0].Nodes[0].Nodes.Add("Oltu");
            treeView1.Nodes[0].Nodes[0].Nodes.Add("Hasankale");
            treeView1.Nodes[0].Nodes.Add("Hakkari");
            treeView1.Nodes[0].Nodes[1].Nodes.Add("Çukurca");
            treeView1.Nodes[0].Nodes[1].Nodes.Add("Yüksekova");
            treeView1.Nodes[0].Nodes[1].Nodes.Add("Şemdinli");
            treeView1.Nodes[0].Nodes.Add("Van");
            treeView1.Nodes.Add("Akdeniz");
            treeView1.Nodes[1].Nodes.Add("Mersin");
            treeView1.Nodes[1].Nodes.Add("Antalya");
            treeView1.Nodes.Add("Karadeniz");
            treeView1.Nodes[2].Nodes.Add("Rize");
            treeView1.Nodes[2].Nodes.Add("Trabzon");
            treeView1.Nodes.Add("Marmara");
            treeView1.Nodes.Add("Orta Anadolu");
            treeView1.Nodes.Add("Güneydoğu Anadolu");
        }

        private void treeView1_AfterCheck(object sender, TreeViewEventArgs e)
        {
            bool state = e.Node.Checked;
            TreeNode treeNode = e.Node.FirstNode;
            while (treeNode != null)
            {
                treeNode.Checked = state;
                treeNode = treeNode.NextNode;
            }
        }
    }
}

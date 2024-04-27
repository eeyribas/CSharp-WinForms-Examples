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

namespace TreeView_DriverLists
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] drivers = Directory.GetLogicalDrives();
            for (int i = 0; i <= drivers.GetUpperBound(0); i++)
                treeView1.Nodes.Add(drivers[i]);
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            string[] files = Directory.GetDirectories(e.Node.FullPath + "\\");
            string[] k;
            if (e.Node.GetNodeCount(true) == 0)
            {
                for (int i = 0; i <= files.GetUpperBound(0); i++)
                {
                    k = files[i].Split('\\');
                    e.Node.Nodes.Add(k[k.GetUpperBound(0)]);
                }
            }

            listBox1.Items.Clear();
            string[] directories = Directory.GetFiles(e.Node.FullPath);
            for (int i = 0; i <= directories.GetUpperBound(0); i++)
            {
                k = directories[i].Split('\\');
                listBox1.Items.Add(k[k.GetUpperBound(0)]);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile(treeView1.SelectedNode.FullPath + "\\" + listBox1.SelectedItem);
        }
    }
}

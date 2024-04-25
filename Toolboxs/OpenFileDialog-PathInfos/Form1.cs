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

namespace OpenFileDialog_PathInfos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string path = openFileDialog1.FileName;
                listBox1.Items.Add("Directory Name:" + Path.GetDirectoryName(path));
                listBox1.Items.Add("File Name:" + Path.GetFileName(path));
                listBox1.Items.Add("Extension:" + Path.GetExtension(path));
                listBox1.Items.Add("File Name Without Extension:" + Path.GetFileNameWithoutExtension(path));
                listBox1.Items.Add("Full Path:" + Path.GetFullPath(path));
                listBox1.Items.Add("Path Root:" + Path.GetPathRoot(path));
                listBox1.Items.Add("Is Path Rooted?:" + Path.IsPathRooted(path));
                listBox1.Items.Add("Has Extension?:" + Path.HasExtension(path));
            }
        }
    }
}

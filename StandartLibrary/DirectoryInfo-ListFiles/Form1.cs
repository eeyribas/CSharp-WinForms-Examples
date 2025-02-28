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

namespace DirectoryInfo_ListFiles
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listBox1.DrawMode = DrawMode.OwnerDrawFixed;
            listBox1.ItemHeight = 18;
            textBox1.Text = "c:\\";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Lists(textBox1.Text);
        }

        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex >= 0)
            {
                FileSystemInfo fileSystemInfo = (FileSystemInfo)listBox1.SelectedItem;
                if ((fileSystemInfo.Attributes & FileAttributes.Directory) > 0)
                {
                    Lists(fileSystemInfo.FullName);
                }
                else
                {
                    MessageBox.Show("Directory File : " + fileSystemInfo.FullName + "\r\n" + 
                                    "Created Date : " + fileSystemInfo.CreationTime + "\r\n" +
                                    "Changed Date :" + fileSystemInfo.LastWriteTime + "\r\n" +
                                    "Last Date :" + fileSystemInfo.LastAccessTime);
                }
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex >= 0)
                label2.Text = ((FileSystemInfo)listBox1.SelectedItem).FullName;
        }

        private void listBox1_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index < 0)
                return;

            e.DrawBackground();
            e.DrawFocusRectangle();

            FileSystemInfo fileSystemInfo = (FileSystemInfo)listBox1.Items[e.Index];
            if ((fileSystemInfo.Attributes & System.IO.FileAttributes.Directory) > 0)
                imageList1.Draw(e.Graphics, e.Bounds.X, e.Bounds.Y, 0);
            else
                imageList1.Draw(e.Graphics, e.Bounds.X, e.Bounds.Y, 1);

            e.Graphics.DrawString(fileSystemInfo.Name, listBox1.Font, Brushes.Black, 20, e.Bounds.Y);
        }

        private void Lists(string path)
        {
            DirectoryInfo directoryInfo = new DirectoryInfo(path);
            if (directoryInfo.Exists == true)
            {
                FileSystemInfo[] fileSystemInfos = new DirectoryInfo(path).GetFileSystemInfos();
                listBox1.Items.Clear();
                listBox1.Items.AddRange(fileSystemInfos);
            }
            else
            {
                MessageBox.Show("This folder cannot be found.");
            }
        }
    }
}

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

namespace MonitorDiskDrives
{
    public partial class Form1 : Form
    {
        private FileSystemWatcher[] fileSystemWatchers;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] drivers = Directory.GetLogicalDrives();
            checkedListBox1.Items.AddRange(drivers);
            fileSystemWatchers = new FileSystemWatcher[drivers.Length];

            for(int i = 0; i <= fileSystemWatchers.Length - 1; i++)
            {
                fileSystemWatchers[i] = new FileSystemWatcher();
                try
                {
                    fileSystemWatchers[i].Path = drivers[i];
                }
                catch
                {
                }

                fileSystemWatchers[i].Filter = "*.*";
                fileSystemWatchers[i].NotifyFilter = NotifyFilters.Attributes | NotifyFilters.CreationTime | NotifyFilters.DirectoryName |
                                                     NotifyFilters.FileName | NotifyFilters.LastAccess | NotifyFilters.LastWrite |
                                                     NotifyFilters.Security | NotifyFilters.Size;
                fileSystemWatchers[i].IncludeSubdirectories = true;
                fileSystemWatchers[i].Changed += new FileSystemEventHandler(Change);
                fileSystemWatchers[i].Created += new FileSystemEventHandler(New);
                fileSystemWatchers[i].Deleted += new FileSystemEventHandler(Delete);
                fileSystemWatchers[i].Renamed += new RenamedEventHandler(ChangeName);
            }
  
            listView1.Columns.Add("Driver", -2, HorizontalAlignment.Left);
            listView1.Columns.Add("Process Type", -2, HorizontalAlignment.Left);
            listView1.Columns.Add("File/Directory Name", -2, HorizontalAlignment.Left);
            listView1.Columns.Add("Details", -2, HorizontalAlignment.Left);
            listView1.View = View.Details;
            listView1.Sorting = SortOrder.Ascending;
            listView1.Sorting = SortOrder.None;
        }

        private void checkedListBox1_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if(e.NewValue == CheckState.Checked)
                fileSystemWatchers[e.Index].EnableRaisingEvents = true;
            else
                fileSystemWatchers[e.Index].EnableRaisingEvents = false;
        }

        private void Change(object sender, FileSystemEventArgs e)
        {
            ListViewItem listViewItem = listView1.Items.Add((sender as FileSystemWatcher).Path);
            listViewItem.SubItems.Add("Change");
            listViewItem.SubItems.Add(e.FullPath);
            listViewItem.SubItems.Add(e.ChangeType.ToString());
        }

        private void New(object sender, FileSystemEventArgs e)
        {
            ListViewItem listViewItem = listView1.Items.Add((sender as FileSystemWatcher).Path);
            listViewItem.SubItems.Add("New");
            listViewItem.SubItems.Add(e.FullPath);
            listViewItem.SubItems.Add(e.ChangeType.ToString());
        }

        private void Delete(object sender, FileSystemEventArgs e)
        {
            ListViewItem listViewItem = listView1.Items.Add((sender as FileSystemWatcher).Path);
            listViewItem.SubItems.Add("Delete");
            listViewItem.SubItems.Add(e.FullPath);
            listViewItem.SubItems.Add(e.ChangeType.ToString());
        }

        private void ChangeName(object sender, RenamedEventArgs e)
        {
            ListViewItem listViewItem = listView1.Items.Add((sender as FileSystemWatcher).Path);
            listViewItem.SubItems.Add("Change Name");
            listViewItem.SubItems.Add(e.FullPath);
            listViewItem.SubItems.Add(e.OldFullPath);
        }
    }
}

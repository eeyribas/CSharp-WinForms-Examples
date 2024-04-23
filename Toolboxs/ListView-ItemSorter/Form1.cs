using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListView_ItemSorter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listView1.Columns.Add("Full Name", -2, HorizontalAlignment.Left);
            listView1.Columns.Add("Title", -2, HorizontalAlignment.Left);
            listView1.Columns.Add("Registration Number", -2, HorizontalAlignment.Right);
            listView1.Columns.Add("Date of Birth", -2, HorizontalAlignment.Left);

            listView1.Items.Add("Ali");
            listView1.Items[0].SubItems.Add("Lecturer");
            listView1.Items[0].SubItems.Add("1856");
            listView1.Items[0].SubItems.Add("5/5/1970");
            listView1.Items.Add("Jack");
            listView1.Items[1].SubItems.Add("Specialist");
            listView1.Items[1].SubItems.Add("1210");
            listView1.Items[1].SubItems.Add("5/12/1960");
            listView1.Items.Add("July");
            listView1.Items[2].SubItems.Add("Prof Dr.");
            listView1.Items[2].SubItems.Add("4578");
            listView1.Items[2].SubItems.Add("1/1/1950");
            listView1.Items.Add("Jane");
            listView1.Items[3].SubItems.Add("Ass. Professor");
            listView1.Items[3].SubItems.Add("7845");
            listView1.Items[3].SubItems.Add("4/6/1968");
            listView1.Items.Add("Ayşe");
            listView1.Items[4].SubItems.Add("Dr.");
            listView1.Items[4].SubItems.Add("7888");
            listView1.Items[4].SubItems.Add("14/2/1970");
            listView1.View = View.Details;
            listView1.Sorting = SortOrder.Ascending;
        }

        private void listView1_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            switch (e.Column)
            {
                case 0:
                    listView1.ListViewItemSorter = new SortAlphabetically();
                    break;
                case 1:
                    listView1.ListViewItemSorter = new SortByTitle();
                    break;
                case 2:
                    listView1.ListViewItemSorter = new SortNumbers();
                    break;
                case 3:
                    listView1.ListViewItemSorter = new SortDate();
                    break;
            }
        }
    }
}

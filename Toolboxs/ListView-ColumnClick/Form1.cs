using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListView_ColumnClick
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
            listView1.Columns.Add("Job", -2, HorizontalAlignment.Left);
            listView1.Columns.Add("Salary", -2, HorizontalAlignment.Right);

            listView1.Items.Add("Ali");
            listView1.Items[0].SubItems.Add("IT");
            listView1.Items[0].SubItems.Add("500");
            listView1.Items.Add("Jack");
            listView1.Items[1].SubItems.Add("Account");
            listView1.Items[1].SubItems.Add("600");
            listView1.Items.Add("Micheal");
            listView1.Items[2].SubItems.Add("Engineering");
            listView1.Items[2].SubItems.Add("800");
            listView1.Items.Add("July");
            listView1.Items[3].SubItems.Add("Doctor");
            listView1.Items[3].SubItems.Add("500");
            listView1.View = View.Details;
            listView1.Sorting = SortOrder.Ascending;
        }

        private void listView1_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            if (listView1.Sorting == SortOrder.Ascending)
                listView1.Sorting = SortOrder.Descending;
            else
                listView1.Sorting = SortOrder.Ascending;
        }
    }
}

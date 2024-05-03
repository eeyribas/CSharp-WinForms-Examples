using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListView_ItemActivate
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listView1.Activation = ItemActivation.OneClick;

            listView1.Columns.Add("Full Name", -2, HorizontalAlignment.Left);
            listView1.Columns.Add("E-mail", -2, HorizontalAlignment.Left);

            listView1.Items.Add("Jack");
            listView1.Items[0].SubItems.Add("jack@gmail.com");

            listView1.Items.Add("Mehmet");
            listView1.Items[1].SubItems.Add("mehmet@gmail.com");

            listView1.Items.Add("Jane");
            listView1.Items[2].SubItems.Add("jane@gmail.com");

            listView1.View = View.Details;
            listView1.Sorting = SortOrder.Ascending;
        }

        private void listView1_ItemActivate(object sender, EventArgs e)
        {
            string email = "mailto:" + listView1.SelectedItems[0].SubItems[1].Text;
            Process.Start(email);
        }
    }
}

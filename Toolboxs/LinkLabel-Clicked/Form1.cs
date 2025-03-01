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

namespace LinkLabel_Clicked
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            linkLabel1.Text = "To enter our website, click here.\r\n" + "To send an email, click here.\r\n" +
                              "To run the calculator, click here.\r\n" + "To view the contents of the hard disk, click here.";
            linkLabel1.Links.Add(22, 5, "http://www.google.com");
            linkLabel1.Links.Add(53, 5, "example@hotmail.com");
            linkLabel1.Links.Add(89, 5, "calc.exe");
            linkLabel1.Links.Add(141, 5, "c:\\");

            linkLabel1.LinkColor = Color.Blue;
            linkLabel1.VisitedLinkColor = Color.Red;
            linkLabel1.ActiveLinkColor = Color.Brown;
            linkLabel1.LinkBehavior = LinkBehavior.HoverUnderline;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkLabel1.Links[linkLabel1.Links.IndexOf(e.Link)].Visited = true;
            Process.Start(e.Link.LinkData.ToString());
        }
    }
}

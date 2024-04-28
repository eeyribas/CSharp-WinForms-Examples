using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrintDocument_NewPage
{
    public partial class Form1 : Form
    {
        private int pageNo = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

        private void printDocument1_BeginPrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            this.Text = "Printing process started.";
        }

        private void printDocument1_EndPrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            this.Text = "Printing process completed.";
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            pageNo += 1;
            e.Graphics.DrawString("Page " + pageNo.ToString(), new Font("Tahoma", 50, FontStyle.Bold),
                                  Brushes.Black, 100, 100);
            if (pageNo == 3)
            {
                e.HasMorePages = false;
                pageNo = 0;
            }
            else
            {
                e.HasMorePages = true;
            }
        }
    }
}

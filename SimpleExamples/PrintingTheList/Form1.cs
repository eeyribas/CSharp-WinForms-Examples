using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrintingTheList
{
    public partial class Form1 : Form
    {
        private int elementNo = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox1.Text);
            listBox2.Items.Add(textBox2.Text);
            listBox3.Items.Add(textBox3.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            printDocument1.Print();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            pageSetupDialog1.PageSettings = printDocument1.DefaultPageSettings;
            if (pageSetupDialog1.ShowDialog() == DialogResult.OK)
                printDocument1.DefaultPageSettings = pageSetupDialog1.PageSettings;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string[] names = {"Ali", "Veli", "Ahmet", "Mehmet", "Ayşe", "Fatma", "Mustafa", "Hasan", "Hüseyin", "Muhammet"};
            Random random = new Random();
            for (int i = 1; i <= 100; i++)
            {
                listBox1.Items.Add(i.ToString() + " " + names[random.Next(9)]);
                int value = random.Next(100);
                listBox2.Items.Add(value);

                if (value >= 50)
                    listBox3.Items.Add("Pass");
                else
                    listBox3.Items.Add("Fail");
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (int.Parse(textBox2.Text) >= 50)
                textBox3.Text = "Pass";
            else
                textBox3.Text = "Fail";
        }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            PageSettings pageSettings = printDocument1.DefaultPageSettings;
            int pageWidth = pageSettings.PaperSize.Width - pageSettings.Margins.Left - pageSettings.Margins.Right;
            int x = pageSettings.Margins.Left + 2;
            int y = pageSettings.Margins.Top;

            StringFormat alignMiddle = new StringFormat();
            alignMiddle.Alignment = StringAlignment.Center;
            StringFormat alignRight = new StringFormat();
            alignRight.Alignment = StringAlignment.Far;

            Font mainFont = new Font("Tahoma", 20, FontStyle.Regular);
            int rowHeight = (int)e.Graphics.MeasureString("x", mainFont).Height;
            e.Graphics.DrawString(textBox4.Text, mainFont, new SolidBrush(Color.Red),
                                  pageSettings.PaperSize.Width / 2, y, alignMiddle);
            y += rowHeight;
            int tableInit = y;
            Font headerFont = new Font("Tahoma", 12, FontStyle.Bold);
            rowHeight = (int)e.Graphics.MeasureString("x", headerFont).Height;

            e.Graphics.DrawLine(new Pen(Color.Blue, 2), pageSettings.Margins.Left, y,
                                pageSettings.PaperSize.Width - pageSettings.Margins.Right, y);
            e.Graphics.DrawString("Name", headerFont, new SolidBrush(Color.Red), x, y);
            e.Graphics.DrawString("Note", headerFont, new SolidBrush(Color.Red), x + pageWidth / 3, y);
            e.Graphics.DrawString("Info", headerFont, new SolidBrush(Color.Red), x + 2 * pageWidth / 3, y);
            y += rowHeight + 2;
            e.Graphics.DrawLine(new Pen(Color.Blue, 2), pageSettings.Margins.Left, y,
                                pageSettings.PaperSize.Width - pageSettings.Margins.Right, y);

            Font listFont = new Font("Tahoma", 12, FontStyle.Regular);
            rowHeight = (int)e.Graphics.MeasureString("x", listFont).Height;

            while (elementNo < listBox1.Items.Count)
            {
                e.Graphics.DrawString(listBox1.Items[elementNo].ToString(), listFont, new SolidBrush(Color.Red), x, y);
                e.Graphics.DrawString(listBox2.Items[elementNo].ToString(), listFont, new SolidBrush(Color.Red),
                                      x + pageWidth / 3 + 50, y, alignRight);
                e.Graphics.DrawString(listBox3.Items[elementNo].ToString(), listFont, new SolidBrush(Color.Red),
                                      x + 2 * pageWidth / 3, y);
                y += rowHeight + 2;
                e.Graphics.DrawLine(new Pen(Color.Blue, 2), pageSettings.Margins.Left, y, 
                                    pageSettings.PaperSize.Width - pageSettings.Margins.Right, y);
                elementNo += 1;

                if ((y + rowHeight) > (pageSettings.PaperSize.Height - pageSettings.Margins.Bottom))
                {
                    e.HasMorePages = true;
                    break;
                }
            }

            if (elementNo >= listBox1.Items.Count)
            {
                e.HasMorePages = false;
                elementNo = 0;
            }

            e.Graphics.DrawLine(new Pen(Color.Blue, 2), pageSettings.Margins.Left, tableInit, pageSettings.Margins.Left, y);
            e.Graphics.DrawLine(new Pen(Color.Blue, 2), pageSettings.Margins.Left + pageWidth / 3 - 2, tableInit,
                                pageSettings.Margins.Left + pageWidth / 3 - 2, y);
            e.Graphics.DrawLine(new Pen(Color.Blue, 2), pageSettings.Margins.Left + 2 * pageWidth / 3 - 2, tableInit,
                                pageSettings.Margins.Left + 2 * pageWidth / 3 - 2, y);
            e.Graphics.DrawLine(new Pen(Color.Blue, 2), pageSettings.PaperSize.Width - pageSettings.Margins.Right, tableInit,
                                pageSettings.PaperSize.Width - pageSettings.Margins.Right, y);
        }
    }
}

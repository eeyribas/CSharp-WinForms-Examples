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

namespace PrintDocument_TextAndImage
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            printDocument1.Print();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pageSetupDialog1.PageSettings = printDocument1.DefaultPageSettings;
            if (pageSetupDialog1.ShowDialog() == DialogResult.OK)
                printDocument1.DefaultPageSettings = pageSetupDialog1.PageSettings;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Image Files|" + "*.bmp;*.jpg;*.gif;*.wmf;*.tif;*.png";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
                pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
        }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            Font labelFont = new Font("Tahoma", 12, FontStyle.Bold);
            Font textFont = new Font("Tahoma", 12, FontStyle.Regular);
            Font headerFont = new Font("Tahoma", 20, FontStyle.Bold);
 
            PageSettings pageSettings = printDocument1.DefaultPageSettings;
            float x1 = pageSettings.Margins.Left;
            string text = "No : ";
            float x2 = x1 + e.Graphics.MeasureString(text, labelFont).Width;
            float x3 = x2 + 200;
            float y = pageSettings.Margins.Top;
            text = "Infos : ";

            e.Graphics.DrawString(text, headerFont, Brushes.Black, x1, y);
            y += e.Graphics.MeasureString(text, headerFont).Height;
            e.Graphics.DrawLine(new Pen(Color.Blue, 2), x1, y, pageSettings.PaperSize.Width - pageSettings.Margins.Left, y);
            y += 2;
            text = "Name : ";
            e.Graphics.DrawString(text, labelFont, Brushes.Black, x1, y);
            text = textBox1.Text;
            e.Graphics.DrawString(text, textFont, Brushes.Black, x2, y);
            text = "Photo : ";
            e.Graphics.DrawString(text, labelFont, Brushes.Black, x3, y);
            y += e.Graphics.MeasureString(text, labelFont).Height;
            text = "No : ";
            e.Graphics.DrawString(text, labelFont, Brushes.Black, x1, y);
            text = textBox2.Text;
            e.Graphics.DrawString(text, textFont, Brushes.Black, x2, y);

            float y2 = 0;

            try
            {
                e.Graphics.DrawImage(pictureBox1.Image, x3, y, 150, 150);
                y2 = y + 150;
            }
            catch
            {
                text = "Image could not be printed.";
                e.Graphics.DrawString(text, textFont, Brushes.Blue, x3, y);
            }

            y += e.Graphics.MeasureString(text, labelFont).Height;
            text = "Address : ";
            e.Graphics.DrawString(text, labelFont, Brushes.Black, x1, y);
            text = textBox3.Text;
            e.Graphics.DrawString(text, textFont, Brushes.Black, new RectangleF(x2, y, x3 - x2, pageSettings.PaperSize.Height));
            y += e.Graphics.MeasureString(text, labelFont).Height;

            if (y2 > y)
                e.Graphics.DrawLine(new Pen(Color.Blue, 2), x1, y2, pageSettings.PaperSize.Width - pageSettings.Margins.Left, y2);
            else
                e.Graphics.DrawLine(new Pen(Color.Blue, 2), x1, y, pageSettings.PaperSize.Width - pageSettings.Margins.Left, y);
        }
    }
}

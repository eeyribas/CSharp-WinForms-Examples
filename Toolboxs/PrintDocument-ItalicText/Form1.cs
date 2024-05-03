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

namespace PrintDocument_ItalicText
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
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            Font font = new Font("Tahoma", 12, FontStyle.Bold);
            string text = textBox1.Text;
            e.Graphics.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
            PageSettings pageSettings = printDocument1.DefaultPageSettings;

            e.Graphics.TranslateTransform(pageSettings.PaperSize.Width / 2, pageSettings.PaperSize.Height / 2);
            e.Graphics.RotateTransform(-45);
            e.Graphics.DrawString(text, font, Brushes.Red, 0, 0);
            e.Graphics.RotateTransform(45);
            e.Graphics.DrawString(text, font, Brushes.Green, 0, 0);
            e.Graphics.RotateTransform(90);
            e.Graphics.DrawString(text, font, Brushes.Blue, 0, 0);
            e.Graphics.RotateTransform(135);
            e.Graphics.DrawString(text, font, Brushes.Brown, 0, 0);
        }
    }
}

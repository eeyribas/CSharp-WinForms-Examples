using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrintDocument_LongTexts
{
    public partial class Form1 : Form
    {
        private int lastLetter = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Text Files|*.TXT|" + "All Files|*.*";
            openFileDialog1.FilterIndex = 1;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = "";
                TextReader textReader = File.OpenText(openFileDialog1.FileName);
                string row;
                while ((row = textReader.ReadLine()) != null)
                    textBox1.Text += row + "\r\n";
                textReader.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            printDocument1.Print();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pageSetupDialog1.PageSettings = printDocument1.DefaultPageSettings;
            if (pageSetupDialog1.ShowDialog() == DialogResult.OK)
                printDocument1.DefaultPageSettings = pageSetupDialog1.PageSettings;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog() == DialogResult.OK)
                textBox1.Font = fontDialog1.Font;
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Font font = textBox1.Font;
            int rowCount, letterCount;

            PageSettings pageSettings = printDocument1.DefaultPageSettings;
            int height = pageSettings.PaperSize.Height - pageSettings.Margins.Top - pageSettings.Margins.Bottom;
            int width = pageSettings.PaperSize.Width - pageSettings.Margins.Left - pageSettings.Margins.Right;
            StringFormat stringFormat = new StringFormat(StringFormatFlags.LineLimit);
            RectangleF rectangleF = new RectangleF(pageSettings.Margins.Left, pageSettings.Margins.Top, width, height);
            
            e.Graphics.MeasureString(textBox1.Text.Substring(lastLetter), font, new SizeF(width, height), stringFormat, out letterCount, out rowCount);
            string text = textBox1.Text.Substring(lastLetter, letterCount);
            e.Graphics.DrawString(text, font, new SolidBrush(Color.Black), rectangleF, stringFormat);
            lastLetter += letterCount;

            if (lastLetter < textBox1.Text.Length)
            {
                e.HasMorePages = true;
            }
            else
            {
                e.HasMorePages = false;
                lastLetter = 0;
            }
        }
    }
}

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

namespace PrintDocument_MultiplePages
{
    public partial class Form1 : Form
    {
        private int number = 1;
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

        private void button3_Click(object sender, EventArgs e)
        {
            pageSetupDialog1.PageSettings = printDocument1.DefaultPageSettings;
            if (pageSetupDialog1.ShowDialog() == DialogResult.OK)
                printDocument1.DefaultPageSettings = pageSetupDialog1.PageSettings;
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Font font = new Font("Tahoma", 12, FontStyle.Regular);
            PageSettings pageSettings = printDocument1.DefaultPageSettings;

            int pageHeight = pageSettings.PaperSize.Height - pageSettings.Margins.Top - pageSettings.Margins.Bottom;
            int lineHeight  = (int)e.Graphics.MeasureString("1", font).Height;
            int maxLine = pageHeight / lineHeight;
            int i, lineNo = 0;
            for (i = number; i <= number + maxLine - 1; i++)
            {
                if (i > 1000)
                {
                    e.HasMorePages = false;
                    number = 1;
                    return;
                }

                e.Graphics.DrawString(i.ToString() + ". line", font, new SolidBrush(Color.Black),
                printDocument1.DefaultPageSettings.Margins.Left, printDocument1.DefaultPageSettings.Margins.Top + lineNo * lineHeight);
                lineNo += 1;
            }

            number = i;
            if (i < 1000)
                e.HasMorePages = true;
        }
    }
}

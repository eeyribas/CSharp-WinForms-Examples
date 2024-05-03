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

namespace PrintPreview_Text
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.FillEllipse(new SolidBrush(Color.Red), 10, 10, 400, 60);
            e.Graphics.DrawString("Visual C# .NET", new Font("Tahoma", 24, FontStyle.Regular), new SolidBrush(Color.White), 75, 25);
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
            e.Graphics.FillEllipse(new SolidBrush(Color.Red), 10, 10, 400, 60);
            e.Graphics.DrawString("Visual C# .NET", new Font("Tahoma", 24, FontStyle.Regular), new SolidBrush(Color.White), 75, 25);
        }
    }
}

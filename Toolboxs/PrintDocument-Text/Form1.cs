using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrintDocument_Text
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
            e.Graphics.DrawString("C# .NET", new Font("Tahoma", 24, FontStyle.Regular), new SolidBrush(Color.White), 75, 25);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            printDocument1.Print();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.FillEllipse(new SolidBrush(Color.Red), 10, 10, 400, 60);
            e.Graphics.DrawString("C# .NET", new Font("Tahoma", 24, FontStyle.Regular), new SolidBrush(Color.White), 75, 25);
        }
    }
}

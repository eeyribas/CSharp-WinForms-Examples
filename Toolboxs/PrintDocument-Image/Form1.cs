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

namespace PrintDocument_Image
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Image Files|" + "*.bmp;*.jpg;*.gif;*.wmf;*.tif;*.png";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
                pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
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

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            PageSettings pageSettings = printDocument1.DefaultPageSettings;
            int x = pageSettings.Margins.Left;
            int y = pageSettings.Margins.Top;
            int weight = pictureBox1.Image.Width;
            int height = pictureBox1.Image.Height;

            if (checkBox1.Checked)
            {
                weight = pageSettings.PaperSize.Width - pageSettings.Margins.Left - pageSettings.Margins.Right;
                height = pageSettings.PaperSize.Height - pageSettings.Margins.Top - pageSettings.Margins.Bottom;
            }

            if (checkBox2.Checked)
            {
                x = pageSettings.Margins.Left + ((pageSettings.PaperSize.Width - pageSettings.Margins.Left - pageSettings.Margins.Right) -
                    pictureBox1.Image.Width) / 2;
                y = pageSettings.Margins.Top + ((pageSettings.PaperSize.Height - pageSettings.Margins.Top - pageSettings.Margins.Bottom) -
                    pictureBox1.Image.Height) / 2;
            }

            e.Graphics.DrawImage(pictureBox1.Image, x, y, weight, height);
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DrawOnTheImage
{
    public partial class Form1 : Form
    {
        bool selection;
        string[] images = new string[500];

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            openFileDialog1.Title = "Select the folder with the images to be displayed.";
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            if (selection == false)
                e.Graphics.DrawString("Double-click the form to select an image",
                new Font("Tahoma", 16, FontStyle.Regular), new SolidBrush(Color.Black), 0, 0);
            else
            {
                e.Graphics.Clear(this.BackColor);
                FileInfo fileInfo = new FileInfo(openFileDialog1.FileName);
                DirectoryInfo directoryInfo = new DirectoryInfo(fileInfo.DirectoryName);
                FileInfo[] fileInfos;

                string[] paths = { "*.jpg", "*.bmp", "*.gif", "*.wmf" };
                int k = 0, row = 0, column = 0;
                int maxColumn = this.ClientSize.Width / 50;

                for (int u = 0; u <= paths.Length - 1; u++)
                {
                    fileInfos = directoryInfo.GetFiles(paths[u]);
                    for (int i = 0; i <= fileInfos.Length - 1; i++)
                    {
                        if (column == maxColumn)
                        {
                            column = 0;
                            row += 1;
                        }

                        images[k] = fileInfos[i].FullName;
                        try
                        {
                            e.Graphics.DrawImage(Image.FromFile(fileInfos[i].FullName),new Rectangle(column * 50, row * 50, 45, 45));
                        }
                        catch
                        {
                            e.Graphics.DrawString("ERROR", new Font("Tahoma", 8, FontStyle.Regular),
                            new SolidBrush(Color.Red), column * 50, row * 50);
                        }
                        column += 1;
                        k += 1;
                    }
                }
            }
        }

        private void Form1_DoubleClick(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                selection = true;
                this.Invalidate();
            }
        }
    }
}

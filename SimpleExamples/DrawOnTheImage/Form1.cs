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
        private bool selection;

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
            string[] imageStrs = new string[500];

            if (selection == true)
            {
                e.Graphics.Clear(this.BackColor);
                FileInfo fileInfo = new FileInfo(openFileDialog1.FileName);
                DirectoryInfo directoryInfo = new DirectoryInfo(fileInfo.DirectoryName);

                string[] paths = { "*.jpg", "*.bmp", "*.gif", "*.wmf" };
                int k = 0, row = 0, column = 0;
                int maxColumn = this.ClientSize.Width / 50;

                for (int i = 0; i <= paths.Length - 1; i++)
                {
                    FileInfo[] fileInfos = directoryInfo.GetFiles(paths[i]);
                    for (int j = 0; j <= fileInfos.Length - 1; j++)
                    {
                        if (column == maxColumn)
                        {
                            column = 0;
                            row += 1;
                        }
                        imageStrs[k] = fileInfos[j].FullName;

                        try
                        {
                            e.Graphics.DrawImage(Image.FromFile(fileInfos[j].FullName), new Rectangle(column * 50, row * 50, 45, 45));
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
            else
            {
                e.Graphics.DrawString("Double-click the form to select an image", new Font("Tahoma", 16, FontStyle.Regular),
                                      new SolidBrush(Color.Black), 0, 0);
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

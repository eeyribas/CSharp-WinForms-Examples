using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListBox_MeasureItem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listBox1.DrawMode = DrawMode.OwnerDrawVariable;
            FontFamily[] fontFamily = FontFamily.Families;
            for (int i = 0; i <= fontFamily.GetUpperBound(0); i++)
                listBox1.Items.Add(fontFamily[i].Name);
        }

        private void listBox1_MeasureItem(object sender, MeasureItemEventArgs e)
        {
            try
            {
                string name = listBox1.Items[e.Index].ToString();
                Font font = new Font(name, 12, FontStyle.Regular);
                e.ItemHeight = font.Height;
            }
            catch
            {
            }
        }

        private void listBox1_DrawItem(object sender, DrawItemEventArgs e)
        {
            try
            {
                e.DrawBackground();
                e.DrawFocusRectangle();

                string name = listBox1.Items[e.Index].ToString();
                e.Graphics.DrawString(name, new Font(name, 12, FontStyle.Regular),
                                      new SolidBrush(Color.Black), e.Bounds.Left, e.Bounds.Top);
            }
            catch
            {
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                textBox1.Font = new Font(listBox1.SelectedItem.ToString(), 14, FontStyle.Regular);
            }
            catch
            {
                MessageBox.Show("This font cannot be displayed.");
            }
        }
    }
}

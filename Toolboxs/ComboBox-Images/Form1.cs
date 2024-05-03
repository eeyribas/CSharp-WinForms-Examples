using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComboBox_Images
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] countries = {"Türkiye", "Denmark", "Germany", "Austria", "Japan", "Italy"};
            comboBox1.DrawMode = DrawMode.OwnerDrawVariable;
            comboBox1.Items.AddRange(countries);
        }

        private void comboBox1_DrawItem(object sender, DrawItemEventArgs e)
        {
            string str = comboBox1.Items[e.Index].ToString();
            e.DrawBackground();
            e.DrawFocusRectangle();
            imageList1.Draw(e.Graphics, e.Bounds.Left, e.Bounds.Top, e.Index);
            e.Graphics.DrawString(str, new Font("Tahoma", 10, FontStyle.Bold), new SolidBrush(Color.Black), e.Bounds.Left + 35, 
                                  e.Bounds.Top + 8);
        }

        private void comboBox1_MeasureItem(object sender, MeasureItemEventArgs e)
        {
            e.ItemHeight = 32;
        }
    }
}

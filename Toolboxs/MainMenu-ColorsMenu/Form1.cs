using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainMenu_ColorsMenu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            menuItem2.Click += new EventHandler(menuItem1_Click);
            menuItem3.Click += new EventHandler(menuItem1_Click);
            menuItem4.Click += new EventHandler(menuItem1_Click);
            menuItem5.Click += new EventHandler(menuItem1_Click);
            menuItem6.Click += new EventHandler(menuItem1_Click);

            menuItem2.DrawItem += new DrawItemEventHandler(menuItem1_DrawItem);
            menuItem3.DrawItem += new DrawItemEventHandler(menuItem1_DrawItem);
            menuItem4.DrawItem += new DrawItemEventHandler(menuItem1_DrawItem);
            menuItem5.DrawItem += new DrawItemEventHandler(menuItem1_DrawItem);
            menuItem6.DrawItem += new DrawItemEventHandler(menuItem1_DrawItem);

            menuItem2.MeasureItem += new MeasureItemEventHandler(menuItem1_MeasureItem);
            menuItem3.MeasureItem += new MeasureItemEventHandler(menuItem1_MeasureItem);
            menuItem4.MeasureItem += new MeasureItemEventHandler(menuItem1_MeasureItem);
            menuItem5.MeasureItem += new MeasureItemEventHandler(menuItem1_MeasureItem);
            menuItem6.MeasureItem += new MeasureItemEventHandler(menuItem1_MeasureItem);
        }

        private void menuItem1_Click(object sender, EventArgs e)
        {
            Color color = FindColor((sender as MenuItem).Text);
            this.BackColor = color;
        }

        private void menuItem1_DrawItem(object sender, DrawItemEventArgs e)
        {
            Color color = FindColor((sender as MenuItem).Text);
            e.DrawBackground();
            e.Graphics.DrawString((sender as MenuItem).Text, this.Font, new SolidBrush(color),
                                   e.Bounds.Left, e.Bounds.Top);
            e.DrawFocusRectangle();
        }

        private void menuItem1_MeasureItem(object sender, MeasureItemEventArgs e)
        {
            e.ItemHeight = this.Font.Height;
            e.ItemWidth = 100;
        }

        private Color FindColor(string colorName)
        {
            switch (colorName)
            {
                case "Red":
                    return Color.Red;
                case "Blue":
                    return Color.Blue;
                case "Green":
                    return Color.Green;
                case "Yellow":
                    return Color.Yellow;
                case "Brown":
                    return Color.Brown;
                case "Black":
                    return Color.Black;
                default:
                    return Color.Black;
            }
        }
    }
}

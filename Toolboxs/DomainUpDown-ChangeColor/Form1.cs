using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DomainUpDown_ChangeColor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] colors = { "Red", "Green", "Blue", "Black", "Brown" };
            domainUpDown1.Items.AddRange(colors);
            domainUpDown1.Wrap = true; 

            string[] turkishColors = { "Kırmızı", "Yeşil", "Mavi", "Siyah", "Kahverengi" };
            domainUpDown2.Items.AddRange(turkishColors);
            domainUpDown2.Wrap = true;
        }

        private void domainUpDown1_SelectedItemChanged(object sender, EventArgs e)
        {
            if (domainUpDown1.SelectedIndex >= 0)
                textBox1.BackColor = Color.FromName(domainUpDown1.SelectedItem.ToString());
        }

        private void domainUpDown2_SelectedItemChanged(object sender, EventArgs e)
        {
            if (domainUpDown2.SelectedIndex >= 0)
            {
                Color color = Color.Black;
                switch (domainUpDown2.SelectedItem.ToString())
                {
                    case "Kırmızı":
                        color = Color.Red; break;
                    case "Mavi":
                        color = Color.Blue; break;
                    case "Yeşil":
                        color = Color.Green; break;
                    case "Siyah":
                        color = Color.Black; break;
                    case "Kahverengi":
                        color = Color.Brown; break;
                }

                textBox1.BackColor = color;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComboBox_Dock
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] strArray = { "Empty", "Left", "Right", "Top", "Bottom", "Into" };
            comboBox1.Items.AddRange(strArray);
            comboBox2.Items.AddRange(strArray);
            comboBox3.Items.AddRange(strArray);

            comboBox2.SelectedIndexChanged += new EventHandler(comboBox1_SelectedIndexChanged);
            comboBox3.SelectedIndexChanged += new EventHandler(comboBox1_SelectedIndexChanged);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch ((sender as ComboBox).Text)
            {
                case "Left":
                    (sender as ComboBox).Parent.Dock = DockStyle.Left;
                    break;
                case "Right":
                    (sender as ComboBox).Parent.Dock = DockStyle.Right;
                    break;
                case "Top":
                    (sender as ComboBox).Parent.Dock = DockStyle.Top;
                    break;
                case "Bottom":
                    (sender as ComboBox).Parent.Dock = DockStyle.Bottom;
                    break;
                case "Into":
                    (sender as ComboBox).Parent.Dock = DockStyle.Fill;
                    break;
                case "Empty":
                    (sender as ComboBox).Parent.Dock = DockStyle.None;
                    break;
            }
        }
    }
}

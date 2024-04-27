using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TabControl_Images
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tabControl1.Multiline = false;
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.Multiselect = true;
            openFileDialog1.Filter = "Image Files|*.bmp;*.jpg;*.gif;*.wmf";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                for (int i = 0; i <= openFileDialog1.FileNames.GetUpperBound(0); i++)
                    tabControl1.TabPages.Add(new TabPage(openFileDialog1.FileNames[i]));
                tabControl1_SelectedIndexChanged(sender, e);
            }
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile(tabControl1.SelectedTab.Text);
        }
    }
}

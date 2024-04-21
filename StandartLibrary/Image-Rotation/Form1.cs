using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Image_Rotation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i <= 6; i++)
                comboBox1.Items.Add((RotateFlipType)i);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Image image = (Image)pictureBox1.Image.Clone();
            image.RotateFlip((RotateFlipType)comboBox1.SelectedItem);
            pictureBox2.Image = image;
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageList_SelectIcon
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            numericUpDown1.Maximum = imageList1.Images.Count;
            numericUpDown1.Minimum = 1;
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            Bitmap bitmap = (Bitmap)imageList1.Images[(int)(numericUpDown1.Value - 1)];
            this.Icon = Icon.FromHandle(bitmap.GetHicon());
            pictureBox1.Image = bitmap;
        }
    }
}

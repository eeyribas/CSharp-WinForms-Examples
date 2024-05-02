using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PictureGallery
{
    public partial class Form1 : Form
    {
        private int count;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Button_Click(sender, e);
        }

        void Button_Click(object sender, EventArgs e)
        {
            if (sender == button1)
                count = 0;
            else if (sender == button2)
                count = (count + 9) % 10;
            else if (sender == button3)
                count = (count + 1) % 10;
            else if (sender == button4)
                count = 9;

            string str = string.Format("Rsm{0}", count);
            label1.Text = str + ".jpg";
            pictureBox1.Image = (Image)(Properties.Resources.ResourceManager.GetObject(str));
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            Color color = ((Bitmap)pictureBox1.Image).GetPixel(e.X, e.Y);
            Text = "Alpha:" + color.A.ToString() + " / Red:" + color.R.ToString() + " / Green:" + color.G.ToString()
                 + " / Blue:" + color.B.ToString() + " / X:" + e.X.ToString() + " / Y:" + e.Y.ToString();
        }
    }
}

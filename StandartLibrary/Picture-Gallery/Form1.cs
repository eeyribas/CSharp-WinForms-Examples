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
        int k;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Btn_Click(sender, e);
        }

        void Btn_Click(object sender, EventArgs e)
        {
            if (sender == Btn1) 
                k = 0;
            else if (sender == Btn2) 
                k = (k + 9) % 10;
            else if (sender == Btn3) 
                k = (k + 1) % 10;
            else if (sender == Btn4) 
                k = 9;
            string s = string.Format("Rsm{0}", k);
            Lbl.Text = s + ".jpg";
            Pic.Image = (Image)(Properties.Resources.ResourceManager.GetObject(s));
        }

        private void Pic_MouseMove(object sender, MouseEventArgs e)
        {
            Color color = ((Bitmap)Pic.Image).GetPixel(e.X, e.Y);
            Text = "Alpha:" + color.A.ToString()
                 + " / Red:" + color.R.ToString()
                 + " / Green:" + color.G.ToString()
                 + " / Blue:" + color.B.ToString()
                 + " / X:" + e.X.ToString()
                 + " / Y:" + e.Y.ToString();
        }
    }
}

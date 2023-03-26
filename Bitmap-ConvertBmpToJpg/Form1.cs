using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bitmap_ConvertBmpToJpg
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            Bitmap bmp = new Bitmap("papaya.bmp");
            bmp.Save("papaya.jpg", ImageFormat.Jpeg);
            bmp.Dispose();
            Close();
        }
    }
}

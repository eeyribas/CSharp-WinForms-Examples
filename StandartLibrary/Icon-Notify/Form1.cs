using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Icon_Notify
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            numericUpDown1.Minimum = 0;
            numericUpDown1.Maximum = 3;
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            Bitmap bitmap = (Bitmap)imageList1.Images[(int)numericUpDown1.Value];
            notifyIcon1.Icon = Icon.FromHandle(bitmap.GetHicon());
        }
    }
}

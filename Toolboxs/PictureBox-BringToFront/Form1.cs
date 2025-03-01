using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PictureBox_BringToFront
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox1.Click += new EventHandler(pictureBox_Click);
            pictureBox2.Click += new EventHandler(pictureBox_Click);
            pictureBox3.Click += new EventHandler(pictureBox_Click);
        }

        private void pictureBox_Click(object sender, System.EventArgs e)
        {
            (sender as PictureBox).BringToFront();
        }
    }
}

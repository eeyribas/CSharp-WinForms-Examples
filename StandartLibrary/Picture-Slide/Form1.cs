using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PictureSlide
{
    public partial class Form1 : Form
    {
        int n, N;
        string[] str;

        public Form1()
        {
            InitializeComponent();
        }

        private void Btn_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                str = Directory.GetFiles(folderBrowserDialog1.SelectedPath, "*.jpg");
                N = str.Length;
                if (N > 0)
                {
                    n = N - 1;
                    timer1.Interval = 100;
                    timer1.Enabled = true;
                }
            }
        }

        private void Tmr_Tick(object sender, EventArgs e)
        {
            n = (++n) % N;
            pictureBox1.ImageLocation = str[n];        
            Text = str[n];
        }
    }
}

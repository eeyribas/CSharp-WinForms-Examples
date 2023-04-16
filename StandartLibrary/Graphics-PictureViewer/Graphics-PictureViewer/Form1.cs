using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Graphics_PictureViewer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Graphics graphics = this.CreateGraphics();
            graphics.Clear(SystemColors.Control);
            graphics.DrawRectangle(Pens.Blue, pictureBox1.Left - 1, pictureBox1.Top - 1, pictureBox1.Width + 1, pictureBox1.Height + 1);
            graphics.Dispose();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            form.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Width = this.Width + 10;
            this.Height = this.Height + 10;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Width = this.Width - 10;
            this.Height = this.Height - 10;
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            lblX.Text = "";
            lblY.Text = "";
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            lblX.Text = "X: " + e.X.ToString();
            lblY.Text = "Y: " + e.Y.ToString();
        }
    }
}

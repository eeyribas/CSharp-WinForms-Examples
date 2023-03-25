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

        private void AddBtn_Click(object sender, EventArgs e)
        {
            if (ofdResimGetir.ShowDialog() == DialogResult.OK)
            {
                Pic.Image = Image.FromFile(ofdResimGetir.FileName);
            }
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DrawCornerBtn_Click(object sender, EventArgs e)
        {
            Graphics graphics = this.CreateGraphics();
            graphics.Clear(SystemColors.Control); 
            graphics.DrawRectangle(Pens.Blue, Pic.Left - 1, Pic.Top - 1, Pic.Width + 1, Pic.Height + 1);
            graphics.Dispose(); 
        }

        private void ZoomInBtn_Click(object sender, EventArgs e)
        {
            this.Width = this.Width + 10;
            this.Height = this.Height + 10;
        }

        private void ZoomOutBtn_Click(object sender, EventArgs e)
        {
            this.Width = this.Width - 10;
            this.Height = this.Height - 10;
        }

        private void NewFormBtn_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            form.Show();
        }

        private void Pic_MouseLeave(object sender, EventArgs e)
        {
            lblX.Text = "";
            lblY.Text = "";
        }

        private void Pic_MouseMove(object sender, MouseEventArgs e)
        {
            lblX.Text = "X: " + e.X.ToString();
            lblY.Text = "Y: " + e.Y.ToString();
        }
    }
}

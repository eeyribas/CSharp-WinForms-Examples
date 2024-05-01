using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormScale
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Rectangle resolution = new Rectangle();
            resolution = Screen.GetBounds(resolution);

            int originalX = 800;
            int originalY = 600;
            float ratioX = (float)resolution.Width / originalX;
            float ratioY = (float)resolution.Height / originalY;

            this.Left = 0;
            this.Top = 0;
            this.Scale(ratioX, ratioY);
        }
    }
}

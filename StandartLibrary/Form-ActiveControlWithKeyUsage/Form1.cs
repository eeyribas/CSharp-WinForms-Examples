using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form_ActiveControlWithKeyUsage
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if ((this.Tag != "1") && (e.Alt == true) && (e.KeyCode == Keys.CapsLock))
            {
                this.Tag = "1";
                this.ActiveControl.Width *= 2;
                this.ActiveControl.Height *= 2;
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            this.Tag = "0";

            if ((e.Alt == true) && (e.KeyCode == Keys.CapsLock))
            {
                this.ActiveControl.Width /= 2;
                this.ActiveControl.Height /= 2;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AreaAndVolumeOfTheSphere
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Lbl4.Text = Math.PI.ToString();
            Txt.ResetText();
        }

        private void Txt_TextChanged(object sender, EventArgs e)
        {
            Lbl1.ResetText();
            Lbl2.ResetText();
            Lbl3.ResetText();
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            double r = 0;
            if(!double.TryParse(Txt.Text, out r)) {
                MessageBox.Show("Enter real number", "Info");
                Txt.Focus();
                return;
            }
            double area = 4 * Math.PI * r * r;
            double volume = area * r / 3;
            Lbl1.Text = r.ToString();
            Lbl2.Text = volume.ToString();
            Lbl3.Text = area.ToString();
            Txt.Focus();
        }
    }
}

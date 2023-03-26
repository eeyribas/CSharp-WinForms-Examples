using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChangeColorWithButton
{
    public partial class Form1 : Form
    {
        int i, j;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int k, n = Controls.Count;
            Text = "Nesne Sayısı = " + n.ToString();
            for (k = 0; k < n; k++) {
                if (Controls[k] is TextBox) {
                    Controls[k].BackColor = Color.Pink;
                    Controls[k].ForeColor = Color.Blue;
                }
            }
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            i = j = 0;
            for (int k = 0; k < Controls.Count; k++)
                Controls[k].Text = "Esen EYRIBAS";
        }

        void Txt_Enter(object sender, EventArgs e)
        {
            Lbl1.Text = "Enter = " + (++i).ToString();
            (sender as TextBox).BackColor = Color.Yellow;
            (sender as TextBox).ForeColor = Color.Red;
        }

        void Txt_Leave(object sender, EventArgs e)
        {
            Lbl2.Text = "Leave = " + (++j).ToString();
            (sender as TextBox).BackColor = Color.Pink;
            (sender as TextBox).ForeColor = Color.Blue;
        }
    }
}

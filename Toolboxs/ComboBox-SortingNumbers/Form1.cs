using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComboBox_SortingNumbers
{
    public partial class Form1 : Form
    {
        int n;
        double[] a, b;
        Random random;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            random = new Random();
            Btn_Click(sender, e);
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            n = random.Next(15, 31);
            a = new double[n];
            Text = "Array size = " + n.ToString();
            Lst1.Items.Clear();
            for (int i = 0; i < n; i++)
            {
                a[i] = Math.Round(1e3 * random.NextDouble(), 6);
                Lst1.Items.Add(a[i].ToString());
            }
            Cmb_SelectedIndexChanged(sender, e);
        }

        private void Cmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Cmb.SelectedIndex < 0) 
                return;

            b = new double[n];
            Array.Copy(a, b, n);
            Array.Sort(b);
            if (Cmb.SelectedIndex > 0) 
                Array.Reverse(b);

            Lst2.Items.Clear();
            for (int i = 0; i < n; i++)
                Lst2.Items.Add(b[i].ToString());
        }

        private void Cmb_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}

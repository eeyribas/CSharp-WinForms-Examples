using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CultureInfoList
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Globalization.CultureInfo[] cultures;
            cultures = System.Globalization.CultureInfo.GetCultures(System.Globalization.CultureTypes.AllCultures);
            foreach (System.Globalization.CultureInfo c in cultures)
                listBox1.Items.Add(c.Name + ", " + c.NativeName);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.Text = "Culture:" + listBox1.Text;
            int i = listBox1.SelectedIndex;
            System.Globalization.CultureInfo k;
            k = new System.Globalization.CultureInfo(System.Globalization.CultureInfo.GetCultures(
             System.Globalization.CultureTypes.AllCultures)[i].Name);
            label2.Text = DateTime.Now.ToString(k.DateTimeFormat);
            label2.Text = DateTime.Now.ToString(k.DateTimeFormat);
            decimal money = 150000000M;
            label4.Text = money.ToString("C", k.NumberFormat);
        }
    }
}

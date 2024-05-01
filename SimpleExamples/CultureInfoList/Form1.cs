using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
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
            CultureInfo[] cultureInfos = CultureInfo.GetCultures(CultureTypes.AllCultures);
            foreach (CultureInfo cultureInfo in cultureInfos)
                listBox1.Items.Add(cultureInfo.Name + ", " + cultureInfo.NativeName);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.Text = "Culture : " + listBox1.Text;
            int i = listBox1.SelectedIndex;

            CultureInfo cultureInfo = new CultureInfo(CultureInfo.GetCultures(CultureTypes.AllCultures)[i].Name);
            label2.Text = DateTime.Now.ToString(cultureInfo.DateTimeFormat);
            label2.Text = DateTime.Now.ToString(cultureInfo.DateTimeFormat);

            decimal value = 150000000M;
            label4.Text = value.ToString("C", cultureInfo.NumberFormat);
        }
    }
}

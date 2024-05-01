using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ForeachUsage
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            for(int i = 1; i <= 100; i++)
                listBox1.Items.Add(random.Next(1000).ToString());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int sum = 0;
            foreach (string item in listBox1.Items)
                sum += int.Parse(item);

            MessageBox.Show(sum.ToString());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int sum = 0;
            for(int i = 0; i <= listBox1.Items.Count - 1; i++)
                sum += int.Parse(listBox1.Items[i].ToString());

            MessageBox.Show(sum.ToString());
        }
    }
}

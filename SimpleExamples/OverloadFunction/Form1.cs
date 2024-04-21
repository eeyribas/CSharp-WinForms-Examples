using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OverloadFunction
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Sum(5, 6).ToString());
            MessageBox.Show(Sum(5, 6, 7).ToString());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Subtraction(10, 3).ToString());
            MessageBox.Show(Subtraction("Istanbul", "a"));
        }

        int Sum(int x, int y)
        {
            MessageBox.Show("The one with 2 parameters is working.");
            return x + y;
        }

        int Sum(int x, int y, int z)
        {
            MessageBox.Show("The one with 3 parameters is working.");
            return x + y + z;
        }

        int Subtraction(int x, int y)
        {
            return x - y;
        }

        string Subtraction(string x, string y)
        {
            return x.Replace(y, "");
        }
    }
}

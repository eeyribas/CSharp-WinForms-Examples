using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StringSplit
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string str1, str2;
            string words = textBox1.Text;
            string[] str = words.Split(' ');

            if (str.Length == 1)
            {
                str1 = str[0];
                MessageBox.Show(str1 + " Length-1 ");
            }

            if (str.Length == 2)
            {
                str1 = str[0];
                str2 = str[1];
                MessageBox.Show(str1 + " Length-2 " + str2);
            }

            if (str.Length == 3)
            {
                str1 = str[0] + " " + str[1];
                str2 = str[2];
                MessageBox.Show(str1 + " Length-3 " + str2);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string sentence = textBox2.Text;
            string[] str = sentence.Split(' ');
            MessageBox.Show(str.Length.ToString() + " wrote the word.");

            for (int i = 0; i < str.Length; i++)
                listBox1.Items.Add(str[i]);
            str = sentence.Split('.');
            MessageBox.Show(str.Length.ToString() + " wrote a sentence.");

            for (int i = 0; i < str.Length; i++)
                listBox2.Items.Add(str[i]);
        }
    }
}

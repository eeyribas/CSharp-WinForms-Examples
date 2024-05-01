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
            string[] strArray = words.Split(' ');

            if (strArray.Length == 1)
            {
                str1 = strArray[0];
                MessageBox.Show(str1 + " Length-1 ");
            }

            if (strArray.Length == 2)
            {
                str1 = strArray[0];
                str2 = strArray[1];
                MessageBox.Show(str1 + " Length-2 " + str2);
            }

            if (strArray.Length == 3)
            {
                str1 = strArray[0] + " " + strArray[1];
                str2 = strArray[2];
                MessageBox.Show(str1 + " Length-3 " + str2);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string sentence = textBox2.Text;
            string[] strArray = sentence.Split(' ');
            MessageBox.Show(strArray.Length.ToString() + " wrote the word.");

            for (int i = 0; i < strArray.Length; i++)
                listBox1.Items.Add(strArray[i]);
            strArray = sentence.Split('.');
            MessageBox.Show(strArray.Length.ToString() + " wrote a sentence.");

            for (int i = 0; i < strArray.Length; i++)
                listBox2.Items.Add(strArray[i]);
        }
    }
}

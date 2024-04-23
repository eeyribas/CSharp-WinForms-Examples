using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MatrixAdditionAndMultiplication
{
    public partial class Form1 : Form
    {
        private int[,] a = new int[3, 3];
        private int[,] b = new int[3, 3];
        private int[,] c = new int[3, 3];
        private int j;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Write the matrices with spaces between the elements.\r\n" +
                            "Press the Enter key between the rows.");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GetMatrix(textBox1.Text, a);
            GetMatrix(textBox2.Text, b);
            label3.Text = "A+B Matrix";
            textBox3.Text = "";

            for (int i = 0; i <= 2; i++)
            {
                for (int j = 0; j <= 2; j++)
                {
                    c[i, j] = a[i, j] + b[i, j];
                    textBox3.Text = textBox3.Text + " " + c[i, j].ToString();
                }
                textBox3.Text += "\r\n";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            GetMatrix(textBox1.Text, a);
            GetMatrix(textBox2.Text, b);
            label3.Text = "AxB Matrix";
            textBox3.Text = "";

            for (int i = 0; i <= 2; i++)
            {
                for (int j = 0; j <= 2; j++)
                {
                    int x = 0;
                    for (int k = 0; k <= 2; k++)
                    {
                        x += a[i, k] * b[k, j];
                    }
                    c[i, j] = x;
                }
            }
    
            for (int i = 0; i <= 2; i++)
            {
                for (int j = 0; j <= 2; j++)
                    textBox3.Text = textBox3.Text + "  " + c[i, j].ToString();
                textBox3.Text += "\r\n";
            }
        }

        private bool GetMatrix(string str, int[,] array)
        {
            char[] splits = { ' ', '\r' };
            string[] s = str.Split(splits);
            if (s.GetUpperBound(0) < 8)
            {
                MessageBox.Show("Matris yanlış girilmiş");
                return false;
            }

            int k = 0;
            for (int i = 0; i <= 2; i++)
            {
                for (int j = 0; j <= 2; j++)
                {
                    array[i, j] = int.Parse(s[k]);
                    k++;
                }
            }

            return true;
        }
    }
}

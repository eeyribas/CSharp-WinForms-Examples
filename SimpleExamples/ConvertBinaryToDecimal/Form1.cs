using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConvertBinaryToDecimal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string h, a, s = "";
            try
            {
                h = int.Parse(textBox1.Text).ToString("X");
            }
            catch
            {
                MessageBox.Show("Error number");
                return;
            }

            for (int i = 1; i <= h.Length; i++)
            {
                string b = h.Substring(i - 1, 1); 
                switch (b)
                {
                    case "0": 
                        a = "0000"; 
                        break;
                    case "1": 
                        a = "0001"; 
                        break;
                    case "2": 
                        a = "0010"; 
                        break;
                    case "3": 
                        a = "0011"; 
                        break;
                    case "4": 
                        a = "0100"; 
                        break;
                    case "5": 
                        a = "0101";
                        break;
                    case "6":
                        a = "0110"; 
                        break;
                    case "7": 
                        a = "0111"; 
                        break;
                    case "8": 
                        a = "1000"; 
                        break;
                    case "9": 
                        a = "1001";
                        break;
                    case "A": 
                        a = "1010"; 
                        break;
                    case "B": 
                        a = "1011"; 
                        break;
                    case "C":
                        a = "1100"; 
                        break;
                    case "D": 
                        a = "1101"; 
                        break;
                    case "E":
                        a = "1110"; 
                        break;
                    case "F": 
                        a = "1111"; 
                        break;
                    default: 
                        a = ""; 
                        break;
                }
                s += a;
            }

            label1.Text = s;
        }

        private void button2_Click(object sender, EventArgs e)
        {           
            try
            {
                int j = 0, s = 0;
                for (int i = textBox1.Text.Length; i >= 1; i--, j++)
                    s += int.Parse(textBox1.Text.Substring(i - 1, 1)) * (int)(Math.Pow(2, j));
                label1.Text = s.ToString();
            }
            catch
            {
                MessageBox.Show("Error number");
            }
        }
    }
}

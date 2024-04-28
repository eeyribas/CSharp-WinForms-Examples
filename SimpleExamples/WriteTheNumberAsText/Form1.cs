using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WriteTheNumberAsText
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.AcceptButton = button1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                label1.Text = Convert(textBox1.Text);
            }
            catch
            {
                MessageBox.Show("Error number!");
            }
        }

        private string Convert(string number)
        {
            int maxDigitNumber = 18;
            string[] ones =  { "", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            string[] tens = { "", "ten", "twenty", "thirty", "forty", "fifty", "sixty", "seventy", "eighty", "ninety" };
            string[] thousands = { "quadrillion", "trillion", "billion", "million", "thousand", "" };
            int[] digitArray = new int[3];
            string result = "";
            string tmpResult = "";

            number = number.PadLeft(maxDigitNumber, '0');
            for (int i = 0; i <= maxDigitNumber / 3 - 1; i++)
            {
                digitArray[0] = int.Parse(number.Substring(i * 3, 1));
                digitArray[1] = int.Parse(number.Substring((i * 3) + 1, 1));
                digitArray[2] = int.Parse(number.Substring((i * 3) + 2, 1));

                if (digitArray[0] == 0)
                    tmpResult = "";
                else if (digitArray[0] == 1)
                    tmpResult = "hundred";
                else
                    tmpResult = ones[digitArray[0]] + "hundred";
                tmpResult = tmpResult + tens[digitArray[1]] + ones[digitArray[2]];

                if (tmpResult != "")
                    tmpResult = tmpResult + thousands[i];
                if ((i > 1) && (tmpResult == "one thousand"))
                    tmpResult = "thousand";
                if (tmpResult != "")
                    result = result + tmpResult + " ";
            }

            if (result.Trim() == "")
                result = "zero";

            return result.Trim();
        }
    }
}

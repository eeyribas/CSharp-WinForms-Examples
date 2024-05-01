using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ModernCalculator
{
    public partial class Form1 : Form
    {
        private decimal number1, number2, memory;
        private string process;
        private bool resulted;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "Calculator";
            textBox1.Text = "";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0)
                textBox1.Text = textBox1.Text.Substring(0, textBox1.Text.Length - 1);
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0)
            {
                if (textBox1.Text.Substring(0, 1) == "-")
                    textBox1.Text = textBox1.Text.Substring(1);
                else
                    textBox1.Text = "-" + textBox1.Text.Substring(0);
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.IndexOf(",") <= 0)
            {
                if (textBox1.Text.Length == 0)
                    textBox1.Text = "0,";
                else
                    textBox1.Text = textBox1.Text + ",";
            }
        }

        private void button26_Click(object sender, EventArgs e)
        {
            number2 = decimal.Parse(textBox1.Text);
            decimal result = 0;

            switch (process)
            {
                case "+":
                    result = number1 + number2;
                    break;
                case "-":
                    result = number1 - number2;
                    break;
                case "*":
                    result = number1 * number2;
                    break;
                case "/":
                    if (number2 == 0)
                        return;
                    result = number1 / number2;
                    break;
            }

            resulted = true;
            textBox1.Text = result.ToString();
            number1 = number2;
        }

        private void Number(object sender, System.EventArgs e)
        {
            if (resulted)
                textBox1.Text = (sender as Button).Text;
            else
                textBox1.Text += (sender as Button).Text;

            resulted = false;
        }

        private void MemoryProcesses(object sender, System.EventArgs e)
        {
            if (textBox1.Text.Length == 0)
                textBox1.Text = "0";

            switch ((sender as Button).Text)
            {
                case "MC":
                    memory = 0;
                    break;
                case "M+":
                    memory += decimal.Parse(textBox1.Text);
                    break;
                case "M-":
                    memory -= decimal.Parse(textBox1.Text);
                    break;
                case "MR":
                    textBox1.Text = memory.ToString();
                    break;
            }
        }

        private void GeneralProcesses(object sender, System.EventArgs e)
        {
            process = (sender as Button).Text;
            if (textBox1.Text.Length == 0)
                textBox1.Text = "0";

            number1 = decimal.Parse(textBox1.Text);
            resulted = true;
        }

        private void AdvancedProcesses(object sender, System.EventArgs e)
        {
            if (textBox1.Text.Length == 0)
                textBox1.Text = "0";
            decimal number = decimal.Parse(textBox1.Text);

            switch ((sender as Button).Text)
            {
                case "S":
                    if (number >= 0)
                        textBox1.Text = Math.Sqrt((double)number).ToString();
                    break;
                case "x²":
                    textBox1.Text = (number * number).ToString();
                    break;
                case "1/x":
                    if (number != 0)
                        textBox1.Text = (1 / number).ToString();
                    break;
            }
        }
    }
}

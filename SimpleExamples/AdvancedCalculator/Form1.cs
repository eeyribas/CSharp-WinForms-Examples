using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdvancedCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button1.Click += new EventHandler(button_Click);
            button2.Click += new EventHandler(button_Click);
            button3.Click += new EventHandler(button_Click);
            button4.Click += new EventHandler(button_Click);
            button5.Click += new EventHandler(button_Click);
            button6.Click += new EventHandler(button_Click);
            button7.Click += new EventHandler(button_Click);
            button8.Click += new EventHandler(button_Click);
            button9.Click += new EventHandler(button_Click);
            button10.Click += new EventHandler(button_Click);
            button11.Click += new EventHandler(button_Click);
            button12.Click += new EventHandler(button_Click);
        }

        private void button_Click(object sender, System.EventArgs e)
        {
            decimal number1 = 0;

            try
            {
                number1 = decimal.Parse(textBox1.Text);
                decimal number2 = decimal.Parse(textBox2.Text);
                decimal result = 0;

                switch ((sender as Button).Text)
                {
                    case "+": 
                        result = number1 + number2; 
                        break;
                    case "*": 
                        result = number1 * number2; 
                        break;
                    case "/": 
                        result = number1 / number2; 
                        break;
                    case "-": 
                        result = number1 - number2; 
                        break;
                    case "Log": 
                        result = (decimal)Math.Log10((double)number1); 
                        break;
                    case "Ln": 
                        result = (decimal)Math.Log((double)number1); 
                        break;
                    case "Sin": 
                        result = (decimal)Math.Sin((double)number1); 
                        break;
                    case "Cos": 
                        result = (decimal)Math.Cos((double)number1); 
                        break;
                    case "Tan": 
                        result = (decimal)Math.Tan((double)number1); 
                        break;
                    case "Square": 
                        result = (decimal)Math.Pow((double)number1, (double)(1 / number2)); 
                        break;
                    case "Exponent": 
                        result = (decimal)Math.Pow((double)number1, (double)number2); 
                        break;
                    case "e Pow": 
                        result = (decimal)Math.Exp((double)number1); 
                        break;
                }

                textBox3.Text = result.ToString();
            }
            catch (DivideByZeroException divideByZeroException)
            {
                MessageBox.Show("You are trying to divide by zero.\r\n" + divideByZeroException.Message);
            }
            catch (OverflowException overflowException)
            {
                if (number1 < 0)
                    MessageBox.Show("You can't perform this operation with a negative number.\r\n" + overflowException.Message);
                else
                    MessageBox.Show("The numbers are too large.\r\n" + overflowException.Message);
            }
            catch (FormatException formatException)
            {
                MessageBox.Show("You haven't entered a number.\r\n" + formatException.Message);
            }
            catch (Exception exception)
            {
                MessageBox.Show("An unknown error occurred.\r\n" + exception.Message);
            }
        }
    }
}

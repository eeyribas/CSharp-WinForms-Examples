using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProductBalanceCalculation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            long amount = 0, difference = 0, penaltyFee = 0;

            try
            {
                amount = long.Parse(textBox2.Text);
                DateTime dueDate = DateTime.Parse(textBox3.Text);
                DateTime paymentDate = DateTime.Parse(textBox4.Text);
                difference = (long)(paymentDate.ToOADate() - dueDate.ToOADate());
            }
            catch (Exception exception)
            {
                MessageBox.Show("Information is incorrect." + exception.Message);
            }

            if (difference > 0)
            {
                penaltyFee = difference * amount * 2 / 1000;
                textBox5.Text = penaltyFee.ToString("#,#");
                textBox6.Text = (amount + penaltyFee).ToString("#,#");
                MessageBox.Show(difference + " paid after the due date." + textBox5.Text + " $ penalty fee.");
            }
            else if (difference == 0)
            {
                penaltyFee = 0;
                textBox5.Text = "0";
                textBox6.Text = amount.ToString("#,#");
                MessageBox.Show("Paid on time.");
            }
            else
            {
                penaltyFee = 5000000;
                textBox5.Text = penaltyFee.ToString("#,#");
                textBox6.Text = (amount - penaltyFee).ToString("#,#");
                MessageBox.Show(difference + " paid early." + textBox5.Text + " $ discount.");
            }
        }
    }
}

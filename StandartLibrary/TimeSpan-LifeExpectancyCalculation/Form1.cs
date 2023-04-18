using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimeSpan_LifeExpectancyCalculation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime date = DateTime.Parse(textBox1.Text);
                TimeSpan difference = DateTime.Now.Subtract(date);
                textBox2.Text =
                 "Hour: " + difference.TotalHours.ToString() + "\r\n" +
                 "Minute: " + difference.TotalMinutes.ToString() + "\r\n" +
                 "Second: " + difference.TotalSeconds.ToString() + "\r\n" +
                 "Day: " + difference.TotalDays.ToString();
            }
            catch
            {
                MessageBox.Show("Error");
            }
        }
    }
}

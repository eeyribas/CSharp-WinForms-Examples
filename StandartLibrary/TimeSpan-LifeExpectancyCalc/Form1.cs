using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimeSpan_LifeExpectancyCalc
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
                DateTime dateTime = DateTime.Parse(textBox1.Text);
                TimeSpan timeSpan = DateTime.Now.Subtract(dateTime);
                textBox2.Text = "Hour: " + timeSpan.TotalHours.ToString() + "\r\n" + "Minute: " + timeSpan.TotalMinutes.ToString() + "\r\n" +
                                "Second: " + timeSpan.TotalSeconds.ToString() + "\r\n" + "Day: " + timeSpan.TotalDays.ToString();
            }
            catch
            {
                MessageBox.Show("Error!");
            }
        }
    }
}

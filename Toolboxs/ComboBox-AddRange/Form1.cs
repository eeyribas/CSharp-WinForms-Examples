using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComboBox_AddRange
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] jobs = {"Worker", "Engineer", "Accountant", "Trainer", "Programmer", "Technician"};
            comboBox1.Items.AddRange(jobs);
        }

        private void comboBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)27)
                comboBox1.Text = comboBox1.Items[0].ToString();
        }

        private void comboBox1_Leave(object sender, EventArgs e)
        {
            if (comboBox1.FindStringExact(comboBox1.Text) < 0)
                comboBox1.Items.Add(comboBox1.Text);
        }
    }
}

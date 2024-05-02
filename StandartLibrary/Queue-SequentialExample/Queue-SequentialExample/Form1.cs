using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Queue_SequentialExample
{
    public partial class Form1 : Form
    {
        private Queue queue = new Queue();
        private int count = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (queue.Count != 0)
                {
                    queue.Dequeue();
                    label3.Text = queue.Count.ToString();
                    label1.Text = queue.Count.ToString();
                    label5.Text = queue.Peek().ToString();
                }
            }
            catch
            {
                MessageBox.Show("Error", "303", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                count++;
                queue.Enqueue(count);
                label3.Text = queue.Count.ToString();
            }
            catch
            {
                MessageBox.Show("Error", "404", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

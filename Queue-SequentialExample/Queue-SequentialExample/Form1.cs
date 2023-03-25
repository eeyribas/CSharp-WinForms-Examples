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
        Queue queue = new Queue();
        int count = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void GiveOrderBtn_Click(object sender, EventArgs e)
        {
            try
            {
                count++;
                queue.Enqueue(count); 
                Lbl2.Text = queue.Count.ToString();
            }
            catch
            {
                MessageBox.Show("Error", "404", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CallBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (queue.Count != 0)
                {
                    queue.Dequeue();
                    Lbl2.Text = queue.Count.ToString();
                    CallLbl.Text = queue.Count.ToString();
                    Lbl4.Text = queue.Peek().ToString();
                }
            }
            catch
            {
                MessageBox.Show("Error", "303", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

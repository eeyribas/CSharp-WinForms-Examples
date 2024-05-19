using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicketingSystem
{
    public partial class Form1 : Form
    {
		private Queue<int> queues = new Queue<int>();
		private int count = 0;

		public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
			Button button = new Button();
			button = (Button)sender;

			if (queues.Count != 0)
			{
				switch (button.Name)
				{
					case "button1":
						label1.Text = Convert.ToString(queues.Dequeue());
						break;
					case "button2":
						label2.Text = Convert.ToString(queues.Dequeue());
						break;
					case "button3":
						label3.Text = Convert.ToString(queues.Dequeue());
						break;
					case "button4":
						label4.Text = Convert.ToString(queues.Dequeue());
						break;
					case "button5":
						label5.Text = Convert.ToString(queues.Dequeue());
						break;
					default:
						break;
				}

				label12.Text = queues.Count.ToString();
				if (queues.Count != 0)
					label14.Text = queues.Peek().ToString();
			}
			else
			{
				MessageBox.Show("Empty Queue!", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
		}

		private void button6_Click(object sender, EventArgs e)
		{
			try
			{
				count++;
				queues.Enqueue(count);
				label12.Text = queues.Count.ToString();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void button7_Click(object sender, EventArgs e)
		{
			try
			{
				queues.Clear();
				count = 0;

				label1.Text = label2.Text = label3.Text = label4.Text = label5.Text = "0";
				label6.Text = "Cnt 1: 0";
				label7.Text = "Cnt 2: 0";
				label8.Text = "Cnt 3: 0";
				label9.Text = "Cnt 4: 0";
				label10.Text = "Cnt 5: 0";
				label12.Text = label14.Text = "0";
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void label1_TextChanged(object sender, EventArgs e)
        {
			Label label = new Label();
			label = (Label)sender;

			switch (label.Name)
			{
				case "label1":
					label6.Text = "Cnt 1: " + label1.Text;
					break;
				case "label2":
					label7.Text = "Cnt 2: " + label2.Text;
					break;
				case "label3":
					label8.Text = "Cnt 3: " + label3.Text;
					break;
				case "label4":
					label9.Text = "Cnt 4: " + label4.Text;
					break;
				case "label5":
					label10.Text = "Cnt 5: " + label5.Text;
					break;
				default:
					break;
			}
		}
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MessageBoxTopics
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("The program will close.", "Exit", MessageBoxButtons.OKCancel, 
                                                        MessageBoxIcon.Information);
            
            if (dialogResult == DialogResult.Cancel)
                e.Cancel = true;
            else
                MessageBox.Show("Goodbye!", "The program has ended.", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.IndexOf(textBox1.Text) >= 0)
            {
                DialogResult dialogResult = MessageBox.Show("This item is already in the list. Do you want to add it again?", "Item exists.",
                                            MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dialogResult == DialogResult.Yes)
                    listBox1.Items.Add(textBox1.Text);
            }
            else
            {
                listBox1.Items.Add(textBox1.Text);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex < 0)
            {
                MessageBox.Show("Select the item you want to delete.", "You didn't select anything.", MessageBoxButtons.OK, 
                                MessageBoxIcon.Information);
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this item?", "Delete Item",
                                                            MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                    listBox1.Items.Remove(listBox1.SelectedItem);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("This operation will take a long time. Do you want to continue?", "A very long operation.",
                                                        MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dialogResult == DialogResult.Yes)
            {
                long sum = 0;
                for (int i = 1; i <= 1000000000; i++)
                    sum += i;

                MessageBox.Show("Result: " + sum.ToString(), "Sum", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("There is a problem. Files could not be deleted. Possible reasons:\r\n" +
                            "There may be no diskette in the drive.\r\n" +
                            "There may be no files in the main folder.\r\n" +
                            "The diskette's write-protect tab may be closed.\r\n" +
                            "Another program may be using the file being deleted.\r\n" +
                            "There may not be a floppy disk drive on your computer.",
                            "An error occurred.",
                            MessageBoxButtons.RetryCancel, MessageBoxIcon.Exclamation);
        }
    }
}

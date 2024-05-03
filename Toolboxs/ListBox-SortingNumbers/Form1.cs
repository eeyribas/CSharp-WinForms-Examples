using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListBox_SortingNumbers
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Random random = new Random();
            for (int i = 1; i <= 20; i++)
                listBox1.Items.Add(((int)random.Next(1000)).ToString());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i <= listBox1.Items.Count - 1; i++)
            {
                for (int j = i; j <= listBox1.Items.Count - 1; j++)
                {
                    if (int.Parse(listBox1.Items[j].ToString()) > int.Parse(listBox1.Items[i].ToString()))
                    {
                        int value = int.Parse(listBox1.Items[i].ToString());
                        listBox1.Items[i] = listBox1.Items[j];
                        listBox1.Items[j] = value.ToString();
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            Random random = new Random();
            for (int i = 1; i <= 2000; i++)
                listBox1.Items.Add(((int)random.Next(1000)).ToString());

            this.Text = "Please wait...";
            DateTime startTime = DateTime.Now;
            listBox1.BeginUpdate();
            for (int i = 0; i <= listBox1.Items.Count - 1; i++)
            {
                for (int j = i; j <= listBox1.Items.Count - 1; j++)
                {
                    if (int.Parse(listBox1.Items[j].ToString()) > int.Parse(listBox1.Items[i].ToString()))
                    {
                        int value = int.Parse(listBox1.Items[i].ToString());
                        listBox1.Items[i] = listBox1.Items[j];
                        listBox1.Items[j] = value.ToString();
                    }
                }
            }
            listBox1.EndUpdate();

            DateTime lastTime = DateTime.Now;
            TimeSpan difference = lastTime - startTime;
            this.Text = "Process Time " + difference.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            Random random = new Random();
            for (int i = 1; i <= 2000; i++)
                listBox1.Items.Add(((int)random.Next(1000)).ToString());

            this.Text = "Please wait..";
            DateTime startTime = DateTime.Now;
            listBox1.BeginUpdate();
            int[] x = new int[listBox1.Items.Count];
            for (int i = 0; i <= listBox1.Items.Count - 1; i++)
                x[i] = int.Parse(listBox1.Items[i].ToString());

            for (int i = 0; i <= listBox1.Items.Count - 1; i++)
            {
                for (int j = i; j <= listBox1.Items.Count - 1; j++)
                {
                    if (x[j] > x[i])
                    {
                        int tmp = x[i];
                        x[i] = x[j];
                        x[j] = tmp;
                    }
                }
            }

            for (int i = 0; i <= listBox1.Items.Count - 1; i++)
                listBox1.Items[i] = x[i];

            listBox1.EndUpdate();
            DateTime lastTime = DateTime.Now;
            TimeSpan difference = lastTime - startTime;
            this.Text = "Process Time " + difference.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            Random random = new Random();
            for (int i = 1; i <= 2000; i++)
                listBox1.Items.Add(((int)random.Next(1000)).ToString());

            this.Text = "Please wait...";
            DateTime startTime = DateTime.Now;
            for (int i = 0; i <= listBox1.Items.Count - 1; i++)
            {
                for (int j = i; j <= listBox1.Items.Count - 1; j++)
                {
                    if (int.Parse(listBox1.Items[j].ToString()) > int.Parse(listBox1.Items[i].ToString()))
                    {
                        int tmp = int.Parse(listBox1.Items[i].ToString());
                        listBox1.Items[i] = listBox1.Items[j];
                        listBox1.Items[j] = tmp.ToString();
                    }
                }
            }

            DateTime lastTime = DateTime.Now;
            TimeSpan difference = lastTime - startTime;
            this.Text = "Process Time " + difference.ToString();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Filing_AddList
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            FileInfo fileInfo = new FileInfo("list.dat");
            if(fileInfo.Exists == true) 
            {
                TextReader textReader = File.OpenText("list.dat");
                string element1, element2, element3;
                while((element1 = textReader.ReadLine()) != null)
                {
                    listBox1.Items.Add(element1);
                    element2 = textReader.ReadLine();
                    listBox2.Items.Add(element2);
                    element3 = textReader.ReadLine();
                    listBox3.Items.Add(element3);
                }
                textReader.Close();
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            TextWriter textWriter = File.CreateText("list.dat");
            for(int i = 0; i <= listBox1.Items.Count - 1; i++)
            {
                textWriter.WriteLine(listBox1.Items[i]);
                textWriter.WriteLine(listBox2.Items[i]);
                textWriter.WriteLine(listBox3.Items[i]);
            }
            textWriter.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox1.Text);
            listBox2.Items.Add(textBox2.Text);
            listBox3.Items.Add(textBox3.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int index = listBox1.SelectedIndex;
            if(index < 0)
            {
                MessageBox.Show("Selection element!");
            }   
            else
            {
                listBox1.Items.RemoveAt(index);
                listBox2.Items.RemoveAt(index);
                listBox3.Items.RemoveAt(index);
            }
        }
    }
}

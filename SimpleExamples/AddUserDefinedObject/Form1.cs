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

namespace AddUserDefinedObject
{
    public partial class Form1 : Form
    {
        struct Personel
        {
            public string name, job, department;
            public override string ToString()
            {
                string s1, s2;
                s1 = "Name=" + name;
                s1 = s1.PadRight(30);
                s2 = s1;

                s1 = "Job=" + job;
                s1 = s1.PadRight(20);
                s2 += s1;

                s1 = "Department=" + department;
                s1 = s1.PadRight(20);
                s2 += s1;

                return s2;
            }
        }

        private int tmp = -1;
        private string search;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] jobs = { "Engineer", "Teacher", "Student", "Worker", "Accountant", "Programmer" };
            comboBox1.Items.AddRange(jobs);
            string[] departments = {"Satış", "Education", "Marketing", "Accounting", "Advertising", "Production" };
            comboBox2.Items.AddRange(departments);
            listBox1.Font = new Font("Courier New", 8, FontStyle.Regular);

            Personel personel;
            TextReader textReader = File.OpenText("pers.dat");
            string row;
            while ((row = textReader.ReadLine()) != null)
            {
                personel.name = row;
                row = textReader.ReadLine();
                personel.job = row;
                row = textReader.ReadLine();
                personel.department = row;
                listBox1.Items.Add(personel);
            }
            textReader.Close();

            label5.Text = listBox1.Items.Count.ToString();
            label7.Text = (listBox1.SelectedIndex + 1).ToString();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            TextWriter textWriter = File.CreateText("pers.dat");
            for (int i = 0; i <= listBox1.Items.Count - 1; i++)
            {
                textWriter.WriteLine(((Personel)listBox1.Items[i]).name);
                textWriter.WriteLine(((Personel)listBox1.Items[i]).department);
                textWriter.WriteLine(((Personel)listBox1.Items[i]).job);
            }
            textWriter.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Personel personel;
            personel.name = textBox1.Text;
            personel.job = comboBox1.Text;
            personel.department = comboBox2.Text;
            listBox1.Items.Add(personel);
            label5.Text = listBox1.Items.Count.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex < 0)
            {
                MessageBox.Show("Please select the item to be deleted first : ");
                return;
            }

            DialogResult dialogResult = MessageBox.Show(listBox1.SelectedItem + " Delete?", "Delete", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
                label5.Text = listBox1.Items.Count.ToString();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            search = "Name=" + textBox2.Text;
            tmp = listBox1.FindStringExact(search);
            if (tmp < 0)
            {
                tmp = listBox1.FindString(search);
                if (tmp < 0)
                    MessageBox.Show("Not find.");
            }

            if (tmp >= 0)
                listBox1.SelectedIndex = tmp;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (tmp < listBox1.Items.Count - 1)
            {
                tmp = listBox1.FindString(search, tmp);
                if (tmp >= 0)
                    listBox1.SelectedIndex = tmp;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Personel personel;
            personel.name = textBox1.Text;
            personel.job = comboBox1.Text;
            personel.department = comboBox2.Text;
            int index = listBox1.SelectedIndex;
            if (index < 0)
                MessageBox.Show("Please select the item to be replaced first : ");
            else
                listBox1.Items[index] = personel;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int index = listBox1.SelectedIndex;
            if (index < 0)
            {
                MessageBox.Show("Please select where the item will be added first : ");
            }
            else
            {
                Personel personel;
                personel.name = textBox1.Text;
                personel.job = comboBox1.Text;
                personel.department = comboBox2.Text;
                listBox1.Items.Insert(index, personel);
                label5.Text = listBox1.Items.Count.ToString();
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex < 0)
                return;

            textBox1.Text = ((Personel)listBox1.SelectedItem).name;
            comboBox1.Text = ((Personel)listBox1.SelectedItem).job;
            comboBox2.Text = ((Personel)listBox1.SelectedItem).department;
            label7.Text = (listBox1.SelectedIndex + 1).ToString();
        }
    }
}

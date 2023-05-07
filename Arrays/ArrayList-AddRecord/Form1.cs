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

namespace ArrayList_AddRecord
{
    public partial class Form1 : Form
    {
        struct Record
        {
            public string name, surname, fatherName, city, job;

            public override string ToString()
            {
                return "Name = " + name + ", Surname = " + surname + ", Father Name = " + fatherName + ", City = " + city + ", Job = " + job;
            }
        }

        public ArrayList arrayList = new ArrayList();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Record record;
            record.name= textBox1.Text;
            record.surname = textBox2.Text;
            record.fatherName = textBox3.Text;
            record.city = textBox4.Text;
            record.job = textBox5.Text;
            arrayList.Add(record);
            label7.Text = arrayList.Count.ToString();
            label9.Text = arrayList.Capacity.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            for(int i = 0; i <= arrayList.Count - 1; i++)
                form2.listBox1.Items.Add(arrayList[i].ToString());
            form2.Show();
        }
    }
}

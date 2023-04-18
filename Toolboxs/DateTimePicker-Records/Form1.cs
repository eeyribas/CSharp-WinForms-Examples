using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DateTimePicker_Records
{
    public partial class Form1 : Form
    {
        struct Student
        {
            public string name, fatherName, city;
            public DateTime birthDay, recordDate, date;
            public bool finish;

            public override string ToString()
            {
                string s1, s2;
                s1 = name;
                s1 = s1.PadRight(20);
                s2 = s1;

                s1 = fatherName;
                s1 = s1.PadRight(10);
                s2 = s2 + s1;

                s1 = city;
                s1 = s1.PadRight(10);
                s2 = s2 + s1;

                s1 = birthDay.ToShortDateString();
                s1 = s1.PadRight(11);
                s2 = s2 + s1;

                s1 = recordDate.ToShortDateString();
                s1 = s1.PadRight(11);
                s2 = s2 + s1;

                if(finish)
                    s1 = date.ToShortDateString();
                else
                    s1 = "Error";

                s1 = s1.PadRight(12);
                s2 = s2 + s1;

                return s2;
            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker2.Format = DateTimePickerFormat.Short;
            dateTimePicker3.Format = DateTimePickerFormat.Short;

            dateTimePicker1.MaxDate = DateTime.Now;
            dateTimePicker2.MaxDate = DateTime.Now;
            dateTimePicker3.MaxDate = DateTime.Now;

            dateTimePicker3.ShowCheckBox = true;
            listBox1.Font = new Font("Courier New", 8, FontStyle.Regular);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Student student;
            student.name = textBox1.Text;
            student.fatherName = textBox2.Text;
            student.city = textBox3.Text;
            student.birthDay = dateTimePicker1.Value;
            student.recordDate = dateTimePicker2.Value;
            student.date = dateTimePicker3.Value;

            if(dateTimePicker3.Checked)
                student.finish = true;
            else
                student.finish = false;

            if (student.date >= student.recordDate)
            {
                MessageBox.Show("Error1");
                return;
            }

            if(student.finish)
            {
                if(student.recordDate > student.date)
                {
                    MessageBox.Show("Error2");
                    return;
                }
            }
                
            listBox1.Items.Add(student);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Remove(listBox1.SelectedItem);
        }
    }
}

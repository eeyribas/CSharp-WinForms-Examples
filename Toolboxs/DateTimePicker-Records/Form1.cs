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
            public string fullName, fatherName, city;
            public DateTime birthDay, recordDate, date;
            public bool finish;

            public override string ToString()
            {
                string str1, str2;

                str1 = fullName;
                str1 = str1.PadRight(20);
                str2 = str1;

                str1 = fatherName;
                str1 = str1.PadRight(10);
                str2 += str1;

                str1 = city;
                str1 = str1.PadRight(10);
                str2 += str1;

                str1 = birthDay.ToShortDateString();
                str1 = str1.PadRight(11);
                str2 += str1;

                str1 = recordDate.ToShortDateString();
                str1 = str1.PadRight(11);
                str2 += str1;

                if (finish)
                    str1 = date.ToShortDateString();
                else
                    str1 = "Error";

                str1 = str1.PadRight(12);
                str2 += str1;

                return str2;
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
            student.fullName = textBox1.Text;
            student.fatherName = textBox2.Text;
            student.city = textBox3.Text;
            student.birthDay = dateTimePicker1.Value;
            student.recordDate = dateTimePicker2.Value;
            student.date = dateTimePicker3.Value;

            if (dateTimePicker3.Checked)
                student.finish = true;
            else
                student.finish = false;

            if (student.date >= student.recordDate)
            {
                MessageBox.Show("Error1");
                return;
            }

            if (student.finish)
            {
                if (student.recordDate > student.date)
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

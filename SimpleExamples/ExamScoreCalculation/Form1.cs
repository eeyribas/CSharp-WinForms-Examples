using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamScoreCalculation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            this.AcceptButton = button1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int midtermGrade, finalExamGrade, makeupExamGrade;

            try
            {
                midtermGrade = int.Parse(textBox1.Text);
                finalExamGrade = int.Parse(textBox2.Text);
            }
            catch
            {
                MessageBox.Show("Valid numbers have not been entered for the midterm and final.");
                return;
            }

            float average = midtermGrade * 40 / 100 + finalExamGrade * 60 / 100;
            if (average >= 49.5 && finalExamGrade >= 50)
            {
                MessageBox.Show("You passed. Your average : " + average.ToString());
            }
            else
            {
                MessageBox.Show("You failed the make-up exam.");
                try
                {
                    makeupExamGrade = int.Parse(textBox3.Text);
                }
                catch
                {
                    MessageBox.Show("A valid score has not been entered for the make-up exam.");
                    return;
                }

                average = midtermGrade * 40 / 100 + makeupExamGrade * 60 / 100;
                if (average >= 49.5 && makeupExamGrade >= 50)
                    MessageBox.Show("You passed the make-up exam. Your average : " + average.ToString());
                else
                    MessageBox.Show("You failed. Your average : " + average.ToString());
            }
        }
    }
}

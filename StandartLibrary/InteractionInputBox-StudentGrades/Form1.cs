using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InteractionInputBox_StudentGrades
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int count = int.Parse(Interaction.InputBox("Enter the number of students", " Input", "10", 0, 0));
            string[] names = new string[count];
            int[] notes = new int[count];

            for (int i = 0; i <= count - 1; i++)
            {
                names[i] = Interaction.InputBox((i + 1).ToString() + " name of student with the number:", "Name Input", "", 0, 0);
                notes[i] = int.Parse(Interaction.InputBox((i + 1).ToString() + " name of student with the number:", "Name Input", "50", 0, 0));
            }

            for (int i = 0; i <= count - 1; i++)
            {
                if (notes[i] >= 50)
                    listBox1.Items.Add(names[i] + "--> Geçti");
                else
                    listBox1.Items.Add(names[i] + "--> Kaldı");
            }
        }
    }
}

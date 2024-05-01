using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CharacterGroups
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listBox1.Font = new Font("Courier New", 16, FontStyle.Bold);
            listBox1.MultiColumn = true;
            listBox1.ColumnWidth = 125;

            comboBox1.Items.Add("All Characters");
            comboBox1.Items.Add("Control");
            comboBox1.Items.Add("Digit");
            comboBox1.Items.Add("Letter");
            comboBox1.Items.Add("Lower");
            comboBox1.Items.Add("Number");
            comboBox1.Items.Add("Symbol");
            comboBox1.Items.Add("Upper");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            for (int i = (int)Char.MinValue; i <= (int)Char.MaxValue; i++)
            {
                char ch = (char)i;
                string str = i.ToString().PadLeft(6, ' ') + "  " + ch;

                switch (comboBox1.SelectedIndex)
                {
                    case 0:
                        listBox1.Items.Add(str);
                        break;
                    case 1:
                        if (Char.IsControl(ch))
                            listBox1.Items.Add(str);
                        break;
                    case 2:
                        if (Char.IsDigit(ch))
                            listBox1.Items.Add(str);
                        break;
                    case 3:
                        if (Char.IsLetter(ch))
                            listBox1.Items.Add(str);
                        break;
                    case 4:
                        if (Char.IsLower(ch))
                            listBox1.Items.Add(str);
                        break;
                    case 5:
                        if (Char.IsNumber(ch))
                            listBox1.Items.Add(str);
                        break;
                    case 6:
                        if (Char.IsSymbol(ch))
                            listBox1.Items.Add(str);
                        break;
                    case 7:
                        if (Char.IsUpper(ch))
                            listBox1.Items.Add(str);
                        break;
                }
            }
        }

        private void comboBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}

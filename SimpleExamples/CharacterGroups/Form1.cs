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
            listBox.Font = new Font("Courier New", 16, FontStyle.Bold);
            listBox.MultiColumn = true;
            listBox.ColumnWidth = 125;
            comboBox.Items.Add("Tüm Karakterler");
            comboBox.Items.Add("Control");
            comboBox.Items.Add("Digit");
            comboBox.Items.Add("Letter");
            comboBox.Items.Add("Lower");
            comboBox.Items.Add("Number");
            comboBox.Items.Add("Symbol");
            comboBox.Items.Add("Upper");
        }

        private void comboBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox.Items.Clear();
            for (int i = (int)Char.MinValue; i <= (int)Char.MaxValue; i++)
            {
                char c = (char)i;
                string s = i.ToString().PadLeft(6, ' ') + "  " + c;
                switch (comboBox.SelectedIndex)
                {
                    case 0:
                        listBox.Items.Add(s);
                        break;
                    case 1:
                        if (Char.IsControl(c))
                            listBox.Items.Add(s);
                        break;
                    case 2:
                        if (Char.IsDigit(c))
                            listBox.Items.Add(s);
                        break;
                    case 3:
                        if (Char.IsLetter(c))
                            listBox.Items.Add(s);
                        break;
                    case 4:
                        if (Char.IsLower(c))
                            listBox.Items.Add(s);
                        break;
                    case 5:
                        if (Char.IsNumber(c))
                            listBox.Items.Add(s);
                        break;
                    case 6:
                        if (Char.IsSymbol(c))
                            listBox.Items.Add(s);
                        break;
                    case 7:
                        if (Char.IsUpper(c))
                            listBox.Items.Add(s);
                        break;
                }
            }
        }
    }
}

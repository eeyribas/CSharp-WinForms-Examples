using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Char_CharacterGroups
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Control");
            comboBox1.Items.Add("Digit");
            comboBox1.Items.Add("Letter");
            comboBox1.Items.Add("LetterOrDigit");
            comboBox1.Items.Add("Lower");
            comboBox1.Items.Add("Number");
            comboBox1.Items.Add("Punctuation");
            comboBox1.Items.Add("Separator");
            comboBox1.Items.Add("Surrogate");
            comboBox1.Items.Add("Symbol");
            comboBox1.Items.Add("Upper");
            comboBox1.Items.Add("WhiteSpace");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Font = new Font("Courier new", 10, FontStyle.Regular);

            listBox1.Items.Clear();
            listBox1.Items.Add("Karakter Kodu    Karakter");
            listBox1.Items.Add("-------------    --------");
            for (int i = 0; i <= 255; i++)
            {
                string str = i.ToString().PadLeft(8, ' ');
                str += "           " + (char)i;

                switch (comboBox1.Text)
                {
                    case "Control":
                        if (Char.IsControl((char)i))
                            listBox1.Items.Add(str);
                        break;
                    case "Digit":
                        if (Char.IsDigit((char)i))
                            listBox1.Items.Add(str);
                        break;
                    case "Letter":
                        if (Char.IsLetter((char)i))
                            listBox1.Items.Add(str);
                        break;
                    case "LetterOrDigit":
                        if (Char.IsLetterOrDigit((char)i))
                            listBox1.Items.Add(str);
                        break;
                    case "Lower":
                        if (Char.IsLower((char)i))
                            listBox1.Items.Add(str);
                        break;
                    case "Number":
                        if (Char.IsNumber((char)i))
                            listBox1.Items.Add(str);
                        break;
                    case "Punctuation":
                        if (Char.IsPunctuation((char)i))
                            listBox1.Items.Add(str);
                        break;
                    case "Separator":
                        if (Char.IsSeparator((char)i))
                            listBox1.Items.Add(str);
                        break;
                    case "Surrogate":
                        if (Char.IsSurrogate((char)i))
                            listBox1.Items.Add(str);
                        break;
                    case "Symbol":
                        if (Char.IsSymbol((char)i))
                            listBox1.Items.Add(str);
                        break;
                    case "Upper":
                        if (Char.IsUpper((char)i))
                            listBox1.Items.Add(str);
                        break;
                    case "WhiteSpace":
                        if (Char.IsWhiteSpace((char)i))
                            listBox1.Items.Add(str);
                        break;
                }
            }
        }
    }
}

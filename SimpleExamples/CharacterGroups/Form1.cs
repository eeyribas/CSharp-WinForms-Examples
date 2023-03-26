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
            Lst.Font = new Font("Courier New", 16, FontStyle.Bold);
            Lst.MultiColumn = true;
            Lst.ColumnWidth = 125;
            Cmb.Items.Add("Tüm Karakterler");
            Cmb.Items.Add("Control");
            Cmb.Items.Add("Digit");
            Cmb.Items.Add("Letter");
            Cmb.Items.Add("Lower");
            Cmb.Items.Add("Number");
            Cmb.Items.Add("Symbol");
            Cmb.Items.Add("Upper");
        }

        private void Cmb_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void Cmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            Lst.Items.Clear();
            for(int i = (int)Char.MinValue; i <= (int)Char.MaxValue; i++) {
                char c = (char)i;
                string s = i.ToString().PadLeft(6, ' ') + "  " + c;
                switch (Cmb.SelectedIndex) {
                    case 0: 
                        Lst.Items.Add(s); 
                        break;
                    case 1: 
                        if (Char.IsControl(c)) 
                            Lst.Items.Add(s); 
                        break;
                    case 2: 
                        if (Char.IsDigit(c)) 
                            Lst.Items.Add(s); 
                        break;
                    case 3: 
                        if (Char.IsLetter(c)) 
                            Lst.Items.Add(s); 
                        break;
                    case 4: 
                        if (Char.IsLower(c)) 
                            Lst.Items.Add(s); 
                        break;
                    case 5: 
                        if (Char.IsNumber(c)) 
                            Lst.Items.Add(s);
                        break;
                    case 6: 
                        if (Char.IsSymbol(c)) 
                            Lst.Items.Add(s); 
                        break;
                    case 7: 
                        if (Char.IsUpper(c)) 
                            Lst.Items.Add(s); 
                        break;
                }
            }
        }
    }
}

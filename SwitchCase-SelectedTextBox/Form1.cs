using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SwitchCase_SelectedTextBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        void Txt_Enter(object sender, EventArgs e)
        {
            switch ((sender as Control).Name) {
                case "Txt1": 
                    Cmb.SelectedIndex = 0; 
                    break;
                case "Txt2": 
                    Cmb.SelectedIndex = 1; 
                    break;
                case "Txt3": 
                    Cmb.SelectedIndex = 2; 
                    break;
                case "Txt4": 
                    Cmb.SelectedIndex = 3; 
                    break;
            }
        }

        private void Cmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch(Cmb.SelectedIndex) {
                case 0: 
                    Txt1.Focus(); 
                    Txt1.SelectAll(); 
                    break;
                case 1: 
                    Txt2.Focus(); 
                    Txt2.SelectAll(); 
                    break;
                case 2:
                    Txt3.Focus(); 
                    Txt3.SelectAll(); 
                    break;
                case 3: 
                    Txt4.Focus(); 
                    Txt4.SelectAll(); 
                    break;
            }
        }

        private void Cmb_Enter(object sender, EventArgs e)
        {
            Cmb.SelectedIndex = -1;
        }

        private void Cmb_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form_KeyUp_KeyDown_KeyPress
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            label1.Text = "KeyPress"
                        + "\nKeyChar : " + e.KeyChar
                        + "\nHandled : " + e.Handled;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            label2.Text = "KeyDown"
                        + "\nAlt : " + e.Alt
                        + "\nControl : " + e.Control
                        + "\nShift : " + e.Shift
                        + "\nKeyCode : " + e.KeyCode
                        + "\nKeyData : " + e.KeyData
                        + "\nKeyValue : " + e.KeyValue
                        + "\nHandled : " + e.Handled
                        + "\nModifiers : " + e.Modifiers
                        + "\nSuppressKeyPress : " + e.SuppressKeyPress;
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            label1.ResetText();
            label2.ResetText();
        }
    }
}

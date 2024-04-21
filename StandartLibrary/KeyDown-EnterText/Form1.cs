using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KeyDown_EnterText
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.AutoSize = false;
            textBox2.AutoSize = false;
            textBox3.AutoSize = false;

            textBox2.KeyDown += new KeyEventHandler(textBox1_KeyDown);
            textBox3.KeyDown += new KeyEventHandler(textBox1_KeyDown);
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            // Directional keys
            if (e.Control)
            {
                switch (e.KeyCode)
                {
                    case Keys.Left:
                        (sender as TextBox).Left = (sender as TextBox).Left - 5;
                        break;
                    case Keys.Right:
                        (sender as TextBox).Left = (sender as TextBox).Left + 5;
                        break;
                    case Keys.Up:
                        (sender as TextBox).Top = (sender as TextBox).Top - 5;
                        break;
                    case Keys.Down:
                        (sender as TextBox).Top = (sender as TextBox).Top + 5;
                        break;
                }
            }

            // Alt key
            if (e.Alt)
            {
                switch (e.KeyCode)
                {
                    case Keys.Left:
                        (sender as TextBox).Width = (sender as TextBox).Width - 5;
                        break;
                    case Keys.Right:
                        (sender as TextBox).Width = (sender as TextBox).Width + 5;
                        break;
                    case Keys.Up:
                        (sender as TextBox).Height = (sender as TextBox).Height - 5;
                        break;
                    case Keys.Down:
                        (sender as TextBox).Height = (sender as TextBox).Height + 5;
                        break;
                }
            }

            // F5 key
            if (e.KeyCode == Keys.F5)
            {
                // Alt-F5
                if (e.Alt)
                    (sender as TextBox).Text = (sender as TextBox).Text.ToUpper();
                //Ctrl-F5
                if (e.Control)
                    (sender as TextBox).Text = (sender as TextBox).Text.ToLower();
            }

            //Shift BackSpace
            if (e.Shift && (e.KeyCode == Keys.Back))
                (sender as TextBox).Text = "";

            //F10
            if (e.KeyCode == Keys.F10)
                Close();

            this.Text = "The numerical code of the key you pressed:" + e.KeyValue.ToString() + " Symbolic Name:" + e.KeyCode.ToString();
        }
    }
}

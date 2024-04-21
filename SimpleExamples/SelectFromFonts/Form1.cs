using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SelectFromFonts
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            FontFamily[] fonts = FontFamily.Families;

            for(int i = 0; i <= fonts.Length - 1; i++)
                listBox1.Items.Add(fonts[i].Name);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                textBox1.Font = new Font(listBox1.SelectedItem.ToString(), 14, FontStyle.Regular);
            }
            catch
            {
                MessageBox.Show("Font isn't showing.");
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CharacterCodes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "Character Codes";
            listBox1.Font = new Font("Courier New", 20, FontStyle.Regular);
            listBox1.MultiColumn = true;
            listBox1.ColumnWidth = 150;
            for (int i = 32; i <= 65535; i++)
                listBox1.Items.Add(i.ToString() + "=" + (char)i);
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainMenu_CreatingWithCode
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 8; i <= 20; i += 2)
                menuItem1.MenuItems.Add(i.ToString(), new EventHandler(menuItem1_Click));
        }

        private void menuItem1_Click(object sender, EventArgs e)
        {
            int size = int.Parse((sender as MenuItem).Text);
            textBox1.Font = new Font(textBox1.Font.FontFamily, size, textBox1.Font.Style);
        }
    }
}

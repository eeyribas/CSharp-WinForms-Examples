using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form_CreateFormsAndTransitions
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            Random random = new Random();
            Left = random.Next(200);
            Top = random.Next(200);
            Lbl.Text = Form1.x.ToString();
        }
    }
}

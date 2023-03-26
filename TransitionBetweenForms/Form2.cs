using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TransitionBetweenForms
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            Tmr.Interval = 3000;
            Tmr.Enabled = true;
        }

        private void Tmr_Tick(object sender, EventArgs e)
        {
            Close();
        }
    }
}

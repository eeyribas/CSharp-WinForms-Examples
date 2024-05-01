using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OpenOnlyFormWithAnotherForm
{
    public partial class Form1 : Form
    {
        private Form2 form2;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (form2 == null)
            {
                form2 = new Form2();
                form2.Closed += new EventHandler(Closed);
                form2.Show();
            }
            else
            {
                form2.Activate();
            }
        }

        private void Closed(object sender, System.EventArgs e)
        {
            form2 = null;
        }
    }
}

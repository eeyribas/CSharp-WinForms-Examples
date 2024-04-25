using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeleteTmpFile
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label2.Text = Path.GetTempPath();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string tmpFileName = Path.GetTempPath();
                DirectoryInfo directoryInfo = new DirectoryInfo(tmpFileName);
                directoryInfo.Delete(true);
            }
            catch (Exception exception)
            {
                MessageBox.Show("There was an issue while deleting the temporary folder.\r\n" + exception.Message);
            }
        }
    }
}

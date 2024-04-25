using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StreamWriter_CreatingTemporaryFile
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string tmpFileName = Path.GetTempFileName();
            MessageBox.Show(tmpFileName + " created file.");

            FileInfo fileInfo = new FileInfo(tmpFileName);
            FileStream fileStream = new FileStream(tmpFileName, FileMode.Open);
            StreamWriter streamWriter = new StreamWriter(fileStream);
            streamWriter.WriteLine("Useless information.");
            streamWriter.WriteLine("This is useless information.");
            streamWriter.Close();
            fileStream.Close();
            fileInfo.Refresh();
            MessageBox.Show("The temporary file has been written to.");

            Process.Start("notepad.exe", tmpFileName);
            MessageBox.Show("It has been deleted.");
            fileInfo.Delete();
            MessageBox.Show("The temporary file has been deleted.");
        }
    }
}

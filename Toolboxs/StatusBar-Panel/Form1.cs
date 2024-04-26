using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StatusBar_Panel
{
    public partial class Form1 : Form
    {
        [DllImport("kernel32.dll")]
        public static extern int GetDiskFreeSpaceExA(string lpRootPathName, ref long lpFreeBytesAvailableToCaller,
                                               ref long lpTotalNumberOfBytes, ref long lpTotalNumberOfFreeBytes);

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
            timer1.Interval = 1000;
            timer1.Enabled = true;
            statusBar1.Panels[0].ToolTipText = "Disk Capacity";
            statusBar1.Panels[1].ToolTipText = "Screen resolution";
            statusBar1.Panels[2].ToolTipText = "Status of Keys";
            statusBar1.Panels[3].ToolTipText = "Hour";

            long x = 0, y = 0, z = 0;
            string str = "";
            string[] drivers = Directory.GetLogicalDrives();
            for (int i = 0; i <= drivers.GetUpperBound(0); i++)
            {
                y = 0;
                GetDiskFreeSpaceExA(drivers[i], ref x, ref y, ref z);

                if (y > 1024 * 1024 * 1024)
                    str += drivers[i] + "=" + (y / 1024 / 1024 / 1024).ToString() + "GB" + " ";
                else
                    str += drivers[i] + "=" + (y / 1024 / 1024).ToString() + "MB" + " ";
            }
            statusBar1.Panels[0].Text = str;

            Rectangle rectangle = new Rectangle();
            rectangle = Screen.GetBounds(rectangle);
            statusBar1.Panels[1].Text = rectangle.Width.ToString() + "x" + rectangle.Height.ToString();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            statusBar1.Panels[2].Text = e.KeyData.ToString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            statusBar1.Panels[3].Text = DateTime.Now.TimeOfDay.ToString();
        }
    }
}

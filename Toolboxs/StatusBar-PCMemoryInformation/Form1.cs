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

namespace StatusBar_PCMemoryInformation
{
    public partial class Form1 : Form
    {
        [DllImport("kernel32.dll")]
        public static extern int GetDiskFreeSpaceExA(string lpRootPathName, ref long lpFreeBytesAvailableToCaller,
                                                     ref long lpTotalNumberOfBytes, ref long lpTotalNumberOfFreeBytes);
        private float[] percentages;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            statusBar1.ShowPanels = true;

            long x = 0, y = 0, z = 0;
            string[] drivers = Directory.GetLogicalDrives();
            percentages = new float[drivers.Length];
            StatusBarPanel statusBarPanel;

            for (int i = 0; i <= drivers.GetUpperBound(0); i++)
            {
                y = 0;
                z = 0;
                GetDiskFreeSpaceExA(drivers[i], ref x, ref y, ref z);
                string str = drivers[i];
                statusBarPanel = statusBar1.Panels.Add(str);
                statusBarPanel.Style = StatusBarPanelStyle.OwnerDraw;
                statusBarPanel.AutoSize = StatusBarPanelAutoSize.Spring;

                if (y == 0)
                    percentages[i] = 0;
                else
                    percentages[i] = (float)z / y * 100;

                statusBarPanel.ToolTipText = drivers[i] + "=" + (y / 1024 / 1024).ToString() + " MB Full, " + 
                                             (z / 1024 / 1024).ToString() + " MB Empty";
            }

            statusBarPanel = statusBar1.Panels.Add("Hour");
            statusBarPanel.ToolTipText = "Hour";
            statusBarPanel.Style = StatusBarPanelStyle.OwnerDraw;
            statusBarPanel.Width = (int)(statusBar1.Height * 1.5);

            timer1.Interval = 1000;
            timer1.Enabled = true;
        }

        private void statusBar1_DrawItem(object sender, StatusBarDrawItemEventArgs sbdevent)
        {
            Rectangle rectangle = new Rectangle();
            rectangle = sbdevent.Bounds;

            if (sbdevent.Index < percentages.Length)
            {
                sbdevent.Graphics.DrawString(sbdevent.Panel.Text, new Font("Tahoma", 12, FontStyle.Bold), Brushes.Blue, sbdevent.Bounds.Left, 
                                             sbdevent.Bounds.Top);
                rectangle.X = sbdevent.Bounds.Left + 30;
                sbdevent.Graphics.FillRectangle(Brushes.Blue, rectangle);
                rectangle.Width = (int)((sbdevent.Bounds.Width - 30) * (1 - percentages[sbdevent.Index] / 100));
                sbdevent.Graphics.FillRectangle(Brushes.Red, rectangle);
                sbdevent.Graphics.DrawString("%" + ((int)percentages[sbdevent.Index]).ToString() + " empty", new Font("Tahoma", 8, FontStyle.Bold), 
                                             Brushes.White, sbdevent.Bounds.Left + 30, sbdevent.Bounds.Top);
            }
            else
            {
                sbdevent.Graphics.DrawRectangle(new Pen(Color.Red), rectangle);
                float xMiddle = rectangle.Left + rectangle.Width / 2;
                float yMiddle = rectangle.Top + rectangle.Height / 2;

                float diameter;
                if (rectangle.Width > rectangle.Height)
                    diameter = rectangle.Height / 2;
                else
                    diameter = rectangle.Width / 2;
    
                int hour = DateTime.Now.Hour;
                int angle = -hour * 30 + 90;
                float sX = (float)(xMiddle + diameter * 2 / 3 * Math.Cos(angle * 3.1415 / 180));
                float sY = (float)(yMiddle - diameter * 2 / 3 * Math.Sin(angle * 3.1415 / 180));
                sbdevent.Graphics.DrawLine(new Pen(Color.Red, 2), xMiddle, yMiddle, sX, sY);

                int minute = DateTime.Now.Minute;
                angle = -minute * 6 + 90;
                sX = (float)(xMiddle + diameter * Math.Cos(angle * 3.1415 / 180));
                sY = (float)(yMiddle - diameter * Math.Sin(angle * 3.1415 / 180));
                sbdevent.Graphics.DrawLine(new Pen(Color.Blue, 2), xMiddle, yMiddle, sX, sY);

                int second = DateTime.Now.Second;
                angle = -second * 6 + 90;
                sX = (float)(xMiddle + diameter * Math.Cos(angle * 3.1415 / 180));
                sY = (float)(yMiddle - diameter * Math.Sin(angle * 3.1415 / 180));
                sbdevent.Graphics.DrawLine(new Pen(Color.Black, 1), xMiddle, yMiddle, sX, sY);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            statusBar1.Panels[percentages.Length].Text = DateTime.UtcNow.ToString();
        }
    }
}

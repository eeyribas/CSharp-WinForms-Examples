using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NumericUpDown_Date
{
    public partial class Form1 : Form
    {
        public struct SystemTime
        {
            public short year;
            public short month;
            public short dayOfWeek;
            public short day;
            public short hour;
            public short minute;
            public short second;
            public short milliseconds;
        }

        public class DateTimeSettings
        {
            [DllImport("kernel32.dll")]
            public static extern bool GetLocalTime(ref SystemTime systemTime);
            [DllImport("kernel32.dll")]
            public static extern bool SetLocalTime(ref SystemTime systemTime);

            public void TimeSetting(short hour, short minute, short second)
            {
                SystemTime systemTime = new SystemTime();
                GetLocalTime(ref systemTime);
                systemTime.hour = hour;
                systemTime.minute = minute;
                systemTime.second = second;
                SetLocalTime(ref systemTime);
            }

            public void DateSetting(short day, short month, short year)
            {
                SystemTime systemTime = new SystemTime();
                GetLocalTime(ref systemTime);
                systemTime.day = day;
                systemTime.month = month;
                systemTime.year = year;
                SetLocalTime(ref systemTime);
            }
        }

        private bool state;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            state = true;

            numericUpDown1.Minimum = 1;
            numericUpDown2.Minimum = 1;
            numericUpDown3.Minimum = 1;
                                       
            numericUpDown1.Maximum = 31;
            numericUpDown2.Maximum = 12;
            numericUpDown3.Maximum = 9999;
                                          
            numericUpDown4.Maximum = 23;
            numericUpDown5.Maximum = 59;
            numericUpDown6.Maximum = 59;
                                        
            numericUpDown1.ReadOnly = true;
            numericUpDown2.ReadOnly = true;
            numericUpDown3.ReadOnly = true;
            numericUpDown4.ReadOnly = true;
            numericUpDown5.ReadOnly = true;
            numericUpDown6.ReadOnly = true;
           
            numericUpDown1.Value = DateTime.Now.Day;
            numericUpDown2.Value = DateTime.Now.Month;
            numericUpDown3.Value = DateTime.Now.Year;
            
            numericUpDown4.Value = DateTime.Now.Hour;
            numericUpDown5.Value = DateTime.Now.Minute;
            numericUpDown6.Value = DateTime.Now.Second;
            state = false;

            numericUpDown2.ValueChanged += new EventHandler(numericUpDown1_ValueChanged);
            numericUpDown3.ValueChanged += new EventHandler(numericUpDown1_ValueChanged);
            numericUpDown4.ValueChanged += new EventHandler(numericUpDown1_ValueChanged);
            numericUpDown5.ValueChanged += new EventHandler(numericUpDown1_ValueChanged);
            numericUpDown6.ValueChanged += new EventHandler(numericUpDown1_ValueChanged);
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            if (state)
                return;

            try
            {
                DateTimeSettings dateTimeSettings = new DateTimeSettings();
                dateTimeSettings.DateSetting((short)numericUpDown1.Value, (short)numericUpDown2.Value, (short)numericUpDown3.Value);
                dateTimeSettings.TimeSetting((short)numericUpDown4.Value, (short)numericUpDown5.Value, (short)numericUpDown6.Value);
            }
            catch
            {
                MessageBox.Show("The date or time is invalid!");
            }
        }
    }
}

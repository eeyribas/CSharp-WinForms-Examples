using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GalatasarayFootballClubCalendar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            numericUpDown1.Minimum = 1;
            numericUpDown1.Maximum = 12;
            numericUpDown2.Minimum = 1;
            numericUpDown2.Maximum = 9999;
            numericUpDown1.Value = DateTime.Now.Month;
            numericUpDown2.Value = DateTime.Now.Year;
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Draw();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            Draw();
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            Draw();
        }

        private void Draw()
        {
            Font monthFont = new Font("Tahoma", 14, FontStyle.Bold);
            Font dayNameFont = new Font("Tahoma", 10, FontStyle.Bold);
            Font dayFont = new Font("Tahoma", 16, FontStyle.Regular);
            Font weekFont = new Font("Tahoma", 16, FontStyle.Bold);

            DateTime dateTime;
            int month = (int)numericUpDown1.Value;
            int year = (int)numericUpDown2.Value;

            try
            {
                dateTime = new DateTime(year, month, 1);
            }
            catch
            {
                return;
            }

            dateTime = new DateTime(year, month, 1);
            Graphics graphics = CreateGraphics();
            graphics.Clear(Color.Brown);
            string str = dateTime.ToString("MMMM") + " " + year + " Takvimi";
            graphics.DrawString(str, monthFont, new SolidBrush(Color.Yellow), 10, 50);

            int y = 90;
            int x = 10;
            graphics.DrawString("Week", dayNameFont, new SolidBrush(Color.Cyan), x, y);
            x += 50;
            string[] days = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
            for (int i = 1; i <= 7; i++)
            {
                graphics.DrawString(days[i - 1], dayNameFont, new SolidBrush(Color.Cyan), x, y);
                x += 80;
            }

            y += 50;
            x = 10;
            int start = (int)dateTime.DayOfWeek;
            if (start == 0)
                start = 7;

            int week = Thread.CurrentThread.CurrentCulture.Calendar.GetWeekOfYear(dateTime, CalendarWeekRule.FirstDay, DayOfWeek.Monday);
            int day = 0;
            for (int i = week; i <= week + 6; i++)
            {
                graphics.DrawString(i.ToString(), weekFont, new SolidBrush(Color.DarkCyan), x, y);
                for (int j = start; j <= 7; j++)
                {
                    day += 1;
                    if (day > DateTime.DaysInMonth(year, month))
                        break;

                    if ((j == 6) || (j == 7))
                        graphics.DrawString(day.ToString(), dayFont, new SolidBrush(Color.LightGreen), x + j * 80, y);
                    else
                        graphics.DrawString(day.ToString(), dayFont, new SolidBrush(Color.Yellow), x + j * 80, y);
                }

                start = 1;
                if (day > DateTime.DaysInMonth(year, month))
                    break;
                y += 50;
            }
            graphics.Dispose();
        }
    }
}

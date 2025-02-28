using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FindingGregorianAndHijriDates
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label3.Text = DateTime.Now.ToString("d-MMMM-yyyy");

            HijriCalendar hijri = new HijriCalendar();
            DateTime hijriDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, DateTime.Now.Hour,
                                              DateTime.Now.Minute, DateTime.Now.Second, HijriCalendar.CurrentEra);

            string[] months = { "Muharrem", "Safer", "Rebiül Evvel", "Rebiül Ahir", "Cemaziyel Evvel", "Cemaziyel Ahir", 
                                "Recep", "Şaban", "Ramazan", "Şevval", "Zilkadde", "Zilhicce" };
            int hDay = hijri.GetDayOfMonth(hijriDate);
            int hMonth = hijri.GetMonth(hijriDate);
            int hYear = hijri.GetYear(hijriDate);
            label4.Text = hDay.ToString() + "-" + months[hMonth - 1] + '-' + hYear.ToString();
        }
    }
}

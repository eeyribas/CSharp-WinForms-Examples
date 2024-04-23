using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MonthCalendar
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
            numericUpDown2.Maximum = 12;
            monthCalendar1.ShowWeekNumbers = true;

            DateTime[] holidayDays = {new DateTime( 2000,1,1),
                                      new DateTime(2000,4,23),
                                      new DateTime(2000,5,19), 
                                      new DateTime(2000,10,29) };
            monthCalendar1.AnnuallyBoldedDates = holidayDays;
            numericUpDown2.ValueChanged += new EventHandler(numericUpDown1_ValueChanged);
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            if (numericUpDown1.Value * numericUpDown2.Value == 0)
                return;
            if (numericUpDown1.Value * numericUpDown2.Value > 12)
                MessageBox.Show("The row-column multiplication cannot exceed 12.");
            else
                monthCalendar1.CalendarDimensions = new Size((int)numericUpDown1.Value, (int)numericUpDown2.Value);
        }
    }
}

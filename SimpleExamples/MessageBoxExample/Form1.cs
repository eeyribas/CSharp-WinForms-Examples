using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MessageBoxExample
{
    public partial class Form1 : Form
    {
        MessageBoxButtons bType;
        MessageBoxIcon iType;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Rdo1.Text = "Ok";
            Rdo2.Text = "OKCancel";
            Rdo3.Text = "RetryCancel";
            Rdo4.Text = "YesNo";
            Rdo5.Text = "YesNoCancel";
            Rdo6.Text = "AbortRetryIgnore";
            Rdo7.Text = "Asterisk";
            Rdo8.Text = "Error";
            Rdo9.Text = "Exclamation";
            Rdo10.Text = "Hand";
            Rdo11.Text = "Information";
            Rdo12.Text = "None";
            Rdo13.Text = "Question";
            Rdo14.Text = "OkStop";
            Rdo15.Text = "Warning";
            Rdo1.Checked = true;
            Rdo7.Checked = true;
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            DialogResult state = MessageBox.Show("Message Box", "Info", bType, iType);
            switch(state) {
                case DialogResult.OK:
                    Lbl.Text = "OK";
                    break;
                case DialogResult.Cancel:
                    Lbl.Text = "Cancel";
                    break;
                case DialogResult.Abort:
                    Lbl.Text = "Abort";
                    break;
                case DialogResult.Retry:
                    Lbl.Text = "Retry";
                    break;
                case DialogResult.Ignore:
                    Lbl.Text = "Ignore";
                    break;
                case DialogResult.Yes:
                    Lbl.Text = "Yes";
                    break;
                case DialogResult.No:
                    Lbl.Text = "No";
                    break;
            }
        }

        void bType_CheckedChanged(object sender, EventArgs e)
        {
            switch ((sender as Control).Name)
            {
                case "Rdo1":
                    bType = MessageBoxButtons.OK;
                    break;
                case "Rdo2":
                    bType = MessageBoxButtons.OKCancel;
                    break;
                case "Rdo3":
                    bType = MessageBoxButtons.RetryCancel;
                    break;
                case "Rdo4":
                    bType = MessageBoxButtons.YesNo;
                    break;
                case "Rdo5":
                    bType = MessageBoxButtons.YesNoCancel;
                    break;
                case "Rdo6":
                    bType = MessageBoxButtons.AbortRetryIgnore;
                    break;
            }
        }

        void iType_CheckedChanged(object sender, EventArgs e)
        {
            switch ((sender as Control).Name)
            {
                case "Rdo7":
                    iType = MessageBoxIcon.Asterisk;
                    break;
                case "Rdo8":
                    iType = MessageBoxIcon.Error;
                    break;
                case "Rdo9":
                    iType = MessageBoxIcon.Exclamation;
                    break;
                case "Rdo10":
                    iType = MessageBoxIcon.Hand;
                    break;
                case "Rdo11":
                    iType = MessageBoxIcon.Information;
                    break;
                case "Rdo12":
                    iType = MessageBoxIcon.None;
                    break;
                case "Rdo13":
                    iType = MessageBoxIcon.Question;
                    break;
                case "Rdo14":
                    iType = MessageBoxIcon.Stop;
                    break;
                case "Rdo15":
                    iType = MessageBoxIcon.Warning;
                    break;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataGridView_CreateRowsAndColumns
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DataTable dataTable = new DataTable();
            DataColumn dataColumn;
            DataRow dataRow;

            dataColumn = new DataColumn("Order No");
            dataColumn.DataType = Type.GetType("System.Int32");
            dataColumn.AutoIncrement = true;
            dataColumn.AutoIncrementStep = 1;
            dataTable.Columns.Add(dataColumn);

            dataColumn = new DataColumn("Name Surname");
            dataColumn.DataType = Type.GetType("System.String");
            dataTable.Columns.Add(dataColumn);

            dataColumn = new DataColumn("Date");
            dataColumn.DataType = Type.GetType("System.DateTime");
            dataTable.Columns.Add(dataColumn);

            dataColumn = new DataColumn("Place");
            dataColumn.DataType = Type.GetType("System.String");
            dataTable.Columns.Add(dataColumn);

            dataGridView1.DataSource = dataTable;

            dataRow = dataTable.NewRow();
            dataRow["Name Surname"] = "Ali";
            dataRow["Date"] = "17/11/1973";
            dataRow["Place"] = "Erzurum";
            dataTable.Rows.Add(dataRow);

            dataRow = dataTable.NewRow();
            dataRow["Name Surname"] = "Veli";
            dataRow["Date"] = "5/5/1985";
            dataRow["Place"] = "Ankara";
            dataTable.Rows.Add(dataRow);
        }
    }
}

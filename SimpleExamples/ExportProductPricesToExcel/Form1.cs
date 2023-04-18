using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExportProductPricesToExcel
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

            dataColumn = new DataColumn("Product Name", Type.GetType("System.String"));
            dataTable.Columns.Add(dataColumn);
            dataColumn = new DataColumn("Piece", Type.GetType("System.Int32"));
            dataTable.Columns.Add(dataColumn);
            dataColumn = new DataColumn("Price", Type.GetType("System.Decimal"));
            dataTable.Columns.Add(dataColumn);
            dataColumn = new DataColumn("Sum", Type.GetType("System.Decimal"));
            dataColumn.Expression = "Piece*[Price]";
            dataTable.Columns.Add(dataColumn);

            dataGridView1.DataSource = dataTable;
        }

        private void dataGridView1_CurrentCellChanged(object sender, EventArgs e)
        {
            Sum();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            saveFileDialog1.DefaultExt = "xml";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                DataTable dataTable = (DataTable)dataGridView1.DataSource;
                DataSet dataSet = new DataSet();

                dataSet.Tables.Add(dataTable);
                dataSet.WriteXml(saveFileDialog1.FileName);
                string xsd = saveFileDialog1.FileName.Substring(saveFileDialog1.FileName.LastIndexOf("."));
                xsd = xsd + ".XSD";
                dataSet.WriteXmlSchema(xsd);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "XML Dosyaları|*.xml";
            openFileDialog1.FilterIndex = 0;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                DataSet dataSet = new DataSet();
                string xsd = openFileDialog1.FileName.Substring(openFileDialog1.FileName.LastIndexOf("."));
                xsd = xsd + ".XSD";

                dataSet.ReadXmlSchema(xsd);
                dataSet.ReadXml(openFileDialog1.FileName);

                DataTable dataTable = dataSet.Tables[0];
                dataGridView1.DataSource = dataTable;
            }
        }

        void Sum()
        {
            DataTable dataTable = (DataTable)dataGridView1.DataSource;
            decimal sum = 0;
            for (int i = 0; i <= dataTable.Rows.Count - 1; i++)
            {
                sum += decimal.Parse(dataGridView1[i, 3].ToString());
                label2.Text = sum.ToString();
            }
        }
    }
}

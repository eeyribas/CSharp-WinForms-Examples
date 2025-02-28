using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArrayList_AddAndList
{
    public partial class Form1 : Form
    {
        struct Data
        {
            public string data1, data2, data3, data4, data5;
            public override string ToString()
            {
                return "Data1=" + data1 + ", Data2=" + data2 + ", Data3=" + data3 + ", Data4=" + data4 + ", Data5=" + data5;
            }
        }

        private ArrayList arrayList = new ArrayList();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Data data;
            data.data1 = textBox1.Text;
            data.data2 = textBox2.Text;
            data.data3 = textBox3.Text;
            data.data4 = textBox4.Text;
            data.data5 = textBox5.Text;
            arrayList.Add(data);

            label7.Text = arrayList.Count.ToString();
            label9.Text = arrayList.Capacity.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            for(int i = 0; i <= arrayList.Count - 1; i++)
                form2.listBox1.Items.Add(arrayList[i].ToString());
            form2.Show();
        }
    }
}

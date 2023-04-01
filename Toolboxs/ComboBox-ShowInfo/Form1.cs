using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComboBox_ShowInfo
{
    public partial class Form1 : Form
    {
        class Provinces
        {
            public string name;
            public string plate;

            public Provinces(string tmpName, string tmpPlate)
            {
                name = tmpName;
                plate = tmpPlate;
            }
          
            public Provinces()
            {
                name = "";
                plate = "";
            }

            public override string ToString()
            {
                return plate + " " + name;
            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Provinces province = new Provinces("Hakkari", "30");
            comboBox1.Items.Add(province);
            Provinces[] provinces = {new Provinces("Ankara",   "06"),
                 new Provinces("İstanbul", "34"),
                 new Provinces("Erzurum",  "25"),
                 new Provinces("Bursa",    "16"),
                 new Provinces("İzmir",    "35")};
            comboBox1.Items.AddRange(provinces);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex < 0)
                return;
            label2.Text = ((Provinces)comboBox1.SelectedItem).name;
            label4.Text = ((Provinces)comboBox1.SelectedItem).plate;
        }
    }
}

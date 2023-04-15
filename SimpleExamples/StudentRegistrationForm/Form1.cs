using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentRegistrationForm
{
    public partial class Form1 : Form
    {
        public int count;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listView1.LargeImageList = imageList1;
            listView1.SmallImageList = imageList2;
        }

        private void ClearListMnsItem_Click(object sender, EventArgs e)
        {
            if (count != 0)
            {
                DialogResult dialogResult;

                dialogResult = MessageBox.Show("Are you sure you want to clear the list?", "Clear", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (dialogResult == DialogResult.Yes && count != 0)
                {
                    while (listView1.Items.Count > 0)
                    {
                        count--;
                        listView1.Items.RemoveAt(listView1.Items[count].Index);
                    }
                }
            }
            else
            {
                MessageBox.Show("No record to be deleted!", "Carefull!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void ClearSelectionMnsItem_Click(object sender, EventArgs e)
        {
            if (listView1.Items.Count > 0 && listView1.SelectedIndices.Count > 0)
            {
                DialogResult dialogResult;

                dialogResult = MessageBox.Show("Are you sure you want to delete the selected one?", "Delete Selected", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dialogResult == DialogResult.Yes)
                {
                    listView1.Items.RemoveAt(listView1.SelectedItems[0].Index); 
                    count--;
                }

            }
            else
            {
                MessageBox.Show("No record to be deleted!", "Carefull!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        public String SelectionGender()
        {
            if (radioButton1.Checked == true) return "Male";
            else return "Female";
        }

        public String SelectionHobbys(String hobby)
        {
            switch (hobby)
            {
                case "Watch Film":
                    {
                        if (checkBox1.Checked == true) return "Available";
                        else return "Empty";

                        break;
                    }
                case "Listen Music":
                    {
                        if (checkBox2.Checked == true) return "Available";
                        else return "Empty";

                        break;
                    }
                case "Make Sports":
                    {
                        if (checkBox3.Checked == true) return "Available";
                        else return "Empty";

                        break;
                    }

                default: return "Empty";

            }
        }

        private int SelectionIcon()
        {
            if (radioButton3.Checked) return 0;
            else if (radioButton5.Checked) return 1;
            else if (radioButton4.Checked) return 2;
            else return 3;
        }

        private void AboutMnsItem_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Location = new Point(222, 333);
            form2.ShowDialog();
        }

        private void Clear()
        {
            textBox1.Text = "";
            radioButton1.Checked = true;
            radioButton3.Checked = true;
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            comboBox2.SelectedIndex = -1;
            listBox1.Items.Clear();
        }

        private void ExitMnsItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddListBtn_MouseMove(object sender, MouseEventArgs e)
        {
            toolStripStatusLabel2.Text = "Please do not press the add button until you have entered all the information correctly.";
        }

        private void AddListBtn_MouseLeave(object sender, EventArgs e)
        {
            toolStripStatusLabel2.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listView1.Items.Add(textBox1.Text, SelectionIcon());
            listView1.Items[count].SubItems.Add(comboBox2.Text);
            listView1.Items[count].SubItems.Add(listBox1.Text);
            listView1.Items[count].SubItems.Add(SelectionGender());
            listView1.Items[count].SubItems.Add(SelectionHobbys("Watch Film"));
            listView1.Items[count].SubItems.Add(SelectionHobbys("List Music"));
            listView1.Items[count].SubItems.Add(SelectionHobbys("Make Sports"));
            count++;
            Clear();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            if (comboBox2.SelectedIndex == 0 || comboBox2.Text == "Kütahya")
            {
                listBox1.Items.Add("Altıntaş");
                listBox1.Items.Add("Aslanapa");
                listBox1.Items.Add("Çavdarhisar");
                listBox1.Items.Add("Domaniç");
                listBox1.Items.Add("Dumlupınar");
                listBox1.Items.Add("Emet");
                listBox1.Items.Add("Gediz");
                listBox1.Items.Add("Hisarcık");
                listBox1.Items.Add("Pazarlar");
                listBox1.Items.Add("Simav");
                listBox1.Items.Add("Şaphane");
                listBox1.Items.Add("Tavşanlı");
            }
            else if (comboBox2.SelectedIndex == 1 || comboBox2.Text == "Bilecik")
            {
                listBox1.Items.Add("Bozüyük");
                listBox1.Items.Add("Gölpazarı");
                listBox1.Items.Add("İnhisar");
                listBox1.Items.Add("Osmaneli");
                listBox1.Items.Add("Pazaryeri");
                listBox1.Items.Add("Söğüt");
                listBox1.Items.Add("Yenipazar");

            }
            else if (comboBox2.SelectedIndex == 2 || comboBox2.Text == "Sakarya")
            {
                listBox1.Items.Add("Adapazarı");
                listBox1.Items.Add("Akyazı");
                listBox1.Items.Add("Ferizli");
                listBox1.Items.Add("Geyve");
                listBox1.Items.Add("Hendek");
                listBox1.Items.Add("Karapürçek");
                listBox1.Items.Add("Karasu");
                listBox1.Items.Add("Kaynarca");
                listBox1.Items.Add("Kocaali");
                listBox1.Items.Add("Pamukova");
                listBox1.Items.Add("Sapanca");
                listBox1.Items.Add("Söğütlü");
                listBox1.Items.Add("Taraklı");
            }
            else if (comboBox2.SelectedIndex == 3 || comboBox2.Text == "Bursa")
            {
                listBox1.Items.Add("Nilüfer");
                listBox1.Items.Add("Yıldırım");
                listBox1.Items.Add("Osman Gazi");
                listBox1.Items.Add("Büyük Orhan");
                listBox1.Items.Add("Gemlik");
                listBox1.Items.Add("Gürsu");
                listBox1.Items.Add("Harmancık");
                listBox1.Items.Add("İnegöl");
                listBox1.Items.Add("İznik");
                listBox1.Items.Add("Karacabey");
                listBox1.Items.Add("Kales");
                listBox1.Items.Add("Kestel");
                listBox1.Items.Add("Mudanya");
                listBox1.Items.Add("Mustafa Kemal Paşa");
                listBox1.Items.Add("Orhaneli");
                listBox1.Items.Add("Orhangazi");
                listBox1.Items.Add("Yenişehir");
            }
            else
            {
                listBox1.Items.Add("Ayancık");
                listBox1.Items.Add("Boyabat");
                listBox1.Items.Add("Dikmen");
                listBox1.Items.Add("Durağan");
                listBox1.Items.Add("Erfelek");
                listBox1.Items.Add("Gerze");
                listBox1.Items.Add("Saraydüzü");
                listBox1.Items.Add("Türkeli");
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            View tur = new View();
            tur = (View)comboBox1.SelectedIndex;
            listView1.View = tur;
        }
    }
}

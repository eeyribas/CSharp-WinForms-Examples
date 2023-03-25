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
            StudentsLvw.LargeImageList = ImgList1;
            StudentsLvw.SmallImageList = ImgList2;
        }

        private void ClearListMnsItem_Click(object sender, EventArgs e)
        {
            if (count != 0)
            {
                DialogResult dialogResult;

                dialogResult = MessageBox.Show("Are you sure you want to clear the list?", "Clear", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (dialogResult == DialogResult.Yes && count != 0)
                {
                    while (StudentsLvw.Items.Count > 0)
                    {
                        count--;
                        StudentsLvw.Items.RemoveAt(StudentsLvw.Items[count].Index);
                    }
                }
            }
            else
            {
                MessageBox.Show("No record to be deleted!", "Carefull!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void AddListBtn_Click(object sender, EventArgs e)
        {
            StudentsLvw.Items.Add(StudentNameTxt.Text, SelectionIcon());
            StudentsLvw.Items[count].SubItems.Add(CityCmb.Text);
            StudentsLvw.Items[count].SubItems.Add(TownLst.Text);
            StudentsLvw.Items[count].SubItems.Add(SelectionGender());
            StudentsLvw.Items[count].SubItems.Add(SelectionHobbys("Watch Film"));
            StudentsLvw.Items[count].SubItems.Add(SelectionHobbys("List Music"));
            StudentsLvw.Items[count].SubItems.Add(SelectionHobbys("Make Sports"));
            count++;
            Clear();
        }

        private void ClearSelectionMnsItem_Click(object sender, EventArgs e)
        {
            if (StudentsLvw.Items.Count > 0 && StudentsLvw.SelectedIndices.Count > 0)
            {
                DialogResult dialogResult;

                dialogResult = MessageBox.Show("Are you sure you want to delete the selected one?", "Delete Selected", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dialogResult == DialogResult.Yes)
                {
                    StudentsLvw.Items.RemoveAt(StudentsLvw.SelectedItems[0].Index); 
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
            if (MaleRadioBtn.Checked == true) return "Male";
            else return "Female";
        }

        public String SelectionHobbys(String hobby)
        {
            switch (hobby)
            {
                case "Watch Film":
                    {
                        if (FilmChk.Checked == true) return "Available";
                        else return "Empty";

                        break;
                    }
                case "Listen Music":
                    {
                        if (MusicChk.Checked == true) return "Available";
                        else return "Empty";

                        break;
                    }
                case "Make Sports":
                    {
                        if (SportChk.Checked == true) return "Available";
                        else return "Empty";

                        break;
                    }

                default: return "Empty";

            }
        }

        private void CityCmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            TownLst.Items.Clear();
            if (CityCmb.SelectedIndex == 0 || CityCmb.Text == "Kütahya")
            {
                TownLst.Items.Add("Altıntaş");
                TownLst.Items.Add("Aslanapa");
                TownLst.Items.Add("Çavdarhisar");
                TownLst.Items.Add("Domaniç");
                TownLst.Items.Add("Dumlupınar");
                TownLst.Items.Add("Emet");
                TownLst.Items.Add("Gediz");
                TownLst.Items.Add("Hisarcık");
                TownLst.Items.Add("Pazarlar");
                TownLst.Items.Add("Simav");
                TownLst.Items.Add("Şaphane");
                TownLst.Items.Add("Tavşanlı");
            }
            else if (CityCmb.SelectedIndex == 1 || CityCmb.Text == "Bilecik")
            {
                TownLst.Items.Add("Bozüyük");
                TownLst.Items.Add("Gölpazarı");
                TownLst.Items.Add("İnhisar");
                TownLst.Items.Add("Osmaneli");
                TownLst.Items.Add("Pazaryeri");
                TownLst.Items.Add("Söğüt");
                TownLst.Items.Add("Yenipazar");

            }
            else if (CityCmb.SelectedIndex == 2 || CityCmb.Text == "Sakarya")
            {
                TownLst.Items.Add("Adapazarı");
                TownLst.Items.Add("Akyazı");
                TownLst.Items.Add("Ferizli");
                TownLst.Items.Add("Geyve");
                TownLst.Items.Add("Hendek");
                TownLst.Items.Add("Karapürçek");
                TownLst.Items.Add("Karasu");
                TownLst.Items.Add("Kaynarca");
                TownLst.Items.Add("Kocaali");
                TownLst.Items.Add("Pamukova");
                TownLst.Items.Add("Sapanca");
                TownLst.Items.Add("Söğütlü");
                TownLst.Items.Add("Taraklı");
            }
            else if (CityCmb.SelectedIndex == 3 || CityCmb.Text == "Bursa")
            {
                TownLst.Items.Add("Nilüfer");
                TownLst.Items.Add("Yıldırım");
                TownLst.Items.Add("Osman Gazi");
                TownLst.Items.Add("Büyük Orhan");
                TownLst.Items.Add("Gemlik");
                TownLst.Items.Add("Gürsu");
                TownLst.Items.Add("Harmancık");
                TownLst.Items.Add("İnegöl");
                TownLst.Items.Add("İznik");
                TownLst.Items.Add("Karacabey");
                TownLst.Items.Add("Kales");
                TownLst.Items.Add("Kestel");
                TownLst.Items.Add("Mudanya");
                TownLst.Items.Add("Mustafa Kemal Paşa");
                TownLst.Items.Add("Orhaneli");
                TownLst.Items.Add("Orhangazi");
                TownLst.Items.Add("Yenişehir");
            }
            else
            {
                TownLst.Items.Add("Ayancık");
                TownLst.Items.Add("Boyabat");
                TownLst.Items.Add("Dikmen");
                TownLst.Items.Add("Durağan");
                TownLst.Items.Add("Erfelek");
                TownLst.Items.Add("Gerze");
                TownLst.Items.Add("Saraydüzü");
                TownLst.Items.Add("Türkeli");
            }
        }

        private void ListTypeCmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            View tur = new View();
            tur = (View)ListTypeCmb.SelectedIndex;
            StudentsLvw.View = tur;
        }

        private int SelectionIcon()
        {
            if (IconRadioBtn1.Checked) return 0;
            else if (IconRadioBtn2.Checked) return 1;
            else if (IconRadioBtn3.Checked) return 2;
            else return 3;
        }

        private void AboutMnsItem_Click(object sender, EventArgs e)
        {
            About about = new About();
            about.Location = new Point(222, 333);
            about.ShowDialog();
        }

        private void Clear()
        {
            StudentNameTxt.Text = "";
            MaleRadioBtn.Checked = true;
            IconRadioBtn1.Checked = true;
            FilmChk.Checked = false;
            MusicChk.Checked = false;
            SportChk.Checked = false;
            CityCmb.SelectedIndex = -1;
            TownLst.Items.Clear();
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
    }
}

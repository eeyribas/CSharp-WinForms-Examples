using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HanoiTowers_Advanced
{
    public partial class Form1 : Form
    {
        private Form2 form2 = new Form2();

        private List<int>[] allStandPlates;
        private List<int> standPlates1 = new List<int>();
        private List<int> standPlates2 = new List<int>();
        private List<int> standPlates3 = new List<int>();

        private int plates = 4;
        private int source = 1, intermediate = 2, destination = 3;
        private int standWidth = 30;
        private int plateHeight = 20;
        private int totalMoves;


        public Form1()
        {
            InitializeComponent();

            allStandPlates = new List<int>[]{standPlates1, standPlates2, standPlates3};
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Start();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            Panel panel = (Panel)sender;
            Graphics graphics = e.Graphics;
            graphics.Clear(Color.White);
            DrawTheStand(graphics, panel);
            DrawPlates(graphics, panel, panel.TabIndex);
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            plates = Convert.ToInt32(numericUpDown1.Value);
            RedRawPanels();
        }

        void Start()
        {
            totalMoves = 0;
            for (int i = plates; i > 0; i--)
                standPlates1.Add(i);

            RedRawPanels();
            SolveTowers(plates, source, destination, intermediate);
        }

        private void RedRawPanels()
        {
            panel2.Invalidate();
            panel3.Invalidate();
            panel4.Invalidate();
        }

        void SolveTowers(int count, int source, int dest, int inter)
        {
            if (count == 1)
            {
                MoveFromTo(source, dest);
                totalMoves++;

                form2.label1.Text = "Move from stand " + source.ToString() + " to stand " + dest.ToString();
                form2.label3.Text = totalMoves.ToString();
                form2.Location = new Point(this.Width / 2 - form2.Width / 2, this.Height - 25);
                form2.ShowDialog();

                label2.Text = "Total moves: " + totalMoves.ToString();
            }
            else
            {
                SolveTowers(count - 1, source, inter, dest);
                SolveTowers(1, source, dest, inter);
                SolveTowers(count - 1, inter, dest, source);
            }
        }

        private void MoveFromTo(int source, int dest)
        {
            int top = allStandPlates[source - 1][allStandPlates[source - 1].Count - 1];
            allStandPlates[source - 1].Remove(top);
            allStandPlates[dest - 1].Add(top);
            RedRawPanels();

        }

        private void DrawTheStand(Graphics graphics, Panel panel)
        {
            graphics.FillRectangle(new SolidBrush(Color.Gray), new Rectangle(panel.Width / 2 - standWidth / 2, panel.Width / 2 - standWidth / 2,
                                   standWidth, panel.Height - 20));
        }

        private void DrawPlates(Graphics graphics, Panel panel, int standNo)
        {
            if (standPlates1 == null) 
                return;

            standPlates1.Sort();
            standPlates1.Reverse();

            switch (standNo)
            {
                case 1:
                    DrawStandPlates(graphics, standPlates1, panel); 
                    break;
                case 2:
                    DrawStandPlates(graphics, standPlates2, panel); 
                    break;
                case 3:
                    DrawStandPlates(graphics, standPlates3, panel); 
                    break;
            }
        }

        private void DrawStandPlates(Graphics graphics, List<int> plates, Panel panel)
        {
            int i = 0;
            foreach (int plateNo in plates)
            {
                i++;
                graphics.FillEllipse(new SolidBrush(Color.Red), new Rectangle(panel.Width / 2 - (plateNo * 30) / 2, 
                                     panel.Height - i * plateHeight, plateNo * 30, plateHeight));
                graphics.DrawString(plateNo.ToString(), new Font("Tahoma", 12F, FontStyle.Bold), Brushes.Black, new Rectangle(panel.Width / 2 - 8, 
                                    panel.Height - i * plateHeight, plateNo * 30, plateHeight));
            }
        }
    }
}

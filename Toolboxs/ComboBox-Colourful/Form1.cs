using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComboBox_Colourful
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] colors = {"Red", "Green", "Yellow", "Black", "Blue", "Brown"};
            comboBox1.Items.AddRange(colors);
        }

        private void comboBox1_DrawItem(object sender, DrawItemEventArgs e)
        {
            Color color = Color.Black;
            string element = comboBox1.Items[e.Index].ToString();
            switch (element)
            {
                case "Red": 
                    color = Color.Red; 
                    break;
                case "Green": 
                    color = Color.Green; 
                    break;
                case "Yellow": 
                    color = Color.Yellow; 
                    break;
                case "Black": 
                    color = Color.Black; 
                    break;
                case "Blue": 
                    color = Color.Blue; 
                    break;
                case "Brown": 
                    color = Color.Brown; 
                    break;
            }

            if (e.State == DrawItemState.Selected)
                e.Graphics.FillRectangle(new SolidBrush(Color.Turquoise), e.Bounds.Left, e.Bounds.Top,
                                         e.Bounds.Width, e.Bounds.Height);
            else
                e.Graphics.FillRectangle(new SolidBrush(color), e.Bounds.Left, e.Bounds.Top,
                                         e.Bounds.Width, e.Bounds.Height);
                                         e.Graphics.DrawString(element, e.Font, new SolidBrush(Color.White),
                                         e.Bounds.Left, e.Bounds.Top);
            e.DrawFocusRectangle();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Color color = Color.Black;
            string element = comboBox1.SelectedItem.ToString();
            switch (element)
            {
                case "Red": 
                    color = Color.Red; 
                    break;
                case "Green": 
                    color = Color.Green; 
                    break;
                case "Yellow": 
                    color = Color.Yellow; 
                    break;
                case "Black": 
                    color = Color.Black; 
                    break;
                case "Blue": 
                    color = Color.Blue; 
                    break;
                case "Brown": 
                    color = Color.Brown; 
                    break;
            }

            this.BackColor = color;
            comboBox1.BackColor = color;
            comboBox1.ForeColor = Color.White;
        }
    }
}

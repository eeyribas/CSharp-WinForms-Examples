using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Graphics_ShapesDrawing
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Rectangle");
            comboBox1.Items.Add("Square");
            comboBox1.Items.Add("Circle");
            comboBox1.Items.Add("Ellipse");
            comboBox1.Items.Add("Text");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Graphics graphics = this.CreateGraphics();
            graphics.Clear(this.BackColor);

            switch (comboBox1.Text)
            {
                case "Rectangle":
                    graphics.FillRectangle(new SolidBrush(Color.Red), 10, 100, 75, 125);
                    break;
                case "Square":
                    graphics.FillRectangle(new SolidBrush(Color.Red), 10, 100, 75, 75);
                    break;
                case "Circle":
                    graphics.FillEllipse(new SolidBrush(Color.Red), 10, 100, 75, 75);
                    break;
                case "Ellipse":
                    graphics.FillEllipse(new SolidBrush(Color.Red), 10, 100, 75, 125);
                    break;
                case "Text":
                    graphics.DrawString("Visual C # .NET", new Font("Tahoma", 16, FontStyle.Regular),
                                         new SolidBrush(Color.Red), 10, 100);
                    break;
                default:
                    MessageBox.Show("Select a value from the list.");
                    break;
            }
            graphics.Dispose();
        }
    }
}

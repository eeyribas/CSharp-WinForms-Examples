using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DrawingObjectsWithMouseAndSavingThem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            for (int i = 1; i <= listBox1.Items.Count - 1; i++)
            {
                Point point = (Point)listBox1.Items[i];
                Point before = (Point)listBox1.Items[i - 1];
                e.Graphics.DrawLine(new Pen(Color.Red), before.X, before.Y, point.X, point.Y);
            }
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            Point point = new Point();
            point.X = e.X;
            point.Y = e.Y;
            listBox1.Items.Add(point);

            Point before;
            Graphics graphics;
            if (listBox1.Items.Count > 1)
            {
                before = (Point)listBox1.Items[listBox1.Items.Count - 2];
                graphics = this.CreateGraphics();
                graphics.DrawLine(new Pen(Color.Red), before.X, before.Y, point.X, point.Y);
                graphics.Dispose();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TextWriter textWriter = File.CreateText("image.dat");
            for (int i = 0; i <= listBox1.Items.Count - 1; i++)
            {
                textWriter.WriteLine(((Point)listBox1.Items[i]).X.ToString());
                textWriter.WriteLine(((Point)listBox1.Items[i]).Y.ToString());
            }
            textWriter.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            Point point = new Point();

            try
            {
                TextReader textReader = File.OpenText("image.dat");
                string row;
                while ((row = textReader.ReadLine()) != null)
                {
                    point.X = int.Parse(row);
                    row = textReader.ReadLine();
                    point.Y = int.Parse(row);
                    listBox1.Items.Add(point);
                }
                textReader.Close();
            }
            catch
            {
         
            }

            this.Invalidate();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Remove(listBox1.SelectedItem);
            this.Invalidate();
        }
    }
}

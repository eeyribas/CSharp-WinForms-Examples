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

namespace Dialog_FormDesign
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            FileInfo fileInfo = new FileInfo("setting.dat");
            if (fileInfo.Exists)
            {
                TextReader textReader = File.OpenText("setting.dat");
                textBox1.Text = textReader.ReadLine();
                textBox1.ForeColor = Color.FromName(textReader.ReadLine());
                textBox1.Font = new Font(textReader.ReadLine(), float.Parse(textReader.ReadLine()), FontStyle.Bold, 
                                         GraphicsUnit.Point);
                this.Text = textReader.ReadLine();

                textBox2.Text = this.Text;
                this.BackColor = Color.FromName(textReader.ReadLine());
                this.Width = int.Parse(textReader.ReadLine());
                this.Height = int.Parse(textReader.ReadLine());
                textReader.Close(); 
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            TextWriter textWriter = File.CreateText("setting.dat");
            textWriter.WriteLine(textBox1.Text);
            textWriter.WriteLine(textBox1.ForeColor.ToKnownColor().ToString());
            textWriter.WriteLine(textBox1.Font.Name);
            textWriter.WriteLine(textBox1.Font.Size);
            textWriter.WriteLine(this.Text);
            textWriter.WriteLine(BackColor.ToKnownColor().ToString());
            textWriter.WriteLine(this.Size.Width);
            textWriter.WriteLine(this.Size.Height);
            textWriter.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
                textBox1.ForeColor = colorDialog1.Color;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
                this.BackColor = colorDialog1.Color;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog() == DialogResult.OK)
                textBox1.Font = fontDialog1.Font;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Text = textBox2.Text;
        }
    }
}

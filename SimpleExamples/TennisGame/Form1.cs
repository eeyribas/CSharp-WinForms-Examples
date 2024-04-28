using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TennisGame
{
    public partial class Form1 : Form
    {
        private int rowCount, columnCount, boxCount, score, level;
        private int xa, ya;
        private bool demo = false;
        private int[] box;
        int imageNo = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "Tennis Game 1.0";
            Show();
            KeyPreview = true;
            level = 1;
            rowCount = 4;
            columnCount = 4;

            button1.Text = "";
            button1.Top = this.ClientSize.Height - 100;
            label1.AutoSize = true;
            label2.AutoSize = true;
            label3.AutoSize = true;
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 14, FontStyle.Bold);
            label1.Text = "0";
            label1.Top = ClientSize.Height - label1.Height;
            label1.Left = 0;
            label2.Text = "Box Count";
            label2.Top = ClientSize.Height - label2.Height;
            label2.Left = label1.Left + label2.Width + 10;
            label3.Text = "Level 1";
            label3.Top = ClientSize.Height - label3.Height;
            label3.Left = label2.Left + label2.Width + 10;
            pictureBox1.Width = 16;
            pictureBox1.Height = 16;

            NewGame();
            timer1.Interval = 50;
            timer1.Enabled = true;
            timer2.Enabled = true;
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)27) 
                demo = !demo;
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            int ks = 0;
            SolidBrush solidBrush = new SolidBrush(Color.White);

            for (int i = 0; i <= rowCount * columnCount - 1; i++)
            {
                float x = 60 * (i % columnCount);
                float y = 20 * (int)(i / columnCount);

                if (box[i] != 100)
                {
                    Random random = new Random((int)(DateTime.Now.Ticks % Int32.MaxValue));
                    solidBrush.Color = Color.FromArgb(random.Next(255), random.Next(255), random.Next(255));
                    ks++;

                    e.Graphics.FillRectangle(solidBrush, x, y, 60, 20);
                    e.Graphics.DrawRectangle(new Pen(this.BackColor), x, y, 60, 20);
                    if (box[i] != 200)
                        imageList2.Draw(e.Graphics, (int)x + 22, (int)y + 2, box[i] - 1);
                }
                else
                {
                    solidBrush.Color = this.BackColor;
                    e.Graphics.FillRectangle(solidBrush, x, y, 60, 20);
                }
            }
            boxCount = ks;
            label2.Text = boxCount.ToString();
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if ((boxCount != 1) && (demo == false))
                button1.Left = e.X;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (pictureBox1.Left <= 0)
            {
                xa = -xa;
                pictureBox1.Left = 0;
            }
 
            if (pictureBox1.Right >= ClientSize.Width)
                xa = -xa;

            if (pictureBox1.Top <= 0)
            {
                ya = -ya;
                pictureBox1.Top = 0;
            }

            if ((pictureBox1.Top >= button1.Top) && (pictureBox1.Top < button1.Bottom) && (pictureBox1.Left > button1.Left) && (pictureBox1.Left < button1.Right))
                ya = -ya;

            if (pictureBox1.Top >= ClientSize.Height)
            {
                timer1.Enabled = false;
                MessageBox.Show("Game Over");
            }
            pictureBox1.Left += xa;
            pictureBox1.Top += ya;
   
            int i = (int)(pictureBox1.Left + pictureBox1.Width / 2) / 60;
            int j = (int)pictureBox1.Top / 20;
            int k = j * columnCount + i;

            if ((j <= rowCount - 1) && (i <= columnCount - 1))
            {
                if (box[k] != 100)
                {
                    Graphics graphics = this.CreateGraphics();
                    boxCount--;
                    score += 10 * box[k];
                    label1.Text = score.ToString();

                    graphics.DrawString((box[k] * 10).ToString(), new Font("Tahoma", 10, FontStyle.Bold), new SolidBrush(Color.White),
                                        60 * (k % columnCount) + 10, 20 * (k / columnCount) + 5);
                    Thread.Sleep(100);
                    ya = -ya; 

                    if (box[k] == 200)
                    {
                        for (int m = i; m <= i + 2; m++)
                        {
                            for (int n = j - 1; n <= j + 1; n++)
                            {
                                int s = n * columnCount + m - 1;
                                if ((s >= 0) && (n <= rowCount - 1) && (m <= columnCount - 1))
                                {
                                    box[s] = 100;
                                    graphics.DrawString("Boomm!", new Font("Tahoma", 10, FontStyle.Bold), new SolidBrush(Color.White),
                                                        60 * (s % columnCount), 20 * (s / columnCount));
                                    Thread.Sleep(100);
                                }
                            }
                        }
                    }

                    box[k] = 100;
                    this.Invalidate();
                    graphics.Dispose();
                }
            }

            if ((boxCount == 1) || (demo == true))
            {
                button1.Left = pictureBox1.Left - (button1.Width / 2);
                button1.Text = "Auto Pilot";
            }
            else
            {
                button1.Text = "";
            }

            if (boxCount == 0)
            {
                level++;
                NewGame();
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            imageNo++;
            imageNo %= 8;
            pictureBox1.Image = imageList1.Images[imageNo];
        }

        private void button1_MouseMove(object sender, MouseEventArgs e)
        {
            if ((boxCount != 1) && (demo == false))
                button1.Left += e.X;
        }

        private void NewGame()
        {
            rowCount++;
            columnCount++;
            boxCount = rowCount * columnCount;
            box = new int[boxCount];
            xa = 10;
            ya = -10;

            this.pictureBox1.Top = this.button1.Top - 100;
            this.label3.Text = "Level " + level;
            this.Width = 60 * columnCount + 8;

            Random random = new Random((int)(System.DateTime.Now.Ticks % System.Int32.MaxValue));
            this.BackColor = Color.FromArgb(random.Next(255), random.Next(255), random.Next(255));
            this.button1.Width -= 10;

            for (int i = 0; i <= boxCount - 1; i++)
                box[i] = (int)(random.Next(6)) + 1;

            for (int i = 0; i <= boxCount / 5; i++)
            {
                int j = random.Next(boxCount);
                box[j] = 200;
            }

            this.label4.Text = "Level " + level;
            this.label4.Left = (this.ClientSize.Width - this.label4.Width) / 2;
            this.label4.Top = (this.ClientSize.Height - this.label4.Height) / 2;
            this.label4.Visible = true;
            Application.DoEvents();
            System.Threading.Thread.Sleep(2000);
            this.label4.Visible = false;
        }
    }
}

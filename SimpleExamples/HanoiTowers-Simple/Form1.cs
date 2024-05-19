using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HanoiTowers_Simple
{
    public partial class Form1 : Form
    {
        public class TransportInfo
        {
            public string src;
            public string dest;
            public int number;

            public TransportInfo(string s, string d, int n)
            {
                src = s;
                dest = d;
                number = n;
            }
        }

        public class DiskInfo
        {
            public int width;
            public int height;
            public Color color;
            public int number;
            public Brush brush;

            public DiskInfo(int w, int h, Color c, int n)
            {
                width = w;
                height = h;
                color = c;
                number = n;
                brush = new SolidBrush(color);
            }
        }

        static public Stack<int> aStack = new Stack<int>();
        static public Stack<int> bStack = new Stack<int>();
        static public Stack<int> cStack = new Stack<int>();

        static public List<TransportInfo> transportInfoList = new List<TransportInfo>();
        static int currentStep = 0;
        static int aCount = 0;
        static int bCount = 0;
        static int cCount = 0;

        public Stack<DiskInfo> aTower = new Stack<DiskInfo>();
        public Stack<DiskInfo> bTower = new Stack<DiskInfo>();
        public Stack<DiskInfo> cTower = new Stack<DiskInfo>();

        private int count = 1;
        private int before = 3;
        static public int transportCount = 0;


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Text = "3";
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics graphics = e.Graphics;
            int maxDisk = Convert.ToInt32(comboBox1.Text);

            DrawTower(aTower, maxDisk, 100, 100, e.Graphics);
            DrawTower(bTower, maxDisk, 300, 100, e.Graphics);
            DrawTower(cTower, maxDisk, 500, 100, e.Graphics);

            graphics.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (currentStep == transportInfoList.Count)
                return;

            TransportInfo transportInfo = transportInfoList[currentStep++];
            textBox1.Text = currentStep.ToString() + " - " + transportInfoList.Count.ToString();

            if (transportInfo.src == "A")
            {
                if (transportInfo.dest == "B")
                {
                    bTower.Push(aTower.Pop());
                    listBox1.Items.Add(count + " - A -- > B");
                    count++;
                }
                else
                {
                    cTower.Push(aTower.Pop());
                    listBox1.Items.Add(count + " - A -- > C");
                    count++;
                }
            }
            else if (transportInfo.src == "B")
            {
                if (transportInfo.dest == "C")
                {
                    cTower.Push(bTower.Pop());
                    listBox1.Items.Add(count + " - B -- > C");
                    count++;
                }
                else
                {
                    aTower.Push(bTower.Pop());
                    listBox1.Items.Add(count + " - B -- > A");
                    count++;
                }
            }
            else if (transportInfo.src == "C")
            {
                if (transportInfo.dest == "A")
                {
                    aTower.Push(cTower.Pop());
                    listBox1.Items.Add(count + " - C -- > A");
                    count++;
                }
                else
                {
                    bTower.Push(cTower.Pop());
                    listBox1.Items.Add(count + " - C -- > B");
                    count++;
                }
            }

            Invalidate();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int maxDisk = Convert.ToInt32(comboBox1.Text);
            if (before != maxDisk)
            {
                listBox1.Items.Clear();
                count = 1;
                before = maxDisk;
            }

            transportCount = 0;
            transportInfoList.Clear();
            for (int i = maxDisk; i >= 1; i--)
                aStack.Push(i);

            aCount = aStack.Count;
            bCount = bStack.Count;
            cCount = cStack.Count;
            printStack();
            DiskSolution2(maxDisk, aStack, bStack, cStack);

            DiskInfo diskInfo1 = new DiskInfo(40, 25, Color.Green, 1);
            DiskInfo diskInfo2 = new DiskInfo(60, 30, Color.Blue, 2);
            DiskInfo diskInfo3 = new DiskInfo(80, 35, Color.YellowGreen, 3);
            DiskInfo diskInfo4 = new DiskInfo(100, 40, Color.Red, 4);
            DiskInfo diskInfo5 = new DiskInfo(120, 45, Color.Violet, 5);
            DiskInfo diskInfo6 = new DiskInfo(140, 50, Color.Purple, 6);
            DiskInfo diskInfo7 = new DiskInfo(160, 55, Color.OrangeRed, 7);
            DiskInfo diskInfo8 = new DiskInfo(180, 60, Color.Khaki, 8);
            DiskInfo diskInfo9 = new DiskInfo(200, 65, Color.IndianRed, 9);
            DiskInfo[] arrDiscs = { diskInfo1, diskInfo2, diskInfo3, diskInfo4, diskInfo5,
                                    diskInfo6, diskInfo7, diskInfo8, diskInfo9 };

            aTower.Clear();
            bTower.Clear();
            cTower.Clear();

            for (int i = maxDisk - 1; i >= 0; i--)
                aTower.Push(arrDiscs[i]);
            currentStep = 0;
            textBox1.Text = currentStep.ToString() + " - " + transportInfoList.Count.ToString();
            Invalidate();
        }

        static public void DiskSolution(Stack<int> source, Stack<int> temp, Stack<int> dest)
        {
            temp.Push(source.Pop());
            transportCount++;
            printStack();

            dest.Push(source.Pop());
            transportCount++;
            printStack();

            dest.Push(temp.Pop());
            transportCount++;
            printStack();
        }

        static public bool DiskSolution2(int nDiscs, Stack<int> source, Stack<int> temp, Stack<int> dest)
        {
            if (nDiscs <= 4)
            {
                if ((nDiscs % 2) == 0)
                {
                    DiskSolution(source, temp, dest);
                    nDiscs--;
                    if (nDiscs == 1)
                        return true;

                    temp.Push(source.Pop());
                    transportCount++;
                    printStack();

                    DiskSolution(dest, source, temp);
                    dest.Push(source.Pop());
                    transportCount++;
                    printStack();

                    DiskSolution2(nDiscs, temp, source, dest);
                }
                else
                {
                    if (nDiscs == 1)
                        return false;
                    DiskSolution(source, dest, temp);
                    nDiscs--;

                    dest.Push(source.Pop());
                    transportCount++;
                    printStack();
                    DiskSolution(temp, source, dest);
                }
                return true;
            }
            else if (nDiscs >= 5)
            {
                DiskSolution2(nDiscs - 2, source, temp, dest);
                temp.Push(source.Pop());
                transportCount++;
                printStack();
                DiskSolution2(nDiscs - 2, dest, source, temp);

                dest.Push(source.Pop());
                transportCount++;
                printStack();
                DiskSolution2(nDiscs - 1, temp, source, dest);
            }

            return true;
        }

        static public void printStack()
        {
            if (aCount != aStack.Count || bCount != bStack.Count || cCount != cStack.Count)
            {
                int aDifference = aStack.Count - aCount;
                int bDifference = bStack.Count - bCount;
                int cDifference = cStack.Count - cCount;

                if (aDifference == 1)
                {
                    if (bDifference == -1)
                        transportInfoList.Add(new TransportInfo("B", "A", aStack.Peek()));
                    else
                        transportInfoList.Add(new TransportInfo("C", "A", aStack.Peek()));
                }
                else if (bDifference == 1)
                {
                    if (aDifference == -1)
                        transportInfoList.Add(new TransportInfo("A", "B", bStack.Peek()));
                    else
                        transportInfoList.Add(new TransportInfo("C", "B", bStack.Peek()));
                }
                else
                {
                    if (aDifference == -1)
                        transportInfoList.Add(new TransportInfo("A", "C", cStack.Peek()));
                    else
                        transportInfoList.Add(new TransportInfo("B", "C", cStack.Peek()));
                }

                aCount = aStack.Count;
                bCount = bStack.Count;
                cCount = cStack.Count;
                Console.WriteLine();
            }
        }

        public void DrawTower(Stack<DiskInfo> tower, int maxDisks, int xBeg, int yBeg, Graphics graphics)
        {
            Stack<DiskInfo>.Enumerator diskInfoEnum = tower.GetEnumerator();
            List<DiskInfo> diList = new List<DiskInfo>();
            int yOffset = maxDisks - tower.Count;

            while (true)
            {
                if (diskInfoEnum.MoveNext() == false)
                    break;

                diList.Add(diskInfoEnum.Current);
            }

            for (int i = diList.Count - 1; i >= 0; i--)
            {
                Rectangle rectangle = new Rectangle(xBeg - diList[i].number * 10, yBeg + (i + yOffset) * 10, 
                                                    diList[i].width, diList[i].height);
                Pen pen = new Pen(Color.White);

                rectangle.Y += 5;
                graphics.FillEllipse(diList[i].brush, rectangle);
                graphics.DrawEllipse(pen, rectangle);

                rectangle.Y -= 5;
                graphics.FillEllipse(diList[i].brush, rectangle);
                graphics.DrawEllipse(pen, rectangle);
            }
        }
    }
}

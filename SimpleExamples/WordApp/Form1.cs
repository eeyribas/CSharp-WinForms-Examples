using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WordApp
{
    public partial class Form1 : Form
    {
        public Form2 form2 = new Form2();
        public static RichTextBox richTextBox;
        private string fileName;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            toolBar1.ImageList = imageList1;
            string[] buttons = { "New", "Open", "Save", "Cut", "Cut", "Copy", "Paste", "Delete", "Cut", "Bold",
                                 "Italic", "Underline", "Strikethrough", "Cut", "Left", "Center", "Right", "Cut",
                                 "Find", "Cut", "Undo", "Refresh", "Cut", "Bullet Point", "Cut", "Superscript", "Subscript" };
            int[] styles = {0, 0, 0, 1, 0, 0, 0, 0, 1, 2, 2, 2, 2, 1, 2, 2, 2, 1, 0, 1, 0, 0, 1, 2, 1, 2, 2};
            int image = 0;

            for (int i = 0; i <= buttons.Length - 1; i++)
            {
                ToolBarButton button = new ToolBarButton();
                toolBar1.Buttons.Add(button);
                button.ToolTipText = buttons[i];
                button.ImageIndex = image;
                button.Text = buttons[i];

                switch (styles[i])
                {
                    case 0:
                        button.Style = ToolBarButtonStyle.PushButton;
                        image += 1;
                        break;
                    case 1:
                        button.Style = ToolBarButtonStyle.Separator;
                        button.ImageIndex = -1;
                        break;
                    case 2:
                        button.Style = ToolBarButtonStyle.ToggleButton;
                        image += 1;
                        break;
                }
            }

            comboBox1.DrawMode = DrawMode.OwnerDrawVariable;
            FontFamily[] fonts = FontFamily.Families;
            for (int i = 0; i <= fonts.GetUpperBound(0) - 1; i++)
                comboBox1.Items.Add(fonts[i].Name);
            comboBox1.Text = richTextBox1.Font.Name;

            for (int i = 8; i <= 100; i += 2)
                comboBox2.Items.Add(i.ToString());
            comboBox2.Text = richTextBox1.Font.Size.ToString();

            comboBox3.DrawMode = DrawMode.OwnerDrawFixed;
            string[] colors = { "Red", "Green", "Yellow", "Black", "Blue", "Brown" };
            comboBox3.Items.AddRange(colors);
            comboBox3.Text = "Black";

            comboBox4.Items.Add("%64");
            comboBox4.Items.Add("%75");
            comboBox4.Items.Add("%100");
            comboBox4.Items.Add("%150");
            comboBox4.Items.Add("%200");
            comboBox4.Items.Add("%400");
            comboBox4.Items.Add("%500");
            comboBox4.Items.Add("%1000");
            comboBox4.Text = "%100";

            richTextBox1.HideSelection = false;
            richTextBox1.Text = "";
            richTextBox1.Modified = false;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Exit() == false)
                e.Cancel = true;
        }

        private void menuItem2_Click(object sender, EventArgs e)
        {
            New();
        }

        private void menuItem3_Click(object sender, EventArgs e)
        {
            Open();
        }

        private void menuItem4_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void menuItem5_Click(object sender, EventArgs e)
        {
            SaveAs();
        }

        private void menuItem7_Click(object sender, EventArgs e)
        {
            if (Exit() == true)
                this.Close();
        }

        private void menuItem8_Click(object sender, EventArgs e)
        {
            if (richTextBox1.SelectionLength == 0)
            {
                menuItem12.Enabled = false;
                menuItem13.Enabled = false;
                menuItem15.Enabled = false;
            }
            else
            {
                menuItem12.Enabled = true;
                menuItem13.Enabled = true;
                menuItem15.Enabled = true;
            }

            if (richTextBox1.CanUndo)
            {
                menuItem9.Enabled = true;
                menuItem9.Text = "Undo-" + richTextBox1.UndoActionName;
            }
            else
            {
                menuItem9.Enabled = false;
                menuItem9.Text = "Cannot be undone.";
            }

            if (richTextBox1.CanRedo)
            {
                menuItem10.Enabled = true;
                menuItem10.Text = "Redo-" + richTextBox1.RedoActionName;
            }
            else
            {
                menuItem10.Enabled = false;
                menuItem10.Text = "Cannot be redone.";
            }
        }

        private void menuItem9_Click(object sender, EventArgs e)
        {
            Undo();
        }

        private void menuItem10_Click(object sender, EventArgs e)
        {
            Refr();
        }

        private void menuItem12_Click(object sender, EventArgs e)
        {
            Cut();
        }

        private void menuItem13_Click(object sender, EventArgs e)
        {
            Copy();
        }

        private void menuItem14_Click(object sender, EventArgs e)
        {
            Paste();
        }

        private void menuItem15_Click(object sender, EventArgs e)
        {
            Delete();
        }

        private void menuItem17_Click(object sender, EventArgs e)
        {
            Find();
        }

        private void menuItem18_Click(object sender, EventArgs e)
        {
            if (richTextBox1.SelectionFont != null)
            {
                if (richTextBox1.SelectionFont.Bold)
                    menuItem19.Checked = true;
                else
                    menuItem19.Checked = false;

                if (richTextBox1.SelectionFont.Italic)
                    menuItem20.Checked = true;
                else
                    menuItem20.Checked = false;

                if (richTextBox1.SelectionFont.Underline)
                    menuItem21.Checked = true;
                else
                    menuItem21.Checked = false;

                if (richTextBox1.SelectionFont.Strikeout)
                    menuItem22.Checked = true;
                else
                    menuItem22.Checked = false;
            }

            if (richTextBox1.SelectionCharOffset > 0)
                menuItem24.Checked = true;
            else
                menuItem24.Checked = false;

            if (richTextBox1.SelectionCharOffset < 0)
                menuItem25.Checked = true;
            else
                menuItem25.Checked = false;
        }

        private void menuItem19_Click(object sender, EventArgs e)
        {
            Bold(true);
        }

        private void menuItem20_Click(object sender, EventArgs e)
        {
            Italic(true);
        }

        private void menuItem21_Click(object sender, EventArgs e)
        {
            Underline(true);
        }

        private void menuItem22_Click(object sender, EventArgs e)
        {
            BulletPoint(true);
        }

        private void menuItem24_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionCharOffset = (int)richTextBox1.SelectionFont.Size / 2;
        }

        private void menuItem25_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionCharOffset = (int)-richTextBox1.SelectionFont.Size / 2;
        }

        private void menuItem27_Click(object sender, EventArgs e)
        {
            if (richTextBox1.SelectionFont != null)
                fontDialog1.Font = richTextBox1.SelectionFont;
            else
                fontDialog1.Font = null;

            if (fontDialog1.ShowDialog() == DialogResult.OK)
                richTextBox1.SelectionFont = fontDialog1.Font;
        }

        private void menuItem29_Click(object sender, EventArgs e)
        {
            colorDialog1.Color = richTextBox1.SelectionColor;
            if (colorDialog1.ShowDialog() == DialogResult.OK)
                richTextBox1.SelectionColor = colorDialog1.Color;
        }

        private void menuItem30_Click(object sender, EventArgs e)
        {
            menuItem31.Checked = false;
            menuItem32.Checked = false;
            menuItem33.Checked = false;

            switch (richTextBox1.SelectionAlignment)
            {
                case HorizontalAlignment.Left:
                    menuItem31.Checked = true;
                    break;
                case HorizontalAlignment.Center:
                    menuItem32.Checked = true;
                    break;
                case HorizontalAlignment.Right:
                    menuItem33.Checked = true;
                    break;
            }

            if (richTextBox1.SelectionBullet)
                menuItem35.Checked = true;
            else
                menuItem35.Checked = false;
        }

        private void menuItem31_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Left;
        }

        private void menuItem32_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Center;
        }

        private void menuItem33_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Right;
        }

        private void menuItem35_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionBullet = !richTextBox1.SelectionBullet;
        }

        private void toolBar1_ButtonClick(object sender, ToolBarButtonClickEventArgs e)
        {
            switch (e.Button.Text)
            {
                case "New":
                    New();
                    break;
                case "Open":
                    Open();
                    break;
                case "Save":
                    Save();
                    break;
                case "Cut":
                    Cut();
                    break;
                case "Copy":
                    Copy();
                    break;
                case "Paste":
                    Paste();
                    break;
                case "Delete":
                    Delete();
                    break;
                case "Bold":
                    Bold(e.Button.Pushed);
                    break;
                case "Italic":
                    Italic(e.Button.Pushed);
                    break;
                case "Underline":
                    Underline(e.Button.Pushed);
                    break;
                case "Strikethrough":
                    Strikethrough(e.Button.Pushed);
                    break;
                case "Left":
                case "Center":
                case "Right":
                    Align(e.Button);
                    break;
                case "Find":
                    Find();
                    break;
                case "Undo":
                    Undo();
                    break;
                case "Refresh":
                    Refr();
                    break;
                case "Bullet Point":
                    BulletPoint(e.Button.Pushed);
                    break;
                case "Superscript":
                case "Subscript":
                    SuperscriptSubscript(e.Button);
                    break;
            }
        }

        private void comboBox1_MeasureItem(object sender, MeasureItemEventArgs e)
        {
            string name = comboBox1.Items[e.Index].ToString();
            Font font = new Font(name, 12, FontStyle.Regular);
            e.ItemHeight = font.Height;
        }

        private void comboBox1_DrawItem(object sender, DrawItemEventArgs e)
        {
            e.DrawBackground();
            e.DrawFocusRectangle();
            string name = comboBox1.Items[e.Index].ToString();
            e.Graphics.DrawString(name, new Font(name, 12, FontStyle.Regular), new SolidBrush(Color.Black),
                                  e.Bounds.Left, e.Bounds.Top);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            richTextBox1.SelectionFont = new Font(comboBox1.SelectedItem.ToString(), richTextBox1.SelectionFont.Size,
                                                  richTextBox1.SelectionFont.Style);
            richTextBox1.Focus();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont.Name, float.Parse(comboBox2.Text),
                                                  richTextBox1.SelectionFont.Style);
            richTextBox1.Focus();
        }

        private void comboBox3_DrawItem(object sender, DrawItemEventArgs e)
        {
            Color color = Color.Black;
            string element = comboBox3.Items[e.Index].ToString();
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

            e.Graphics.DrawString(element, e.Font, new SolidBrush(Color.White), e.Bounds.Left, e.Bounds.Top);
            e.DrawFocusRectangle();
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            Color color = Color.Black;
            string element = comboBox3.SelectedItem.ToString();
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

            richTextBox1.SelectionColor = color;
            comboBox3.BackColor = color;
            comboBox3.ForeColor = Color.White;
            richTextBox1.Focus();
        }

        private void comboBox4_TextChanged(object sender, EventArgs e)
        {
            richTextBox1.ZoomFactor = float.Parse(comboBox4.Text.Substring(1)) / 100;
        }

        private void button1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                button1.Left = e.X + button1.Left;
                richTextBox1.SelectionIndent = button1.Left;
                richTextBox1.SelectionHangingIndent = button2.Left - button1.Left;
            }
        }

        private void button2_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                button2.Left = e.X + button2.Left;
                richTextBox1.SelectionHangingIndent = button2.Left - button1.Left;
            }
        }

        private void button3_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                button3.Left = e.X + button3.Left;

                try
                {
                    richTextBox1.SelectionRightIndent = richTextBox1.ClientSize.Width - button3.Left;
                }
                catch
                {
                    button3.Left = richTextBox1.ClientSize.Width;
                }
            }
        }

        private void richTextBox1_SelectionChanged(object sender, EventArgs e)
        {
            if (richTextBox1.SelectionLength == 0)
            {
                toolBar1.Buttons[4].Enabled = false;
                toolBar1.Buttons[5].Enabled = false;
                toolBar1.Buttons[7].Enabled = false;
            }
            else
            {
                toolBar1.Buttons[4].Enabled = true;
                toolBar1.Buttons[5].Enabled = true;
                toolBar1.Buttons[7].Enabled = true;
            }

            if (richTextBox1.SelectionFont != null)
            {
                if (richTextBox1.SelectionFont.Bold)
                    toolBar1.Buttons[9].Pushed = true;
                else
                    toolBar1.Buttons[9].Pushed = false;

                if (richTextBox1.SelectionFont.Italic)
                    toolBar1.Buttons[10].Pushed = true;
                else
                    toolBar1.Buttons[10].Pushed = false;

                if (richTextBox1.SelectionFont.Underline)
                    toolBar1.Buttons[11].Pushed = true;
                else
                    toolBar1.Buttons[11].Pushed = false;

                if (richTextBox1.SelectionFont.Strikeout)
                    toolBar1.Buttons[12].Pushed = true;
                else
                    toolBar1.Buttons[12].Pushed = false;

                comboBox1.Text = richTextBox1.SelectionFont.Name;
                comboBox2.Text = richTextBox1.SelectionFont.Size.ToString();
            }

            toolBar1.Buttons[14].Pushed = false;
            toolBar1.Buttons[15].Pushed = false;
            toolBar1.Buttons[16].Pushed = false;

            switch (richTextBox1.SelectionAlignment)
            {
                case HorizontalAlignment.Left:
                    toolBar1.Buttons[14].Pushed = true;
                    break;
                case HorizontalAlignment.Center:
                    toolBar1.Buttons[15].Pushed = true;
                    break;
                case HorizontalAlignment.Right:
                    toolBar1.Buttons[16].Pushed = true;
                    break;
            }

            if (richTextBox1.SelectionBullet)
                toolBar1.Buttons[23].Pushed = true;
            else
                toolBar1.Buttons[23].Pushed = false;

            if (richTextBox1.SelectionCharOffset > 0)
                toolBar1.Buttons[25].Pushed = true;
            else
                toolBar1.Buttons[25].Pushed = false;

            if (richTextBox1.SelectionCharOffset < 0)
                toolBar1.Buttons[26].Pushed = true;
            else
                toolBar1.Buttons[26].Pushed = false;

            if (richTextBox1.SelectionIndent == 0)
            {
                button1.Left = 0;
                button2.Left = 0;
                button3.Left = richTextBox1.ClientSize.Width - button3.Width;
            }
            else
            {
                button1.Left = richTextBox1.SelectionIndent;
                button2.Left = richTextBox1.SelectionHangingIndent + button1.Left;
                button3.Left = richTextBox1.ClientSize.Width - richTextBox1.SelectionRightIndent;
            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            if (richTextBox1.CanUndo)
            {
                toolBar1.Buttons[20].Enabled = true;
                toolBar1.Buttons[20].ToolTipText = "Undo-" + richTextBox1.UndoActionName;
            }
            else
            {
                toolBar1.Buttons[20].Enabled = false;
                toolBar1.Buttons[20].ToolTipText = "Cannot be undone.";
            }

            if (richTextBox1.CanRedo)
            {
                toolBar1.Buttons[21].Enabled = true;
                toolBar1.Buttons[21].ToolTipText = "Redo-" + richTextBox1.RedoActionName;
            }
            else
            {
                toolBar1.Buttons[21].Enabled = false;
                toolBar1.Buttons[21].ToolTipText = "Cannot be redone.";
            }
        }

        private void richTextBox1_LinkClicked(object sender, LinkClickedEventArgs e)
        {
            Process.Start(e.LinkText);
        }

        private void New()
        {
            if (richTextBox1.Modified)
            {
                DialogResult dialogResult = MessageBox.Show("Save changes?", "Save", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                    Save();
            }

            richTextBox1.Text = "";
            richTextBox1.Modified = false;
            fileName = "";
            this.Text = "New File";
        }

        private void Save()
        {
            if (fileName == "")
            {
                SaveAs();
            }
            else
            {
                richTextBox1.SaveFile(fileName);
                richTextBox1.Modified = false;
            }
        }

        private void SaveAs()
        {
            saveFileDialog1.Title = "Save As";
            saveFileDialog1.Filter = "RTF Files|*.rtf";
            saveFileDialog1.DefaultExt = "RTF";

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                fileName = saveFileDialog1.FileName;
                richTextBox1.SaveFile(fileName);
                richTextBox1.Modified = false;
                this.Text = fileName;
            }
        }

        private void Open()
        {
            openFileDialog1.Title = "Open";
            openFileDialog1.Filter = "RTF Files|*.rtf";
            openFileDialog1.DefaultExt = "RTF";

            if (richTextBox1.Modified)
            {
                DialogResult dialogResult = MessageBox.Show("Save changes?", "Save", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                    Save();
            }

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                fileName = openFileDialog1.FileName;
                richTextBox1.LoadFile(fileName);
                richTextBox1.Modified = false;
                this.Text = fileName;
            }
        }

        private bool Exit()
        {
            if (richTextBox1.Modified)
            {
                DialogResult dialogResult = MessageBox.Show("Save changes?", "Exit", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                switch (dialogResult)
                {
                    case DialogResult.Yes:
                        Save();
                        return true;
                    case DialogResult.No:
                        return true;
                    case DialogResult.Cancel:
                        return false;
                }
            }
            else
            {
                return true;
            }

            return true;
        }

        private void Bold(bool state)
        {
            if (state)
                richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont, richTextBox1.SelectionFont.Style | FontStyle.Bold);
            else
                richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont, richTextBox1.SelectionFont.Style ^ FontStyle.Bold);
        }

        private void Underline(bool state)
        {
            if (state)
                richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont, richTextBox1.SelectionFont.Style | FontStyle.Underline);
            else
                richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont, richTextBox1.SelectionFont.Style ^ FontStyle.Underline);
        }

        private void Italic(bool state)
        {
            if (state)
                richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont, richTextBox1.SelectionFont.Style | FontStyle.Italic);
            else
                richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont, richTextBox1.SelectionFont.Style ^ FontStyle.Italic);
        }

        private void Strikethrough(bool state)
        {
            if (state)
                richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont, richTextBox1.SelectionFont.Style | FontStyle.Strikeout);
            else
                richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont, richTextBox1.SelectionFont.Style ^ FontStyle.Strikeout);
        }

        private void Align(ToolBarButton button)
        {
            bool state = button.Pushed;
            toolBar1.Buttons[14].Pushed = false;
            toolBar1.Buttons[15].Pushed = false;
            toolBar1.Buttons[16].Pushed = false;

            if (state)
            {
                switch (button.Text)
                {
                    case "Left":
                        richTextBox1.SelectionAlignment = HorizontalAlignment.Left;
                        toolBar1.Buttons[14].Pushed = true;
                        break;
                    case "Center":
                        richTextBox1.SelectionAlignment = HorizontalAlignment.Center;
                        toolBar1.Buttons[15].Pushed = true;
                        break;
                    case "Right":
                        richTextBox1.SelectionAlignment = HorizontalAlignment.Right;
                        toolBar1.Buttons[16].Pushed = true;
                        break;
                }
            }
        }

        private void SuperscriptSubscript(ToolBarButton button)
        {
            bool state = button.Pushed;
            toolBar1.Buttons[25].Pushed = false;
            toolBar1.Buttons[26].Pushed = false;

            if (state)
            {
                switch (button.Text)
                {
                    case "Superscript":
                        richTextBox1.SelectionCharOffset = (int)richTextBox1.SelectionFont.Size / 2;
                        toolBar1.Buttons[25].Pushed = true;
                        break;
                    case "Subscript":
                        richTextBox1.SelectionCharOffset = (int)-richTextBox1.SelectionFont.Size / 2;
                        toolBar1.Buttons[26].Pushed = true;
                        break;
                }
            }
            else
            {
                richTextBox1.SelectionCharOffset = 0;
            }
        }

        private void Cut()
        {
            richTextBox1.Cut();
        }

        private void Copy()
        {
            richTextBox1.Copy();
        }

        private void Paste()
        {
            richTextBox1.Paste();
        }

        private void Delete()
        {
            richTextBox1.SelectedText = "";
        }

        private void Undo()
        {
            if (richTextBox1.CanUndo)
                richTextBox1.Undo();
        }

        private void Refr()
        {
            if (richTextBox1.CanRedo)
                richTextBox1.Redo();
        }

        private void BulletPoint(bool state)
        {
            richTextBox1.SelectionBullet = state;
        }

        public void Find()
        {
            form2.textBox1.Text = richTextBox1.SelectedText;
            richTextBox = richTextBox1;
            form2.Show();
        }
    }
}

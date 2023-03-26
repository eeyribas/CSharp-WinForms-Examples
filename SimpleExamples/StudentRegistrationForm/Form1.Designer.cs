
namespace StudentRegistrationForm
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.MaleRadioBtn = new System.Windows.Forms.RadioButton();
            this.CityCmb = new System.Windows.Forms.ComboBox();
            this.IconPic3 = new System.Windows.Forms.PictureBox();
            this.IconPic4 = new System.Windows.Forms.PictureBox();
            this.IconPic2 = new System.Windows.Forms.PictureBox();
            this.IconPic1 = new System.Windows.Forms.PictureBox();
            this.IconRadioBtn4 = new System.Windows.Forms.RadioButton();
            this.IconRadioBtn3 = new System.Windows.Forms.RadioButton();
            this.CityLbl = new System.Windows.Forms.Label();
            this.StudentNameTxt = new System.Windows.Forms.TextBox();
            this.StudentNameLbl = new System.Windows.Forms.Label();
            this.StudentListGrp = new System.Windows.Forms.GroupBox();
            this.StudentsLvw = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TownLbl = new System.Windows.Forms.Label();
            this.ListTypeCmb = new System.Windows.Forms.ComboBox();
            this.AddListBtn = new System.Windows.Forms.Button();
            this.ImgList1 = new System.Windows.Forms.ImageList(this.components);
            this.ImgList2 = new System.Windows.Forms.ImageList(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.IconRadioBtn2 = new System.Windows.Forms.RadioButton();
            this.MenuMns = new System.Windows.Forms.MenuStrip();
            this.FileTsr = new System.Windows.Forms.ToolStripMenuItem();
            this.ClearSelectionMnsItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ClearListMnsItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitMnsItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HelpTsr = new System.Windows.Forms.ToolStripMenuItem();
            this.AboutMnsItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolboxTsr = new System.Windows.Forms.ToolStrip();
            this.ClearTsr = new System.Windows.Forms.ToolStripButton();
            this.ClearAllTsr = new System.Windows.Forms.ToolStripButton();
            this.InfoTsr = new System.Windows.Forms.ToolStripButton();
            this.StundentInfoGrp = new System.Windows.Forms.GroupBox();
            this.TownLst = new System.Windows.Forms.ListBox();
            this.HobbyGrp = new System.Windows.Forms.GroupBox();
            this.SportChk = new System.Windows.Forms.CheckBox();
            this.MusicChk = new System.Windows.Forms.CheckBox();
            this.FilmChk = new System.Windows.Forms.CheckBox();
            this.IconGrp = new System.Windows.Forms.GroupBox();
            this.IconRadioBtn1 = new System.Windows.Forms.RadioButton();
            this.GenderGrp = new System.Windows.Forms.GroupBox();
            this.FemaleRadioBtn = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.IconPic3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IconPic4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IconPic2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IconPic1)).BeginInit();
            this.StudentListGrp.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.MenuMns.SuspendLayout();
            this.ToolboxTsr.SuspendLayout();
            this.StundentInfoGrp.SuspendLayout();
            this.HobbyGrp.SuspendLayout();
            this.IconGrp.SuspendLayout();
            this.GenderGrp.SuspendLayout();
            this.SuspendLayout();
            // 
            // MaleRadioBtn
            // 
            this.MaleRadioBtn.AutoSize = true;
            this.MaleRadioBtn.Checked = true;
            this.MaleRadioBtn.Location = new System.Drawing.Point(8, 23);
            this.MaleRadioBtn.Margin = new System.Windows.Forms.Padding(4);
            this.MaleRadioBtn.Name = "MaleRadioBtn";
            this.MaleRadioBtn.Size = new System.Drawing.Size(59, 21);
            this.MaleRadioBtn.TabIndex = 0;
            this.MaleRadioBtn.TabStop = true;
            this.MaleRadioBtn.Text = "Male";
            this.MaleRadioBtn.UseVisualStyleBackColor = true;
            // 
            // CityCmb
            // 
            this.CityCmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CityCmb.FormattingEnabled = true;
            this.CityCmb.Items.AddRange(new object[] {
            "Kütahya",
            "Bilecik",
            "Sakarya",
            "Bursa",
            "Sinop"});
            this.CityCmb.Location = new System.Drawing.Point(140, 66);
            this.CityCmb.Margin = new System.Windows.Forms.Padding(4);
            this.CityCmb.Name = "CityCmb";
            this.CityCmb.Size = new System.Drawing.Size(216, 24);
            this.CityCmb.TabIndex = 3;
            this.CityCmb.SelectedIndexChanged += new System.EventHandler(this.CityCmb_SelectedIndexChanged);
            // 
            // IconPic3
            // 
            this.IconPic3.Image = ((System.Drawing.Image)(resources.GetObject("IconPic3.Image")));
            this.IconPic3.Location = new System.Drawing.Point(35, 52);
            this.IconPic3.Margin = new System.Windows.Forms.Padding(4);
            this.IconPic3.Name = "IconPic3";
            this.IconPic3.Size = new System.Drawing.Size(27, 25);
            this.IconPic3.TabIndex = 7;
            this.IconPic3.TabStop = false;
            // 
            // IconPic4
            // 
            this.IconPic4.Image = ((System.Drawing.Image)(resources.GetObject("IconPic4.Image")));
            this.IconPic4.Location = new System.Drawing.Point(157, 52);
            this.IconPic4.Margin = new System.Windows.Forms.Padding(4);
            this.IconPic4.Name = "IconPic4";
            this.IconPic4.Size = new System.Drawing.Size(27, 25);
            this.IconPic4.TabIndex = 6;
            this.IconPic4.TabStop = false;
            // 
            // IconPic2
            // 
            this.IconPic2.Image = ((System.Drawing.Image)(resources.GetObject("IconPic2.Image")));
            this.IconPic2.Location = new System.Drawing.Point(157, 20);
            this.IconPic2.Margin = new System.Windows.Forms.Padding(4);
            this.IconPic2.Name = "IconPic2";
            this.IconPic2.Size = new System.Drawing.Size(27, 25);
            this.IconPic2.TabIndex = 5;
            this.IconPic2.TabStop = false;
            // 
            // IconPic1
            // 
            this.IconPic1.Image = ((System.Drawing.Image)(resources.GetObject("IconPic1.Image")));
            this.IconPic1.InitialImage = null;
            this.IconPic1.Location = new System.Drawing.Point(35, 20);
            this.IconPic1.Margin = new System.Windows.Forms.Padding(4);
            this.IconPic1.Name = "IconPic1";
            this.IconPic1.Size = new System.Drawing.Size(27, 25);
            this.IconPic1.TabIndex = 4;
            this.IconPic1.TabStop = false;
            // 
            // IconRadioBtn4
            // 
            this.IconRadioBtn4.AutoSize = true;
            this.IconRadioBtn4.Location = new System.Drawing.Point(129, 52);
            this.IconRadioBtn4.Margin = new System.Windows.Forms.Padding(4);
            this.IconRadioBtn4.Name = "IconRadioBtn4";
            this.IconRadioBtn4.Size = new System.Drawing.Size(33, 21);
            this.IconRadioBtn4.TabIndex = 3;
            this.IconRadioBtn4.TabStop = true;
            this.IconRadioBtn4.Text = " ";
            this.IconRadioBtn4.UseVisualStyleBackColor = true;
            // 
            // IconRadioBtn3
            // 
            this.IconRadioBtn3.AutoSize = true;
            this.IconRadioBtn3.Location = new System.Drawing.Point(8, 52);
            this.IconRadioBtn3.Margin = new System.Windows.Forms.Padding(4);
            this.IconRadioBtn3.Name = "IconRadioBtn3";
            this.IconRadioBtn3.Size = new System.Drawing.Size(33, 21);
            this.IconRadioBtn3.TabIndex = 2;
            this.IconRadioBtn3.TabStop = true;
            this.IconRadioBtn3.Text = " ";
            this.IconRadioBtn3.UseVisualStyleBackColor = true;
            // 
            // CityLbl
            // 
            this.CityLbl.AutoSize = true;
            this.CityLbl.Location = new System.Drawing.Point(8, 70);
            this.CityLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CityLbl.Name = "CityLbl";
            this.CityLbl.Size = new System.Drawing.Size(39, 17);
            this.CityLbl.TabIndex = 2;
            this.CityLbl.Text = "City :";
            // 
            // StudentNameTxt
            // 
            this.StudentNameTxt.Location = new System.Drawing.Point(96, 25);
            this.StudentNameTxt.Margin = new System.Windows.Forms.Padding(4);
            this.StudentNameTxt.Name = "StudentNameTxt";
            this.StudentNameTxt.Size = new System.Drawing.Size(260, 22);
            this.StudentNameTxt.TabIndex = 1;
            // 
            // StudentNameLbl
            // 
            this.StudentNameLbl.AutoSize = true;
            this.StudentNameLbl.Location = new System.Drawing.Point(8, 28);
            this.StudentNameLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.StudentNameLbl.Name = "StudentNameLbl";
            this.StudentNameLbl.Size = new System.Drawing.Size(53, 17);
            this.StudentNameLbl.TabIndex = 0;
            this.StudentNameLbl.Text = "Name :";
            // 
            // StudentListGrp
            // 
            this.StudentListGrp.Controls.Add(this.StudentsLvw);
            this.StudentListGrp.Location = new System.Drawing.Point(404, 79);
            this.StudentListGrp.Margin = new System.Windows.Forms.Padding(4);
            this.StudentListGrp.Name = "StudentListGrp";
            this.StudentListGrp.Padding = new System.Windows.Forms.Padding(4);
            this.StudentListGrp.Size = new System.Drawing.Size(692, 414);
            this.StudentListGrp.TabIndex = 10;
            this.StudentListGrp.TabStop = false;
            this.StudentListGrp.Text = "Student List";
            // 
            // StudentsLvw
            // 
            this.StudentsLvw.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7});
            this.StudentsLvw.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.StudentsLvw.FullRowSelect = true;
            this.StudentsLvw.HideSelection = false;
            this.StudentsLvw.Location = new System.Drawing.Point(4, 29);
            this.StudentsLvw.Margin = new System.Windows.Forms.Padding(4);
            this.StudentsLvw.Name = "StudentsLvw";
            this.StudentsLvw.Size = new System.Drawing.Size(684, 381);
            this.StudentsLvw.TabIndex = 9;
            this.StudentsLvw.UseCompatibleStateImageBehavior = false;
            this.StudentsLvw.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Name Surname";
            this.columnHeader1.Width = 131;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Country";
            this.columnHeader2.Width = 74;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Town";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Gender";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Film";
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Music";
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Sport";
            // 
            // TownLbl
            // 
            this.TownLbl.AutoSize = true;
            this.TownLbl.Location = new System.Drawing.Point(8, 111);
            this.TownLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TownLbl.Name = "TownLbl";
            this.TownLbl.Size = new System.Drawing.Size(50, 17);
            this.TownLbl.TabIndex = 4;
            this.TownLbl.Text = "Town :";
            // 
            // ListTypeCmb
            // 
            this.ListTypeCmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ListTypeCmb.FormattingEnabled = true;
            this.ListTypeCmb.Items.AddRange(new object[] {
            "Large icon",
            "Details",
            "Small icon",
            "List",
            "Tile"});
            this.ListTypeCmb.Location = new System.Drawing.Point(919, 496);
            this.ListTypeCmb.Margin = new System.Windows.Forms.Padding(4);
            this.ListTypeCmb.Name = "ListTypeCmb";
            this.ListTypeCmb.Size = new System.Drawing.Size(160, 24);
            this.ListTypeCmb.TabIndex = 12;
            this.ListTypeCmb.SelectedIndexChanged += new System.EventHandler(this.ListTypeCmb_SelectedIndexChanged);
            // 
            // AddListBtn
            // 
            this.AddListBtn.Location = new System.Drawing.Point(216, 492);
            this.AddListBtn.Margin = new System.Windows.Forms.Padding(4);
            this.AddListBtn.Name = "AddListBtn";
            this.AddListBtn.Size = new System.Drawing.Size(180, 28);
            this.AddListBtn.TabIndex = 11;
            this.AddListBtn.Text = "Add Info In List >>";
            this.AddListBtn.UseVisualStyleBackColor = true;
            this.AddListBtn.Click += new System.EventHandler(this.AddListBtn_Click);
            this.AddListBtn.MouseLeave += new System.EventHandler(this.AddListBtn_MouseLeave);
            this.AddListBtn.MouseMove += new System.Windows.Forms.MouseEventHandler(this.AddListBtn_MouseMove);
            // 
            // ImgList1
            // 
            this.ImgList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ImgList1.ImageStream")));
            this.ImgList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ImgList1.Images.SetKeyName(0, "person1-small.jpg");
            this.ImgList1.Images.SetKeyName(1, "person2-small.jpg");
            this.ImgList1.Images.SetKeyName(2, "person3-small.jpg");
            this.ImgList1.Images.SetKeyName(3, "person4-small.png");
            // 
            // ImgList2
            // 
            this.ImgList2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ImgList2.ImageStream")));
            this.ImgList2.TransparentColor = System.Drawing.Color.Transparent;
            this.ImgList2.Images.SetKeyName(0, "person1-large.jpg");
            this.ImgList2.Images.SetKeyName(1, "person2-large.jpg");
            this.ImgList2.Images.SetKeyName(2, "person3-large.jpg");
            this.ImgList2.Images.SetKeyName(3, "person4-large.png");
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2});
            this.statusStrip1.Location = new System.Drawing.Point(0, 532);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1112, 22);
            this.statusStrip1.TabIndex = 13;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 16);
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(0, 16);
            // 
            // IconRadioBtn2
            // 
            this.IconRadioBtn2.AutoSize = true;
            this.IconRadioBtn2.Location = new System.Drawing.Point(129, 23);
            this.IconRadioBtn2.Margin = new System.Windows.Forms.Padding(4);
            this.IconRadioBtn2.Name = "IconRadioBtn2";
            this.IconRadioBtn2.Size = new System.Drawing.Size(33, 21);
            this.IconRadioBtn2.TabIndex = 1;
            this.IconRadioBtn2.TabStop = true;
            this.IconRadioBtn2.Text = " ";
            this.IconRadioBtn2.UseVisualStyleBackColor = true;
            // 
            // MenuMns
            // 
            this.MenuMns.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.MenuMns.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MenuMns.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileTsr,
            this.HelpTsr});
            this.MenuMns.Location = new System.Drawing.Point(0, 27);
            this.MenuMns.Name = "MenuMns";
            this.MenuMns.Size = new System.Drawing.Size(1112, 28);
            this.MenuMns.TabIndex = 7;
            this.MenuMns.Text = "anaMenü";
            // 
            // FileTsr
            // 
            this.FileTsr.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ClearSelectionMnsItem,
            this.ClearListMnsItem,
            this.ExitMnsItem});
            this.FileTsr.Name = "FileTsr";
            this.FileTsr.ShortcutKeyDisplayString = "D";
            this.FileTsr.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D)));
            this.FileTsr.Size = new System.Drawing.Size(46, 24);
            this.FileTsr.Text = "&File";
            // 
            // ClearSelectionMnsItem
            // 
            this.ClearSelectionMnsItem.Name = "ClearSelectionMnsItem";
            this.ClearSelectionMnsItem.ShortcutKeyDisplayString = "CTRL+I";
            this.ClearSelectionMnsItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.I)));
            this.ClearSelectionMnsItem.Size = new System.Drawing.Size(332, 26);
            this.ClearSelectionMnsItem.Tag = "S";
            this.ClearSelectionMnsItem.Text = "&Clear Selection Student Info";
            this.ClearSelectionMnsItem.Click += new System.EventHandler(this.ClearSelectionMnsItem_Click);
            // 
            // ClearListMnsItem
            // 
            this.ClearListMnsItem.Name = "ClearListMnsItem";
            this.ClearListMnsItem.ShortcutKeyDisplayString = "CTRL+L";
            this.ClearListMnsItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.L)));
            this.ClearListMnsItem.Size = new System.Drawing.Size(332, 26);
            this.ClearListMnsItem.Text = "Clear List";
            this.ClearListMnsItem.Click += new System.EventHandler(this.ClearListMnsItem_Click);
            // 
            // ExitMnsItem
            // 
            this.ExitMnsItem.Name = "ExitMnsItem";
            this.ExitMnsItem.ShortcutKeyDisplayString = "CTRL+Q";
            this.ExitMnsItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
            this.ExitMnsItem.Size = new System.Drawing.Size(332, 26);
            this.ExitMnsItem.Text = "Exit";
            this.ExitMnsItem.Click += new System.EventHandler(this.ExitMnsItem_Click);
            // 
            // HelpTsr
            // 
            this.HelpTsr.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AboutMnsItem});
            this.HelpTsr.Name = "HelpTsr";
            this.HelpTsr.Size = new System.Drawing.Size(55, 24);
            this.HelpTsr.Text = "&Help";
            // 
            // AboutMnsItem
            // 
            this.AboutMnsItem.Name = "AboutMnsItem";
            this.AboutMnsItem.ShortcutKeyDisplayString = "Ctrl+A";
            this.AboutMnsItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.AboutMnsItem.Size = new System.Drawing.Size(185, 26);
            this.AboutMnsItem.Text = "&About";
            this.AboutMnsItem.Click += new System.EventHandler(this.AboutMnsItem_Click);
            // 
            // ToolboxTsr
            // 
            this.ToolboxTsr.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ToolboxTsr.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ToolboxTsr.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ClearTsr,
            this.ClearAllTsr,
            this.InfoTsr});
            this.ToolboxTsr.Location = new System.Drawing.Point(0, 0);
            this.ToolboxTsr.Name = "ToolboxTsr";
            this.ToolboxTsr.Size = new System.Drawing.Size(1112, 27);
            this.ToolboxTsr.TabIndex = 8;
            this.ToolboxTsr.Text = "araçKutusu";
            // 
            // ClearTsr
            // 
            this.ClearTsr.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ClearTsr.Image = ((System.Drawing.Image)(resources.GetObject("ClearTsr.Image")));
            this.ClearTsr.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ClearTsr.Name = "ClearTsr";
            this.ClearTsr.Size = new System.Drawing.Size(29, 24);
            this.ClearTsr.Text = "SeçilenÖğrenciBilgileriTemizle";
            this.ClearTsr.Click += new System.EventHandler(this.ClearListMnsItem_Click);
            // 
            // ClearAllTsr
            // 
            this.ClearAllTsr.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ClearAllTsr.Image = ((System.Drawing.Image)(resources.GetObject("ClearAllTsr.Image")));
            this.ClearAllTsr.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ClearAllTsr.Name = "ClearAllTsr";
            this.ClearAllTsr.Size = new System.Drawing.Size(29, 24);
            this.ClearAllTsr.Text = "ListesiTemizle";
            this.ClearAllTsr.Click += new System.EventHandler(this.ClearSelectionMnsItem_Click);
            // 
            // InfoTsr
            // 
            this.InfoTsr.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.InfoTsr.Image = ((System.Drawing.Image)(resources.GetObject("InfoTsr.Image")));
            this.InfoTsr.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.InfoTsr.Name = "InfoTsr";
            this.InfoTsr.Size = new System.Drawing.Size(29, 24);
            this.InfoTsr.Text = "BilgiEdin";
            this.InfoTsr.Click += new System.EventHandler(this.AboutMnsItem_Click);
            // 
            // StundentInfoGrp
            // 
            this.StundentInfoGrp.Controls.Add(this.TownLst);
            this.StundentInfoGrp.Controls.Add(this.HobbyGrp);
            this.StundentInfoGrp.Controls.Add(this.IconGrp);
            this.StundentInfoGrp.Controls.Add(this.GenderGrp);
            this.StundentInfoGrp.Controls.Add(this.TownLbl);
            this.StundentInfoGrp.Controls.Add(this.CityCmb);
            this.StundentInfoGrp.Controls.Add(this.CityLbl);
            this.StundentInfoGrp.Controls.Add(this.StudentNameTxt);
            this.StundentInfoGrp.Controls.Add(this.StudentNameLbl);
            this.StundentInfoGrp.Location = new System.Drawing.Point(15, 79);
            this.StundentInfoGrp.Margin = new System.Windows.Forms.Padding(4);
            this.StundentInfoGrp.Name = "StundentInfoGrp";
            this.StundentInfoGrp.Padding = new System.Windows.Forms.Padding(4);
            this.StundentInfoGrp.Size = new System.Drawing.Size(381, 414);
            this.StundentInfoGrp.TabIndex = 9;
            this.StundentInfoGrp.TabStop = false;
            this.StundentInfoGrp.Text = "Student Info";
            // 
            // TownLst
            // 
            this.TownLst.FormattingEnabled = true;
            this.TownLst.ItemHeight = 16;
            this.TownLst.Location = new System.Drawing.Point(140, 111);
            this.TownLst.Margin = new System.Windows.Forms.Padding(4);
            this.TownLst.Name = "TownLst";
            this.TownLst.Size = new System.Drawing.Size(216, 68);
            this.TownLst.TabIndex = 9;
            // 
            // HobbyGrp
            // 
            this.HobbyGrp.Controls.Add(this.SportChk);
            this.HobbyGrp.Controls.Add(this.MusicChk);
            this.HobbyGrp.Controls.Add(this.FilmChk);
            this.HobbyGrp.Location = new System.Drawing.Point(19, 287);
            this.HobbyGrp.Margin = new System.Windows.Forms.Padding(4);
            this.HobbyGrp.Name = "HobbyGrp";
            this.HobbyGrp.Padding = new System.Windows.Forms.Padding(4);
            this.HobbyGrp.Size = new System.Drawing.Size(339, 119);
            this.HobbyGrp.TabIndex = 8;
            this.HobbyGrp.TabStop = false;
            this.HobbyGrp.Text = "Hobby";
            // 
            // SportChk
            // 
            this.SportChk.AutoSize = true;
            this.SportChk.Location = new System.Drawing.Point(8, 92);
            this.SportChk.Margin = new System.Windows.Forms.Padding(4);
            this.SportChk.Name = "SportChk";
            this.SportChk.Size = new System.Drawing.Size(109, 21);
            this.SportChk.TabIndex = 2;
            this.SportChk.Text = "Make Sports";
            this.SportChk.UseVisualStyleBackColor = true;
            // 
            // MusicChk
            // 
            this.MusicChk.AutoSize = true;
            this.MusicChk.Location = new System.Drawing.Point(8, 64);
            this.MusicChk.Margin = new System.Windows.Forms.Padding(4);
            this.MusicChk.Name = "MusicChk";
            this.MusicChk.Size = new System.Drawing.Size(108, 21);
            this.MusicChk.TabIndex = 1;
            this.MusicChk.Text = "Listen Music";
            this.MusicChk.UseVisualStyleBackColor = true;
            // 
            // FilmChk
            // 
            this.FilmChk.AutoSize = true;
            this.FilmChk.Location = new System.Drawing.Point(8, 36);
            this.FilmChk.Margin = new System.Windows.Forms.Padding(4);
            this.FilmChk.Name = "FilmChk";
            this.FilmChk.Size = new System.Drawing.Size(99, 21);
            this.FilmChk.TabIndex = 0;
            this.FilmChk.Text = "Watch Film";
            this.FilmChk.UseVisualStyleBackColor = true;
            // 
            // IconGrp
            // 
            this.IconGrp.Controls.Add(this.IconPic3);
            this.IconGrp.Controls.Add(this.IconPic4);
            this.IconGrp.Controls.Add(this.IconPic2);
            this.IconGrp.Controls.Add(this.IconPic1);
            this.IconGrp.Controls.Add(this.IconRadioBtn4);
            this.IconGrp.Controls.Add(this.IconRadioBtn3);
            this.IconGrp.Controls.Add(this.IconRadioBtn2);
            this.IconGrp.Controls.Add(this.IconRadioBtn1);
            this.IconGrp.Location = new System.Drawing.Point(153, 187);
            this.IconGrp.Margin = new System.Windows.Forms.Padding(4);
            this.IconGrp.Name = "IconGrp";
            this.IconGrp.Padding = new System.Windows.Forms.Padding(4);
            this.IconGrp.Size = new System.Drawing.Size(204, 92);
            this.IconGrp.TabIndex = 7;
            this.IconGrp.TabStop = false;
            this.IconGrp.Text = "Selection Icon :";
            // 
            // IconRadioBtn1
            // 
            this.IconRadioBtn1.AutoSize = true;
            this.IconRadioBtn1.Checked = true;
            this.IconRadioBtn1.Location = new System.Drawing.Point(8, 23);
            this.IconRadioBtn1.Margin = new System.Windows.Forms.Padding(4);
            this.IconRadioBtn1.Name = "IconRadioBtn1";
            this.IconRadioBtn1.Size = new System.Drawing.Size(17, 16);
            this.IconRadioBtn1.TabIndex = 0;
            this.IconRadioBtn1.TabStop = true;
            this.IconRadioBtn1.UseVisualStyleBackColor = true;
            // 
            // GenderGrp
            // 
            this.GenderGrp.Controls.Add(this.FemaleRadioBtn);
            this.GenderGrp.Controls.Add(this.MaleRadioBtn);
            this.GenderGrp.Location = new System.Drawing.Point(19, 187);
            this.GenderGrp.Margin = new System.Windows.Forms.Padding(4);
            this.GenderGrp.Name = "GenderGrp";
            this.GenderGrp.Padding = new System.Windows.Forms.Padding(4);
            this.GenderGrp.Size = new System.Drawing.Size(113, 92);
            this.GenderGrp.TabIndex = 6;
            this.GenderGrp.TabStop = false;
            this.GenderGrp.Text = "Gender";
            // 
            // FemaleRadioBtn
            // 
            this.FemaleRadioBtn.AutoSize = true;
            this.FemaleRadioBtn.Location = new System.Drawing.Point(8, 52);
            this.FemaleRadioBtn.Margin = new System.Windows.Forms.Padding(4);
            this.FemaleRadioBtn.Name = "FemaleRadioBtn";
            this.FemaleRadioBtn.Size = new System.Drawing.Size(75, 21);
            this.FemaleRadioBtn.TabIndex = 1;
            this.FemaleRadioBtn.TabStop = true;
            this.FemaleRadioBtn.Text = "Female";
            this.FemaleRadioBtn.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1112, 554);
            this.Controls.Add(this.StudentListGrp);
            this.Controls.Add(this.ListTypeCmb);
            this.Controls.Add(this.AddListBtn);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.MenuMns);
            this.Controls.Add(this.ToolboxTsr);
            this.Controls.Add(this.StundentInfoGrp);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.IconPic3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IconPic4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IconPic2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IconPic1)).EndInit();
            this.StudentListGrp.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.MenuMns.ResumeLayout(false);
            this.MenuMns.PerformLayout();
            this.ToolboxTsr.ResumeLayout(false);
            this.ToolboxTsr.PerformLayout();
            this.StundentInfoGrp.ResumeLayout(false);
            this.StundentInfoGrp.PerformLayout();
            this.HobbyGrp.ResumeLayout(false);
            this.HobbyGrp.PerformLayout();
            this.IconGrp.ResumeLayout(false);
            this.IconGrp.PerformLayout();
            this.GenderGrp.ResumeLayout(false);
            this.GenderGrp.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton MaleRadioBtn;
        private System.Windows.Forms.ComboBox CityCmb;
        private System.Windows.Forms.PictureBox IconPic3;
        private System.Windows.Forms.PictureBox IconPic4;
        private System.Windows.Forms.PictureBox IconPic2;
        private System.Windows.Forms.PictureBox IconPic1;
        private System.Windows.Forms.RadioButton IconRadioBtn4;
        private System.Windows.Forms.RadioButton IconRadioBtn3;
        private System.Windows.Forms.Label CityLbl;
        private System.Windows.Forms.TextBox StudentNameTxt;
        private System.Windows.Forms.Label StudentNameLbl;
        private System.Windows.Forms.GroupBox StudentListGrp;
        private System.Windows.Forms.ListView StudentsLvw;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.Label TownLbl;
        private System.Windows.Forms.ComboBox ListTypeCmb;
        private System.Windows.Forms.Button AddListBtn;
        private System.Windows.Forms.ImageList ImgList1;
        private System.Windows.Forms.ImageList ImgList2;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.RadioButton IconRadioBtn2;
        private System.Windows.Forms.MenuStrip MenuMns;
        private System.Windows.Forms.ToolStripMenuItem FileTsr;
        private System.Windows.Forms.ToolStripMenuItem ClearSelectionMnsItem;
        private System.Windows.Forms.ToolStripMenuItem ClearListMnsItem;
        private System.Windows.Forms.ToolStripMenuItem ExitMnsItem;
        private System.Windows.Forms.ToolStripMenuItem HelpTsr;
        private System.Windows.Forms.ToolStripMenuItem AboutMnsItem;
        private System.Windows.Forms.ToolStrip ToolboxTsr;
        private System.Windows.Forms.ToolStripButton ClearTsr;
        private System.Windows.Forms.ToolStripButton ClearAllTsr;
        private System.Windows.Forms.ToolStripButton InfoTsr;
        private System.Windows.Forms.GroupBox StundentInfoGrp;
        private System.Windows.Forms.ListBox TownLst;
        private System.Windows.Forms.GroupBox HobbyGrp;
        private System.Windows.Forms.CheckBox SportChk;
        private System.Windows.Forms.CheckBox MusicChk;
        private System.Windows.Forms.CheckBox FilmChk;
        private System.Windows.Forms.GroupBox IconGrp;
        private System.Windows.Forms.RadioButton IconRadioBtn1;
        private System.Windows.Forms.GroupBox GenderGrp;
        private System.Windows.Forms.RadioButton FemaleRadioBtn;
    }
}


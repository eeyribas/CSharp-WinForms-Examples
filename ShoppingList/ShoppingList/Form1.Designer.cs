
namespace ShoppingList
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
            this.SearchBtn = new System.Windows.Forms.Button();
            this.ListLbl = new System.Windows.Forms.Label();
            this.AddListBtn = new System.Windows.Forms.Button();
            this.ClearListBtn = new System.Windows.Forms.Button();
            this.ExtractListBtn = new System.Windows.Forms.Button();
            this.ListLst = new System.Windows.Forms.ListBox();
            this.AddSearchLbl = new System.Windows.Forms.Label();
            this.AddTxt = new System.Windows.Forms.TextBox();
            this.LastRadioBtn = new System.Windows.Forms.RadioButton();
            this.FirstRadioBtn = new System.Windows.Forms.RadioButton();
            this.SelectionWithAddGrp = new System.Windows.Forms.GroupBox();
            this.SelectionWithAddBtn = new System.Windows.Forms.Button();
            this.SearchResultLbl = new System.Windows.Forms.Label();
            this.SelectionWithAddGrp.SuspendLayout();
            this.SuspendLayout();
            // 
            // SearchBtn
            // 
            this.SearchBtn.Location = new System.Drawing.Point(209, 38);
            this.SearchBtn.Margin = new System.Windows.Forms.Padding(4);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.Size = new System.Drawing.Size(60, 28);
            this.SearchBtn.TabIndex = 20;
            this.SearchBtn.Text = "Search";
            this.SearchBtn.UseVisualStyleBackColor = true;
            this.SearchBtn.Click += new System.EventHandler(this.SearchBtn_Click);
            // 
            // ListLbl
            // 
            this.ListLbl.AutoSize = true;
            this.ListLbl.Location = new System.Drawing.Point(279, 18);
            this.ListLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ListLbl.Name = "ListLbl";
            this.ListLbl.Size = new System.Drawing.Size(30, 17);
            this.ListLbl.TabIndex = 19;
            this.ListLbl.Text = "List";
            // 
            // AddListBtn
            // 
            this.AddListBtn.Location = new System.Drawing.Point(15, 70);
            this.AddListBtn.Margin = new System.Windows.Forms.Padding(4);
            this.AddListBtn.Name = "AddListBtn";
            this.AddListBtn.Size = new System.Drawing.Size(107, 28);
            this.AddListBtn.TabIndex = 18;
            this.AddListBtn.Text = "Add List";
            this.AddListBtn.UseVisualStyleBackColor = true;
            this.AddListBtn.Click += new System.EventHandler(this.SelectionWithAddBtn_Click);
            // 
            // ClearListBtn
            // 
            this.ClearListBtn.Location = new System.Drawing.Point(453, 210);
            this.ClearListBtn.Margin = new System.Windows.Forms.Padding(4);
            this.ClearListBtn.Name = "ClearListBtn";
            this.ClearListBtn.Size = new System.Drawing.Size(100, 42);
            this.ClearListBtn.TabIndex = 17;
            this.ClearListBtn.Text = "Clear List";
            this.ClearListBtn.UseVisualStyleBackColor = true;
            this.ClearListBtn.Click += new System.EventHandler(this.ClearListBtn_Click);
            // 
            // ExtractListBtn
            // 
            this.ExtractListBtn.Location = new System.Drawing.Point(283, 210);
            this.ExtractListBtn.Margin = new System.Windows.Forms.Padding(4);
            this.ExtractListBtn.Name = "ExtractListBtn";
            this.ExtractListBtn.Size = new System.Drawing.Size(161, 42);
            this.ExtractListBtn.TabIndex = 16;
            this.ExtractListBtn.Text = "Extract List";
            this.ExtractListBtn.UseVisualStyleBackColor = true;
            this.ExtractListBtn.Click += new System.EventHandler(this.ExtractListBtn_Click);
            // 
            // ListLst
            // 
            this.ListLst.FormattingEnabled = true;
            this.ListLst.ItemHeight = 16;
            this.ListLst.Location = new System.Drawing.Point(283, 38);
            this.ListLst.Margin = new System.Windows.Forms.Padding(4);
            this.ListLst.Name = "ListLst";
            this.ListLst.Size = new System.Drawing.Size(263, 164);
            this.ListLst.TabIndex = 15;
            // 
            // AddSearchLbl
            // 
            this.AddSearchLbl.AutoSize = true;
            this.AddSearchLbl.Location = new System.Drawing.Point(46, 18);
            this.AddSearchLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.AddSearchLbl.Name = "AddSearchLbl";
            this.AddSearchLbl.Size = new System.Drawing.Size(82, 17);
            this.AddSearchLbl.TabIndex = 14;
            this.AddSearchLbl.Text = "Add/Search";
            // 
            // AddTxt
            // 
            this.AddTxt.Location = new System.Drawing.Point(11, 38);
            this.AddTxt.Margin = new System.Windows.Forms.Padding(4);
            this.AddTxt.Name = "AddTxt";
            this.AddTxt.Size = new System.Drawing.Size(188, 22);
            this.AddTxt.TabIndex = 13;
            // 
            // LastRadioBtn
            // 
            this.LastRadioBtn.AutoSize = true;
            this.LastRadioBtn.Checked = true;
            this.LastRadioBtn.Location = new System.Drawing.Point(8, 58);
            this.LastRadioBtn.Margin = new System.Windows.Forms.Padding(4);
            this.LastRadioBtn.Name = "LastRadioBtn";
            this.LastRadioBtn.Size = new System.Drawing.Size(56, 21);
            this.LastRadioBtn.TabIndex = 10;
            this.LastRadioBtn.TabStop = true;
            this.LastRadioBtn.Text = "Last";
            this.LastRadioBtn.UseVisualStyleBackColor = true;
            // 
            // FirstRadioBtn
            // 
            this.FirstRadioBtn.AutoSize = true;
            this.FirstRadioBtn.Location = new System.Drawing.Point(8, 30);
            this.FirstRadioBtn.Margin = new System.Windows.Forms.Padding(4);
            this.FirstRadioBtn.Name = "FirstRadioBtn";
            this.FirstRadioBtn.Size = new System.Drawing.Size(56, 21);
            this.FirstRadioBtn.TabIndex = 9;
            this.FirstRadioBtn.Text = "First";
            this.FirstRadioBtn.UseVisualStyleBackColor = true;
            // 
            // SelectionWithAddGrp
            // 
            this.SelectionWithAddGrp.Controls.Add(this.SelectionWithAddBtn);
            this.SelectionWithAddGrp.Controls.Add(this.LastRadioBtn);
            this.SelectionWithAddGrp.Controls.Add(this.FirstRadioBtn);
            this.SelectionWithAddGrp.Location = new System.Drawing.Point(11, 134);
            this.SelectionWithAddGrp.Margin = new System.Windows.Forms.Padding(4);
            this.SelectionWithAddGrp.Name = "SelectionWithAddGrp";
            this.SelectionWithAddGrp.Padding = new System.Windows.Forms.Padding(4);
            this.SelectionWithAddGrp.Size = new System.Drawing.Size(257, 96);
            this.SelectionWithAddGrp.TabIndex = 21;
            this.SelectionWithAddGrp.TabStop = false;
            this.SelectionWithAddGrp.Text = "Selection With Add";
            // 
            // SelectionWithAddBtn
            // 
            this.SelectionWithAddBtn.Location = new System.Drawing.Point(176, 30);
            this.SelectionWithAddBtn.Margin = new System.Windows.Forms.Padding(4);
            this.SelectionWithAddBtn.Name = "SelectionWithAddBtn";
            this.SelectionWithAddBtn.Size = new System.Drawing.Size(60, 49);
            this.SelectionWithAddBtn.TabIndex = 12;
            this.SelectionWithAddBtn.Text = "Add";
            this.SelectionWithAddBtn.UseVisualStyleBackColor = true;
            this.SelectionWithAddBtn.Click += new System.EventHandler(this.SelectionWithAddBtn_Click);
            // 
            // SearchResultLbl
            // 
            this.SearchResultLbl.AutoSize = true;
            this.SearchResultLbl.Location = new System.Drawing.Point(137, 76);
            this.SearchResultLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SearchResultLbl.Name = "SearchResultLbl";
            this.SearchResultLbl.Size = new System.Drawing.Size(105, 17);
            this.SearchResultLbl.TabIndex = 22;
            this.SearchResultLbl.Text = "Search Result :";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(557, 276);
            this.Controls.Add(this.SearchBtn);
            this.Controls.Add(this.ListLbl);
            this.Controls.Add(this.AddListBtn);
            this.Controls.Add(this.ClearListBtn);
            this.Controls.Add(this.ExtractListBtn);
            this.Controls.Add(this.ListLst);
            this.Controls.Add(this.AddSearchLbl);
            this.Controls.Add(this.AddTxt);
            this.Controls.Add(this.SelectionWithAddGrp);
            this.Controls.Add(this.SearchResultLbl);
            this.Name = "Form1";
            this.Text = "Create Shopping List";
            this.SelectionWithAddGrp.ResumeLayout(false);
            this.SelectionWithAddGrp.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SearchBtn;
        private System.Windows.Forms.Label ListLbl;
        private System.Windows.Forms.Button AddListBtn;
        private System.Windows.Forms.Button ClearListBtn;
        private System.Windows.Forms.Button ExtractListBtn;
        private System.Windows.Forms.ListBox ListLst;
        private System.Windows.Forms.Label AddSearchLbl;
        private System.Windows.Forms.TextBox AddTxt;
        private System.Windows.Forms.RadioButton LastRadioBtn;
        private System.Windows.Forms.RadioButton FirstRadioBtn;
        private System.Windows.Forms.GroupBox SelectionWithAddGrp;
        private System.Windows.Forms.Button SelectionWithAddBtn;
        private System.Windows.Forms.Label SearchResultLbl;
    }
}



namespace ListBox_Records
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
            this.Btn4 = new System.Windows.Forms.Button();
            this.Txt4 = new System.Windows.Forms.TextBox();
            this.Txt3 = new System.Windows.Forms.TextBox();
            this.Txt2 = new System.Windows.Forms.TextBox();
            this.Lbl4 = new System.Windows.Forms.Label();
            this.Lbl3 = new System.Windows.Forms.Label();
            this.Lbl2 = new System.Windows.Forms.Label();
            this.Lbl1 = new System.Windows.Forms.Label();
            this.Lst = new System.Windows.Forms.ListBox();
            this.Btn3 = new System.Windows.Forms.Button();
            this.Btn2 = new System.Windows.Forms.Button();
            this.Btn1 = new System.Windows.Forms.Button();
            this.Txt1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Btn4
            // 
            this.Btn4.ForeColor = System.Drawing.Color.Indigo;
            this.Btn4.Location = new System.Drawing.Point(44, 295);
            this.Btn4.Name = "Btn4";
            this.Btn4.Size = new System.Drawing.Size(128, 28);
            this.Btn4.TabIndex = 32;
            this.Btn4.Text = "Find";
            this.Btn4.UseVisualStyleBackColor = true;
            this.Btn4.Click += new System.EventHandler(this.Btn4_Click);
            // 
            // Txt4
            // 
            this.Txt4.ForeColor = System.Drawing.Color.DarkGreen;
            this.Txt4.Location = new System.Drawing.Point(44, 331);
            this.Txt4.Name = "Txt4";
            this.Txt4.Size = new System.Drawing.Size(200, 26);
            this.Txt4.TabIndex = 34;
            this.Txt4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt24_KeyPress);
            // 
            // Txt3
            // 
            this.Txt3.ForeColor = System.Drawing.Color.DarkGreen;
            this.Txt3.Location = new System.Drawing.Point(185, 298);
            this.Txt3.MaxLength = 6;
            this.Txt3.Name = "Txt3";
            this.Txt3.Size = new System.Drawing.Size(59, 26);
            this.Txt3.TabIndex = 33;
            this.Txt3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt3_KeyPress);
            // 
            // Txt2
            // 
            this.Txt2.ForeColor = System.Drawing.Color.DarkGreen;
            this.Txt2.Location = new System.Drawing.Point(274, 49);
            this.Txt2.Name = "Txt2";
            this.Txt2.Size = new System.Drawing.Size(200, 26);
            this.Txt2.TabIndex = 37;
            this.Txt2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt24_KeyPress);
            // 
            // Lbl4
            // 
            this.Lbl4.AutoSize = true;
            this.Lbl4.Location = new System.Drawing.Point(282, 30);
            this.Lbl4.Name = "Lbl4";
            this.Lbl4.Size = new System.Drawing.Size(119, 20);
            this.Lbl4.TabIndex = 35;
            this.Lbl4.Text = "Selection =";
            // 
            // Lbl3
            // 
            this.Lbl3.AutoSize = true;
            this.Lbl3.Location = new System.Drawing.Point(45, 30);
            this.Lbl3.Name = "Lbl3";
            this.Lbl3.Size = new System.Drawing.Size(59, 20);
            this.Lbl3.TabIndex = 27;
            this.Lbl3.Text = "Sum =";
            // 
            // Lbl2
            // 
            this.Lbl2.AutoSize = true;
            this.Lbl2.Location = new System.Drawing.Point(110, 30);
            this.Lbl2.Name = "Lbl2";
            this.Lbl2.Size = new System.Drawing.Size(19, 20);
            this.Lbl2.TabIndex = 28;
            this.Lbl2.Text = "-";
            // 
            // Lbl1
            // 
            this.Lbl1.AutoSize = true;
            this.Lbl1.Location = new System.Drawing.Point(407, 30);
            this.Lbl1.Name = "Lbl1";
            this.Lbl1.Size = new System.Drawing.Size(19, 20);
            this.Lbl1.TabIndex = 36;
            this.Lbl1.Text = "-";
            // 
            // Lst
            // 
            this.Lst.ForeColor = System.Drawing.Color.DarkGreen;
            this.Lst.FormattingEnabled = true;
            this.Lst.ItemHeight = 18;
            this.Lst.Items.AddRange(new object[] {
            "Hasan",
            "Ahmet",
            "Serdar",
            "Metin",
            "Celal",
            "Ümit",
            "Nejat",
            "Kamil"});
            this.Lst.Location = new System.Drawing.Point(274, 77);
            this.Lst.Name = "Lst";
            this.Lst.Size = new System.Drawing.Size(200, 274);
            this.Lst.TabIndex = 38;
            this.Lst.SelectedIndexChanged += new System.EventHandler(this.Lst_SelectedIndexChanged);
            // 
            // Btn3
            // 
            this.Btn3.ForeColor = System.Drawing.Color.Indigo;
            this.Btn3.Location = new System.Drawing.Point(44, 211);
            this.Btn3.Name = "Btn3";
            this.Btn3.Size = new System.Drawing.Size(200, 32);
            this.Btn3.TabIndex = 31;
            this.Btn3.Text = "Delete Selection";
            this.Btn3.UseVisualStyleBackColor = true;
            this.Btn3.Click += new System.EventHandler(this.Btn3_Click);
            // 
            // Btn2
            // 
            this.Btn2.ForeColor = System.Drawing.Color.Indigo;
            this.Btn2.Location = new System.Drawing.Point(44, 154);
            this.Btn2.Name = "Btn2";
            this.Btn2.Size = new System.Drawing.Size(200, 32);
            this.Btn2.TabIndex = 30;
            this.Btn2.Text = "Delete All";
            this.Btn2.UseVisualStyleBackColor = true;
            this.Btn2.Click += new System.EventHandler(this.Btn2_Click);
            // 
            // Btn1
            // 
            this.Btn1.ForeColor = System.Drawing.Color.Indigo;
            this.Btn1.Location = new System.Drawing.Point(44, 77);
            this.Btn1.Name = "Btn1";
            this.Btn1.Size = new System.Drawing.Size(200, 32);
            this.Btn1.TabIndex = 29;
            this.Btn1.Text = "Add";
            this.Btn1.UseVisualStyleBackColor = true;
            this.Btn1.Click += new System.EventHandler(this.Btn1_Click);
            // 
            // Txt1
            // 
            this.Txt1.ForeColor = System.Drawing.Color.DarkGreen;
            this.Txt1.Location = new System.Drawing.Point(44, 49);
            this.Txt1.MaxLength = 24;
            this.Txt1.Name = "Txt1";
            this.Txt1.Size = new System.Drawing.Size(200, 26);
            this.Txt1.TabIndex = 26;
            this.Txt1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt1_KeyPress);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 386);
            this.Controls.Add(this.Btn4);
            this.Controls.Add(this.Txt4);
            this.Controls.Add(this.Txt3);
            this.Controls.Add(this.Txt2);
            this.Controls.Add(this.Lbl4);
            this.Controls.Add(this.Lbl3);
            this.Controls.Add(this.Lbl2);
            this.Controls.Add(this.Lbl1);
            this.Controls.Add(this.Lst);
            this.Controls.Add(this.Btn3);
            this.Controls.Add(this.Btn2);
            this.Controls.Add(this.Btn1);
            this.Controls.Add(this.Txt1);
            this.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold);
            this.ForeColor = System.Drawing.Color.Sienna;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn4;
        private System.Windows.Forms.TextBox Txt4;
        private System.Windows.Forms.TextBox Txt3;
        private System.Windows.Forms.TextBox Txt2;
        private System.Windows.Forms.Label Lbl4;
        private System.Windows.Forms.Label Lbl3;
        private System.Windows.Forms.Label Lbl2;
        private System.Windows.Forms.Label Lbl1;
        private System.Windows.Forms.ListBox Lst;
        private System.Windows.Forms.Button Btn3;
        private System.Windows.Forms.Button Btn2;
        private System.Windows.Forms.Button Btn1;
        private System.Windows.Forms.TextBox Txt1;
    }
}


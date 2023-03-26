
namespace ComboBox_SortingNumbers
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
            this.Cmb = new System.Windows.Forms.ComboBox();
            this.Btn = new System.Windows.Forms.Button();
            this.Lst2 = new System.Windows.Forms.ListBox();
            this.Lst1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // Cmb
            // 
            this.Cmb.FormattingEnabled = true;
            this.Cmb.Items.AddRange(new object[] {
            "Small to large",
            "Large to small"});
            this.Cmb.Location = new System.Drawing.Point(256, 47);
            this.Cmb.Name = "Cmb";
            this.Cmb.Size = new System.Drawing.Size(168, 26);
            this.Cmb.TabIndex = 5;
            this.Cmb.SelectedIndexChanged += new System.EventHandler(this.Cmb_SelectedIndexChanged);
            this.Cmb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Cmb_KeyPress);
            // 
            // Btn
            // 
            this.Btn.Location = new System.Drawing.Point(49, 39);
            this.Btn.Name = "Btn";
            this.Btn.Size = new System.Drawing.Size(168, 39);
            this.Btn.TabIndex = 4;
            this.Btn.Text = "Random";
            this.Btn.UseVisualStyleBackColor = true;
            this.Btn.Click += new System.EventHandler(this.Btn_Click);
            // 
            // Lst2
            // 
            this.Lst2.FormattingEnabled = true;
            this.Lst2.ItemHeight = 18;
            this.Lst2.Location = new System.Drawing.Point(256, 84);
            this.Lst2.Name = "Lst2";
            this.Lst2.Size = new System.Drawing.Size(168, 472);
            this.Lst2.TabIndex = 7;
            // 
            // Lst1
            // 
            this.Lst1.FormattingEnabled = true;
            this.Lst1.ItemHeight = 18;
            this.Lst1.Location = new System.Drawing.Point(49, 84);
            this.Lst1.Name = "Lst1";
            this.Lst1.Size = new System.Drawing.Size(168, 472);
            this.Lst1.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 594);
            this.Controls.Add(this.Cmb);
            this.Controls.Add(this.Btn);
            this.Controls.Add(this.Lst2);
            this.Controls.Add(this.Lst1);
            this.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold);
            this.ForeColor = System.Drawing.Color.Tomato;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox Cmb;
        private System.Windows.Forms.Button Btn;
        private System.Windows.Forms.ListBox Lst2;
        private System.Windows.Forms.ListBox Lst1;
    }
}


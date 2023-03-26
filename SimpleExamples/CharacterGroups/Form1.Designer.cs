
namespace CharacterGroups
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
            this.Lbl = new System.Windows.Forms.Label();
            this.Cmb = new System.Windows.Forms.ComboBox();
            this.Lst = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // Lbl
            // 
            this.Lbl.AutoSize = true;
            this.Lbl.Location = new System.Drawing.Point(31, 30);
            this.Lbl.Name = "Lbl";
            this.Lbl.Size = new System.Drawing.Size(159, 20);
            this.Lbl.TabIndex = 8;
            this.Lbl.Text = "Character Group";
            // 
            // Cmb
            // 
            this.Cmb.FormattingEnabled = true;
            this.Cmb.Location = new System.Drawing.Point(157, 27);
            this.Cmb.Name = "Cmb";
            this.Cmb.Size = new System.Drawing.Size(184, 26);
            this.Cmb.TabIndex = 7;
            this.Cmb.SelectedIndexChanged += new System.EventHandler(this.Cmb_SelectedIndexChanged);
            this.Cmb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Cmb_KeyPress);
            // 
            // Lst
            // 
            this.Lst.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Lst.ForeColor = System.Drawing.Color.Navy;
            this.Lst.FormattingEnabled = true;
            this.Lst.ItemHeight = 18;
            this.Lst.Location = new System.Drawing.Point(31, 57);
            this.Lst.Name = "Lst";
            this.Lst.Size = new System.Drawing.Size(771, 508);
            this.Lst.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 592);
            this.Controls.Add(this.Lbl);
            this.Controls.Add(this.Cmb);
            this.Controls.Add(this.Lst);
            this.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold);
            this.ForeColor = System.Drawing.Color.Sienna;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl;
        private System.Windows.Forms.ComboBox Cmb;
        private System.Windows.Forms.ListBox Lst;
    }
}



namespace Button_DeleteContent
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
            this.ContentText = new System.Windows.Forms.TextBox();
            this.Lbl = new System.Windows.Forms.Label();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ContentText
            // 
            this.ContentText.ForeColor = System.Drawing.Color.Sienna;
            this.ContentText.Location = new System.Drawing.Point(60, 77);
            this.ContentText.MaxLength = 20;
            this.ContentText.Name = "ContentText";
            this.ContentText.Size = new System.Drawing.Size(170, 22);
            this.ContentText.TabIndex = 3;
            this.ContentText.Text = "content";
            this.ContentText.TextChanged += new System.EventHandler(this.ContentText_TextChanged);
            // 
            // Lbl
            // 
            this.Lbl.AutoSize = true;
            this.Lbl.Location = new System.Drawing.Point(57, 47);
            this.Lbl.Name = "Lbl";
            this.Lbl.Size = new System.Drawing.Size(46, 17);
            this.Lbl.TabIndex = 5;
            this.Lbl.Text = "label1";
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.Location = new System.Drawing.Point(60, 114);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(122, 33);
            this.DeleteBtn.TabIndex = 4;
            this.DeleteBtn.Text = "Delete";
            this.DeleteBtn.UseVisualStyleBackColor = true;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(287, 195);
            this.Controls.Add(this.ContentText);
            this.Controls.Add(this.Lbl);
            this.Controls.Add(this.DeleteBtn);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ContentText;
        private System.Windows.Forms.Label Lbl;
        private System.Windows.Forms.Button DeleteBtn;
    }
}


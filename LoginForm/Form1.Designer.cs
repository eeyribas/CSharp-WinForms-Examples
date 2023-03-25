
namespace LoginForm
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
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.ContentTxt = new System.Windows.Forms.TextBox();
            this.Lbl = new System.Windows.Forms.Label();
            this.OkBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.Location = new System.Drawing.Point(212, 115);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(105, 33);
            this.DeleteBtn.TabIndex = 6;
            this.DeleteBtn.Text = "Delete";
            this.DeleteBtn.UseVisualStyleBackColor = true;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // ContentTxt
            // 
            this.ContentTxt.ForeColor = System.Drawing.Color.Sienna;
            this.ContentTxt.Location = new System.Drawing.Point(68, 72);
            this.ContentTxt.MaxLength = 30;
            this.ContentTxt.Name = "ContentTxt";
            this.ContentTxt.Size = new System.Drawing.Size(249, 22);
            this.ContentTxt.TabIndex = 4;
            this.ContentTxt.Text = "content";
            this.ContentTxt.TextChanged += new System.EventHandler(this.ContentTxt_TextChanged);
            this.ContentTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ContentTxt_KeyPress);
            // 
            // Lbl
            // 
            this.Lbl.AutoSize = true;
            this.Lbl.Location = new System.Drawing.Point(68, 38);
            this.Lbl.Name = "Lbl";
            this.Lbl.Size = new System.Drawing.Size(46, 17);
            this.Lbl.TabIndex = 7;
            this.Lbl.Text = "label1";
            // 
            // OkBtn
            // 
            this.OkBtn.Location = new System.Drawing.Point(68, 115);
            this.OkBtn.Name = "OkBtn";
            this.OkBtn.Size = new System.Drawing.Size(105, 33);
            this.OkBtn.TabIndex = 5;
            this.OkBtn.Text = "Ok";
            this.OkBtn.UseVisualStyleBackColor = true;
            this.OkBtn.Click += new System.EventHandler(this.OkBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 195);
            this.Controls.Add(this.DeleteBtn);
            this.Controls.Add(this.ContentTxt);
            this.Controls.Add(this.Lbl);
            this.Controls.Add(this.OkBtn);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button DeleteBtn;
        private System.Windows.Forms.TextBox ContentTxt;
        private System.Windows.Forms.Label Lbl;
        private System.Windows.Forms.Button OkBtn;
    }
}


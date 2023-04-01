
namespace Button_AcceptCancel
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
            this.PassTxt = new System.Windows.Forms.TextBox();
            this.PassLbl = new System.Windows.Forms.Label();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.OkBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // PassTxt
            // 
            this.PassTxt.Location = new System.Drawing.Point(90, 22);
            this.PassTxt.Name = "PassTxt";
            this.PassTxt.PasswordChar = '*';
            this.PassTxt.Size = new System.Drawing.Size(120, 22);
            this.PassTxt.TabIndex = 25;
            this.PassTxt.Text = "Password";
            // 
            // PassLbl
            // 
            this.PassLbl.Location = new System.Drawing.Point(23, 22);
            this.PassLbl.Name = "PassLbl";
            this.PassLbl.Size = new System.Drawing.Size(58, 27);
            this.PassLbl.TabIndex = 24;
            this.PassLbl.Text = "Password :";
            // 
            // CancelBtn
            // 
            this.CancelBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelBtn.Location = new System.Drawing.Point(119, 69);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(90, 26);
            this.CancelBtn.TabIndex = 23;
            this.CancelBtn.Text = "İptal";
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // OkBtn
            // 
            this.OkBtn.Location = new System.Drawing.Point(23, 69);
            this.OkBtn.Name = "OkBtn";
            this.OkBtn.Size = new System.Drawing.Size(90, 26);
            this.OkBtn.TabIndex = 22;
            this.OkBtn.Text = "Tamam";
            this.OkBtn.Click += new System.EventHandler(this.OkBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(243, 129);
            this.Controls.Add(this.PassTxt);
            this.Controls.Add(this.PassLbl);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.OkBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.TextBox PassTxt;
        internal System.Windows.Forms.Label PassLbl;
        internal System.Windows.Forms.Button CancelBtn;
        internal System.Windows.Forms.Button OkBtn;
    }
}



namespace OpeningFormWithEncryptedForm
{
    partial class Form2
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
            this.Btn2 = new System.Windows.Forms.Button();
            this.Txt = new System.Windows.Forms.TextBox();
            this.Btn1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Lbl
            // 
            this.Lbl.AutoSize = true;
            this.Lbl.ForeColor = System.Drawing.Color.Brown;
            this.Lbl.Location = new System.Drawing.Point(30, 59);
            this.Lbl.Name = "Lbl";
            this.Lbl.Size = new System.Drawing.Size(109, 20);
            this.Lbl.TabIndex = 7;
            this.Lbl.Text = "Password :";
            // 
            // Btn2
            // 
            this.Btn2.Location = new System.Drawing.Point(219, 115);
            this.Btn2.Name = "Btn2";
            this.Btn2.Size = new System.Drawing.Size(116, 38);
            this.Btn2.TabIndex = 6;
            this.Btn2.Text = "Cancel";
            this.Btn2.UseVisualStyleBackColor = true;
            this.Btn2.Click += new System.EventHandler(this.Btn2_Click);
            // 
            // Txt
            // 
            this.Txt.ForeColor = System.Drawing.Color.SaddleBrown;
            this.Txt.Location = new System.Drawing.Point(145, 56);
            this.Txt.MaxLength = 16;
            this.Txt.Name = "Txt";
            this.Txt.PasswordChar = '*';
            this.Txt.Size = new System.Drawing.Size(173, 26);
            this.Txt.TabIndex = 4;
            // 
            // Btn1
            // 
            this.Btn1.Location = new System.Drawing.Point(64, 115);
            this.Btn1.Name = "Btn1";
            this.Btn1.Size = new System.Drawing.Size(116, 38);
            this.Btn1.TabIndex = 5;
            this.Btn1.Text = "Ok";
            this.Btn1.UseVisualStyleBackColor = true;
            this.Btn1.Click += new System.EventHandler(this.Btn1_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aquamarine;
            this.ClientSize = new System.Drawing.Size(399, 208);
            this.Controls.Add(this.Lbl);
            this.Controls.Add(this.Btn2);
            this.Controls.Add(this.Txt);
            this.Controls.Add(this.Btn1);
            this.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold);
            this.ForeColor = System.Drawing.Color.Green;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl;
        private System.Windows.Forms.Button Btn2;
        private System.Windows.Forms.TextBox Txt;
        private System.Windows.Forms.Button Btn1;
    }
}
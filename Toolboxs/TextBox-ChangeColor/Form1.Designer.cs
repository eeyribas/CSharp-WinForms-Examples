
namespace TextBox_ChangeColor
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
            this.Txt2 = new System.Windows.Forms.TextBox();
            this.Lbl2 = new System.Windows.Forms.Label();
            this.Lbl1 = new System.Windows.Forms.Label();
            this.Txt1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Txt2
            // 
            this.Txt2.ForeColor = System.Drawing.Color.SeaGreen;
            this.Txt2.Location = new System.Drawing.Point(75, 112);
            this.Txt2.MaxLength = 25;
            this.Txt2.Name = "Txt2";
            this.Txt2.Size = new System.Drawing.Size(208, 22);
            this.Txt2.TabIndex = 5;
            this.Txt2.Text = "content-2";
            this.Txt2.TextChanged += new System.EventHandler(this.Txt_Changed);
            // 
            // Lbl2
            // 
            this.Lbl2.AutoSize = true;
            this.Lbl2.Location = new System.Drawing.Point(289, 115);
            this.Lbl2.Name = "Lbl2";
            this.Lbl2.Size = new System.Drawing.Size(46, 17);
            this.Lbl2.TabIndex = 7;
            this.Lbl2.Text = "label2";
            // 
            // Lbl1
            // 
            this.Lbl1.AutoSize = true;
            this.Lbl1.Location = new System.Drawing.Point(289, 57);
            this.Lbl1.Name = "Lbl1";
            this.Lbl1.Size = new System.Drawing.Size(46, 17);
            this.Lbl1.TabIndex = 6;
            this.Lbl1.Text = "label1";
            // 
            // Txt1
            // 
            this.Txt1.ForeColor = System.Drawing.Color.SeaGreen;
            this.Txt1.Location = new System.Drawing.Point(75, 54);
            this.Txt1.MaxLength = 25;
            this.Txt1.Name = "Txt1";
            this.Txt1.Size = new System.Drawing.Size(208, 22);
            this.Txt1.TabIndex = 4;
            this.Txt1.Text = "content-1";
            this.Txt1.TextChanged += new System.EventHandler(this.Txt_Changed);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 188);
            this.Controls.Add(this.Txt2);
            this.Controls.Add(this.Lbl2);
            this.Controls.Add(this.Lbl1);
            this.Controls.Add(this.Txt1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Txt2;
        private System.Windows.Forms.Label Lbl2;
        private System.Windows.Forms.Label Lbl1;
        private System.Windows.Forms.TextBox Txt1;
    }
}


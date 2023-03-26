
namespace TextBox_EnteringOnlyNumbersOrLetters
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
            this.Lbl4 = new System.Windows.Forms.Label();
            this.Lbl3 = new System.Windows.Forms.Label();
            this.Lbl2 = new System.Windows.Forms.Label();
            this.Lbl1 = new System.Windows.Forms.Label();
            this.Txt2 = new System.Windows.Forms.TextBox();
            this.Txt1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Lbl4
            // 
            this.Lbl4.AutoSize = true;
            this.Lbl4.Location = new System.Drawing.Point(41, 110);
            this.Lbl4.Name = "Lbl4";
            this.Lbl4.Size = new System.Drawing.Size(219, 20);
            this.Lbl4.TabIndex = 15;
            this.Lbl4.Text = "Entering only letters";
            // 
            // Lbl3
            // 
            this.Lbl3.AutoSize = true;
            this.Lbl3.Location = new System.Drawing.Point(41, 43);
            this.Lbl3.Name = "Lbl3";
            this.Lbl3.Size = new System.Drawing.Size(219, 20);
            this.Lbl3.TabIndex = 12;
            this.Lbl3.Text = "Entering only numbers";
            // 
            // Lbl2
            // 
            this.Lbl2.AutoSize = true;
            this.Lbl2.ForeColor = System.Drawing.Color.DarkGreen;
            this.Lbl2.Location = new System.Drawing.Point(256, 132);
            this.Lbl2.Name = "Lbl2";
            this.Lbl2.Size = new System.Drawing.Size(69, 20);
            this.Lbl2.TabIndex = 17;
            this.Lbl2.Text = "label2";
            // 
            // Lbl1
            // 
            this.Lbl1.AutoSize = true;
            this.Lbl1.ForeColor = System.Drawing.Color.DarkGreen;
            this.Lbl1.Location = new System.Drawing.Point(256, 65);
            this.Lbl1.Name = "Lbl1";
            this.Lbl1.Size = new System.Drawing.Size(69, 20);
            this.Lbl1.TabIndex = 14;
            this.Lbl1.Text = "label1";
            // 
            // Txt2
            // 
            this.Txt2.ForeColor = System.Drawing.Color.Maroon;
            this.Txt2.Location = new System.Drawing.Point(41, 129);
            this.Txt2.MaxLength = 25;
            this.Txt2.Name = "Txt2";
            this.Txt2.Size = new System.Drawing.Size(209, 26);
            this.Txt2.TabIndex = 16;
            this.Txt2.Text = "content";
            this.Txt2.TextChanged += new System.EventHandler(this.Txt2_TextChanged);
            this.Txt2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt2_KeyPress);
            // 
            // Txt1
            // 
            this.Txt1.ForeColor = System.Drawing.Color.Maroon;
            this.Txt1.Location = new System.Drawing.Point(41, 62);
            this.Txt1.MaxLength = 25;
            this.Txt1.Name = "Txt1";
            this.Txt1.Size = new System.Drawing.Size(209, 26);
            this.Txt1.TabIndex = 13;
            this.Txt1.Text = "content";
            this.Txt1.TextChanged += new System.EventHandler(this.Txt1_TextChanged);
            this.Txt1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt1_KeyPress);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 199);
            this.Controls.Add(this.Lbl4);
            this.Controls.Add(this.Lbl3);
            this.Controls.Add(this.Lbl2);
            this.Controls.Add(this.Lbl1);
            this.Controls.Add(this.Txt2);
            this.Controls.Add(this.Txt1);
            this.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold);
            this.ForeColor = System.Drawing.Color.DarkBlue;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl4;
        private System.Windows.Forms.Label Lbl3;
        private System.Windows.Forms.Label Lbl2;
        private System.Windows.Forms.Label Lbl1;
        private System.Windows.Forms.TextBox Txt2;
        private System.Windows.Forms.TextBox Txt1;
    }
}


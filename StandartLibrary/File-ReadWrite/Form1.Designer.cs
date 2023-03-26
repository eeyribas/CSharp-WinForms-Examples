
namespace File_ReadWrite
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
            this.Txt = new System.Windows.Forms.RichTextBox();
            this.Lbl = new System.Windows.Forms.Label();
            this.Btn3 = new System.Windows.Forms.Button();
            this.Btn2 = new System.Windows.Forms.Button();
            this.Btn1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Txt
            // 
            this.Txt.Location = new System.Drawing.Point(227, 51);
            this.Txt.Name = "Txt";
            this.Txt.Size = new System.Drawing.Size(268, 351);
            this.Txt.TabIndex = 5;
            this.Txt.Text = "";
            // 
            // Lbl
            // 
            this.Lbl.AutoSize = true;
            this.Lbl.Location = new System.Drawing.Point(66, 300);
            this.Lbl.Name = "Lbl";
            this.Lbl.Size = new System.Drawing.Size(69, 20);
            this.Lbl.TabIndex = 9;
            this.Lbl.Text = "label1";
            // 
            // Btn3
            // 
            this.Btn3.Location = new System.Drawing.Point(69, 225);
            this.Btn3.Name = "Btn3";
            this.Btn3.Size = new System.Drawing.Size(130, 36);
            this.Btn3.TabIndex = 8;
            this.Btn3.Text = "Delete File";
            this.Btn3.UseVisualStyleBackColor = true;
            this.Btn3.Click += new System.EventHandler(this.Btn3_Click);
            // 
            // Btn2
            // 
            this.Btn2.Location = new System.Drawing.Point(69, 157);
            this.Btn2.Name = "Btn2";
            this.Btn2.Size = new System.Drawing.Size(130, 36);
            this.Btn2.TabIndex = 7;
            this.Btn2.Text = "Read File";
            this.Btn2.UseVisualStyleBackColor = true;
            this.Btn2.Click += new System.EventHandler(this.Btn2_Click);
            // 
            // Btn1
            // 
            this.Btn1.Location = new System.Drawing.Point(69, 94);
            this.Btn1.Name = "Btn1";
            this.Btn1.Size = new System.Drawing.Size(130, 36);
            this.Btn1.TabIndex = 6;
            this.Btn1.Text = "Write File";
            this.Btn1.UseVisualStyleBackColor = true;
            this.Btn1.Click += new System.EventHandler(this.Btn1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(561, 452);
            this.Controls.Add(this.Txt);
            this.Controls.Add(this.Lbl);
            this.Controls.Add(this.Btn3);
            this.Controls.Add(this.Btn2);
            this.Controls.Add(this.Btn1);
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

        private System.Windows.Forms.RichTextBox Txt;
        private System.Windows.Forms.Label Lbl;
        private System.Windows.Forms.Button Btn3;
        private System.Windows.Forms.Button Btn2;
        private System.Windows.Forms.Button Btn1;
    }
}



namespace Bitmap_ConvertBmpToJpg
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
            this.Lbl2 = new System.Windows.Forms.Label();
            this.Lbl1 = new System.Windows.Forms.Label();
            this.Btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Lbl2
            // 
            this.Lbl2.AutoSize = true;
            this.Lbl2.Location = new System.Drawing.Point(75, 145);
            this.Lbl2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl2.Name = "Lbl2";
            this.Lbl2.Size = new System.Drawing.Size(366, 31);
            this.Lbl2.TabIndex = 5;
            this.Lbl2.Text = "Convert and Close Form";
            // 
            // Lbl1
            // 
            this.Lbl1.AutoSize = true;
            this.Lbl1.Location = new System.Drawing.Point(24, 80);
            this.Lbl1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl1.Name = "Lbl1";
            this.Lbl1.Size = new System.Drawing.Size(462, 31);
            this.Lbl1.TabIndex = 4;
            this.Lbl1.Text = "papaya.bmp  --->  papaya.jpg";
            // 
            // Btn
            // 
            this.Btn.ForeColor = System.Drawing.Color.Green;
            this.Btn.Location = new System.Drawing.Point(102, 209);
            this.Btn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Btn.Name = "Btn";
            this.Btn.Size = new System.Drawing.Size(271, 47);
            this.Btn.TabIndex = 3;
            this.Btn.Text = "Convert";
            this.Btn.UseVisualStyleBackColor = true;
            this.Btn.Click += new System.EventHandler(this.Btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 336);
            this.Controls.Add(this.Lbl2);
            this.Controls.Add(this.Lbl1);
            this.Controls.Add(this.Btn);
            this.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Bold);
            this.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl2;
        private System.Windows.Forms.Label Lbl1;
        private System.Windows.Forms.Button Btn;
    }
}


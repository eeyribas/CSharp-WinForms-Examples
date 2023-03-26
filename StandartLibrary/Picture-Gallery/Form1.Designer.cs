
namespace PictureGallery
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
            this.Pic = new System.Windows.Forms.PictureBox();
            this.Btn4 = new System.Windows.Forms.Button();
            this.Btn3 = new System.Windows.Forms.Button();
            this.Btn2 = new System.Windows.Forms.Button();
            this.Btn1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Pic)).BeginInit();
            this.SuspendLayout();
            // 
            // Lbl
            // 
            this.Lbl.AutoSize = true;
            this.Lbl.Location = new System.Drawing.Point(428, 30);
            this.Lbl.Name = "Lbl";
            this.Lbl.Size = new System.Drawing.Size(69, 20);
            this.Lbl.TabIndex = 17;
            this.Lbl.Text = "label1";
            // 
            // Pic
            // 
            this.Pic.InitialImage = null;
            this.Pic.Location = new System.Drawing.Point(28, 70);
            this.Pic.Name = "Pic";
            this.Pic.Size = new System.Drawing.Size(159, 87);
            this.Pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Pic.TabIndex = 16;
            this.Pic.TabStop = false;
            this.Pic.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Pic_MouseMove);
            // 
            // Btn4
            // 
            this.Btn4.Location = new System.Drawing.Point(332, 24);
            this.Btn4.Name = "Btn4";
            this.Btn4.Size = new System.Drawing.Size(75, 28);
            this.Btn4.TabIndex = 15;
            this.Btn4.Text = "Last";
            this.Btn4.UseVisualStyleBackColor = true;
            this.Btn4.Click += new System.EventHandler(this.Btn_Click);
            // 
            // Btn3
            // 
            this.Btn3.Location = new System.Drawing.Point(225, 24);
            this.Btn3.Name = "Btn3";
            this.Btn3.Size = new System.Drawing.Size(101, 28);
            this.Btn3.TabIndex = 14;
            this.Btn3.Text = "Forward";
            this.Btn3.UseVisualStyleBackColor = true;
            this.Btn3.Click += new System.EventHandler(this.Btn_Click);
            // 
            // Btn2
            // 
            this.Btn2.Location = new System.Drawing.Point(109, 24);
            this.Btn2.Name = "Btn2";
            this.Btn2.Size = new System.Drawing.Size(100, 28);
            this.Btn2.TabIndex = 13;
            this.Btn2.Text = "Backward";
            this.Btn2.UseVisualStyleBackColor = true;
            this.Btn2.Click += new System.EventHandler(this.Btn_Click);
            // 
            // Btn1
            // 
            this.Btn1.Location = new System.Drawing.Point(28, 24);
            this.Btn1.Name = "Btn1";
            this.Btn1.Size = new System.Drawing.Size(75, 28);
            this.Btn1.TabIndex = 12;
            this.Btn1.Text = "First";
            this.Btn1.UseVisualStyleBackColor = true;
            this.Btn1.Click += new System.EventHandler(this.Btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 434);
            this.Controls.Add(this.Lbl);
            this.Controls.Add(this.Pic);
            this.Controls.Add(this.Btn4);
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
            ((System.ComponentModel.ISupportInitialize)(this.Pic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl;
        private System.Windows.Forms.PictureBox Pic;
        private System.Windows.Forms.Button Btn4;
        private System.Windows.Forms.Button Btn3;
        private System.Windows.Forms.Button Btn2;
        private System.Windows.Forms.Button Btn1;
    }
}


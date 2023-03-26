
namespace Bitmap_Negative
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Btn4 = new System.Windows.Forms.Button();
            this.Pic1 = new System.Windows.Forms.PictureBox();
            this.Btn3 = new System.Windows.Forms.Button();
            this.Btn2 = new System.Windows.Forms.Button();
            this.Btn1 = new System.Windows.Forms.Button();
            this.Pic2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Pic1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic2)).BeginInit();
            this.SuspendLayout();
            // 
            // Btn4
            // 
            this.Btn4.Location = new System.Drawing.Point(36, 333);
            this.Btn4.Name = "Btn4";
            this.Btn4.Size = new System.Drawing.Size(156, 33);
            this.Btn4.TabIndex = 24;
            this.Btn4.Text = "Neg Colorless";
            this.Btn4.UseVisualStyleBackColor = true;
            this.Btn4.Click += new System.EventHandler(this.Btn4_Click);
            // 
            // Pic1
            // 
            this.Pic1.Image = ((System.Drawing.Image)(resources.GetObject("Pic1.Image")));
            this.Pic1.Location = new System.Drawing.Point(36, 36);
            this.Pic1.Name = "Pic1";
            this.Pic1.Size = new System.Drawing.Size(143, 103);
            this.Pic1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Pic1.TabIndex = 22;
            this.Pic1.TabStop = false;
            // 
            // Btn3
            // 
            this.Btn3.Location = new System.Drawing.Point(46, 278);
            this.Btn3.Name = "Btn3";
            this.Btn3.Size = new System.Drawing.Size(122, 33);
            this.Btn3.TabIndex = 21;
            this.Btn3.Text = "Colorless";
            this.Btn3.UseVisualStyleBackColor = true;
            this.Btn3.Click += new System.EventHandler(this.Btn3_Click);
            // 
            // Btn2
            // 
            this.Btn2.Location = new System.Drawing.Point(36, 218);
            this.Btn2.Name = "Btn2";
            this.Btn2.Size = new System.Drawing.Size(156, 35);
            this.Btn2.TabIndex = 20;
            this.Btn2.Text = "Neg Colourful";
            this.Btn2.UseVisualStyleBackColor = true;
            this.Btn2.Click += new System.EventHandler(this.Btn2_Click);
            // 
            // Btn1
            // 
            this.Btn1.Location = new System.Drawing.Point(46, 161);
            this.Btn1.Name = "Btn1";
            this.Btn1.Size = new System.Drawing.Size(122, 33);
            this.Btn1.TabIndex = 19;
            this.Btn1.Text = "Colourful";
            this.Btn1.UseVisualStyleBackColor = true;
            this.Btn1.Click += new System.EventHandler(this.Btn1_Click);
            // 
            // Pic2
            // 
            this.Pic2.Location = new System.Drawing.Point(206, 45);
            this.Pic2.Name = "Pic2";
            this.Pic2.Size = new System.Drawing.Size(515, 334);
            this.Pic2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Pic2.TabIndex = 23;
            this.Pic2.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(757, 415);
            this.Controls.Add(this.Btn4);
            this.Controls.Add(this.Pic1);
            this.Controls.Add(this.Btn3);
            this.Controls.Add(this.Btn2);
            this.Controls.Add(this.Btn1);
            this.Controls.Add(this.Pic2);
            this.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold);
            this.ForeColor = System.Drawing.Color.Sienna;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Pic1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Btn4;
        private System.Windows.Forms.PictureBox Pic1;
        private System.Windows.Forms.Button Btn3;
        private System.Windows.Forms.Button Btn2;
        private System.Windows.Forms.Button Btn1;
        private System.Windows.Forms.PictureBox Pic2;
    }
}


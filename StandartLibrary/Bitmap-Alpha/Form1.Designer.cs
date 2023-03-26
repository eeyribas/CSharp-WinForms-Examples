
namespace ImageAlpha
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
            this.Lbl = new System.Windows.Forms.Label();
            this.Hsc = new System.Windows.Forms.HScrollBar();
            this.Pic = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Pic)).BeginInit();
            this.SuspendLayout();
            // 
            // Lbl
            // 
            this.Lbl.AutoSize = true;
            this.Lbl.Location = new System.Drawing.Point(50, 356);
            this.Lbl.Name = "Lbl";
            this.Lbl.Size = new System.Drawing.Size(69, 20);
            this.Lbl.TabIndex = 10;
            this.Lbl.Text = "label1";
            // 
            // Hsc
            // 
            this.Hsc.LargeChange = 15;
            this.Hsc.Location = new System.Drawing.Point(53, 386);
            this.Hsc.Maximum = 269;
            this.Hsc.Name = "Hsc";
            this.Hsc.Size = new System.Drawing.Size(455, 24);
            this.Hsc.TabIndex = 9;
            this.Hsc.ValueChanged += new System.EventHandler(this.Hsc_ValueChanged);
            // 
            // Pic
            // 
            this.Pic.Image = ((System.Drawing.Image)(resources.GetObject("Pic.Image")));
            this.Pic.Location = new System.Drawing.Point(53, 43);
            this.Pic.Name = "Pic";
            this.Pic.Size = new System.Drawing.Size(455, 300);
            this.Pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Pic.TabIndex = 11;
            this.Pic.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 453);
            this.Controls.Add(this.Lbl);
            this.Controls.Add(this.Hsc);
            this.Controls.Add(this.Pic);
            this.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold);
            this.ForeColor = System.Drawing.Color.Sienna;
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
        private System.Windows.Forms.HScrollBar Hsc;
        private System.Windows.Forms.PictureBox Pic;
    }
}



namespace Picture_AutoZoom
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Pic2 = new System.Windows.Forms.PictureBox();
            this.Pic1 = new System.Windows.Forms.PictureBox();
            this.Tmr = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.Pic2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic1)).BeginInit();
            this.SuspendLayout();
            // 
            // Pic2
            // 
            this.Pic2.Location = new System.Drawing.Point(500, 30);
            this.Pic2.Name = "Pic2";
            this.Pic2.Size = new System.Drawing.Size(300, 300);
            this.Pic2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Pic2.TabIndex = 3;
            this.Pic2.TabStop = false;
            // 
            // Pic1
            // 
            this.Pic1.Image = ((System.Drawing.Image)(resources.GetObject("Pic1.Image")));
            this.Pic1.Location = new System.Drawing.Point(26, 41);
            this.Pic1.Name = "Pic1";
            this.Pic1.Size = new System.Drawing.Size(449, 279);
            this.Pic1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Pic1.TabIndex = 2;
            this.Pic1.TabStop = false;
            this.Pic1.MouseEnter += new System.EventHandler(this.Pic1_MouseEnter);
            this.Pic1.MouseLeave += new System.EventHandler(this.Pic1_MouseLeave);
            this.Pic1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Pic1_MouseMove);
            // 
            // Tmr
            // 
            this.Tmr.Tick += new System.EventHandler(this.Tmr_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(826, 361);
            this.Controls.Add(this.Pic2);
            this.Controls.Add(this.Pic1);
            this.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold);
            this.ForeColor = System.Drawing.Color.Sienna;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Pic2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Pic2;
        private System.Windows.Forms.PictureBox Pic1;
        private System.Windows.Forms.Timer Tmr;
    }
}


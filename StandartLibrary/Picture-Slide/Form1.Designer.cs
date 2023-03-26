
namespace PictureSlide
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
            this.Pic = new System.Windows.Forms.PictureBox();
            this.Btn = new System.Windows.Forms.Button();
            this.Fbd = new System.Windows.Forms.FolderBrowserDialog();
            this.Tmr = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.Pic)).BeginInit();
            this.SuspendLayout();
            // 
            // Pic
            // 
            this.Pic.Location = new System.Drawing.Point(12, 60);
            this.Pic.Name = "Pic";
            this.Pic.Size = new System.Drawing.Size(692, 440);
            this.Pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Pic.TabIndex = 7;
            this.Pic.TabStop = false;
            // 
            // Btn
            // 
            this.Btn.Location = new System.Drawing.Point(271, 12);
            this.Btn.Name = "Btn";
            this.Btn.Size = new System.Drawing.Size(175, 42);
            this.Btn.TabIndex = 6;
            this.Btn.Text = "Selection File";
            this.Btn.UseVisualStyleBackColor = true;
            this.Btn.Click += new System.EventHandler(this.Btn_Click);
            // 
            // Fbd
            // 
            this.Fbd.SelectedPath = "D:\\";
            // 
            // Tmr
            // 
            this.Tmr.Tick += new System.EventHandler(this.Tmr_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(716, 512);
            this.Controls.Add(this.Pic);
            this.Controls.Add(this.Btn);
            this.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold);
            this.ForeColor = System.Drawing.Color.Sienna;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.Pic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox Pic;
        private System.Windows.Forms.Button Btn;
        private System.Windows.Forms.FolderBrowserDialog Fbd;
        private System.Windows.Forms.Timer Tmr;
    }
}


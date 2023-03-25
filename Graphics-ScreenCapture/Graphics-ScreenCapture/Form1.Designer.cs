
namespace Graphics_ScreenCapture
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
            this.ScreenshotSaveFileDlg = new System.Windows.Forms.SaveFileDialog();
            this.CaptureBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ScreenshotSaveFileDlg
            // 
            this.ScreenshotSaveFileDlg.Filter = "PNG File|*.png";
            // 
            // CaptureBtn
            // 
            this.CaptureBtn.Location = new System.Drawing.Point(93, 84);
            this.CaptureBtn.Margin = new System.Windows.Forms.Padding(4);
            this.CaptureBtn.Name = "CaptureBtn";
            this.CaptureBtn.Size = new System.Drawing.Size(100, 28);
            this.CaptureBtn.TabIndex = 1;
            this.CaptureBtn.Text = "Capture";
            this.CaptureBtn.UseVisualStyleBackColor = true;
            this.CaptureBtn.Click += new System.EventHandler(this.CaptureBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(287, 197);
            this.Controls.Add(this.CaptureBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SaveFileDialog ScreenshotSaveFileDlg;
        private System.Windows.Forms.Button CaptureBtn;
    }
}


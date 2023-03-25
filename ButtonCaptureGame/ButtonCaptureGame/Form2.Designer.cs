
namespace ButtonCaptureGame
{
    partial class Form2
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
            this.Btn = new System.Windows.Forms.Button();
            this.Tmr1 = new System.Windows.Forms.Timer(this.components);
            this.Tmr2 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // Btn
            // 
            this.Btn.Location = new System.Drawing.Point(24, 27);
            this.Btn.Margin = new System.Windows.Forms.Padding(0);
            this.Btn.Name = "Btn";
            this.Btn.Size = new System.Drawing.Size(148, 50);
            this.Btn.TabIndex = 1;
            this.Btn.Text = "Click";
            this.Btn.UseVisualStyleBackColor = true;
            this.Btn.Click += new System.EventHandler(this.Btn_Click);
            // 
            // Tmr1
            // 
            this.Tmr1.Enabled = true;
            this.Tmr1.Interval = 1000;
            this.Tmr1.Tick += new System.EventHandler(this.Tmr1_Tick);
            // 
            // Tmr2
            // 
            this.Tmr2.Enabled = true;
            this.Tmr2.Interval = 1;
            this.Tmr2.Tick += new System.EventHandler(this.Tmr2_Tick);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 341);
            this.Controls.Add(this.Btn);
            this.Name = "Form2";
            this.Text = "Form2";
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Form2_MouseClick);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Btn;
        private System.Windows.Forms.Timer Tmr1;
        private System.Windows.Forms.Timer Tmr2;
    }
}
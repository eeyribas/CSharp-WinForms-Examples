
namespace Timer_SetText
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
            this.DateLbl = new System.Windows.Forms.Label();
            this.Tmr = new System.Windows.Forms.Timer(this.components);
            this.InfoLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // DateLbl
            // 
            this.DateLbl.AutoSize = true;
            this.DateLbl.Location = new System.Drawing.Point(188, 311);
            this.DateLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.DateLbl.Name = "DateLbl";
            this.DateLbl.Size = new System.Drawing.Size(38, 17);
            this.DateLbl.TabIndex = 3;
            this.DateLbl.Text = "Date";
            // 
            // Tmr
            // 
            this.Tmr.Enabled = true;
            this.Tmr.Interval = 1000;
            this.Tmr.Tick += new System.EventHandler(this.Tmr_Tick);
            // 
            // InfoLbl
            // 
            this.InfoLbl.AutoSize = true;
            this.InfoLbl.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.InfoLbl.Location = new System.Drawing.Point(13, 9);
            this.InfoLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.InfoLbl.Name = "InfoLbl";
            this.InfoLbl.Size = new System.Drawing.Size(620, 250);
            this.InfoLbl.TabIndex = 2;
            this.InfoLbl.Text = resources.GetString("InfoLbl.Text");
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(631, 366);
            this.Controls.Add(this.DateLbl);
            this.Controls.Add(this.InfoLbl);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label DateLbl;
        private System.Windows.Forms.Timer Tmr;
        private System.Windows.Forms.Label InfoLbl;
    }
}


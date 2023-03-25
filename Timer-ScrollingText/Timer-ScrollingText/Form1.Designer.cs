
namespace Timer_ScrollingText
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
            this.ScrollingTextLbl = new System.Windows.Forms.Label();
            this.StpBtn = new System.Windows.Forms.Button();
            this.StrtBtn = new System.Windows.Forms.Button();
            this.InfoLbl = new System.Windows.Forms.Label();
            this.Tmr = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // ScrollingTextLbl
            // 
            this.ScrollingTextLbl.AutoSize = true;
            this.ScrollingTextLbl.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ScrollingTextLbl.Location = new System.Drawing.Point(216, 297);
            this.ScrollingTextLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ScrollingTextLbl.Name = "ScrollingTextLbl";
            this.ScrollingTextLbl.Size = new System.Drawing.Size(130, 25);
            this.ScrollingTextLbl.TabIndex = 7;
            this.ScrollingTextLbl.Text = "Scrolling Text";
            // 
            // StpBtn
            // 
            this.StpBtn.Location = new System.Drawing.Point(235, 377);
            this.StpBtn.Margin = new System.Windows.Forms.Padding(4);
            this.StpBtn.Name = "StpBtn";
            this.StpBtn.Size = new System.Drawing.Size(100, 28);
            this.StpBtn.TabIndex = 6;
            this.StpBtn.Text = "Stop";
            this.StpBtn.UseVisualStyleBackColor = true;
            this.StpBtn.Click += new System.EventHandler(this.StpBtn_Click);
            // 
            // StrtBtn
            // 
            this.StrtBtn.Location = new System.Drawing.Point(236, 341);
            this.StrtBtn.Margin = new System.Windows.Forms.Padding(4);
            this.StrtBtn.Name = "StrtBtn";
            this.StrtBtn.Size = new System.Drawing.Size(100, 28);
            this.StrtBtn.TabIndex = 5;
            this.StrtBtn.Text = "Start";
            this.StrtBtn.UseVisualStyleBackColor = true;
            this.StrtBtn.Click += new System.EventHandler(this.StrtBtn_Click);
            // 
            // InfoLbl
            // 
            this.InfoLbl.AutoSize = true;
            this.InfoLbl.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.InfoLbl.Location = new System.Drawing.Point(13, 9);
            this.InfoLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.InfoLbl.Name = "InfoLbl";
            this.InfoLbl.Size = new System.Drawing.Size(620, 200);
            this.InfoLbl.TabIndex = 4;
            this.InfoLbl.Text = resources.GetString("InfoLbl.Text");
            // 
            // Tmr
            // 
            this.Tmr.Tick += new System.EventHandler(this.Tmr_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 418);
            this.Controls.Add(this.ScrollingTextLbl);
            this.Controls.Add(this.StpBtn);
            this.Controls.Add(this.StrtBtn);
            this.Controls.Add(this.InfoLbl);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ScrollingTextLbl;
        private System.Windows.Forms.Button StpBtn;
        private System.Windows.Forms.Button StrtBtn;
        private System.Windows.Forms.Label InfoLbl;
        private System.Windows.Forms.Timer Tmr;
    }
}


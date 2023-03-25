
namespace ButtonCaptureGame
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
            this.Chk = new System.Windows.Forms.CheckBox();
            this.Lbl6 = new System.Windows.Forms.Label();
            this.Trb2 = new System.Windows.Forms.TrackBar();
            this.Lbl5 = new System.Windows.Forms.Label();
            this.Lbl2 = new System.Windows.Forms.Label();
            this.Lbl1 = new System.Windows.Forms.Label();
            this.Trb1 = new System.Windows.Forms.TrackBar();
            this.Btn = new System.Windows.Forms.Button();
            this.TabPage = new System.Windows.Forms.TabPage();
            this.Tab = new System.Windows.Forms.TabControl();
            ((System.ComponentModel.ISupportInitialize)(this.Trb2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Trb1)).BeginInit();
            this.TabPage.SuspendLayout();
            this.Tab.SuspendLayout();
            this.SuspendLayout();
            // 
            // Chk
            // 
            this.Chk.AutoSize = true;
            this.Chk.Checked = true;
            this.Chk.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Chk.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Chk.Location = new System.Drawing.Point(20, 217);
            this.Chk.Margin = new System.Windows.Forms.Padding(4);
            this.Chk.Name = "Chk";
            this.Chk.Size = new System.Drawing.Size(191, 28);
            this.Chk.TabIndex = 8;
            this.Chk.Text = "Change Screen Size";
            this.Chk.UseVisualStyleBackColor = true;
            this.Chk.CheckedChanged += new System.EventHandler(this.Chk_CheckedChanged);
            // 
            // Lbl6
            // 
            this.Lbl6.AutoSize = true;
            this.Lbl6.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Lbl6.Location = new System.Drawing.Point(341, 160);
            this.Lbl6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl6.Name = "Lbl6";
            this.Lbl6.Size = new System.Drawing.Size(44, 24);
            this.Lbl6.TabIndex = 7;
            this.Lbl6.Text = "Lbl6";
            // 
            // Trb2
            // 
            this.Trb2.Location = new System.Drawing.Point(20, 144);
            this.Trb2.Margin = new System.Windows.Forms.Padding(4);
            this.Trb2.Maximum = 4;
            this.Trb2.Name = "Trb2";
            this.Trb2.Size = new System.Drawing.Size(288, 56);
            this.Trb2.TabIndex = 6;
            this.Trb2.Value = 2;
            this.Trb2.Scroll += new System.EventHandler(this.Trb2_Scroll);
            // 
            // Lbl5
            // 
            this.Lbl5.AutoSize = true;
            this.Lbl5.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Lbl5.Location = new System.Drawing.Point(96, 108);
            this.Lbl5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl5.Name = "Lbl5";
            this.Lbl5.Size = new System.Drawing.Size(134, 33);
            this.Lbl5.TabIndex = 5;
            this.Lbl5.Text = "Screen Size";
            // 
            // Lbl2
            // 
            this.Lbl2.AutoSize = true;
            this.Lbl2.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Lbl2.Location = new System.Drawing.Point(111, 14);
            this.Lbl2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl2.Name = "Lbl2";
            this.Lbl2.Size = new System.Drawing.Size(161, 33);
            this.Lbl2.TabIndex = 4;
            this.Lbl2.Text = "Button Speed";
            // 
            // Lbl1
            // 
            this.Lbl1.AutoSize = true;
            this.Lbl1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Lbl1.Location = new System.Drawing.Point(341, 63);
            this.Lbl1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl1.Name = "Lbl1";
            this.Lbl1.Size = new System.Drawing.Size(44, 24);
            this.Lbl1.TabIndex = 3;
            this.Lbl1.Text = "Lbl1";
            // 
            // Trb1
            // 
            this.Trb1.Location = new System.Drawing.Point(20, 49);
            this.Trb1.Margin = new System.Windows.Forms.Padding(4);
            this.Trb1.Maximum = 4;
            this.Trb1.Name = "Trb1";
            this.Trb1.Size = new System.Drawing.Size(288, 56);
            this.Trb1.TabIndex = 2;
            this.Trb1.Value = 2;
            this.Trb1.Scroll += new System.EventHandler(this.Trb1_Scroll);
            // 
            // Btn
            // 
            this.Btn.Location = new System.Drawing.Point(347, 213);
            this.Btn.Margin = new System.Windows.Forms.Padding(4);
            this.Btn.Name = "Btn";
            this.Btn.Size = new System.Drawing.Size(144, 36);
            this.Btn.TabIndex = 0;
            this.Btn.Text = "Start";
            this.Btn.UseVisualStyleBackColor = true;
            this.Btn.Click += new System.EventHandler(this.Btn_Click);
            // 
            // TabPage
            // 
            this.TabPage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.TabPage.Controls.Add(this.Chk);
            this.TabPage.Controls.Add(this.Lbl6);
            this.TabPage.Controls.Add(this.Trb2);
            this.TabPage.Controls.Add(this.Lbl5);
            this.TabPage.Controls.Add(this.Lbl2);
            this.TabPage.Controls.Add(this.Lbl1);
            this.TabPage.Controls.Add(this.Trb1);
            this.TabPage.Controls.Add(this.Btn);
            this.TabPage.Location = new System.Drawing.Point(4, 25);
            this.TabPage.Margin = new System.Windows.Forms.Padding(4);
            this.TabPage.Name = "TabPage";
            this.TabPage.Padding = new System.Windows.Forms.Padding(4);
            this.TabPage.Size = new System.Drawing.Size(540, 270);
            this.TabPage.TabIndex = 0;
            this.TabPage.Text = "Game";
            this.TabPage.UseVisualStyleBackColor = true;
            // 
            // Tab
            // 
            this.Tab.Controls.Add(this.TabPage);
            this.Tab.Location = new System.Drawing.Point(13, 13);
            this.Tab.Margin = new System.Windows.Forms.Padding(4);
            this.Tab.Name = "Tab";
            this.Tab.SelectedIndex = 0;
            this.Tab.Size = new System.Drawing.Size(548, 299);
            this.Tab.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 330);
            this.Controls.Add(this.Tab);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Trb2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Trb1)).EndInit();
            this.TabPage.ResumeLayout(false);
            this.TabPage.PerformLayout();
            this.Tab.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckBox Chk;
        private System.Windows.Forms.Label Lbl6;
        private System.Windows.Forms.TrackBar Trb2;
        private System.Windows.Forms.Label Lbl5;
        private System.Windows.Forms.Label Lbl2;
        private System.Windows.Forms.Label Lbl1;
        private System.Windows.Forms.TrackBar Trb1;
        private System.Windows.Forms.Button Btn;
        private System.Windows.Forms.TabPage TabPage;
        private System.Windows.Forms.TabControl Tab;
    }
}


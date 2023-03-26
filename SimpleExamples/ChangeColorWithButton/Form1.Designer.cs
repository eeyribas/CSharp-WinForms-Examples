
namespace ChangeColorWithButton
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
            this.Btn = new System.Windows.Forms.Button();
            this.Txt6 = new System.Windows.Forms.TextBox();
            this.Txt5 = new System.Windows.Forms.TextBox();
            this.Txt4 = new System.Windows.Forms.TextBox();
            this.Txt3 = new System.Windows.Forms.TextBox();
            this.Txt2 = new System.Windows.Forms.TextBox();
            this.Lbl2 = new System.Windows.Forms.Label();
            this.Lbl1 = new System.Windows.Forms.Label();
            this.Txt1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Btn
            // 
            this.Btn.Location = new System.Drawing.Point(154, 249);
            this.Btn.Name = "Btn";
            this.Btn.Size = new System.Drawing.Size(172, 31);
            this.Btn.TabIndex = 15;
            this.Btn.Text = "text";
            this.Btn.UseVisualStyleBackColor = true;
            this.Btn.Click += new System.EventHandler(this.Btn_Click);
            // 
            // Txt6
            // 
            this.Txt6.ForeColor = System.Drawing.Color.SeaGreen;
            this.Txt6.Location = new System.Drawing.Point(265, 195);
            this.Txt6.Name = "Txt6";
            this.Txt6.Size = new System.Drawing.Size(133, 22);
            this.Txt6.TabIndex = 14;
            this.Txt6.Text = "text";
            this.Txt6.Enter += new System.EventHandler(this.Txt_Enter);
            this.Txt6.Leave += new System.EventHandler(this.Txt_Leave);
            // 
            // Txt5
            // 
            this.Txt5.ForeColor = System.Drawing.Color.SeaGreen;
            this.Txt5.Location = new System.Drawing.Point(82, 195);
            this.Txt5.Name = "Txt5";
            this.Txt5.Size = new System.Drawing.Size(133, 22);
            this.Txt5.TabIndex = 13;
            this.Txt5.Text = "text";
            this.Txt5.Enter += new System.EventHandler(this.Txt_Enter);
            this.Txt5.Leave += new System.EventHandler(this.Txt_Leave);
            // 
            // Txt4
            // 
            this.Txt4.ForeColor = System.Drawing.Color.SeaGreen;
            this.Txt4.Location = new System.Drawing.Point(265, 142);
            this.Txt4.Name = "Txt4";
            this.Txt4.Size = new System.Drawing.Size(133, 22);
            this.Txt4.TabIndex = 12;
            this.Txt4.Text = "text";
            this.Txt4.Enter += new System.EventHandler(this.Txt_Enter);
            this.Txt4.Leave += new System.EventHandler(this.Txt_Leave);
            // 
            // Txt3
            // 
            this.Txt3.ForeColor = System.Drawing.Color.SeaGreen;
            this.Txt3.Location = new System.Drawing.Point(82, 142);
            this.Txt3.Name = "Txt3";
            this.Txt3.Size = new System.Drawing.Size(133, 22);
            this.Txt3.TabIndex = 11;
            this.Txt3.Text = "text";
            this.Txt3.Enter += new System.EventHandler(this.Txt_Enter);
            this.Txt3.Leave += new System.EventHandler(this.Txt_Leave);
            // 
            // Txt2
            // 
            this.Txt2.ForeColor = System.Drawing.Color.SeaGreen;
            this.Txt2.Location = new System.Drawing.Point(265, 89);
            this.Txt2.Name = "Txt2";
            this.Txt2.Size = new System.Drawing.Size(133, 22);
            this.Txt2.TabIndex = 10;
            this.Txt2.Text = "text";
            this.Txt2.Enter += new System.EventHandler(this.Txt_Enter);
            this.Txt2.Leave += new System.EventHandler(this.Txt_Leave);
            // 
            // Lbl2
            // 
            this.Lbl2.AutoSize = true;
            this.Lbl2.Location = new System.Drawing.Point(265, 43);
            this.Lbl2.Name = "Lbl2";
            this.Lbl2.Size = new System.Drawing.Size(30, 17);
            this.Lbl2.TabIndex = 17;
            this.Lbl2.Text = "text";
            // 
            // Lbl1
            // 
            this.Lbl1.AutoSize = true;
            this.Lbl1.Location = new System.Drawing.Point(82, 43);
            this.Lbl1.Name = "Lbl1";
            this.Lbl1.Size = new System.Drawing.Size(30, 17);
            this.Lbl1.TabIndex = 16;
            this.Lbl1.Text = "text";
            // 
            // Txt1
            // 
            this.Txt1.ForeColor = System.Drawing.Color.SeaGreen;
            this.Txt1.Location = new System.Drawing.Point(82, 89);
            this.Txt1.Name = "Txt1";
            this.Txt1.Size = new System.Drawing.Size(133, 22);
            this.Txt1.TabIndex = 9;
            this.Txt1.Text = "text";
            this.Txt1.Enter += new System.EventHandler(this.Txt_Enter);
            this.Txt1.Leave += new System.EventHandler(this.Txt_Leave);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 330);
            this.Controls.Add(this.Btn);
            this.Controls.Add(this.Txt6);
            this.Controls.Add(this.Txt5);
            this.Controls.Add(this.Txt4);
            this.Controls.Add(this.Txt3);
            this.Controls.Add(this.Txt2);
            this.Controls.Add(this.Lbl2);
            this.Controls.Add(this.Lbl1);
            this.Controls.Add(this.Txt1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn;
        private System.Windows.Forms.TextBox Txt6;
        private System.Windows.Forms.TextBox Txt5;
        private System.Windows.Forms.TextBox Txt4;
        private System.Windows.Forms.TextBox Txt3;
        private System.Windows.Forms.TextBox Txt2;
        private System.Windows.Forms.Label Lbl2;
        private System.Windows.Forms.Label Lbl1;
        private System.Windows.Forms.TextBox Txt1;
    }
}


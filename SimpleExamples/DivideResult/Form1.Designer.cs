
namespace DivideResult
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
            this.Lbl5 = new System.Windows.Forms.Label();
            this.Lbl4 = new System.Windows.Forms.Label();
            this.Lbl3 = new System.Windows.Forms.Label();
            this.Lbl2 = new System.Windows.Forms.Label();
            this.Lbl1 = new System.Windows.Forms.Label();
            this.Txt4 = new System.Windows.Forms.TextBox();
            this.Txt3 = new System.Windows.Forms.TextBox();
            this.Txt2 = new System.Windows.Forms.TextBox();
            this.Txt1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Btn
            // 
            this.Btn.Location = new System.Drawing.Point(210, 151);
            this.Btn.Name = "Btn";
            this.Btn.Size = new System.Drawing.Size(136, 35);
            this.Btn.TabIndex = 10;
            this.Btn.Text = "Ok";
            this.Btn.UseVisualStyleBackColor = true;
            this.Btn.Click += new System.EventHandler(this.Btn_Click);
            // 
            // Lbl5
            // 
            this.Lbl5.AutoSize = true;
            this.Lbl5.ForeColor = System.Drawing.Color.DarkRed;
            this.Lbl5.Location = new System.Drawing.Point(186, 45);
            this.Lbl5.Name = "Lbl5";
            this.Lbl5.Size = new System.Drawing.Size(209, 20);
            this.Lbl5.TabIndex = 19;
            this.Lbl5.Text = "Two Integer Division";
            // 
            // Lbl4
            // 
            this.Lbl4.AutoSize = true;
            this.Lbl4.Location = new System.Drawing.Point(415, 80);
            this.Lbl4.Name = "Lbl4";
            this.Lbl4.Size = new System.Drawing.Size(49, 20);
            this.Lbl4.TabIndex = 18;
            this.Lbl4.Text = "Rest";
            // 
            // Lbl3
            // 
            this.Lbl3.AutoSize = true;
            this.Lbl3.Location = new System.Drawing.Point(298, 80);
            this.Lbl3.Name = "Lbl3";
            this.Lbl3.Size = new System.Drawing.Size(79, 20);
            this.Lbl3.TabIndex = 17;
            this.Lbl3.Text = "Section";
            // 
            // Lbl2
            // 
            this.Lbl2.AutoSize = true;
            this.Lbl2.Location = new System.Drawing.Point(151, 80);
            this.Lbl2.Name = "Lbl2";
            this.Lbl2.Size = new System.Drawing.Size(89, 20);
            this.Lbl2.TabIndex = 16;
            this.Lbl2.Text = "Divisive";
            // 
            // Lbl1
            // 
            this.Lbl1.AutoSize = true;
            this.Lbl1.Location = new System.Drawing.Point(34, 80);
            this.Lbl1.Name = "Lbl1";
            this.Lbl1.Size = new System.Drawing.Size(89, 20);
            this.Lbl1.TabIndex = 15;
            this.Lbl1.Text = "Dividing";
            // 
            // Txt4
            // 
            this.Txt4.ForeColor = System.Drawing.Color.DarkRed;
            this.Txt4.Location = new System.Drawing.Point(415, 99);
            this.Txt4.Name = "Txt4";
            this.Txt4.Size = new System.Drawing.Size(100, 26);
            this.Txt4.TabIndex = 14;
            this.Txt4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt34_KeyPress);
            // 
            // Txt3
            // 
            this.Txt3.ForeColor = System.Drawing.Color.DarkRed;
            this.Txt3.Location = new System.Drawing.Point(298, 99);
            this.Txt3.Name = "Txt3";
            this.Txt3.Size = new System.Drawing.Size(100, 26);
            this.Txt3.TabIndex = 13;
            this.Txt3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt34_KeyPress);
            // 
            // Txt2
            // 
            this.Txt2.ForeColor = System.Drawing.Color.DarkGreen;
            this.Txt2.Location = new System.Drawing.Point(151, 99);
            this.Txt2.Name = "Txt2";
            this.Txt2.Size = new System.Drawing.Size(100, 26);
            this.Txt2.TabIndex = 12;
            this.Txt2.Text = "6";
            this.Txt2.TextChanged += new System.EventHandler(this.Txt12_TextChanged);
            // 
            // Txt1
            // 
            this.Txt1.ForeColor = System.Drawing.Color.DarkGreen;
            this.Txt1.Location = new System.Drawing.Point(34, 99);
            this.Txt1.Name = "Txt1";
            this.Txt1.Size = new System.Drawing.Size(100, 26);
            this.Txt1.TabIndex = 11;
            this.Txt1.Text = "45";
            this.Txt1.TextChanged += new System.EventHandler(this.Txt12_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 230);
            this.Controls.Add(this.Btn);
            this.Controls.Add(this.Lbl5);
            this.Controls.Add(this.Lbl4);
            this.Controls.Add(this.Lbl3);
            this.Controls.Add(this.Lbl2);
            this.Controls.Add(this.Lbl1);
            this.Controls.Add(this.Txt4);
            this.Controls.Add(this.Txt3);
            this.Controls.Add(this.Txt2);
            this.Controls.Add(this.Txt1);
            this.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold);
            this.ForeColor = System.Drawing.Color.Navy;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn;
        private System.Windows.Forms.Label Lbl5;
        private System.Windows.Forms.Label Lbl4;
        private System.Windows.Forms.Label Lbl3;
        private System.Windows.Forms.Label Lbl2;
        private System.Windows.Forms.Label Lbl1;
        private System.Windows.Forms.TextBox Txt4;
        private System.Windows.Forms.TextBox Txt3;
        private System.Windows.Forms.TextBox Txt2;
        private System.Windows.Forms.TextBox Txt1;
    }
}


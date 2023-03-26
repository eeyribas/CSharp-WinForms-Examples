
namespace String_Reverse
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
            this.Lbl1 = new System.Windows.Forms.Label();
            this.Lbl4 = new System.Windows.Forms.Label();
            this.Lbl3 = new System.Windows.Forms.Label();
            this.Lbl2 = new System.Windows.Forms.Label();
            this.Txt3 = new System.Windows.Forms.TextBox();
            this.Txt2 = new System.Windows.Forms.TextBox();
            this.Txt1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Lbl1
            // 
            this.Lbl1.AutoSize = true;
            this.Lbl1.Location = new System.Drawing.Point(138, 67);
            this.Lbl1.Name = "Lbl1";
            this.Lbl1.Size = new System.Drawing.Size(19, 20);
            this.Lbl1.TabIndex = 21;
            this.Lbl1.Text = "-";
            // 
            // Lbl4
            // 
            this.Lbl4.AutoSize = true;
            this.Lbl4.Location = new System.Drawing.Point(351, 122);
            this.Lbl4.Name = "Lbl4";
            this.Lbl4.Size = new System.Drawing.Size(79, 20);
            this.Lbl4.TabIndex = 20;
            this.Lbl4.Text = "Reverse";
            // 
            // Lbl3
            // 
            this.Lbl3.AutoSize = true;
            this.Lbl3.Location = new System.Drawing.Point(351, 56);
            this.Lbl3.Name = "Lbl3";
            this.Lbl3.Size = new System.Drawing.Size(69, 20);
            this.Lbl3.TabIndex = 19;
            this.Lbl3.Text = "Normal";
            // 
            // Lbl2
            // 
            this.Lbl2.AutoSize = true;
            this.Lbl2.Location = new System.Drawing.Point(50, 67);
            this.Lbl2.Name = "Lbl2";
            this.Lbl2.Size = new System.Drawing.Size(89, 20);
            this.Lbl2.TabIndex = 18;
            this.Lbl2.Text = "Length :";
            // 
            // Txt3
            // 
            this.Txt3.ForeColor = System.Drawing.Color.Red;
            this.Txt3.Location = new System.Drawing.Point(213, 119);
            this.Txt3.Name = "Txt3";
            this.Txt3.Size = new System.Drawing.Size(135, 26);
            this.Txt3.TabIndex = 17;
            this.Txt3.Text = "content";
            this.Txt3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt23_KeyPress);
            // 
            // Txt2
            // 
            this.Txt2.ForeColor = System.Drawing.Color.Red;
            this.Txt2.Location = new System.Drawing.Point(213, 53);
            this.Txt2.Name = "Txt2";
            this.Txt2.Size = new System.Drawing.Size(135, 26);
            this.Txt2.TabIndex = 16;
            this.Txt2.Text = "content";
            this.Txt2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt23_KeyPress);
            // 
            // Txt1
            // 
            this.Txt1.ForeColor = System.Drawing.Color.OliveDrab;
            this.Txt1.Location = new System.Drawing.Point(50, 86);
            this.Txt1.MaxLength = 16;
            this.Txt1.Name = "Txt1";
            this.Txt1.Size = new System.Drawing.Size(135, 26);
            this.Txt1.TabIndex = 15;
            this.Txt1.Text = "content";
            this.Txt1.TextChanged += new System.EventHandler(this.Txt1_TextChanged);
            this.Txt1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt1_KeyPress);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 199);
            this.Controls.Add(this.Lbl1);
            this.Controls.Add(this.Lbl4);
            this.Controls.Add(this.Lbl3);
            this.Controls.Add(this.Lbl2);
            this.Controls.Add(this.Txt3);
            this.Controls.Add(this.Txt2);
            this.Controls.Add(this.Txt1);
            this.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold);
            this.ForeColor = System.Drawing.Color.Peru;
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

        private System.Windows.Forms.Label Lbl1;
        private System.Windows.Forms.Label Lbl4;
        private System.Windows.Forms.Label Lbl3;
        private System.Windows.Forms.Label Lbl2;
        private System.Windows.Forms.TextBox Txt3;
        private System.Windows.Forms.TextBox Txt2;
        private System.Windows.Forms.TextBox Txt1;
    }
}



namespace ConvertRadix
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
            this.Lbl4 = new System.Windows.Forms.Label();
            this.Lbl1 = new System.Windows.Forms.Label();
            this.Lbl3 = new System.Windows.Forms.Label();
            this.Nud2 = new System.Windows.Forms.NumericUpDown();
            this.Lbl2 = new System.Windows.Forms.Label();
            this.Nud1 = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.Nud2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Nud1)).BeginInit();
            this.SuspendLayout();
            // 
            // Lbl4
            // 
            this.Lbl4.AutoSize = true;
            this.Lbl4.Location = new System.Drawing.Point(60, 119);
            this.Lbl4.Name = "Lbl4";
            this.Lbl4.Size = new System.Drawing.Size(109, 20);
            this.Lbl4.TabIndex = 11;
            this.Lbl4.Text = "Value --->";
            // 
            // Lbl1
            // 
            this.Lbl1.AutoSize = true;
            this.Lbl1.ForeColor = System.Drawing.Color.Green;
            this.Lbl1.Location = new System.Drawing.Point(185, 119);
            this.Lbl1.Name = "Lbl1";
            this.Lbl1.Size = new System.Drawing.Size(69, 20);
            this.Lbl1.TabIndex = 8;
            this.Lbl1.Text = "result";
            // 
            // Lbl3
            // 
            this.Lbl3.AutoSize = true;
            this.Lbl3.Location = new System.Drawing.Point(151, 80);
            this.Lbl3.Name = "Lbl3";
            this.Lbl3.Size = new System.Drawing.Size(59, 20);
            this.Lbl3.TabIndex = 10;
            this.Lbl3.Text = "Radix";
            // 
            // Nud2
            // 
            this.Nud2.ForeColor = System.Drawing.Color.Green;
            this.Nud2.Location = new System.Drawing.Point(216, 78);
            this.Nud2.Maximum = new decimal(new int[] {
            16,
            0,
            0,
            0});
            this.Nud2.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.Nud2.Name = "Nud2";
            this.Nud2.Size = new System.Drawing.Size(49, 26);
            this.Nud2.TabIndex = 7;
            this.Nud2.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.Nud2.ValueChanged += new System.EventHandler(this.Nud_ValueChanged);
            // 
            // Lbl2
            // 
            this.Lbl2.AutoSize = true;
            this.Lbl2.Location = new System.Drawing.Point(86, 39);
            this.Lbl2.Name = "Lbl2";
            this.Lbl2.Size = new System.Drawing.Size(69, 20);
            this.Lbl2.TabIndex = 9;
            this.Lbl2.Text = "Number";
            // 
            // Nud1
            // 
            this.Nud1.ForeColor = System.Drawing.Color.Green;
            this.Nud1.Location = new System.Drawing.Point(161, 37);
            this.Nud1.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.Nud1.Name = "Nud1";
            this.Nud1.Size = new System.Drawing.Size(104, 26);
            this.Nud1.TabIndex = 6;
            this.Nud1.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.Nud1.ValueChanged += new System.EventHandler(this.Nud_ValueChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 185);
            this.Controls.Add(this.Lbl4);
            this.Controls.Add(this.Lbl1);
            this.Controls.Add(this.Lbl3);
            this.Controls.Add(this.Nud2);
            this.Controls.Add(this.Lbl2);
            this.Controls.Add(this.Nud1);
            this.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold);
            this.ForeColor = System.Drawing.Color.Red;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Nud2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Nud1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl4;
        private System.Windows.Forms.Label Lbl1;
        private System.Windows.Forms.Label Lbl3;
        private System.Windows.Forms.NumericUpDown Nud2;
        private System.Windows.Forms.Label Lbl2;
        private System.Windows.Forms.NumericUpDown Nud1;
    }
}


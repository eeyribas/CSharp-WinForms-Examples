
namespace TextBox_ColorChange
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
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(279, 211);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(168, 35);
            this.button2.TabIndex = 15;
            this.button2.Text = "Original";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(69, 211);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(168, 35);
            this.button1.TabIndex = 14;
            this.button1.Text = "Random";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox6
            // 
            this.textBox6.ForeColor = System.Drawing.Color.SeaGreen;
            this.textBox6.Location = new System.Drawing.Point(279, 156);
            this.textBox6.MaxLength = 20;
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(168, 26);
            this.textBox6.TabIndex = 13;
            this.textBox6.Text = "content";
            // 
            // textBox5
            // 
            this.textBox5.ForeColor = System.Drawing.Color.SeaGreen;
            this.textBox5.Location = new System.Drawing.Point(69, 156);
            this.textBox5.MaxLength = 20;
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(168, 26);
            this.textBox5.TabIndex = 12;
            this.textBox5.Text = "content";
            // 
            // textBox4
            // 
            this.textBox4.ForeColor = System.Drawing.Color.SeaGreen;
            this.textBox4.Location = new System.Drawing.Point(279, 107);
            this.textBox4.MaxLength = 20;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(168, 26);
            this.textBox4.TabIndex = 11;
            this.textBox4.Text = "content";
            // 
            // textBox3
            // 
            this.textBox3.ForeColor = System.Drawing.Color.SeaGreen;
            this.textBox3.Location = new System.Drawing.Point(69, 107);
            this.textBox3.MaxLength = 20;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(168, 26);
            this.textBox3.TabIndex = 10;
            this.textBox3.Text = "content";
            // 
            // textBox2
            // 
            this.textBox2.ForeColor = System.Drawing.Color.SeaGreen;
            this.textBox2.Location = new System.Drawing.Point(279, 59);
            this.textBox2.MaxLength = 20;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(168, 26);
            this.textBox2.TabIndex = 9;
            this.textBox2.Text = "content";
            // 
            // textBox1
            // 
            this.textBox1.ForeColor = System.Drawing.Color.SeaGreen;
            this.textBox1.Location = new System.Drawing.Point(69, 59);
            this.textBox1.MaxLength = 20;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(168, 26);
            this.textBox1.TabIndex = 8;
            this.textBox1.Text = "content";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 304);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold);
            this.ForeColor = System.Drawing.Color.Brown;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
    }
}


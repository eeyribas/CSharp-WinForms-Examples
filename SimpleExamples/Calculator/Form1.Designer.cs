
namespace Calculator
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
            this.Lbl5 = new System.Windows.Forms.Label();
            this.Lbl4 = new System.Windows.Forms.Label();
            this.Lbl3 = new System.Windows.Forms.Label();
            this.Lbl2 = new System.Windows.Forms.Label();
            this.Lbl1 = new System.Windows.Forms.Label();
            this.Txt3 = new System.Windows.Forms.TextBox();
            this.Txt2 = new System.Windows.Forms.TextBox();
            this.Txt1 = new System.Windows.Forms.TextBox();
            this.Btn4 = new System.Windows.Forms.Button();
            this.Btn3 = new System.Windows.Forms.Button();
            this.Btn2 = new System.Windows.Forms.Button();
            this.Btn1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Lbl5
            // 
            this.Lbl5.AutoSize = true;
            this.Lbl5.Location = new System.Drawing.Point(441, 43);
            this.Lbl5.Name = "Lbl5";
            this.Lbl5.Size = new System.Drawing.Size(69, 20);
            this.Lbl5.TabIndex = 23;
            this.Lbl5.Text = "Result";
            // 
            // Lbl4
            // 
            this.Lbl4.AutoSize = true;
            this.Lbl4.Location = new System.Drawing.Point(269, 43);
            this.Lbl4.Name = "Lbl4";
            this.Lbl4.Size = new System.Drawing.Size(89, 20);
            this.Lbl4.TabIndex = 22;
            this.Lbl4.Text = "2.Number";
            // 
            // Lbl3
            // 
            this.Lbl3.AutoSize = true;
            this.Lbl3.Location = new System.Drawing.Point(105, 43);
            this.Lbl3.Name = "Lbl3";
            this.Lbl3.Size = new System.Drawing.Size(89, 20);
            this.Lbl3.TabIndex = 21;
            this.Lbl3.Text = "1.Number";
            // 
            // Lbl2
            // 
            this.Lbl2.AutoSize = true;
            this.Lbl2.ForeColor = System.Drawing.Color.SeaGreen;
            this.Lbl2.Location = new System.Drawing.Point(371, 70);
            this.Lbl2.Name = "Lbl2";
            this.Lbl2.Size = new System.Drawing.Size(19, 20);
            this.Lbl2.TabIndex = 20;
            this.Lbl2.Text = "=";
            // 
            // Lbl1
            // 
            this.Lbl1.AutoSize = true;
            this.Lbl1.ForeColor = System.Drawing.Color.SeaGreen;
            this.Lbl1.Location = new System.Drawing.Point(207, 70);
            this.Lbl1.Name = "Lbl1";
            this.Lbl1.Size = new System.Drawing.Size(19, 20);
            this.Lbl1.TabIndex = 19;
            this.Lbl1.Text = "?";
            // 
            // Txt3
            // 
            this.Txt3.ForeColor = System.Drawing.Color.SeaGreen;
            this.Txt3.Location = new System.Drawing.Point(393, 67);
            this.Txt3.Name = "Txt3";
            this.Txt3.Size = new System.Drawing.Size(144, 26);
            this.Txt3.TabIndex = 14;
            this.Txt3.Text = "content";
            this.Txt3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt3_KeyPress);
            // 
            // Txt2
            // 
            this.Txt2.ForeColor = System.Drawing.Color.SeaGreen;
            this.Txt2.Location = new System.Drawing.Point(229, 67);
            this.Txt2.MaxLength = 16;
            this.Txt2.Name = "Txt2";
            this.Txt2.Size = new System.Drawing.Size(136, 26);
            this.Txt2.TabIndex = 13;
            this.Txt2.Text = "content";
            this.Txt2.TextChanged += new System.EventHandler(this.Txt12_TextChanged);
            // 
            // Txt1
            // 
            this.Txt1.ForeColor = System.Drawing.Color.SeaGreen;
            this.Txt1.Location = new System.Drawing.Point(65, 67);
            this.Txt1.MaxLength = 16;
            this.Txt1.Name = "Txt1";
            this.Txt1.Size = new System.Drawing.Size(136, 26);
            this.Txt1.TabIndex = 12;
            this.Txt1.Text = "content";
            this.Txt1.TextChanged += new System.EventHandler(this.Txt12_TextChanged);
            // 
            // Btn4
            // 
            this.Btn4.ForeColor = System.Drawing.Color.Navy;
            this.Btn4.Location = new System.Drawing.Point(446, 122);
            this.Btn4.Name = "Btn4";
            this.Btn4.Size = new System.Drawing.Size(90, 33);
            this.Btn4.TabIndex = 18;
            this.Btn4.Text = "Divide";
            this.Btn4.UseVisualStyleBackColor = true;
            this.Btn4.Click += new System.EventHandler(this.Btn_Click);
            // 
            // Btn3
            // 
            this.Btn3.ForeColor = System.Drawing.Color.Navy;
            this.Btn3.Location = new System.Drawing.Point(319, 122);
            this.Btn3.Name = "Btn3";
            this.Btn3.Size = new System.Drawing.Size(99, 33);
            this.Btn3.TabIndex = 17;
            this.Btn3.Text = "Multiply";
            this.Btn3.UseVisualStyleBackColor = true;
            this.Btn3.Click += new System.EventHandler(this.Btn_Click);
            // 
            // Btn2
            // 
            this.Btn2.ForeColor = System.Drawing.Color.Navy;
            this.Btn2.Location = new System.Drawing.Point(173, 122);
            this.Btn2.Name = "Btn2";
            this.Btn2.Size = new System.Drawing.Size(128, 33);
            this.Btn2.TabIndex = 16;
            this.Btn2.Text = "Subtraction";
            this.Btn2.UseVisualStyleBackColor = true;
            this.Btn2.Click += new System.EventHandler(this.Btn_Click);
            // 
            // Btn1
            // 
            this.Btn1.ForeColor = System.Drawing.Color.Navy;
            this.Btn1.Location = new System.Drawing.Point(65, 122);
            this.Btn1.Name = "Btn1";
            this.Btn1.Size = new System.Drawing.Size(90, 33);
            this.Btn1.TabIndex = 15;
            this.Btn1.Text = "Sum";
            this.Btn1.UseVisualStyleBackColor = true;
            this.Btn1.Click += new System.EventHandler(this.Btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 217);
            this.Controls.Add(this.Lbl5);
            this.Controls.Add(this.Lbl4);
            this.Controls.Add(this.Lbl3);
            this.Controls.Add(this.Lbl2);
            this.Controls.Add(this.Lbl1);
            this.Controls.Add(this.Txt3);
            this.Controls.Add(this.Txt2);
            this.Controls.Add(this.Txt1);
            this.Controls.Add(this.Btn4);
            this.Controls.Add(this.Btn3);
            this.Controls.Add(this.Btn2);
            this.Controls.Add(this.Btn1);
            this.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold);
            this.ForeColor = System.Drawing.Color.Sienna;
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

        private System.Windows.Forms.Label Lbl5;
        private System.Windows.Forms.Label Lbl4;
        private System.Windows.Forms.Label Lbl3;
        private System.Windows.Forms.Label Lbl2;
        private System.Windows.Forms.Label Lbl1;
        private System.Windows.Forms.TextBox Txt3;
        private System.Windows.Forms.TextBox Txt2;
        private System.Windows.Forms.TextBox Txt1;
        private System.Windows.Forms.Button Btn4;
        private System.Windows.Forms.Button Btn3;
        private System.Windows.Forms.Button Btn2;
        private System.Windows.Forms.Button Btn1;
    }
}



namespace SwitchCase_SelectedTextBox
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.ForeColor = System.Drawing.Color.SaddleBrown;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "1.TextBox",
            "2.TextBox",
            "3.TextBox",
            "4.TextBox"});
            this.comboBox1.Location = new System.Drawing.Point(174, 35);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 26);
            this.comboBox1.TabIndex = 5;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.Cmb_SelectedIndexChanged);
            this.comboBox1.Enter += new System.EventHandler(this.comboBox1_Enter);
            this.comboBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBox1_KeyPress);
            // 
            // textBox4
            // 
            this.textBox4.ForeColor = System.Drawing.Color.SaddleBrown;
            this.textBox4.Location = new System.Drawing.Point(48, 159);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 26);
            this.textBox4.TabIndex = 9;
            this.textBox4.Text = "4.TextBox";
            this.textBox4.Enter += new System.EventHandler(this.textBox_Enter);
            // 
            // textBox3
            // 
            this.textBox3.ForeColor = System.Drawing.Color.SaddleBrown;
            this.textBox3.Location = new System.Drawing.Point(48, 117);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 26);
            this.textBox3.TabIndex = 8;
            this.textBox3.Text = "3.TextBox";
            this.textBox3.Enter += new System.EventHandler(this.textBox_Enter);
            // 
            // textBox2
            // 
            this.textBox2.ForeColor = System.Drawing.Color.SaddleBrown;
            this.textBox2.Location = new System.Drawing.Point(48, 77);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 26);
            this.textBox2.TabIndex = 7;
            this.textBox2.Text = "2.TextBox";
            this.textBox2.Enter += new System.EventHandler(this.textBox_Enter);
            // 
            // textBox1
            // 
            this.textBox1.ForeColor = System.Drawing.Color.SaddleBrown;
            this.textBox1.Location = new System.Drawing.Point(48, 37);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 26);
            this.textBox1.TabIndex = 6;
            this.textBox1.Text = "1.TextBox";
            this.textBox1.Enter += new System.EventHandler(this.textBox_Enter);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(342, 221);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold);
            this.ForeColor = System.Drawing.Color.SaddleBrown;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
    }
}


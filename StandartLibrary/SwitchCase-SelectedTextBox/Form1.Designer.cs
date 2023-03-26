
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
            this.Cmb = new System.Windows.Forms.ComboBox();
            this.Txt4 = new System.Windows.Forms.TextBox();
            this.Txt3 = new System.Windows.Forms.TextBox();
            this.Txt2 = new System.Windows.Forms.TextBox();
            this.Txt1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Cmb
            // 
            this.Cmb.ForeColor = System.Drawing.Color.SaddleBrown;
            this.Cmb.FormattingEnabled = true;
            this.Cmb.Items.AddRange(new object[] {
            "1.TextBox",
            "2.TextBox",
            "3.TextBox",
            "4.TextBox"});
            this.Cmb.Location = new System.Drawing.Point(174, 35);
            this.Cmb.Name = "Cmb";
            this.Cmb.Size = new System.Drawing.Size(121, 26);
            this.Cmb.TabIndex = 5;
            this.Cmb.SelectedIndexChanged += new System.EventHandler(this.Cmb_SelectedIndexChanged);
            this.Cmb.Enter += new System.EventHandler(this.Cmb_Enter);
            this.Cmb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Cmb_KeyPress);
            // 
            // Txt4
            // 
            this.Txt4.ForeColor = System.Drawing.Color.SaddleBrown;
            this.Txt4.Location = new System.Drawing.Point(48, 159);
            this.Txt4.Name = "Txt4";
            this.Txt4.Size = new System.Drawing.Size(100, 26);
            this.Txt4.TabIndex = 9;
            this.Txt4.Text = "4.TextBox";
            this.Txt4.Enter += new System.EventHandler(this.Txt_Enter);
            // 
            // Txt3
            // 
            this.Txt3.ForeColor = System.Drawing.Color.SaddleBrown;
            this.Txt3.Location = new System.Drawing.Point(48, 117);
            this.Txt3.Name = "Txt3";
            this.Txt3.Size = new System.Drawing.Size(100, 26);
            this.Txt3.TabIndex = 8;
            this.Txt3.Text = "3.TextBox";
            this.Txt3.Enter += new System.EventHandler(this.Txt_Enter);
            // 
            // Txt2
            // 
            this.Txt2.ForeColor = System.Drawing.Color.SaddleBrown;
            this.Txt2.Location = new System.Drawing.Point(48, 77);
            this.Txt2.Name = "Txt2";
            this.Txt2.Size = new System.Drawing.Size(100, 26);
            this.Txt2.TabIndex = 7;
            this.Txt2.Text = "2.TextBox";
            this.Txt2.Enter += new System.EventHandler(this.Txt_Enter);
            // 
            // Txt1
            // 
            this.Txt1.ForeColor = System.Drawing.Color.SaddleBrown;
            this.Txt1.Location = new System.Drawing.Point(48, 37);
            this.Txt1.Name = "Txt1";
            this.Txt1.Size = new System.Drawing.Size(100, 26);
            this.Txt1.TabIndex = 6;
            this.Txt1.Text = "1.TextBox";
            this.Txt1.Enter += new System.EventHandler(this.Txt_Enter);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(342, 221);
            this.Controls.Add(this.Cmb);
            this.Controls.Add(this.Txt4);
            this.Controls.Add(this.Txt3);
            this.Controls.Add(this.Txt2);
            this.Controls.Add(this.Txt1);
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

        private System.Windows.Forms.ComboBox Cmb;
        private System.Windows.Forms.TextBox Txt4;
        private System.Windows.Forms.TextBox Txt3;
        private System.Windows.Forms.TextBox Txt2;
        private System.Windows.Forms.TextBox Txt1;
    }
}


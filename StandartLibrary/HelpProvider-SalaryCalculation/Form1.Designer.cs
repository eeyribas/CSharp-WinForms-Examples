
namespace HelpProvider_SalaryCalculation
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Location = new System.Drawing.Point(12, 212);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(480, 92);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "To view the glossary.chm file under the Windows\\Help folder, click the button bel" +
    "ow.";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(29, 37);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(422, 37);
            this.button3.TabIndex = 0;
            this.button3.Text = "Glossary of technical terms";
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.helpProvider1.SetHelpString(this.button2, "Personele ait bilgi giriş kutularını silmek için bu düğmeyi kullanabilirsiniz");
            this.button2.Location = new System.Drawing.Point(298, 66);
            this.button2.Name = "button2";
            this.helpProvider1.SetShowHelp(this.button2, true);
            this.button2.Size = new System.Drawing.Size(115, 27);
            this.button2.TabIndex = 19;
            this.button2.Text = "Delete";
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.helpProvider1.SetHelpString(this.button1, "Personelin alacağı maaşı hesaplamak için bu düğmeye basınız");
            this.button1.Location = new System.Drawing.Point(298, 29);
            this.button1.Name = "button1";
            this.helpProvider1.SetShowHelp(this.button1, true);
            this.button1.Size = new System.Drawing.Size(115, 27);
            this.button1.TabIndex = 18;
            this.button1.Text = "Calculate";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox4
            // 
            this.helpProvider1.SetHelpString(this.textBox4, "Bu kutunun içeriği Yevmiyesi ve Çalıştığı Gün Sayısı kutularının içeriğine göre o" +
        "tomatik hesaplanır. Sonucu görmek için Hesapla düğmesine basmalısınız");
            this.textBox4.Location = new System.Drawing.Point(154, 113);
            this.textBox4.Name = "textBox4";
            this.helpProvider1.SetShowHelp(this.textBox4, true);
            this.textBox4.Size = new System.Drawing.Size(120, 22);
            this.textBox4.TabIndex = 17;
            this.textBox4.Text = "-";
            // 
            // textBox3
            // 
            this.helpProvider1.SetHelpString(this.textBox3, "Bu kutuya maaşını hesaplayacağınız personelin kaç gün çalıştığını yazınız");
            this.textBox3.Location = new System.Drawing.Point(154, 85);
            this.textBox3.Name = "textBox3";
            this.helpProvider1.SetShowHelp(this.textBox3, true);
            this.textBox3.Size = new System.Drawing.Size(120, 22);
            this.textBox3.TabIndex = 15;
            this.textBox3.Text = "-";
            // 
            // textBox2
            // 
            this.helpProvider1.SetHelpString(this.textBox2, "Bu kutuya maaşını hesaplayacağınız personelin bir günlük ücretini yazınız");
            this.textBox2.Location = new System.Drawing.Point(154, 57);
            this.textBox2.Name = "textBox2";
            this.helpProvider1.SetShowHelp(this.textBox2, true);
            this.textBox2.Size = new System.Drawing.Size(120, 22);
            this.textBox2.TabIndex = 13;
            this.textBox2.Text = "-";
            // 
            // textBox1
            // 
            this.helpProvider1.SetHelpString(this.textBox1, "Bu kutuya maaşını hesaplayacağınız personelin adını ve soyadını yazınız");
            this.textBox1.Location = new System.Drawing.Point(154, 29);
            this.textBox1.Name = "textBox1";
            this.helpProvider1.SetShowHelp(this.textBox1, true);
            this.textBox1.Size = new System.Drawing.Size(120, 22);
            this.textBox1.TabIndex = 11;
            this.textBox1.Text = "-";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.textBox4);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(480, 194);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "You can press the F1 key to get help about the controls in this section.";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(298, 103);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(176, 77);
            this.label5.TabIndex = 20;
            this.label5.Text = "You can also get help by clicking on the question mark icon in the top right corn" +
    "er.";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(19, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 26);
            this.label4.TabIndex = 16;
            this.label4.Text = "Wage :";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(19, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 26);
            this.label3.TabIndex = 14;
            this.label3.Text = "Working Days :";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(19, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 27);
            this.label2.TabIndex = 12;
            this.label2.Text = "Daily Allowance :";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(19, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 27);
            this.label1.TabIndex = 10;
            this.label1.Text = "Full Name :";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 327);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.GroupBox groupBox2;
        internal System.Windows.Forms.Button button3;
        internal System.Windows.Forms.HelpProvider helpProvider1;
        internal System.Windows.Forms.Button button2;
        internal System.Windows.Forms.Button button1;
        internal System.Windows.Forms.TextBox textBox4;
        internal System.Windows.Forms.TextBox textBox3;
        internal System.Windows.Forms.TextBox textBox2;
        internal System.Windows.Forms.TextBox textBox1;
        internal System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        internal System.Windows.Forms.Label label4;
        internal System.Windows.Forms.Label label3;
        internal System.Windows.Forms.Label label2;
        internal System.Windows.Forms.Label label1;
    }
}


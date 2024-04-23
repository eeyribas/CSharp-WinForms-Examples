
namespace ListBox_AddInto
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
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.listBox3 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(194, 212);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(192, 27);
            this.button2.TabIndex = 35;
            this.button2.Text = "Delete";
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(21, 212);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(154, 27);
            this.button1.TabIndex = 34;
            this.button1.Text = "Add";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(261, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 26);
            this.label4.TabIndex = 33;
            this.label4.Text = "Age";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(136, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 26);
            this.label3.TabIndex = 32;
            this.label3.Text = "Job";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(12, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 26);
            this.label2.TabIndex = 31;
            this.label2.Text = "Full Name";
            // 
            // listBox3
            // 
            this.listBox3.ItemHeight = 16;
            this.listBox3.Location = new System.Drawing.Point(261, 92);
            this.listBox3.Name = "listBox3";
            this.listBox3.Size = new System.Drawing.Size(125, 84);
            this.listBox3.TabIndex = 30;
            // 
            // listBox2
            // 
            this.listBox2.ItemHeight = 16;
            this.listBox2.Location = new System.Drawing.Point(136, 92);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(116, 84);
            this.listBox2.TabIndex = 29;
            // 
            // listBox1
            // 
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(12, 92);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(115, 84);
            this.listBox1.TabIndex = 28;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(261, 37);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(120, 22);
            this.textBox3.TabIndex = 27;
            this.textBox3.Text = "textBox3";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(136, 37);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(120, 22);
            this.textBox2.TabIndex = 26;
            this.textBox2.Text = "textBox2";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 37);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(120, 22);
            this.textBox1.TabIndex = 25;
            this.textBox1.Text = "textBox1";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 27);
            this.label1.TabIndex = 24;
            this.label1.Text = "Student :";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 260);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listBox3);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button button2;
        internal System.Windows.Forms.Button button1;
        internal System.Windows.Forms.Label label4;
        internal System.Windows.Forms.Label label3;
        internal System.Windows.Forms.Label label2;
        internal System.Windows.Forms.ListBox listBox3;
        internal System.Windows.Forms.ListBox listBox2;
        internal System.Windows.Forms.ListBox listBox1;
        internal System.Windows.Forms.TextBox textBox3;
        internal System.Windows.Forms.TextBox textBox2;
        internal System.Windows.Forms.TextBox textBox1;
        internal System.Windows.Forms.Label label1;
    }
}


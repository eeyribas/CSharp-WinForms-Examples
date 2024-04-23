
namespace DrawingObjectsWithMouseAndSavingThem
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
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(241, 240);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(115, 58);
            this.button3.TabIndex = 14;
            this.button3.Text = "Delete Selected Point";
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(125, 240);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(106, 58);
            this.button2.TabIndex = 13;
            this.button2.Text = "Open";
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(10, 240);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 58);
            this.button1.TabIndex = 12;
            this.button1.Text = "Save";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(231, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 37);
            this.label1.TabIndex = 11;
            this.label1.Text = "Coordinates Clicked by the Mouse";
            // 
            // listBox1
            // 
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(231, 46);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(125, 164);
            this.listBox1.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 317);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Button button3;
        internal System.Windows.Forms.Button button2;
        internal System.Windows.Forms.Button button1;
        internal System.Windows.Forms.Label label1;
        internal System.Windows.Forms.ListBox listBox1;
    }
}


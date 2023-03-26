
namespace Queue_SequentialExample
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
            this.GiveOrderBtn = new System.Windows.Forms.Button();
            this.Lbl1 = new System.Windows.Forms.Label();
            this.Lbl2 = new System.Windows.Forms.Label();
            this.Lbl3 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.Lbl4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.CallBtn = new System.Windows.Forms.Button();
            this.CallLbl = new System.Windows.Forms.Label();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // GiveOrderBtn
            // 
            this.GiveOrderBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.GiveOrderBtn.Location = new System.Drawing.Point(13, 136);
            this.GiveOrderBtn.Margin = new System.Windows.Forms.Padding(4);
            this.GiveOrderBtn.Name = "GiveOrderBtn";
            this.GiveOrderBtn.Size = new System.Drawing.Size(211, 214);
            this.GiveOrderBtn.TabIndex = 28;
            this.GiveOrderBtn.Text = "Give Order";
            this.GiveOrderBtn.UseVisualStyleBackColor = true;
            this.GiveOrderBtn.Click += new System.EventHandler(this.GiveOrderBtn_Click);
            // 
            // Lbl1
            // 
            this.Lbl1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.Lbl1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Lbl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Lbl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Lbl1.Location = new System.Drawing.Point(4, 0);
            this.Lbl1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl1.Name = "Lbl1";
            this.Lbl1.Size = new System.Drawing.Size(163, 53);
            this.Lbl1.TabIndex = 8;
            this.Lbl1.Text = "number of waiting";
            this.Lbl1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Lbl2
            // 
            this.Lbl2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.Lbl2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Lbl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Lbl2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Lbl2.Location = new System.Drawing.Point(4, 53);
            this.Lbl2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl2.Name = "Lbl2";
            this.Lbl2.Size = new System.Drawing.Size(163, 53);
            this.Lbl2.TabIndex = 9;
            this.Lbl2.Text = "0";
            this.Lbl2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Lbl3
            // 
            this.Lbl3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.Lbl3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Lbl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Lbl3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Lbl3.Location = new System.Drawing.Point(4, 106);
            this.Lbl3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl3.Name = "Lbl3";
            this.Lbl3.Size = new System.Drawing.Size(163, 53);
            this.Lbl3.TabIndex = 10;
            this.Lbl3.Text = "next number";
            this.Lbl3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanel2.Controls.Add(this.Lbl1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.Lbl2, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.Lbl3, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.Lbl4, 0, 3);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 4;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(171, 214);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // Lbl4
            // 
            this.Lbl4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.Lbl4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Lbl4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Lbl4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Lbl4.Location = new System.Drawing.Point(4, 159);
            this.Lbl4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl4.Name = "Lbl4";
            this.Lbl4.Size = new System.Drawing.Size(163, 55);
            this.Lbl4.TabIndex = 11;
            this.Lbl4.Text = "0";
            this.Lbl4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tableLayoutPanel2);
            this.panel2.Location = new System.Drawing.Point(250, 136);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(171, 214);
            this.panel2.TabIndex = 27;
            // 
            // CallBtn
            // 
            this.CallBtn.Location = new System.Drawing.Point(40, 77);
            this.CallBtn.Margin = new System.Windows.Forms.Padding(4);
            this.CallBtn.Name = "CallBtn";
            this.CallBtn.Size = new System.Drawing.Size(100, 28);
            this.CallBtn.TabIndex = 19;
            this.CallBtn.Text = "Call";
            this.CallBtn.UseVisualStyleBackColor = true;
            this.CallBtn.Click += new System.EventHandler(this.CallBtn_Click);
            // 
            // CallLbl
            // 
            this.CallLbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.CallLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.CallLbl.Location = new System.Drawing.Point(22, 9);
            this.CallLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CallLbl.Name = "CallLbl";
            this.CallLbl.Size = new System.Drawing.Size(135, 64);
            this.CallLbl.TabIndex = 18;
            this.CallLbl.Text = "0";
            this.CallLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 367);
            this.Controls.Add(this.GiveOrderBtn);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.CallBtn);
            this.Controls.Add(this.CallLbl);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button GiveOrderBtn;
        private System.Windows.Forms.Label Lbl1;
        private System.Windows.Forms.Label Lbl2;
        private System.Windows.Forms.Label Lbl3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label Lbl4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button CallBtn;
        private System.Windows.Forms.Label CallLbl;
    }
}


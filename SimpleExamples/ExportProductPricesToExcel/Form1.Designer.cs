
namespace ExportProductPricesToExcel
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
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGrid();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(319, 234);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 26);
            this.label2.TabIndex = 12;
            this.label2.Text = "-";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(453, 68);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(90, 26);
            this.button2.TabIndex = 14;
            this.button2.Text = "Open";
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(453, 31);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 26);
            this.button1.TabIndex = 13;
            this.button1.Text = "Save";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(217, 234);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 26);
            this.label1.TabIndex = 11;
            this.label1.Text = "Sum :";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AlternatingBackColor = System.Drawing.Color.Lavender;
            this.dataGridView1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.LightGray;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.CaptionBackColor = System.Drawing.Color.LightSteelBlue;
            this.dataGridView1.CaptionFont = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.dataGridView1.CaptionForeColor = System.Drawing.Color.MidnightBlue;
            this.dataGridView1.DataMember = "";
            this.dataGridView1.FlatMode = true;
            this.dataGridView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.dataGridView1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.dataGridView1.GridLineColor = System.Drawing.Color.Gainsboro;
            this.dataGridView1.GridLineStyle = System.Windows.Forms.DataGridLineStyle.None;
            this.dataGridView1.HeaderBackColor = System.Drawing.Color.MidnightBlue;
            this.dataGridView1.HeaderFont = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.dataGridView1.HeaderForeColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridView1.LinkColor = System.Drawing.Color.Teal;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ParentRowsBackColor = System.Drawing.Color.Gainsboro;
            this.dataGridView1.ParentRowsForeColor = System.Drawing.Color.MidnightBlue;
            this.dataGridView1.SelectionBackColor = System.Drawing.Color.CadetBlue;
            this.dataGridView1.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridView1.Size = new System.Drawing.Size(432, 213);
            this.dataGridView1.TabIndex = 10;
            this.dataGridView1.CurrentCellChanged += new System.EventHandler(this.dataGridView1_CurrentCellChanged);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.FileName = "doc1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 279);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Label label2;
        internal System.Windows.Forms.Button button2;
        internal System.Windows.Forms.Button button1;
        internal System.Windows.Forms.OpenFileDialog openFileDialog1;
        internal System.Windows.Forms.Label label1;
        internal System.Windows.Forms.DataGrid dataGridView1;
        internal System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}


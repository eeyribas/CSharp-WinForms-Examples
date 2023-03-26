
namespace Graphics_PictureViewer
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
            this.ExitBtn = new System.Windows.Forms.Button();
            this.AddBtn = new System.Windows.Forms.Button();
            this.Pic = new System.Windows.Forms.PictureBox();
            this.ofdResimGetir = new System.Windows.Forms.OpenFileDialog();
            this.NewFormBtn = new System.Windows.Forms.Button();
            this.ZoomOutBtn = new System.Windows.Forms.Button();
            this.ZoomInBtn = new System.Windows.Forms.Button();
            this.lblY = new System.Windows.Forms.Label();
            this.lblX = new System.Windows.Forms.Label();
            this.DrawCornerBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Pic)).BeginInit();
            this.SuspendLayout();
            // 
            // ExitBtn
            // 
            this.ExitBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ExitBtn.Location = new System.Drawing.Point(533, 68);
            this.ExitBtn.Margin = new System.Windows.Forms.Padding(4);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(116, 28);
            this.ExitBtn.TabIndex = 11;
            this.ExitBtn.Text = "Exit";
            this.ExitBtn.UseVisualStyleBackColor = true;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // AddBtn
            // 
            this.AddBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AddBtn.Location = new System.Drawing.Point(533, 32);
            this.AddBtn.Margin = new System.Windows.Forms.Padding(4);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(116, 28);
            this.AddBtn.TabIndex = 10;
            this.AddBtn.Text = "Add Picture";
            this.AddBtn.UseVisualStyleBackColor = true;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // Pic
            // 
            this.Pic.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Pic.Location = new System.Drawing.Point(38, 31);
            this.Pic.Margin = new System.Windows.Forms.Padding(4);
            this.Pic.Name = "Pic";
            this.Pic.Size = new System.Drawing.Size(487, 342);
            this.Pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Pic.TabIndex = 9;
            this.Pic.TabStop = false;
            this.Pic.MouseLeave += new System.EventHandler(this.Pic_MouseLeave);
            this.Pic.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Pic_MouseMove);
            // 
            // ofdResimGetir
            // 
            this.ofdResimGetir.FileName = "openFileDialog1";
            // 
            // NewFormBtn
            // 
            this.NewFormBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.NewFormBtn.Location = new System.Drawing.Point(538, 308);
            this.NewFormBtn.Margin = new System.Windows.Forms.Padding(4);
            this.NewFormBtn.Name = "NewFormBtn";
            this.NewFormBtn.Size = new System.Drawing.Size(111, 28);
            this.NewFormBtn.TabIndex = 17;
            this.NewFormBtn.Text = "New Form";
            this.NewFormBtn.UseVisualStyleBackColor = true;
            this.NewFormBtn.Click += new System.EventHandler(this.NewFormBtn_Click);
            // 
            // ZoomOutBtn
            // 
            this.ZoomOutBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ZoomOutBtn.Location = new System.Drawing.Point(596, 344);
            this.ZoomOutBtn.Margin = new System.Windows.Forms.Padding(4);
            this.ZoomOutBtn.Name = "ZoomOutBtn";
            this.ZoomOutBtn.Size = new System.Drawing.Size(53, 28);
            this.ZoomOutBtn.TabIndex = 16;
            this.ZoomOutBtn.Text = "v";
            this.ZoomOutBtn.UseVisualStyleBackColor = true;
            this.ZoomOutBtn.Click += new System.EventHandler(this.ZoomOutBtn_Click);
            // 
            // ZoomInBtn
            // 
            this.ZoomInBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ZoomInBtn.Location = new System.Drawing.Point(538, 344);
            this.ZoomInBtn.Margin = new System.Windows.Forms.Padding(4);
            this.ZoomInBtn.Name = "ZoomInBtn";
            this.ZoomInBtn.Size = new System.Drawing.Size(48, 28);
            this.ZoomInBtn.TabIndex = 15;
            this.ZoomInBtn.Text = "^";
            this.ZoomInBtn.UseVisualStyleBackColor = true;
            this.ZoomInBtn.Click += new System.EventHandler(this.ZoomInBtn_Click);
            // 
            // lblY
            // 
            this.lblY.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblY.AutoSize = true;
            this.lblY.Location = new System.Drawing.Point(533, 189);
            this.lblY.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblY.Name = "lblY";
            this.lblY.Size = new System.Drawing.Size(0, 17);
            this.lblY.TabIndex = 14;
            // 
            // lblX
            // 
            this.lblX.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblX.AutoSize = true;
            this.lblX.Location = new System.Drawing.Point(534, 153);
            this.lblX.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblX.Name = "lblX";
            this.lblX.Size = new System.Drawing.Size(0, 17);
            this.lblX.TabIndex = 13;
            // 
            // DrawCornerBtn
            // 
            this.DrawCornerBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DrawCornerBtn.Location = new System.Drawing.Point(533, 105);
            this.DrawCornerBtn.Margin = new System.Windows.Forms.Padding(4);
            this.DrawCornerBtn.Name = "DrawCornerBtn";
            this.DrawCornerBtn.Size = new System.Drawing.Size(116, 28);
            this.DrawCornerBtn.TabIndex = 12;
            this.DrawCornerBtn.Text = "Draw Corner";
            this.DrawCornerBtn.UseVisualStyleBackColor = true;
            this.DrawCornerBtn.Click += new System.EventHandler(this.DrawCornerBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(715, 422);
            this.Controls.Add(this.ExitBtn);
            this.Controls.Add(this.AddBtn);
            this.Controls.Add(this.Pic);
            this.Controls.Add(this.NewFormBtn);
            this.Controls.Add(this.ZoomOutBtn);
            this.Controls.Add(this.ZoomInBtn);
            this.Controls.Add(this.lblY);
            this.Controls.Add(this.lblX);
            this.Controls.Add(this.DrawCornerBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.Pic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ExitBtn;
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.PictureBox Pic;
        private System.Windows.Forms.OpenFileDialog ofdResimGetir;
        private System.Windows.Forms.Button NewFormBtn;
        private System.Windows.Forms.Button ZoomOutBtn;
        private System.Windows.Forms.Button ZoomInBtn;
        private System.Windows.Forms.Label lblY;
        private System.Windows.Forms.Label lblX;
        private System.Windows.Forms.Button DrawCornerBtn;
    }
}


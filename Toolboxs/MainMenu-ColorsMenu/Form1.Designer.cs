
namespace MainMenu_ColorsMenu
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
            this.components = new System.ComponentModel.Container();
            this.menuItem4 = new System.Windows.Forms.MenuItem();
            this.menuItem = new System.Windows.Forms.MenuItem();
            this.menuItem1 = new System.Windows.Forms.MenuItem();
            this.menuItem2 = new System.Windows.Forms.MenuItem();
            this.menuItem3 = new System.Windows.Forms.MenuItem();
            this.menuItem5 = new System.Windows.Forms.MenuItem();
            this.menuItem6 = new System.Windows.Forms.MenuItem();
            this.mainMenu1 = new System.Windows.Forms.MainMenu(this.components);
            this.SuspendLayout();
            // 
            // menuItem4
            // 
            this.menuItem4.Index = 3;
            this.menuItem4.OwnerDraw = true;
            this.menuItem4.Text = "Green";
            // 
            // menuItem
            // 
            this.menuItem.Index = 0;
            this.menuItem.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem1,
            this.menuItem2,
            this.menuItem3,
            this.menuItem4,
            this.menuItem5,
            this.menuItem6});
            this.menuItem.Text = "Colors";
            // 
            // menuItem1
            // 
            this.menuItem1.Index = 0;
            this.menuItem1.OwnerDraw = true;
            this.menuItem1.Text = "Red";
            this.menuItem1.Click += new System.EventHandler(this.menuItem1_Click);
            this.menuItem1.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.menuItem1_DrawItem);
            this.menuItem1.MeasureItem += new System.Windows.Forms.MeasureItemEventHandler(this.menuItem1_MeasureItem);
            // 
            // menuItem2
            // 
            this.menuItem2.Index = 1;
            this.menuItem2.OwnerDraw = true;
            this.menuItem2.Text = "Blue";
            // 
            // menuItem3
            // 
            this.menuItem3.Index = 2;
            this.menuItem3.OwnerDraw = true;
            this.menuItem3.Text = "Yellow";
            // 
            // menuItem5
            // 
            this.menuItem5.Index = 4;
            this.menuItem5.OwnerDraw = true;
            this.menuItem5.Text = "Brown";
            // 
            // menuItem6
            // 
            this.menuItem6.Index = 5;
            this.menuItem6.OwnerDraw = true;
            this.menuItem6.Text = "Black";
            // 
            // mainMenu1
            // 
            this.mainMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem});
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 296);
            this.Menu = this.mainMenu1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.MenuItem menuItem4;
        internal System.Windows.Forms.MenuItem menuItem;
        internal System.Windows.Forms.MenuItem menuItem1;
        internal System.Windows.Forms.MenuItem menuItem2;
        internal System.Windows.Forms.MenuItem menuItem3;
        internal System.Windows.Forms.MenuItem menuItem5;
        internal System.Windows.Forms.MenuItem menuItem6;
        internal System.Windows.Forms.MainMenu mainMenu1;
    }
}


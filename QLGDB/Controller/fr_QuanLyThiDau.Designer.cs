namespace QLGDB.Controller
{
    partial class fr_QuanLyThiDau
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.lịchThiĐấuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tỷSốToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnMain = new System.Windows.Forms.Panel();
            this.chungKếToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.White;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lịchThiĐấuToolStripMenuItem,
            this.tỷSốToolStripMenuItem,
            this.chungKếToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1050, 31);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // lịchThiĐấuToolStripMenuItem
            // 
            this.lịchThiĐấuToolStripMenuItem.Name = "lịchThiĐấuToolStripMenuItem";
            this.lịchThiĐấuToolStripMenuItem.Size = new System.Drawing.Size(123, 27);
            this.lịchThiĐấuToolStripMenuItem.Text = "Lịch Thi Đấu";
            this.lịchThiĐấuToolStripMenuItem.Click += new System.EventHandler(this.lịchThiĐấuToolStripMenuItem_Click);
            // 
            // tỷSốToolStripMenuItem
            // 
            this.tỷSốToolStripMenuItem.Name = "tỷSốToolStripMenuItem";
            this.tỷSốToolStripMenuItem.Size = new System.Drawing.Size(68, 27);
            this.tỷSốToolStripMenuItem.Text = "Tỷ Số";
            this.tỷSốToolStripMenuItem.Click += new System.EventHandler(this.tỷSốToolStripMenuItem_Click);
            // 
            // pnMain
            // 
            this.pnMain.BackColor = System.Drawing.Color.White;
            this.pnMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnMain.Location = new System.Drawing.Point(0, 31);
            this.pnMain.Name = "pnMain";
            this.pnMain.Size = new System.Drawing.Size(1050, 464);
            this.pnMain.TabIndex = 1;
            // 
            // chungKếToolStripMenuItem
            // 
            this.chungKếToolStripMenuItem.Name = "chungKếToolStripMenuItem";
            this.chungKếToolStripMenuItem.Size = new System.Drawing.Size(108, 27);
            this.chungKếToolStripMenuItem.Text = "Chung Kết";
            this.chungKếToolStripMenuItem.Click += new System.EventHandler(this.chungKếToolStripMenuItem_Click);
            // 
            // fr_QuanLyThiDau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1050, 495);
            this.Controls.Add(this.pnMain);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "fr_QuanLyThiDau";
            this.Text = "fr_QuanLyThiDau";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem lịchThiĐấuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tỷSốToolStripMenuItem;
        private System.Windows.Forms.Panel pnMain;
        private System.Windows.Forms.ToolStripMenuItem chungKếToolStripMenuItem;
    }
}
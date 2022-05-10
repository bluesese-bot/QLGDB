namespace QLGDB.Controller
{
    partial class fr_QuanLyGiai
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
            this.đăngKýĐộiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thêmCầuThủToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mùaGiảiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnMain = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.White;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.đăngKýĐộiToolStripMenuItem,
            this.thêmCầuThủToolStripMenuItem,
            this.mùaGiảiToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1171, 31);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // đăngKýĐộiToolStripMenuItem
            // 
            this.đăngKýĐộiToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.đăngKýĐộiToolStripMenuItem.Name = "đăngKýĐộiToolStripMenuItem";
            this.đăngKýĐộiToolStripMenuItem.Size = new System.Drawing.Size(124, 27);
            this.đăngKýĐộiToolStripMenuItem.Text = "Đăng Ký Đội";
            this.đăngKýĐộiToolStripMenuItem.Click += new System.EventHandler(this.đăngKýĐộiToolStripMenuItem_Click);
            // 
            // thêmCầuThủToolStripMenuItem
            // 
            this.thêmCầuThủToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.thêmCầuThủToolStripMenuItem.Name = "thêmCầuThủToolStripMenuItem";
            this.thêmCầuThủToolStripMenuItem.Size = new System.Drawing.Size(139, 27);
            this.thêmCầuThủToolStripMenuItem.Text = "Thêm Cầu Thủ";
            this.thêmCầuThủToolStripMenuItem.Click += new System.EventHandler(this.thêmCầuThủToolStripMenuItem_Click);
            // 
            // mùaGiảiToolStripMenuItem
            // 
            this.mùaGiảiToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.mùaGiảiToolStripMenuItem.Name = "mùaGiảiToolStripMenuItem";
            this.mùaGiảiToolStripMenuItem.Size = new System.Drawing.Size(95, 27);
            this.mùaGiảiToolStripMenuItem.Text = "Mùa Giải";
            this.mùaGiảiToolStripMenuItem.Click += new System.EventHandler(this.mùaGiảiToolStripMenuItem_Click);
            // 
            // pnMain
            // 
            this.pnMain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnMain.Location = new System.Drawing.Point(0, 31);
            this.pnMain.Name = "pnMain";
            this.pnMain.Size = new System.Drawing.Size(1171, 700);
            this.pnMain.TabIndex = 1;
            // 
            // fr_QuanLyGiai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1171, 731);
            this.Controls.Add(this.pnMain);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "fr_QuanLyGiai";
            this.Text = "fr_QuanLyGiai";
            this.Load += new System.EventHandler(this.fr_QuanLyGiai_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem đăngKýĐộiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thêmCầuThủToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mùaGiảiToolStripMenuItem;
        private System.Windows.Forms.Panel pnMain;
    }
}
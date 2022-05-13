
namespace QuanLyCongTacVien
{
    partial class frmMain
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
            this.nguoidungToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.congtacvienToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sanphamToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hoadonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thongkeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nguoidungToolStripMenuItem,
            this.congtacvienToolStripMenuItem,
            this.sanphamToolStripMenuItem,
            this.hoadonToolStripMenuItem,
            this.thongkeToolStripMenuItem});
            this.menuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1068, 40);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // nguoidungToolStripMenuItem
            // 
            this.nguoidungToolStripMenuItem.Name = "nguoidungToolStripMenuItem";
            this.nguoidungToolStripMenuItem.Size = new System.Drawing.Size(244, 36);
            this.nguoidungToolStripMenuItem.Text = "Quản lý người dùng";
            this.nguoidungToolStripMenuItem.Click += new System.EventHandler(this.quanToolStripMenuItem_Click);
            // 
            // congtacvienToolStripMenuItem
            // 
            this.congtacvienToolStripMenuItem.Name = "congtacvienToolStripMenuItem";
            this.congtacvienToolStripMenuItem.Size = new System.Drawing.Size(262, 36);
            this.congtacvienToolStripMenuItem.Text = "Quản lý cộng tác viên";
            this.congtacvienToolStripMenuItem.Click += new System.EventHandler(this.quảnLýCộngTácViênToolStripMenuItem_Click);
            // 
            // sanphamToolStripMenuItem
            // 
            this.sanphamToolStripMenuItem.Name = "sanphamToolStripMenuItem";
            this.sanphamToolStripMenuItem.Size = new System.Drawing.Size(223, 36);
            this.sanphamToolStripMenuItem.Text = "Quản lý sản phẩm";
            this.sanphamToolStripMenuItem.Click += new System.EventHandler(this.quảnLýSảnPhẩmToolStripMenuItem_Click);
            // 
            // hoadonToolStripMenuItem
            // 
            this.hoadonToolStripMenuItem.Name = "hoadonToolStripMenuItem";
            this.hoadonToolStripMenuItem.Size = new System.Drawing.Size(121, 36);
            this.hoadonToolStripMenuItem.Text = "Hóa đơn";
            this.hoadonToolStripMenuItem.Click += new System.EventHandler(this.quảnLýHóaĐơnToolStripMenuItem_Click);
            // 
            // thongkeToolStripMenuItem
            // 
            this.thongkeToolStripMenuItem.Name = "thongkeToolStripMenuItem";
            this.thongkeToolStripMenuItem.Size = new System.Drawing.Size(130, 36);
            this.thongkeToolStripMenuItem.Text = "Thống kê";
            this.thongkeToolStripMenuItem.Click += new System.EventHandler(this.thoToolStripMenuItem_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::QuanLyCongTacVien.Properties.Resources.homepage_background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1068, 566);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMain";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem nguoidungToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem congtacvienToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sanphamToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hoadonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thongkeToolStripMenuItem;
    }
}


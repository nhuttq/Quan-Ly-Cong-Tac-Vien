
namespace QuanLyCongTacVien
{
    partial class frmNguoiDung
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTenHT = new System.Windows.Forms.TextBox();
            this.txtTenDN = new System.Windows.Forms.TextBox();
            this.txtMatKhau = new System.Windows.Forms.TextBox();
            this.btnThemTK = new System.Windows.Forms.Button();
            this.btnSuaTK = new System.Windows.Forms.Button();
            this.btnXoaTK = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btnNHAPLAI = new System.Windows.Forms.Button();
            this.lbloaitk = new System.Windows.Forms.Label();
            this.rbadmin = new System.Windows.Forms.RadioButton();
            this.rbctv = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(651, 555);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(648, 343);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(540, 184);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tên hiển thị";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(540, 274);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(219, 32);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên đăng nhập";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(541, 368);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 32);
            this.label3.TabIndex = 3;
            this.label3.Text = "Mật khẩu";
            // 
            // txtTenHT
            // 
            this.txtTenHT.BackColor = System.Drawing.Color.White;
            this.txtTenHT.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenHT.Location = new System.Drawing.Point(826, 189);
            this.txtTenHT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTenHT.Name = "txtTenHT";
            this.txtTenHT.Size = new System.Drawing.Size(360, 34);
            this.txtTenHT.TabIndex = 4;
            // 
            // txtTenDN
            // 
            this.txtTenDN.BackColor = System.Drawing.Color.White;
            this.txtTenDN.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenDN.Location = new System.Drawing.Point(826, 273);
            this.txtTenDN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTenDN.Name = "txtTenDN";
            this.txtTenDN.Size = new System.Drawing.Size(360, 34);
            this.txtTenDN.TabIndex = 5;
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.BackColor = System.Drawing.Color.White;
            this.txtMatKhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMatKhau.Location = new System.Drawing.Point(826, 368);
            this.txtMatKhau.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.Size = new System.Drawing.Size(360, 34);
            this.txtMatKhau.TabIndex = 6;
            // 
            // btnThemTK
            // 
            this.btnThemTK.BackColor = System.Drawing.Color.White;
            this.btnThemTK.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemTK.ForeColor = System.Drawing.Color.Black;
            this.btnThemTK.Image = global::QuanLyCongTacVien.Properties.Resources.thêm;
            this.btnThemTK.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThemTK.Location = new System.Drawing.Point(1283, 175);
            this.btnThemTK.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThemTK.Name = "btnThemTK";
            this.btnThemTK.Size = new System.Drawing.Size(157, 68);
            this.btnThemTK.TabIndex = 7;
            this.btnThemTK.Text = "Thêm ";
            this.btnThemTK.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThemTK.UseVisualStyleBackColor = false;
            this.btnThemTK.Click += new System.EventHandler(this.btnThemTK_Click);
            // 
            // btnSuaTK
            // 
            this.btnSuaTK.BackColor = System.Drawing.Color.White;
            this.btnSuaTK.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuaTK.ForeColor = System.Drawing.Color.Black;
            this.btnSuaTK.Image = global::QuanLyCongTacVien.Properties.Resources.sửa;
            this.btnSuaTK.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSuaTK.Location = new System.Drawing.Point(1283, 273);
            this.btnSuaTK.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSuaTK.Name = "btnSuaTK";
            this.btnSuaTK.Size = new System.Drawing.Size(157, 68);
            this.btnSuaTK.TabIndex = 8;
            this.btnSuaTK.Text = "Sửa";
            this.btnSuaTK.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSuaTK.UseVisualStyleBackColor = false;
            this.btnSuaTK.Click += new System.EventHandler(this.btnSuaTK_Click);
            // 
            // btnXoaTK
            // 
            this.btnXoaTK.BackColor = System.Drawing.Color.White;
            this.btnXoaTK.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaTK.ForeColor = System.Drawing.Color.Black;
            this.btnXoaTK.Image = global::QuanLyCongTacVien.Properties.Resources.xoá;
            this.btnXoaTK.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnXoaTK.Location = new System.Drawing.Point(1283, 368);
            this.btnXoaTK.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnXoaTK.Name = "btnXoaTK";
            this.btnXoaTK.Size = new System.Drawing.Size(157, 70);
            this.btnXoaTK.TabIndex = 9;
            this.btnXoaTK.Text = "Xóa";
            this.btnXoaTK.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXoaTK.UseVisualStyleBackColor = false;
            this.btnXoaTK.Click += new System.EventHandler(this.btnXoaTK_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cambria", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Maroon;
            this.label4.Location = new System.Drawing.Point(689, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(651, 70);
            this.label4.TabIndex = 10;
            this.label4.Text = "QUẢN LÝ NGƯỜI DÙNG";
            // 
            // btnNHAPLAI
            // 
            this.btnNHAPLAI.BackColor = System.Drawing.Color.Firebrick;
            this.btnNHAPLAI.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNHAPLAI.ForeColor = System.Drawing.Color.White;
            this.btnNHAPLAI.Location = new System.Drawing.Point(1283, 479);
            this.btnNHAPLAI.Name = "btnNHAPLAI";
            this.btnNHAPLAI.Size = new System.Drawing.Size(154, 41);
            this.btnNHAPLAI.TabIndex = 11;
            this.btnNHAPLAI.Text = "Nhập lại";
            this.btnNHAPLAI.UseVisualStyleBackColor = false;
            this.btnNHAPLAI.Click += new System.EventHandler(this.btnNHAPLAI_Click);
            // 
            // lbloaitk
            // 
            this.lbloaitk.AutoSize = true;
            this.lbloaitk.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbloaitk.ForeColor = System.Drawing.Color.Black;
            this.lbloaitk.Location = new System.Drawing.Point(542, 479);
            this.lbloaitk.Name = "lbloaitk";
            this.lbloaitk.Size = new System.Drawing.Size(185, 29);
            this.lbloaitk.TabIndex = 12;
            this.lbloaitk.Text = "Loại tài khoản";
            // 
            // rbadmin
            // 
            this.rbadmin.AutoSize = true;
            this.rbadmin.BackColor = System.Drawing.Color.Transparent;
            this.rbadmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbadmin.ForeColor = System.Drawing.Color.Black;
            this.rbadmin.Location = new System.Drawing.Point(856, 478);
            this.rbadmin.Name = "rbadmin";
            this.rbadmin.Size = new System.Drawing.Size(110, 33);
            this.rbadmin.TabIndex = 13;
            this.rbadmin.TabStop = true;
            this.rbadmin.Text = "ADMIN";
            this.rbadmin.UseVisualStyleBackColor = false;
            // 
            // rbctv
            // 
            this.rbctv.AutoSize = true;
            this.rbctv.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbctv.ForeColor = System.Drawing.Color.Black;
            this.rbctv.Location = new System.Drawing.Point(1062, 475);
            this.rbctv.Name = "rbctv";
            this.rbctv.Size = new System.Drawing.Size(82, 33);
            this.rbctv.TabIndex = 14;
            this.rbctv.TabStop = true;
            this.rbctv.Text = "CTV";
            this.rbctv.UseVisualStyleBackColor = true;
            // 
            // frmNguoiDung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(1535, 892);
            this.Controls.Add(this.rbctv);
            this.Controls.Add(this.rbadmin);
            this.Controls.Add(this.lbloaitk);
            this.Controls.Add(this.btnNHAPLAI);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnXoaTK);
            this.Controls.Add(this.btnSuaTK);
            this.Controls.Add(this.btnThemTK);
            this.Controls.Add(this.txtMatKhau);
            this.Controls.Add(this.txtTenDN);
            this.Controls.Add(this.txtTenHT);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmNguoiDung";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý người dùng";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmNguoiDung_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTenHT;
        private System.Windows.Forms.TextBox txtTenDN;
        private System.Windows.Forms.TextBox txtMatKhau;
        private System.Windows.Forms.Button btnThemTK;
        private System.Windows.Forms.Button btnSuaTK;
        private System.Windows.Forms.Button btnXoaTK;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnNHAPLAI;
        private System.Windows.Forms.Label lbloaitk;
        private System.Windows.Forms.RadioButton rbadmin;
        private System.Windows.Forms.RadioButton rbctv;
    }
}
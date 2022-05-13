
namespace QuanLyCongTacVien
{
    partial class frmCongTacVien
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
            this.lbtenctv = new System.Windows.Forms.Label();
            this.lbmactv = new System.Windows.Forms.Label();
            this.lbdiachi = new System.Windows.Forms.Label();
            this.lbtrangthai = new System.Windows.Forms.Label();
            this.txtTenCTV = new System.Windows.Forms.TextBox();
            this.txtMaCTV = new System.Windows.Forms.TextBox();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lbtimkiem = new System.Windows.Forms.Label();
            this.txtTimkiem = new System.Windows.Forms.TextBox();
            this.lbquanlictv = new System.Windows.Forms.Label();
            this.rbconlamctv = new System.Windows.Forms.RadioButton();
            this.rbkhongconlamctv = new System.Windows.Forms.RadioButton();
            this.btnhaplai = new System.Windows.Forms.Button();
            this.btnTimkiem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbtenctv
            // 
            this.lbtenctv.AutoSize = true;
            this.lbtenctv.BackColor = System.Drawing.Color.Transparent;
            this.lbtenctv.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbtenctv.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbtenctv.Location = new System.Drawing.Point(486, 152);
            this.lbtenctv.Name = "lbtenctv";
            this.lbtenctv.Size = new System.Drawing.Size(267, 36);
            this.lbtenctv.TabIndex = 0;
            this.lbtenctv.Text = "Tên cộng tác viên";
            this.lbtenctv.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbmactv
            // 
            this.lbmactv.AutoSize = true;
            this.lbmactv.BackColor = System.Drawing.Color.Transparent;
            this.lbmactv.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbmactv.Location = new System.Drawing.Point(486, 222);
            this.lbmactv.Name = "lbmactv";
            this.lbmactv.Size = new System.Drawing.Size(256, 36);
            this.lbmactv.TabIndex = 1;
            this.lbmactv.Text = "Mã cộng tác viên";
            // 
            // lbdiachi
            // 
            this.lbdiachi.AutoSize = true;
            this.lbdiachi.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbdiachi.Location = new System.Drawing.Point(486, 286);
            this.lbdiachi.Name = "lbdiachi";
            this.lbdiachi.Size = new System.Drawing.Size(113, 36);
            this.lbdiachi.TabIndex = 2;
            this.lbdiachi.Text = "Địa chỉ";
            // 
            // lbtrangthai
            // 
            this.lbtrangthai.AutoSize = true;
            this.lbtrangthai.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbtrangthai.Location = new System.Drawing.Point(486, 350);
            this.lbtrangthai.Name = "lbtrangthai";
            this.lbtrangthai.Size = new System.Drawing.Size(159, 36);
            this.lbtrangthai.TabIndex = 3;
            this.lbtrangthai.Text = "Trạng thái";
            // 
            // txtTenCTV
            // 
            this.txtTenCTV.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenCTV.Location = new System.Drawing.Point(916, 157);
            this.txtTenCTV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTenCTV.Name = "txtTenCTV";
            this.txtTenCTV.Size = new System.Drawing.Size(356, 34);
            this.txtTenCTV.TabIndex = 4;
            // 
            // txtMaCTV
            // 
            this.txtMaCTV.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaCTV.Location = new System.Drawing.Point(916, 227);
            this.txtMaCTV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMaCTV.Name = "txtMaCTV";
            this.txtMaCTV.Size = new System.Drawing.Size(259, 34);
            this.txtMaCTV.TabIndex = 5;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiaChi.Location = new System.Drawing.Point(916, 290);
            this.txtDiaChi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(183, 34);
            this.txtDiaChi.TabIndex = 6;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(615, 583);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(729, 359);
            this.dataGridView1.TabIndex = 11;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // lbtimkiem
            // 
            this.lbtimkiem.AutoSize = true;
            this.lbtimkiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbtimkiem.Location = new System.Drawing.Point(486, 510);
            this.lbtimkiem.Name = "lbtimkiem";
            this.lbtimkiem.Size = new System.Drawing.Size(338, 36);
            this.lbtimkiem.TabIndex = 12;
            this.lbtimkiem.Text = "Tìm kiếm cộng tác viên";
            this.lbtimkiem.Click += new System.EventHandler(this.lbtimkiem_Click);
            // 
            // txtTimkiem
            // 
            this.txtTimkiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimkiem.Location = new System.Drawing.Point(855, 513);
            this.txtTimkiem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTimkiem.Name = "txtTimkiem";
            this.txtTimkiem.Size = new System.Drawing.Size(356, 34);
            this.txtTimkiem.TabIndex = 13;
            // 
            // lbquanlictv
            // 
            this.lbquanlictv.AutoSize = true;
            this.lbquanlictv.BackColor = System.Drawing.Color.Transparent;
            this.lbquanlictv.Font = new System.Drawing.Font("Cambria", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbquanlictv.ForeColor = System.Drawing.Color.Maroon;
            this.lbquanlictv.Location = new System.Drawing.Point(636, 37);
            this.lbquanlictv.Name = "lbquanlictv";
            this.lbquanlictv.Size = new System.Drawing.Size(698, 70);
            this.lbquanlictv.TabIndex = 16;
            this.lbquanlictv.Text = "QUẢN LÝ CỘNG TÁC VIÊN";
            this.lbquanlictv.Click += new System.EventHandler(this.label6_Click);
            // 
            // rbconlamctv
            // 
            this.rbconlamctv.AutoSize = true;
            this.rbconlamctv.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbconlamctv.Location = new System.Drawing.Point(916, 354);
            this.rbconlamctv.Name = "rbconlamctv";
            this.rbconlamctv.Size = new System.Drawing.Size(177, 33);
            this.rbconlamctv.TabIndex = 17;
            this.rbconlamctv.TabStop = true;
            this.rbconlamctv.Text = "Còn làm CTV";
            this.rbconlamctv.UseVisualStyleBackColor = true;
            // 
            // rbkhongconlamctv
            // 
            this.rbkhongconlamctv.AutoSize = true;
            this.rbkhongconlamctv.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbkhongconlamctv.Location = new System.Drawing.Point(1180, 355);
            this.rbkhongconlamctv.Name = "rbkhongconlamctv";
            this.rbkhongconlamctv.Size = new System.Drawing.Size(248, 33);
            this.rbkhongconlamctv.TabIndex = 18;
            this.rbkhongconlamctv.TabStop = true;
            this.rbkhongconlamctv.Text = "Không còn làm CTV";
            this.rbkhongconlamctv.UseVisualStyleBackColor = true;
            // 
            // btnhaplai
            // 
            this.btnhaplai.BackColor = System.Drawing.Color.Firebrick;
            this.btnhaplai.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnhaplai.ForeColor = System.Drawing.Color.White;
            this.btnhaplai.Location = new System.Drawing.Point(1347, 157);
            this.btnhaplai.Name = "btnhaplai";
            this.btnhaplai.Size = new System.Drawing.Size(122, 40);
            this.btnhaplai.TabIndex = 19;
            this.btnhaplai.Text = "Nhập lại";
            this.btnhaplai.UseVisualStyleBackColor = false;
            this.btnhaplai.Click += new System.EventHandler(this.btnhaplai_Click);
            // 
            // btnTimkiem
            // 
            this.btnTimkiem.BackColor = System.Drawing.Color.Firebrick;
            this.btnTimkiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimkiem.ForeColor = System.Drawing.Color.White;
            this.btnTimkiem.Location = new System.Drawing.Point(1270, 510);
            this.btnTimkiem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTimkiem.Name = "btnTimkiem";
            this.btnTimkiem.Size = new System.Drawing.Size(132, 42);
            this.btnTimkiem.TabIndex = 15;
            this.btnTimkiem.Text = "Tìm kiếm";
            this.btnTimkiem.UseVisualStyleBackColor = false;
            this.btnTimkiem.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.White;
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Image = global::QuanLyCongTacVien.Properties.Resources.xoá;
            this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoa.Location = new System.Drawing.Point(1118, 406);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(163, 77);
            this.btnXoa.TabIndex = 10;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.White;
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Image = global::QuanLyCongTacVien.Properties.Resources.sửa;
            this.btnSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSua.Location = new System.Drawing.Point(873, 406);
            this.btnSua.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(163, 77);
            this.btnSua.TabIndex = 9;
            this.btnSua.Text = "Sửa";
            this.btnSua.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.White;
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Image = global::QuanLyCongTacVien.Properties.Resources.thêm;
            this.btnThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThem.Location = new System.Drawing.Point(648, 406);
            this.btnThem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(163, 77);
            this.btnThem.TabIndex = 8;
            this.btnThem.Text = "Thêm";
            this.btnThem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // frmCongTacVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(1630, 953);
            this.Controls.Add(this.btnhaplai);
            this.Controls.Add(this.rbkhongconlamctv);
            this.Controls.Add(this.rbconlamctv);
            this.Controls.Add(this.lbquanlictv);
            this.Controls.Add(this.btnTimkiem);
            this.Controls.Add(this.txtTimkiem);
            this.Controls.Add(this.lbtimkiem);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.txtDiaChi);
            this.Controls.Add(this.txtMaCTV);
            this.Controls.Add(this.txtTenCTV);
            this.Controls.Add(this.lbtrangthai);
            this.Controls.Add(this.lbdiachi);
            this.Controls.Add(this.lbmactv);
            this.Controls.Add(this.lbtenctv);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmCongTacVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý cộng tác viên";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmCongTacVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbtenctv;
        private System.Windows.Forms.Label lbmactv;
        private System.Windows.Forms.Label lbdiachi;
        private System.Windows.Forms.Label lbtrangthai;
        private System.Windows.Forms.TextBox txtTenCTV;
        private System.Windows.Forms.TextBox txtMaCTV;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lbtimkiem;
        private System.Windows.Forms.TextBox txtTimkiem;
        private System.Windows.Forms.Button btnTimkiem;
        private System.Windows.Forms.Label lbquanlictv;
        private System.Windows.Forms.RadioButton rbconlamctv;
        private System.Windows.Forms.RadioButton rbkhongconlamctv;
        private System.Windows.Forms.Button btnhaplai;
    }
}
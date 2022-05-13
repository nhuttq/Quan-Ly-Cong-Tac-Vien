using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCongTacVien
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
           
        }

        private void tìmKiếmToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void quảnLýHóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHoaDon HoaDon = new frmHoaDon();
            this.Hide();
            HoaDon.ShowDialog();
            this.Show();
        }

        private void quanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNguoiDung nguoiDung = new frmNguoiDung();
            this.Hide();
            nguoiDung.ShowDialog();
            this.Show();


        }

        private void quảnLýCộngTácViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCongTacVien CongTacVien = new frmCongTacVien();
            this.Hide();
            CongTacVien.ShowDialog();
            this.Show();
        }

        private void quảnLýSảnPhẩmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSanPham sanPham = new frmSanPham();
            this.Hide();
            sanPham.ShowDialog();
            this.Show();

        }

        private void thoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmThongKe thongKe = new frmThongKe();
            this.Hide();
            thongKe.ShowDialog();
            this.Show();


        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }
    }
}

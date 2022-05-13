using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QuanLyCongTacVien
{
    public partial class frmDangNhap : Form
    {
        public frmDangNhap()
        {
            InitializeComponent();
         
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=ADMIN\\SQLEXPRESS;Initial Catalog=Quanly_ctv;Integrated Security=True"); 
            try
            {
                con.Open();
                string TenDangNhap = txtdangnhap.Text;
                string MatKhau = txtmatkhau.Text;
                string err = string.Empty;
                if (TenDangNhap == string.Empty)
                    err = "Vui lòng điền tên đăng nhập";
                if (MatKhau == string.Empty)
                    err += "\n Bạn chưa nhập mật khẩu";
                if (err != string.Empty)
                {
                    MessageBox.Show("Error: " + err);
                    return;
                }
                string Query = "select * from TAI_KHOAN_CTV where TenDangNhap=N'" + TenDangNhap + "' and MatKhau= N'" + MatKhau + "'";
                SqlCommand cmd = new SqlCommand(Query, con);
                SqlDataReader ds = cmd.ExecuteReader();
                if (ds.Read() == true)
                {
                    MessageBox.Show("Đăng nhập thành công", "Thông báo", MessageBoxButtons.OK);
                    frmMain f = new frmMain();
                    this.Hide();
                    f.ShowDialog();
                    f.Show();

                }
                else
                {
                    MessageBox.Show("Đăng nhập thất bại", "Thông báo", MessageBoxButtons.OK);
                    txtdangnhap.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmDangNhap_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn muốn thoát chương trình", "Thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void frmDangNhap_Load(object sender, EventArgs e)
        {

        }
    }
}


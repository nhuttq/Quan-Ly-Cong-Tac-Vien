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
    public partial class frmNguoiDung : Form
    {
        string sCon = "Data Source=ADMIN\\SQLEXPRESS;Initial Catalog=Quanly_ctv;Integrated Security=True";
        public frmNguoiDung()
        {
            InitializeComponent();
        }

        private void frmNguoiDung_Load(object sender, EventArgs e)
        {
            Loaddata();

        }

        private void Loaddata()
        {
            // buoc 1
            SqlConnection con = new SqlConnection(sCon);
            try
            {
                con.Open();
            }
            catch (Exception)
            {
                MessageBox.Show("Xảy ra lỗi trong quá trình kết nối DB");
            }
            // buoc 2 - lay du lieu ve
            string sQuery = "select * from TAI_KHOAN_CTV";
            SqlDataAdapter adapter = new SqlDataAdapter(sQuery, con);
            DataSet ds = new DataSet();
            adapter.Fill(ds, "TAI_KHOAN_CTV");
            dataGridView1.DataSource = ds.Tables["TAI_KHOAN_CTV"];

            string sQuery1 = "select TenDangNhap, TenHienThi, MatKhau from TAI_KHOAN_CTV";
            SqlDataAdapter adapter1 = new SqlDataAdapter(sQuery1, con);
            DataSet ds1 = new DataSet();
            adapter1.Fill(ds1, "TAI_KHOAN_CTV");

            con.Close(); // buoc 3
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtTenHT.Text = dataGridView1.Rows[e.RowIndex].Cells["TenHienThi"].Value.ToString();
            txtTenDN.Text = dataGridView1.Rows[e.RowIndex].Cells["TenDangNhap"].Value.ToString();
            txtMatKhau.Text = dataGridView1.Rows[e.RowIndex].Cells["MatKhau"].Value.ToString();
            int iType = Convert.ToInt16(dataGridView1.Rows[e.RowIndex].Cells["Type"].Value);

            if (iType == 0)
            {
                rbctv.Checked = true;
            }
            else
            {
                rbadmin.Checked = true;
            }
        }

        private void btnThemTK_Click(object sender, EventArgs e)
        {
            // buoc 1
            SqlConnection con = new SqlConnection(sCon);
            try
            {
                con.Open();
            }
            catch (Exception)
            {
                MessageBox.Show("Xảy ra lỗi trong quá trình kết nối DB");
            }
            // buoc 2
            
            string sTenHienThi = txtTenHT.Text;
            string sTenDangNhap = txtTenDN.Text;
            string sMatKhau = txtMatKhau.Text;
            int iType = 0;
            if (rbadmin.Checked == true)
            {
                iType = 1;
            }

            //trong bang co 4 cot: TenDangNhap, TenHienThi, MatKhau, Type
            //cau lenh nsessert chi co 3 cot: TenDangNhap, TenHienThi, MatKhau --> Thieu Type
            string sQuery = "insert into TAI_KHOAN_CTV values(@TenDangNhap,@TenHienThi,@MatKhau,@Type)";
            SqlCommand cmd = new SqlCommand(sQuery, con);

            cmd.Parameters.AddWithValue("@TenDangNhap", sTenDangNhap);
            cmd.Parameters.AddWithValue("@TenHienThi", sTenHienThi);
            cmd.Parameters.AddWithValue("@MatKhau", sMatKhau);
            cmd.Parameters.AddWithValue("@Type", iType);

            try
            {
                cmd.ExecuteNonQuery();
                Loaddata();
                MessageBox.Show("Thêm tài khoản thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            con.Close(); //Buoc 3
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnSuaTK_Click(object sender, EventArgs e)
        {
            // buoc 1
            SqlConnection con = new SqlConnection(sCon);
            try
            {
                con.Open();
            }
            catch (Exception)
            {
                MessageBox.Show("Xảy ra lỗi trong quá trình kết nối DB");

            }
            // buoc 2

            string sTenHienThi = txtTenHT.Text;
            string sTenDangNhap = txtTenDN.Text;
            string sMatKhau = txtMatKhau.Text;

            string sQuery = "update TAI_KHOAN_CTV set TenHienThi=@TenHienThi,MatKhau=@MatKhau where TenDangNhap=@TenDangNhap";
            SqlCommand cmd = new SqlCommand(sQuery, con);

            cmd.Parameters.AddWithValue("@TenDangNhap", sTenDangNhap);
            cmd.Parameters.AddWithValue("@TenHienThi", sTenHienThi);
            cmd.Parameters.AddWithValue("@MatKhau", sMatKhau);

            try
            {
                cmd.ExecuteNonQuery();
                Loaddata();
                MessageBox.Show("Cập nhật tài khoản khoản thành công!");
            }
            catch (Exception)
            {
                MessageBox.Show("Xảy ra lỗi khi cập nhật tài khoản khoản!");

            }
            con.Close(); //Buoc 3
        }

        private void btnXoaTK_Click(object sender, EventArgs e)
        {
            DialogResult ret = MessageBox.Show("Bạn có chắc chắn muốn xoá?", "Thông báo", MessageBoxButtons.OKCancel);
            if (ret == DialogResult.OK)
            { // buoc 1
                SqlConnection con = new SqlConnection(sCon);
                try
                {
                    con.Open();
                }
                catch (Exception)
                {
                    MessageBox.Show("Xảy ra lỗi trong quá trình kết nối DB");

                }
                // buoc 2 
                string sTenHienThi = txtTenHT.Text;
                string sQuery = "delete TAI_KHOAN_CTV where TenHienThi=@TenHienThi";
                SqlCommand cmd = new SqlCommand(sQuery, con);
                cmd.Parameters.AddWithValue("@TenHienThi", sTenHienThi);

                try
                {
                    cmd.ExecuteNonQuery();
                    Loaddata();
                    MessageBox.Show("Xoá thành công!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());

                }
                con.Close(); //Buoc 3

            }


        }

        private void btnNHAPLAI_Click(object sender, EventArgs e)
        {
            txtTenHT.Text = "";
            txtTenDN.Text = "";
            txtMatKhau.Text = "";
            Loaddata();
        }
    }
}


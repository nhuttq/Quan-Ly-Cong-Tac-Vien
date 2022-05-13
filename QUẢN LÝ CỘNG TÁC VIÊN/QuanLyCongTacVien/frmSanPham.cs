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
    public partial class frmSanPham : Form
    {
        string sCon = "Data Source=ADMIN\\SQLEXPRESS;Initial Catalog=Quanly_ctv;Integrated Security=True";
        public frmSanPham()
        {
            InitializeComponent();
        }

        private void frmSanPham_Load(object sender, EventArgs e)
        {
            loaddata();
        }

        private void loaddata()
        {
            SqlConnection con = new SqlConnection(sCon);
            try
            {
                con.Open();
            }
            catch (Exception )
            {
                MessageBox.Show("Xay ra loi trong qua trinh ket noi DB");
            }

            string sQuery = "select * from LOAI_SAN_PHAM";
            SqlDataAdapter adapter = new SqlDataAdapter(sQuery, con);

            DataSet ds = new DataSet();

            adapter.Fill(ds, "SanPham");
            dataGridView1.DataSource = ds.Tables["SanPham"];

            con.Close();


        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(sCon);
            try
            {
                con.Open();
            }
            catch (Exception )
            {
                MessageBox.Show("Xảy ra lỗi trong quá trình kết nối DB");
            }

            try
            {
                if (txtMaSP.Text == "" | txtTenSP.Text == "" | txtDGT.Text == "" | txtDVT.Text == "")
                {
                    MessageBox.Show("Bạn chưa nhập đầy đủ thông tin!", "Thông Báo!",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    string sMaSP = txtMaSP.Text;
                    string sTenSP = txtTenSP.Text;
                    string sDonGT = txtDGT.Text;
                    string sDonVT = txtDVT.Text;
                    string sQuery = "insert into LOAI_SAN_PHAM  values(@masp, @tensp, @dongt, @donvt)";
                    SqlCommand cmd = new SqlCommand(sQuery, con);
                    cmd.Parameters.AddWithValue("@masp", sMaSP);
                    cmd.Parameters.AddWithValue("@tensp", sTenSP);
                    cmd.Parameters.AddWithValue("@dongt", sDonGT);
                    cmd.Parameters.AddWithValue("@donvt", sDonVT);

                    cmd.ExecuteNonQuery();
                    loaddata();
                    MessageBox.Show("Thêm thành công", "Thông báo!");

                }
            }
            catch (Exception )
            {
                MessageBox.Show("Lỗi thêm dữ liệu:", "Thông Báo", MessageBoxButtons.OK,
                MessageBoxIcon.Error);

            }

            con.Close();

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            txtMaSP.Text = dataGridView1.Rows[e.RowIndex].Cells["MaLoaiSP"].Value.ToString();
            txtTenSP.Text = dataGridView1.Rows[e.RowIndex].Cells["TenLoaiSP"].Value.ToString();
            txtDGT.Text = dataGridView1.Rows[e.RowIndex].Cells["DonGiaThue"].Value.ToString();
            txtDVT.Text = dataGridView1.Rows[e.RowIndex].Cells["DonViTinh"].Value.ToString();
            txtMaSP.Enabled = false;

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(sCon);
            try
            {
                con.Open();
            }
            catch (Exception )
            {
                MessageBox.Show("Xảy ra lỗi trong quá trình kết nối DB");
            }

            string sMaSP = txtMaSP.Text;
            string sTenSP = txtTenSP.Text;
            string sDonGT = txtDGT.Text;
            string sDonVT = txtDVT.Text;
            string sQuery = "update LOAI_SAN_PHAM set TenLoaiSP = @tensp, DonGiaThue = @dongt, DonViTinh = @donvt where MaLoaiSP = @masp";

            SqlCommand cmd = new SqlCommand(sQuery, con);
            cmd.Parameters.AddWithValue("@masp", sMaSP);
            cmd.Parameters.AddWithValue("@tensp", sTenSP);
            cmd.Parameters.AddWithValue("@dongt", sDonGT);
            cmd.Parameters.AddWithValue("@donvt", sDonVT);

            try
            {
                cmd.ExecuteNonQuery();
                loaddata();
                MessageBox.Show("Sửa thành công", "Thông báo!");
            }

            catch (Exception ex)
            {
                MessageBox.Show("Lỗi Sửa dữ liệu: " + ex.Message, "Thông Báo", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            }
            con.Close();

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Sau khi xóa, dữ liệu sẽ không thể khôi phục! Tiếp tục?", " Xóa hóa đơn", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                SqlConnection con = new SqlConnection(sCon);
                try
                {
                    con.Open();
                }
                catch (Exception )
                {
                    MessageBox.Show("Xảy ra lỗi trong quá trình kết nối DB");
                }

                string sMaSP = txtMaSP.Text;
                string sQuery = "delete LOAI_SAN_PHAM where MaLoaiSP = @masp ";

                SqlCommand cmd = new SqlCommand(sQuery, con);
                cmd.Parameters.AddWithValue("@masp", sMaSP);

                try
                {
                    cmd.ExecuteNonQuery();
                    loaddata();
                    MessageBox.Show("Xóa thành công", "Thông báo!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi Sửa dữ liệu: " + ex.Message, "Thông Báo", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                }
                con.Close();


            }
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(sCon);
            try
            {
                con.Open();
            }
            catch (Exception )
            {
                MessageBox.Show("Xảy ra lỗi trong quá trình kết nối DB");
            }

            string sQuery = "Select * From LOAI_SAN_PHAM where TenLoaiSP  like N'%" + txtTimSP.Text + "%'";
            SqlDataAdapter adapter = new SqlDataAdapter(sQuery, con);

            DataSet ds = new DataSet();

            try
            {
                adapter.Fill(ds, "SanPham");
            }
            catch (Exception )
            {
                MessageBox.Show("Không Tìm Thấy!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            dataGridView1.DataSource = ds.Tables["SanPham"];
            con.Close();


        }

        private void btnNhapLai_Click(object sender, EventArgs e)
        {
            txtMaSP.Enabled = true;
            txtMaSP.Text = "";
            txtTenSP.Text = "";
            txtDGT.Text = "";
            txtDVT.Text = "";
            txtTimSP.Text = "";
            loaddata();

        }
    }
}

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
    public partial class frmHoaDon : Form
    {
        string sCon = "Data Source=ADMIN\\SQLEXPRESS;Initial Catalog=Quanly_ctv;Integrated Security=True";
        public frmHoaDon()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frmHoaDon_Load(object sender, EventArgs e)
        {
            Loaddata();
        }
        private void Loaddata()
        {
            SqlConnection con = new SqlConnection(sCon);
            try
            {
                con.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Xảy ra lỗi trong quá trình kết nối DB ");
            }
            String sQuery = "select * from HOA_DON";
            SqlDataAdapter adapter = new SqlDataAdapter(sQuery, con);
            DataSet ds = new DataSet();
            adapter.Fill(ds, "HOA_DON");
            dataGridView1.DataSource = ds.Tables["HOA_DON"];
            dataGridView1.Columns["Ngay"].DefaultCellStyle.Format = "dd/MM/yyyy";
           

            string sQuery1 = "select MaCTV,TenCTV from CONG_TAC_VIEN";
            SqlDataAdapter adapter1 = new SqlDataAdapter(sQuery1, con);
            DataSet ds1 = new DataSet();
            adapter1.Fill(ds1, "CONG_TAC_VIEN");
            cbbmactv.DataSource = ds1.Tables["CONG_TAC_VIEN"];
            cbbmactv.ValueMember = "MaCTV";
            cbbmactv.DisplayMember = "TenCTV";
            


            string sQuery2 = "select MaLoaiSP, TenLoaiSP from LOAI_SAN_PHAM";
            SqlDataAdapter adapter2 = new SqlDataAdapter(sQuery2, con);
            DataSet ds2 = new DataSet();
            adapter2.Fill(ds2, "LOAI_SAN_PHAM");
            cbbmasp.DataSource = ds2.Tables["LOAI_SAN_PHAM"];
            cbbmasp.ValueMember = "MaLoaiSp";
            cbbmasp.DisplayMember = "TenLoaiSP";

        }




        private void cbbmasp_SelectionChangeCommitted(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection(sCon);
            try
            {
                con.Open();
            }
            catch (Exception)
            {
                MessageBox.Show("Xảy ra lỗi trong quá trình kết nối DB");
            }
            string sQuery2 = "select DonGiaThue from LOAI_SAN_PHAM where MaLoaiSP=" + cbbmasp.SelectedValue.ToString();
            SqlDataAdapter adapter2 = new SqlDataAdapter(sQuery2, con);
            DataSet ds2 = new DataSet();
            adapter2.Fill(ds2, "LOAI_SAN_PHAM");
            txtdongia.Text = ds2.Tables["LOAI_SAN_PHAM"].Rows[0][0].ToString();
           

            con.Close();

        }


        private void txtsoluong_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int isoluong = Convert.ToInt16(txtsoluong.Text);
                int idongia = Convert.ToInt32(txtdongia.Text);
                int ithanhtien = isoluong * idongia;
                txtthanhtien.Text = ithanhtien.ToString();

                
            }
            catch (Exception ex)
            {

            }


        }



        private void btnThemHD_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(sCon);
            try
            {
                con.Open();
            }
            catch (Exception)
            {
                MessageBox.Show("Xảy ra lỗi trong quá trình kết nối DB ");
                return;
            }
            try
            {
                if (txtmahd.Text == "" | txtsoluong.Text == "")
                {
                    MessageBox.Show("Bạn chưa nhập đầy đủ thông tin!", "Thông Báo!",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    string smahd = txtmahd.Text;
                    string smaCTV = cbbmactv.SelectedValue.ToString();
                    string stencvt = "select TenCTV from CONG_TAC_VIEN where MaCTV = @MaCTV";
                    SqlCommand tenctv = new SqlCommand(stencvt, con);
                    tenctv.Parameters.AddWithValue("MaCTV", cbbmactv.SelectedValue.ToString());
                    using (SqlDataReader reader = tenctv.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            stencvt = reader["TenCTV"].ToString();
                        }
                    }
                    string smaloaisp = cbbmasp.SelectedValue.ToString();
                    string stensp = "select TenLoaiSP from LOAI_SAN_PHAM where MaLoaiSP = @MaLoaiSP";
                    SqlCommand tensp = new SqlCommand(stensp, con);
                    tensp.Parameters.AddWithValue("MaLoaiSP", cbbmasp.SelectedValue.ToString());
                    using (SqlDataReader reader = tensp.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            stensp = reader["TenLoaiSP"].ToString();
                        }
                    }

                    string sdongia = txtdongia.Text;
                    string ssoluong = txtsoluong.Text;
                    string sthanhtien = txtthanhtien.Text;
                    string sngay = dateTimePicker1.Value.ToString("yyyy-MM-dd");

                    string sQuery = "insert into HOA_DON values(@MaHoaDon,@MaLoaiSP,@TenLoaiSP,@MaCTV,@TenCTV,@Ngay,@SoLuong,@DonGiaThue,@ThanhTien)";

                    SqlCommand cmd = new SqlCommand(sQuery, con);
                    cmd.Parameters.AddWithValue("@MaHoaDon", smahd);
                    cmd.Parameters.AddWithValue("@MaLoaiSP", smaloaisp);
                    cmd.Parameters.AddWithValue("@TenLoaiSP", stensp);
                    cmd.Parameters.AddWithValue("@MaCTV", smaCTV);
                    cmd.Parameters.AddWithValue("@TenCTV", stencvt);
                    cmd.Parameters.AddWithValue("@Ngay", sngay);
                    cmd.Parameters.AddWithValue("@SoLuong", ssoluong);
                    cmd.Parameters.AddWithValue("@DonGiaThue", sdongia);
                    cmd.Parameters.AddWithValue("@ThanhTien", sthanhtien);


                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Thêm mới thành công!!!", "Thông báo");
                    Loaddata();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            con.Close();

        }


        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtmahd.Text = dataGridView1.Rows[e.RowIndex].Cells["MaHoaDon"].Value.ToString();
            cbbmasp.Text = dataGridView1.Rows[e.RowIndex].Cells["TenLoaiSP"].Value.ToString(); //set gia trị sai
            cbbmactv.Text = dataGridView1.Rows[e.RowIndex].Cells["TenCTV"].Value.ToString(); //set giá trị sai
            dateTimePicker1.Value = Convert.ToDateTime(dataGridView1.Rows[e.RowIndex].Cells["Ngay"].Value);
            txtdongia.Text = dataGridView1.Rows[e.RowIndex].Cells["DonGiaThue"].Value.ToString();
            txtsoluong.Text = dataGridView1.Rows[e.RowIndex].Cells["SoLuong"].Value.ToString();
            txtthanhtien.Text = dataGridView1.Rows[e.RowIndex].Cells["ThanhTien"].Value.ToString();
            txtmahd.Enabled = false;


        }

        private void btnSuaHD_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection(sCon);
            try
            {
                con.Open();
            }
            catch (Exception)
            {
                MessageBox.Show("Xảy ra lỗi trong quá trình kết nối DB");
            }
            string smahd = txtmahd.Text;
            string smaCTV = cbbmactv.SelectedValue.ToString();
            string smaloaisp = cbbmasp.SelectedValue.ToString();

            string ssoluong = txtsoluong.Text;
            string sthanhtien = txtthanhtien.Text;
            string sngay = dateTimePicker1.Value.ToString("yyyy-MM-dd");
            string sQuery = "update HOA_DON set SoLuong=@SoLuong,ThanhTien=@ThanhTien, Ngay=@Ngay where MaHoaDon=@MaHoaDon";
            SqlCommand cmd3 = new SqlCommand(sQuery, con);
            cmd3.Parameters.AddWithValue("@MaHoaDon", smahd);
            cmd3.Parameters.AddWithValue("@MaLoaiSP", smaloaisp);
            cmd3.Parameters.AddWithValue("@MaCTV", smaCTV);
            cmd3.Parameters.AddWithValue("@Ngay", sngay);
            cmd3.Parameters.AddWithValue("@SoLuong", ssoluong);
            cmd3.Parameters.AddWithValue("@ThanhTien", sthanhtien);

            try
            {
                cmd3.ExecuteNonQuery();
                Loaddata();
                MessageBox.Show("Cập nhật thành công ", "Thông báo");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            con.Close();




        }


        private void btnXoaHD_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Sau khi xóa, dữ liệu sẽ không thể khôi phục! Tiếp tục?", " Xóa hóa đơn", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                SqlConnection con = new SqlConnection(sCon);
                try
                {
                    con.Open();
                }
                catch (Exception)
                {
                    MessageBox.Show("Xảy ra lỗi trong quá trình kết nối DB ", "Thông báo");
                }
                string smahd = dataGridView1.CurrentRow.Cells[0].Value.ToString();

                string sQuery2 = "delete HOA_DON where MaHoaDon = @MaHoaDon ";
                SqlCommand cmd2 = new SqlCommand(sQuery2, con);
                cmd2.Parameters.AddWithValue("@MaHoaDon", smahd);

                try
                {
                    cmd2.ExecuteNonQuery();
                    MessageBox.Show("Xóa thành công", "Thông báo");
                    Loaddata();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                con.Close();
            }


        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            dateTimePicker1.MaxDate = DateTime.Now;
        }

        private void btnnhaplai_Click(object sender, EventArgs e)
        {
            txtmahd.Enabled = true;
            txtmahd.Text = "";
            txtdongia.Text = "";
            txtsoluong.Text = "";
            txtthanhtien.Text = "";

        }
    }
}

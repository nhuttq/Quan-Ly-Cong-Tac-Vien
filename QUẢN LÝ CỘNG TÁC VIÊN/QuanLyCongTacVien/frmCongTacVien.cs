using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient; //buoc 0


namespace QuanLyCongTacVien
{
    public partial class frmCongTacVien : Form
    {
        string sCon = "Data Source=ADMIN\\SQLEXPRESS;Initial Catalog=Quanly_ctv;Integrated Security=True";
        public frmCongTacVien()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frmCongTacVien_Load(object sender, EventArgs e)
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
            string sQuery = "select * from CONG_TAC_VIEN";
            SqlDataAdapter adapter = new SqlDataAdapter(sQuery, con);
            DataSet ds = new DataSet();
            adapter.Fill(ds, "CONGTACVIEN");
            dataGridView1.DataSource = ds.Tables["CONGTACVIEN"];

            string sQuery1 = "select MaCTV,TenCTV from CONG_TAC_VIEN";
            SqlDataAdapter adapter1 = new SqlDataAdapter(sQuery1, con);
            DataSet ds1 = new DataSet();
            adapter1.Fill(ds1, "CONG_TAC_VIEN");

            con.Close(); // buoc 3

        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            if (txtTimkiem.Text == "")
                MessageBox.Show("Vui lòng nhập để tìm kiếm!");
            else
            {
                //buoc 1
                SqlConnection con = new SqlConnection(sCon);
                try
                {
                    con.Open();
                }
                catch (Exception)
                {
                    MessageBox.Show("Xảy ra lỗi trong quá trình kết nối DB");

                }
                //buoc 2
                string sQuery = "select * from CONG_TAC_VIEN where TenCTV like N'%" + txtTimkiem.Text + "%'";
                SqlDataAdapter adapter = new SqlDataAdapter(sQuery, con);
                DataSet ds = new DataSet();
                try
                {
                    adapter.Fill(ds, "CONG_TAC_VIEN");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                dataGridView1.DataSource = ds.Tables["CONG_TAC_VIEN"];

                con.Close();
            }

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void lbtimkiem_Click(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
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
            // chuan bi du lieu
            // kiem tra tinh hop le của du lieu

            // gan du lieu vao bien
            string sMaCTV = txtMaCTV.Text;
            string sTenCTV = txtTenCTV.Text;
            string sDiaChi = txtDiaChi.Text;
            int iTrangThai = 0;
            if (rbconlamctv.Checked == true)
            {
                iTrangThai = 1;
            }  
            

            string sQuery = "insert into CONG_TAC_VIEN values(@MaCTV, @TenCTV, @DiaChi, @TrangThai)";
            SqlCommand cmd = new SqlCommand(sQuery, con);

            cmd.Parameters.AddWithValue("@MaCTV", sMaCTV);
            cmd.Parameters.AddWithValue("@TenCTV", sTenCTV);
            cmd.Parameters.AddWithValue("@DiaChi", sDiaChi);
            cmd.Parameters.AddWithValue("@TrangThai", iTrangThai);

            try
            {
                cmd.ExecuteNonQuery();
                Loaddata();
                MessageBox.Show("Thêm mới thành công!");
            }
            catch (Exception)
            {
                MessageBox.Show("Xảy ra lỗi trong quá trình thêm mới!");

            }
            con.Close(); //Buoc 3

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaCTV.Text = dataGridView1.Rows[e.RowIndex].Cells["MaCTV"].Value.ToString();
            txtTenCTV.Text = dataGridView1.Rows[e.RowIndex].Cells["TenCTV"].Value.ToString();
            txtDiaChi.Text = dataGridView1.Rows[e.RowIndex].Cells["DiaChi"].Value.ToString();
            int iTrangThai = Convert.ToInt16(dataGridView1.Rows[e.RowIndex].Cells["TrangThai"].Value);

            if(iTrangThai == 1)
            {
                rbconlamctv.Checked = true;
            }    
            else
            {
                rbkhongconlamctv.Checked = true;
            }    
            txtMaCTV.Enabled = false;

        }

        private void btnSua_Click(object sender, EventArgs e)
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
            // buoc 2 lay gia tri  
            string sMaCTV = txtMaCTV.Text;
            string sTenCTV = txtTenCTV.Text;
            string sDiaChi = txtDiaChi.Text;
            int iTrangThai = 0;
            if (rbconlamctv.Checked == true)
            {
                iTrangThai = 1;
            }


            string sQuery = "update CONG_TAC_VIEN set TenCTV= @TenCTV,DiaChi=@DiaChi, TrangThai=@TrangThai where MaCTV=@MaCTV";
            SqlCommand cmd = new SqlCommand(sQuery, con);

            cmd.Parameters.AddWithValue("@MaCTV", sMaCTV);
            cmd.Parameters.AddWithValue("@TenCTV", sTenCTV);
            cmd.Parameters.AddWithValue("@DiaChi", sDiaChi);
            cmd.Parameters.AddWithValue("@TrangThai", iTrangThai);

            try
            {
                cmd.ExecuteNonQuery();
                Loaddata();
                MessageBox.Show(" Cập nhật thành công!");
            }
            catch (Exception)
            {
                MessageBox.Show(" Xảy ra lỗi trong quá trình cập nhật!");

            }
            con.Close(); //Buoc 3

        }

        private void btnXoa_Click(object sender, EventArgs e)
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
                // buoc 2 lay gia tri
                string sMaCTV = txtMaCTV.Text;
                string sQuery = "delete CONG_TAC_VIEN where MaCTV = @MaCTV";
                SqlCommand cmd = new SqlCommand(sQuery, con);
                cmd.Parameters.AddWithValue("@MaCTV", sMaCTV);

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

        private void btnhaplai_Click(object sender, EventArgs e)
        {

            txtMaCTV.Enabled = true;
            txtMaCTV.Text = "";
            txtTenCTV.Text = "";
            txtDiaChi.Text = "";
            rbconlamctv.Text = "";
            rbkhongconlamctv.Text = "";
            txtTimkiem.Text = "";
            Loaddata();

        }
    }
}

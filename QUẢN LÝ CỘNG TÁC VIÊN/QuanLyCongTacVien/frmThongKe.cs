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
    public partial class frmThongKe : Form
    {
        string sCon = "Data Source=ADMIN\\SQLEXPRESS;Initial Catalog=Quanly_ctv;Integrated Security=True";
        public frmThongKe()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frmThongKe_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(sCon);
            try
            {
                con.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Xay ra loi trong qua trinh ket noi DB");
            }

            string sQuery1 = "select MaCTV,TenCTV from CONG_TAC_VIEN";
            SqlDataAdapter adapter1 = new SqlDataAdapter(sQuery1, con);
            DataSet ds1 = new DataSet();
            adapter1.Fill(ds1, "CONG_TAC_VIEN");
            cbbTK.DataSource = ds1.Tables["CONG_TAC_VIEN"];
            cbbTK.ValueMember = "MaCTV";
            cbbTK.DisplayMember = "TenCTV";

        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            if (cbbTK.Text != "")
            {
                SqlConnection con = new SqlConnection(sCon);
                try
                {
                    con.Open();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Xay ra loi trong qua trinh ket noi DB");
                }
                string stungay = dateTimePicker1.Value.ToString("yyyy-MM-dd");
                string sdenngay = dateTimePicker2.Value.ToString("yyyy-MM-dd");
                string sQuery = "select TenLoaiSP, SoLuong, ThanhTien from HOA_DON where Ngay between @tungay and @denngay and MaCTV=" + cbbTK.SelectedValue.ToString();
                SqlCommand cmd = new SqlCommand(sQuery, con);
                cmd.Parameters.AddWithValue("@tungay", stungay);
                cmd.Parameters.AddWithValue("@denngay", sdenngay);
                try
                {
                    cmd.ExecuteNonQuery();
                    DataTable thongke = new DataTable();
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    adapter.Fill(thongke);

                    dataGridView1.DataSource = thongke;
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }

                int Tongtien = dataGridView1.Rows.Count;
                float ThanhTien = 0;
                float SoLuong = 0;
                for (int i = 0; i < Tongtien - 1; i++)
                {
                    ThanhTien += float.Parse(dataGridView1.Rows[i].Cells["ThanhTien"].Value.ToString());
                    SoLuong += float.Parse(dataGridView1.Rows[i].Cells["SoLuong"].Value.ToString());
                }
                lblTongSP.Text = string.Format("Tổng sản phẩm: {0}", SoLuong);
                lblTongtien.Text = string.Format("Tổng tiền: {0}", ThanhTien);
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            dateTimePicker1.MaxDate = DateTime.Now;
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            dateTimePicker2.MaxDate = DateTime.Now;
        }

    }
}

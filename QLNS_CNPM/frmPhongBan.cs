using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLNS_CNPM
{
   
    public partial class frmPhongBan : Form
    {
        public static string ConnectionString = @"Data Source=DESKTOP-JFFALB2\SQLEXPRESS; Initial Catalog=CNPM_QLNS; User ID = sa; Password = sa ";
        public frmPhongBan()
        {
            InitializeComponent();
            GetData();
        }

        private void frmPhongBan_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.tblBoPhan' table. You can move, or remove it, as needed.
            this.tblBoPhanTableAdapter.Fill(this.dataSet1.tblBoPhan);

        }

        public void GetData()
        {
            try
            {
                SqlConnection conn = new SqlConnection(ConnectionString);
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }

                string query = "Select * from tblPhongBan";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);

                if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                {
                    dtgPhongBan.DataSource = ds.Tables[0];
                }
                else
                {
                    dtgPhongBan.DataSource = null;
                }
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dtgPhongBan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            DataGridViewRow selectedRow = dtgPhongBan.Rows[index];

            txtMaPhong.Text = selectedRow.Cells["MaPhong"].Value.ToString();
            txtTenPhong.Text = selectedRow.Cells["TenPhong"].Value.ToString();
            txtGhiChu.Text = selectedRow.Cells["GhiChu"].Value.ToString();

            cmbMaBoPhan.Text = selectedRow.Cells["MaBoPhan"].Value.ToString();
            
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                //KetNoi
                SqlConnection conn = new SqlConnection(ConnectionString);
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                //KiemTraThongtin

                string query = "Insert into tblPhongBan (MaBoPhan, MaPhong, TenPhong, GhiChu) values (N'" + cmbMaBoPhan.Text + "', N'" + txtMaPhong.Text + "', N'" + txtTenPhong.Text + "', N'" + txtGhiChu.Text + "')";
                SqlCommand cmd = new SqlCommand(query, conn);
                var result = cmd.ExecuteNonQuery();
                if (txtMaPhong.Text == "")
                {
                    MessageBox.Show("Chưa nhập mã phòng ban!", "Thông báo");
                    txtTenPhong.Focus();
                    return;
                }
                if (txtTenPhong.Text == "")
                {
                    MessageBox.Show("Chưa nhập tên phòng ban!", "Thông báo");
                    txtTenPhong.Focus();
                    return;
                }

                //Them

                if (result > 0)
                {
                    MessageBox.Show("Thêm phòng ban thành công!", "Thông báo");
                    GetData();
                }
                else
                {
                    MessageBox.Show("Thêm phòng ban thất bại!", "Thông báo");
                }
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }

            }
            catch
            {
                MessageBox.Show("Mã phòng ban đã tồn tại");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {

                //KetNoi
                SqlConnection conn = new SqlConnection(ConnectionString);
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                //KiemTraThongtin

                string query = "Update tblPhongBan Set MaBoPhan = N'" + cmbMaBoPhan.Text + "', TenPhong = N'" + txtTenPhong.Text + "', GhiChu = N'" + txtGhiChu.Text + "' where MaPhong = '" + txtMaPhong.Text + "'";
                SqlCommand cmd = new SqlCommand(query, conn);
                var result = cmd.ExecuteNonQuery();
                if (txtMaPhong.Text == "")
                {
                    MessageBox.Show("Chưa nhập thông tin mã phòng ban", "Thông báo");
                    txtMaPhong.Focus();
                    return;
                }
                if (txtTenPhong.Text == "")
                {
                    MessageBox.Show("Chưa nhập thông tin tên phòng ban", "Thông báo");
                    txtTenPhong.Focus();
                    return;
                }

                //Them

                if (result > 0)
                {
                    MessageBox.Show("Cập nhật dữ liệu thành công!", "Thông báo");
                    GetData();
                }
                else
                {
                    MessageBox.Show("Cập nhật dữ liệu thất bại!", "Thông báo");
                }
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
            catch
            {
                MessageBox.Show("Mã bộ phận không tồn tại");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                //KetNoi
                SqlConnection conn = new SqlConnection(ConnectionString);
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                //KiemTraThongtin

                string query = "Delete from tblPhongBan where MaPhong = N'" + txtMaPhong.Text + "'";
                SqlCommand cmd = new SqlCommand(query, conn);
                var result = cmd.ExecuteNonQuery();
                if (txtMaPhong.Text == "")
                {
                    MessageBox.Show("Chưa nhập mã phòng", "Thông báo");
                    txtMaPhong.Focus();
                    return;
                }
                

                //Them

                if (result > 0)
                {
                    MessageBox.Show("Xóa dữ liệu thành công!", "Thông báo");
                    GetData();
                }
                else
                {
                    MessageBox.Show("Xóa dữ liệu thất bại!", "Thông báo");
                }
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }

            }
            catch
            {
                MessageBox.Show("Lỗi xóa dữ liệu");
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtMaPhong.Text = "";
            txtTenPhong.Text = "";
            txtGhiChu.Text = "";
        }
    }
}

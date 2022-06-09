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
    public partial class frmLuong : Form
    {
        public static string ConnectionString = @"Data Source=DESKTOP-JFFALB2\SQLEXPRESS; Initial Catalog=CNPM_QLNS; User ID = sa; Password = sa ";
        public frmLuong()
        {
            InitializeComponent();
            GetData();
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

                string query = "Select * from tblLuong";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);

                if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                {
                    dtgLuong.DataSource = ds.Tables[0];
                }
                else
                {
                    dtgLuong.DataSource = null;
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

        private void dtgLuong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            DataGridViewRow selectedRow = dtgLuong.Rows[index];

            txtMaLuong.Text = selectedRow.Cells["MaLuong"].Value.ToString();
            txtLuongCoBan.Text = selectedRow.Cells["LuongCoBan"].Value.ToString();
            txtPhuCap.Text = selectedRow.Cells["PCChucVu"].Value.ToString();
            txtGhiChu.Text = selectedRow.Cells["GhiChu"].Value.ToString();
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

                string query = "Insert into tblLuong (MaLuong, LuongCoban, PCChucVu, GhiChu) values (N'" + txtMaLuong.Text + "', N'" + txtLuongCoBan.Text + "', N'" + txtPhuCap.Text + "', N'" + txtGhiChu.Text + "')";
                SqlCommand cmd = new SqlCommand(query, conn);
                var result = cmd.ExecuteNonQuery();
                if (txtMaLuong.Text == "")
                {
                    MessageBox.Show("Chưa nhập mã lương!", "Thông báo");
                    txtMaLuong.Focus();
                    return;
                }
                if (txtLuongCoBan.Text == "")
                {
                    MessageBox.Show("Chưa nhập lương cơ bản!", "Thông báo");
                    txtLuongCoBan.Focus();
                    return;
                }

                //Them

                if (result > 0)
                {
                    MessageBox.Show("Thêm thành công!", "Thông báo");
                    GetData();
                }
                else
                {
                    MessageBox.Show("Thêm thất bại!", "Thông báo");
                }
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }

            }
            catch
            {
                MessageBox.Show("Mã lương đã tồn tại");
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

                string query = "Update tblLuong Set LuongCoBan = N'" + txtLuongCoBan.Text + "', PCChucVu = N'" + txtPhuCap.Text + "', GhiChu = N'" + txtGhiChu.Text + "' where MaLuong = '" + txtMaLuong.Text + "'";
                SqlCommand cmd = new SqlCommand(query, conn);
                var result = cmd.ExecuteNonQuery();
                if (txtMaLuong.Text == "")
                {
                    MessageBox.Show("Chưa nhập mã lương", "Thông báo");
                    txtMaLuong.Focus();
                    return;
                }
                if (txtLuongCoBan.Text == "")
                {
                    MessageBox.Show("Chưa nhập lương cơ bản", "Thông báo");
                    txtLuongCoBan.Focus();
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
            catch//(Exception ex)
            {
                //MessageBox.Show(ex.Message);
                MessageBox.Show("Mã lương đã tồn tại");
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

                string query = "Delete from tblLuong where MaLuong = N'" + txtMaLuong.Text + "'";
                SqlCommand cmd = new SqlCommand(query, conn);
                var result = cmd.ExecuteNonQuery();
                if (txtMaLuong.Text == "")
                {
                    MessageBox.Show("Chưa nhập mã lương", "Thông báo");
                    txtMaLuong.Focus();
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
            txtGhiChu.Text = "";
            txtLuongCoBan.Text = "";
            txtMaLuong.Text = "";
            txtPhuCap.Text = "";
        }
    }
}

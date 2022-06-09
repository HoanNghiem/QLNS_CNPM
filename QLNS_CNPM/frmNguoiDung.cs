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
    public partial class frmNguoiDung : Form
    {
        public static string ConnectionString = @"Data Source=DESKTOP-JFFALB2\SQLEXPRESS; Initial Catalog=CNPM_QLNS; User ID = sa; Password = sa ";
        
        public frmNguoiDung()
        {
            InitializeComponent();
            GetData();
        }

        private void frmNguoiDung_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.tblHoSoNV' table. You can move, or remove it, as needed.
            this.tblHoSoNVTableAdapter.Fill(this.dataSet1.tblHoSoNV);


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
                
                string query = "Select * from tblNguoiDung";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);

                if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                {
                    dtgNguoiDung.DataSource = ds.Tables[0];
                }
                else
                {
                    dtgNguoiDung.DataSource = null;
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

        private void dtgNguoiDung_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            DataGridViewRow selectedRow = dtgNguoiDung.Rows[index];

            txtTaiKhoan.Text = selectedRow.Cells["TaiKhoan"].Value.ToString();
            txtMatKhau.Text = selectedRow.Cells["MatKhau"].Value.ToString();

            dtpNgayTao.Text = selectedRow.Cells["NgayTao"].Value.ToString();

            cmbMaNV.Text = selectedRow.Cells["MaNV"].Value.ToString();
            cmbQuyen.Text = selectedRow.Cells["Quyen"].Value.ToString();
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

                string query = "Insert into tblNguoiDung (TaiKhoan, MatKhau, Quyen, MaNV, NgayTao) values (N'" + txtTaiKhoan.Text + "', N'" + txtMatKhau.Text + "', N'" + cmbQuyen.Text + "', N'"+cmbMaNV.Text+"', N'"+dtpNgayTao.Text+"')";
                SqlCommand cmd = new SqlCommand(query, conn);
                var result = cmd.ExecuteNonQuery();
                if (txtTaiKhoan.Text == "")
                {
                    MessageBox.Show("Chưa nhập tài khoản!", "Thông báo");
                    txtTaiKhoan.Focus();
                    return;
                }
                if (txtMatKhau.Text == "")
                {
                    MessageBox.Show("Chưa nhập mât khẩu!", "Thông báo");
                    txtMatKhau.Focus();
                    return;
                }

                //Them

                if (result > 0)
                {
                    MessageBox.Show("Thêm người dùng thành công!", "Thông báo");
                    GetData();
                }
                else
                {
                    MessageBox.Show("Thêm người dùng thất bại!", "Thông báo");
                }

                //conn.Close();
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }

            }
            catch
            {
                MessageBox.Show("Tên tài khoản đã tồn tại");
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

                string query = "Update tblNguoiDung Set MatKhau = N'" + txtMatKhau.Text + "', Quyen = N'" + cmbQuyen.Text + "', MaNV = N'" + cmbMaNV.Text + "', NgayTao= N'" + dtpNgayTao.Text+"' where TaiKhoan = '" + txtTaiKhoan.Text + "'";
                SqlCommand cmd = new SqlCommand(query, conn);
                var result = cmd.ExecuteNonQuery();
                if (txtTaiKhoan.Text == "")
                {
                    MessageBox.Show("Chưa nhập thông tin tài khoản", "Thông báo");
                    txtTaiKhoan.Focus();
                    return;
                }
                if (txtMatKhau.Text == "")
                {
                    MessageBox.Show("Chưa nhập thông tin mật khẩu", "Thông báo");
                    txtMatKhau.Focus();
                    return;
                }

                //Capnhat


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
                MessageBox.Show("Mã nhân viên không tồn tại");
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

                string query = "Delete from tblNguoiDung where TaiKhoan = N'" + txtTaiKhoan.Text + "'";
                SqlCommand cmd = new SqlCommand(query, conn);
                var result = cmd.ExecuteNonQuery();
                if (txtTaiKhoan.Text == "")
                {
                    MessageBox.Show("Chưa nhập thông tin tài khoản", "Thông báo");
                    txtTaiKhoan.Focus();
                    return;
                }
                if (txtMatKhau.Text == "")
                {
                    MessageBox.Show("Chưa nhập thông tin mật khẩu", "Thông báo");
                    txtMatKhau.Focus();
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
            txtMatKhau.Text = "";
            txtTaiKhoan.Text = "";
            cmbMaNV.Text = "";
            cmbQuyen.Text = "";
            
        }
    }
}

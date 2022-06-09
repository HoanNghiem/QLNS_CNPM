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
    public partial class frmBoPhan : Form
    {
        public static string ConnectionString = @"Data Source=DESKTOP-JFFALB2\SQLEXPRESS; Initial Catalog=CNPM_QLNS; User ID = sa; Password = sa ";
        public frmBoPhan()
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
                
                string query = "Select * from tblBoPhan";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);

                if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                {
                    dtgBoPhan.DataSource = ds.Tables[0];
                }
                else
                {
                    dtgBoPhan.DataSource = null;
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

        private void dtgBoPhan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            DataGridViewRow selectedRow = dtgBoPhan.Rows[index];

            txtMaBoPhan.Text = selectedRow.Cells["MaBoPhan"].Value.ToString();
            txtTenBoPhan.Text = selectedRow.Cells["TenBoPhan"].Value.ToString();
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
                
                string query = "Insert into tblBoPhan (MaBoPhan, TenBoPhan, GhiChu) values (N'" + txtMaBoPhan.Text + "', N'" + txtTenBoPhan.Text + "', N'" + txtGhiChu.Text + "')";
                SqlCommand cmd = new SqlCommand(query, conn);
                var result = cmd.ExecuteNonQuery();
                if (txtMaBoPhan.Text == "")
                {
                    MessageBox.Show("Chưa nhập thông tin mã bộ phận", "Thông báo");
                    txtMaBoPhan.Focus();
                    return;
                }
                if (txtTenBoPhan.Text == "")
                {
                    MessageBox.Show("Chưa nhập thông tin tên bộ phận", "Thông báo");
                    txtTenBoPhan.Focus();
                    return;
                }

                //Them
                
                if (result > 0)
                {
                    MessageBox.Show("Thêm dữ liệu thành công!", "Thông báo");
                    GetData();
                }
                else
                {
                    MessageBox.Show("Thêm dữ liệu thất bại!", "Thông báo");
                }
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }

            }
            catch 
            {
                MessageBox.Show("Mã bộ phận đã tồn tại");
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

                string query = "Update tblBoPhan Set TenBoPhan = N'" + txtTenBoPhan.Text + "', GhiChu = N'" + txtGhiChu.Text + "' where MaBoPhan = '"+txtMaBoPhan.Text+"'";
                SqlCommand cmd = new SqlCommand(query, conn);
                var result = cmd.ExecuteNonQuery();
                if (txtMaBoPhan.Text == "")
                {
                    MessageBox.Show("Chưa nhập thông tin mã bộ phận", "Thông báo");
                    txtMaBoPhan.Focus();
                    return;
                }
                if (txtTenBoPhan.Text == "")
                {
                    MessageBox.Show("Chưa nhập thông tin tên bộ phận", "Thông báo");
                    txtTenBoPhan.Focus();
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
                MessageBox.Show("Lỗi cập nhật dữ liệu");
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

                string query = "Delete from tblBoPhan where MaBoPhan = N'"+txtMaBoPhan.Text+"'";
                SqlCommand cmd = new SqlCommand(query, conn);
                var result = cmd.ExecuteNonQuery();
                if (txtMaBoPhan.Text == "")
                {
                    MessageBox.Show("Chưa nhập thông tin mã bộ phận", "Thông báo");
                    txtMaBoPhan.Focus();
                    return;
                }
                if (txtTenBoPhan.Text == "")
                {
                    MessageBox.Show("Chưa nhập thông tin tên bộ phận", "Thông báo");
                    txtTenBoPhan.Focus();
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
            txtTenBoPhan.Text = "";
            txtMaBoPhan.Text = "";
            txtGhiChu.Text = "";
        }
    }
}

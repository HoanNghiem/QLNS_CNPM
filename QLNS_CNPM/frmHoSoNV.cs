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
    public partial class frmHoSoNV : Form
    {
        public static string ConnectionString = @"Data Source=DESKTOP-JFFALB2\SQLEXPRESS; Initial Catalog=CNPM_QLNS; User ID = sa; Password = sa ";
        public frmHoSoNV()
        {
            InitializeComponent();
            GetData();
        }

        private void frmHoSoNV_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.tblLuong' table. You can move, or remove it, as needed.
            this.tblLuongTableAdapter.Fill(this.dataSet1.tblLuong);
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

                string query = "Select * from tblHoSoNV";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);

                if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                {
                    dtgHoSoNV.DataSource = ds.Tables[0];
                }
                else
                {
                    dtgHoSoNV.DataSource = null;
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


        private void cmbMaBoPhan_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbMaPhong.Items.Clear();
            SqlConnection conn = new SqlConnection(ConnectionString);
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            //KiemTraThongtin

            string query = "Select MaPhong from tblBoPhan,tblPhongBan Where tblBoPhan.MaBoPhan = tblPhongBan.MaBoPhan and tblBoPhan.MaBoPhan = N'"+cmbMaBoPhan.Text+"' ";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {

                cmbMaPhong.Items.Add(dr[0].ToString());
            }
        }

        private void dtgHoSoNV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            DataGridViewRow selectedRow = dtgHoSoNV.Rows[index];

            cmbMaBoPhan.Text = selectedRow.Cells["MaBoPhan"].Value.ToString();
            cmbMaPhong.Text = selectedRow.Cells["MaPhong"].Value.ToString();
            txtMaNV.Text = selectedRow.Cells["MaNV"].Value.ToString();
            txtHoTen.Text = selectedRow.Cells["HoTen"].Value.ToString();
            cmbMaLuong.Text = selectedRow.Cells["MaLuong"].Value.ToString();

            dtpNgaySinh.Text = selectedRow.Cells["NgaySinh"].Value.ToString();
            cmbGT.Text = selectedRow.Cells["GioiTinh"].Value.ToString();
            txtHonNhan.Text = selectedRow.Cells["HonNhan"].Value.ToString();
            txtCCCD.Text = selectedRow.Cells["CCCD"].Value.ToString();
            txtNoiCap.Text = selectedRow.Cells["NoiCap"].Value.ToString();

            txtChucvu.Text = selectedRow.Cells["ChucVu"].Value.ToString();
            txtHD.Text = selectedRow.Cells["LoaiHD"].Value.ToString();
            txtThoiGian.Text = selectedRow.Cells["ThoiGian"].Value.ToString();
            dtpNgayKy.Text = selectedRow.Cells["NgayKy"].Value.ToString();
            dtpNgayHet.Text = selectedRow.Cells["NgayHetHan"].Value.ToString();

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

                string query = "Insert into tblHoSoNV (MaBoPhan, MaPhong, MaNV, HoTen, MaLuong, NgaySinh, GioiTinh, HonNhan, CCCD, NoiCap, ChucVu, LoaiHD, ThoiGian, NgayKy, NgayHetHan, GhiChu) " +
                    "values (N'" + cmbMaBoPhan.Text + "', N'" + cmbMaPhong.Text + "', N'" + txtMaNV.Text + "', " +
                    "N'" + txtHoTen.Text + "', N'" + cmbMaLuong.Text + "', N'" + dtpNgaySinh.Text + "', N'" + cmbGT.Text + "', " +
                    "N'" + txtHonNhan.Text + "', N'" + txtCCCD.Text + "', N'" + txtNoiCap.Text + "', N'" + txtChucvu.Text + "', " +
                    "N'" + txtHD.Text + "', N'" + txtThoiGian.Text + "', N'" + dtpNgayKy.Text + "', N'" + dtpNgayHet.Text + "', N'" + txtGhiChu.Text + "')";
                SqlCommand cmd = new SqlCommand(query, conn);
                var result = cmd.ExecuteNonQuery();
                if (txtMaNV.Text == "")
                {
                    MessageBox.Show("Chưa nhập mã nhân viên!", "Thông báo");
                    txtMaNV.Focus();
                    return;
                }
                

                //Them

                if (result > 0)
                {
                    MessageBox.Show("Thêm hồ sơ thành công!", "Thông báo");
                    GetData();
                }
                else
                {
                    MessageBox.Show("Thêm hồ sơ thất bại!", "Thông báo");
                }
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }

            }
            catch/*(Exception ex)*/
            {
                //MessageBox.Show(ex.Message);
                //MessageBox.Show("Mã nhân viên đã tồn tại");
                MessageBox.Show("Mã nhân viên đã tồn tại hoặc chưa chọn mã lương");
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

                string query = "Update tblHoSoNV Set MaBoPhan = N'" + cmbMaBoPhan.Text + "', MaPhong = N'" + cmbMaPhong.Text + "', " +
                    "HoTen = N'"+txtHoTen.Text+"', NgaySinh =N'"+dtpNgaySinh.Text+"', GioiTinh = N'"+cmbGT.Text+"', HonNhan = N'"+txtHonNhan.Text+"', " +
                    "CCCD = N'"+txtCCCD.Text+"', NoiCap = N'"+txtNoiCap.Text+"', ChucVu = N'"+txtChucvu.Text +"', LoaiHD = N'"+txtHD.Text+"', ThoiGian = N'"+txtThoiGian.Text+"', " +
                    "NgayKy = N'"+dtpNgayKy.Text+"', NgayHetHan = N'"+dtpNgayHet.Text+"', GhiChu = N'" + txtGhiChu.Text + "' " +
                    "where MaNV = N'" + txtMaNV.Text + "'";
                SqlCommand cmd = new SqlCommand(query, conn);
                var result = cmd.ExecuteNonQuery();
                if (txtMaNV.Text == "")
                {
                    MessageBox.Show("Chưa nhập mã nhân viên", "Thông báo");
                    txtMaNV.Focus();
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
            catch/*(Exception ex)*/
            {
                MessageBox.Show("Mã nhân viên không tồn tại");
                //MessageBox.Show(ex.Message);
                //MessageBox.Show("Mã nhân viên không tồn tại");
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

                string query = "Delete from tblHoSoNV where MaNV = N'" + txtMaNV.Text + "'";
                SqlCommand cmd = new SqlCommand(query, conn);
                var result = cmd.ExecuteNonQuery();
                if (txtMaNV.Text == "")
                {
                    MessageBox.Show("Chưa nhập mã nhân viên", "Thông báo");
                    txtMaNV.Focus();
                    return;
                }


                //Xoa

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
                MessageBox.Show("Lỗi xóa dữ liệu: Mã nhân viên không tồn tại");
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtCCCD.Text = "";
            txtChucvu.Text = "";
            txtGhiChu.Text = "";
            txtHD.Text = "";
            txtHonNhan.Text = "";
            txtHoTen.Text = "";
            txtMaNV.Text = "";
            txtNoiCap.Text = "";
            txtThoiGian.Text = "";
            cmbGT.Text = "";
            cmbMaBoPhan.Text = "";
            cmbMaLuong.Text = "";
            cmbMaPhong.Text = "";
        }

        private void txtCCCD_KeyPress(object sender, KeyPressEventArgs e)
        {
            /*if (char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }*/
        }
    }
}

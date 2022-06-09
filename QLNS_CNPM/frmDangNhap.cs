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
    public partial class frmDangNhap : Form
    {
        public static string ConnectionString = @"Data Source=DESKTOP-JFFALB2\SQLEXPRESS; Initial Catalog=CNPM_QLNS; User ID = sa; Password = sa ";
        public static string quyen = "";
        public frmDangNhap()
        {
            InitializeComponent();
            lblError.Text = "";
          
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            try
            {
                lblError.Text = "";
                //Kiểm tra xem tài khảon mật khẩu đã nhập chưa
                if (txtTaiKhoan.Text != null && txtTaiKhoan.Text.Trim() != "") { }
                else
                {
                    lblError.Text="Chưa nhập tài khoản !";
                    txtTaiKhoan.Focus();
                    return;
                }
                if (txtMatKhau.Text != null && txtMatKhau.Text.Trim() != "") { }
                else
                {
                    lblError.Text = "Chưa nhập mật khẩu !";
                    txtMatKhau.Focus();
                    return;
                }
                SqlConnection conn = new SqlConnection(ConnectionString);
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
               
                conn.Close();
                

                string Tai_Khoan = txtTaiKhoan.Text;
                string Mat_Khau = txtMatKhau.Text;
                string query = "Select * from tblNguoiDung where TaiKhoan='" + Tai_Khoan + "' and MatKhau='" + Mat_Khau + "' ";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                
                if ( ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                {

                    quyen = ds.Tables[0].Rows[0]["Quyen"].ToString();
                    if (quyen == "admin")
                    {
                        MessageBox.Show("Đăng nhập hệ thống (Quyền Admin) !", "Thông báo");
                        frmMain frm_Main = new frmMain(quyen);
                        frm_Main.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Đăng nhập hệ thống (Quyền user) !", "Thông báo");
                        frmMain frm_Main = new frmMain(quyen);
                        frm_Main.Show();
                        this.Hide();
                    }
                    
                }
                else
                {
                    lblError.Text = "Tài khoản hoặc mật khẩu chưa chính xác!";
                }
            }
            catch(Exception ex)
            {
                lblError.Text = ex.Message;
            }               
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
            this.Close();
        }
    }
}

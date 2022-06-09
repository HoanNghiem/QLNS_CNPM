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

namespace QLNS_CNPM
{
    public partial class frmTimKiemNV : Form
    {
        public static string ConnectionString = @"Data Source=DESKTOP-JFFALB2\SQLEXPRESS; Initial Catalog=CNPM_QLNS; User ID = sa; Password = sa ";
        public frmTimKiemNV()
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

                string query = "Select * from tblHoSoNV";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);

                if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                {
                    dtgTimKiemNV.DataSource = ds.Tables[0];
                }
                else
                {
                    dtgTimKiemNV.DataSource = null;
                }
                
                conn.Close();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        int rdb = 0;

        private void rdbMaNV_CheckedChanged(object sender, EventArgs e)
        {
            rdb = 1;
        }

        private void rdbCCCD_CheckedChanged(object sender, EventArgs e)
        {
            rdb = 2;
        }

        private void rdbTenNV_CheckedChanged(object sender, EventArgs e)
        {
            rdb = 3;
        }

        private void btnALL_Click(object sender, EventArgs e)
        {
            GetData();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtThongTin.Text == "")
                {
                    MessageBox.Show("Bạn chưa nhập thông tin!");
                }
                else
                {
                    if (rdb == 1)
                    {
                        try
                        {
                            SqlConnection conn = new SqlConnection(ConnectionString);
                            if (conn.State == ConnectionState.Closed)
                            {
                                conn.Open();
                            }

                            string query = "Select * from tblHoSoNV Where MaNV like '%"+txtThongTin.Text+"%'";
                            SqlCommand cmd = new SqlCommand(query, conn);
                            SqlDataAdapter da = new SqlDataAdapter(cmd);
                            DataSet ds = new DataSet();
                            da.Fill(ds);

                            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                            {
                                dtgTimKiemNV.DataSource = ds.Tables[0];
                            }
                            else
                            {
                                dtgTimKiemNV.DataSource = null;
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
                    if (rdb == 2)
                    {
                        try
                        {
                            SqlConnection conn = new SqlConnection(ConnectionString);
                            if (conn.State == ConnectionState.Closed)
                            {
                                conn.Open();
                            }

                            string query = "Select * from tblHoSoNV Where CCCD like '%" + txtThongTin.Text + "%'";
                            SqlCommand cmd = new SqlCommand(query, conn);
                            SqlDataAdapter da = new SqlDataAdapter(cmd);
                            DataSet ds = new DataSet();
                            da.Fill(ds);

                            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                            {
                                dtgTimKiemNV.DataSource = ds.Tables[0];
                            }
                            else
                            {
                                dtgTimKiemNV.DataSource = null;
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
                    if (rdb == 3)
                    {
                        try
                        {
                            SqlConnection conn = new SqlConnection(ConnectionString);
                            if (conn.State == ConnectionState.Closed)
                            {
                                conn.Open();
                            }

                            string query = "Select * from tblHoSoNV Where HoTen like N'%" + txtThongTin.Text + "%'";
                            SqlCommand cmd = new SqlCommand(query, conn);
                            SqlDataAdapter da = new SqlDataAdapter(cmd);
                            DataSet ds = new DataSet();
                            da.Fill(ds);

                            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                            {
                                dtgTimKiemNV.DataSource = ds.Tables[0];
                            }
                            else
                            {
                                dtgTimKiemNV.DataSource = null;
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
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        
    }
}

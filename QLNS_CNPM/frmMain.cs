using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLNS_CNPM
{
    public partial class frmMain : Form
    {
        public frmMain(string quyen)
        {
            InitializeComponent();
            this.IsMdiContainer = true;
            if (quyen == "admin")
            {
                mnuQLNguoiDung.Enabled = true;
            }
            else
            {
                mnuQLNguoiDung.Enabled = false;
            }
        }

        private void mnuDangXuat_Click(object sender, EventArgs e)
        {
            frmDangNhap frm_DangNhap = new frmDangNhap();
            frm_DangNhap.Show();
            this.Hide();
        }

        private void mnuBoPhan_Click(object sender, EventArgs e)
        {
            frmBoPhan frm_BoPhan = new frmBoPhan();
            frm_BoPhan.MdiParent = this;
            frm_BoPhan.Show();
        }

        private void mnuQLNguoiDung_Click(object sender, EventArgs e)
        {
            frmNguoiDung frm_NguoiDung = new frmNguoiDung();
            frm_NguoiDung.MdiParent = this;
            frm_NguoiDung.Show();
        }

        private void mnuPhongBan_Click(object sender, EventArgs e)
        {
            frmPhongBan frm_PhongBan = new frmPhongBan();
            frm_PhongBan.MdiParent = this;
            frm_PhongBan.Show();
        }

        private void mnuLuongCongTy_Click(object sender, EventArgs e)
        {
            frmLuong frm_Luong = new frmLuong();
            frm_Luong.MdiParent = this;
            frm_Luong.Show();
        }

        private void mnuHoSoNhanVien_Click(object sender, EventArgs e)
        {
            frmHoSoNV frm_HoSoNV = new frmHoSoNV();
            frm_HoSoNV.MdiParent = this;
            frm_HoSoNV.Show();
        }

        private void mnuBaoCaoNhanVien_Click(object sender, EventArgs e)
        {
            frmBaoCaoNV frm_BaoCao = new frmBaoCaoNV();
            frm_BaoCao.MdiParent = this;
            frm_BaoCao.Show();
        }

        private void mnuBaoCaoLuongNV_Click(object sender, EventArgs e)
        {
            frmBaoCaoLuongNV frm_BaoCaoLuongNV = new frmBaoCaoLuongNV();
            frm_BaoCaoLuongNV.MdiParent = this;
            frm_BaoCaoLuongNV.Show();
        }

        private void TimKiemNhanVien_Click(object sender, EventArgs e)
        {
            frmTimKiemNV frm_TimKiem = new frmTimKiemNV();
            frm_TimKiem.MdiParent = this;
            frm_TimKiem.Show();
        }
    }
}

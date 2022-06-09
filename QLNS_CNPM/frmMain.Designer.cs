
namespace QLNS_CNPM
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuTaiKhoan = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDangXuat = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuQLNguoiDung = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuQuanLy = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuBoPhan = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPhongBan = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHoSoNhanVien = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuLuongCongTy = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDanhMuc = new System.Windows.Forms.ToolStripMenuItem();
            this.TimKiemNhanVien = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuChucNang = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuBaoCao = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuBaoCaoNhanVien = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuBaoCaoLuongNV = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuTaiKhoan,
            this.mnuQuanLy,
            this.mnuDanhMuc,
            this.mnuChucNang});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(711, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuTaiKhoan
            // 
            this.mnuTaiKhoan.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuDangXuat,
            this.mnuQLNguoiDung});
            this.mnuTaiKhoan.Name = "mnuTaiKhoan";
            this.mnuTaiKhoan.Size = new System.Drawing.Size(69, 20);
            this.mnuTaiKhoan.Text = "Tài khoản";
            // 
            // mnuDangXuat
            // 
            this.mnuDangXuat.Name = "mnuDangXuat";
            this.mnuDangXuat.Size = new System.Drawing.Size(156, 22);
            this.mnuDangXuat.Text = "Đăng xuất";
            this.mnuDangXuat.Click += new System.EventHandler(this.mnuDangXuat_Click);
            // 
            // mnuQLNguoiDung
            // 
            this.mnuQLNguoiDung.Name = "mnuQLNguoiDung";
            this.mnuQLNguoiDung.Size = new System.Drawing.Size(156, 22);
            this.mnuQLNguoiDung.Text = "QL Người dùng";
            this.mnuQLNguoiDung.Click += new System.EventHandler(this.mnuQLNguoiDung_Click);
            // 
            // mnuQuanLy
            // 
            this.mnuQuanLy.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuBoPhan,
            this.mnuPhongBan,
            this.mnuHoSoNhanVien,
            this.mnuLuongCongTy});
            this.mnuQuanLy.Name = "mnuQuanLy";
            this.mnuQuanLy.Size = new System.Drawing.Size(60, 20);
            this.mnuQuanLy.Text = "Quản lý";
            // 
            // mnuBoPhan
            // 
            this.mnuBoPhan.Name = "mnuBoPhan";
            this.mnuBoPhan.Size = new System.Drawing.Size(160, 22);
            this.mnuBoPhan.Text = "Bộ phận";
            this.mnuBoPhan.Click += new System.EventHandler(this.mnuBoPhan_Click);
            // 
            // mnuPhongBan
            // 
            this.mnuPhongBan.Name = "mnuPhongBan";
            this.mnuPhongBan.Size = new System.Drawing.Size(160, 22);
            this.mnuPhongBan.Text = "Phòng ban";
            this.mnuPhongBan.Click += new System.EventHandler(this.mnuPhongBan_Click);
            // 
            // mnuHoSoNhanVien
            // 
            this.mnuHoSoNhanVien.Name = "mnuHoSoNhanVien";
            this.mnuHoSoNhanVien.Size = new System.Drawing.Size(160, 22);
            this.mnuHoSoNhanVien.Text = "Hồ sơ nhân viên";
            this.mnuHoSoNhanVien.Click += new System.EventHandler(this.mnuHoSoNhanVien_Click);
            // 
            // mnuLuongCongTy
            // 
            this.mnuLuongCongTy.Name = "mnuLuongCongTy";
            this.mnuLuongCongTy.Size = new System.Drawing.Size(160, 22);
            this.mnuLuongCongTy.Text = "Lương công ty";
            this.mnuLuongCongTy.Click += new System.EventHandler(this.mnuLuongCongTy_Click);
            // 
            // mnuDanhMuc
            // 
            this.mnuDanhMuc.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TimKiemNhanVien});
            this.mnuDanhMuc.Name = "mnuDanhMuc";
            this.mnuDanhMuc.Size = new System.Drawing.Size(74, 20);
            this.mnuDanhMuc.Text = "Danh mục";
            // 
            // TimKiemNhanVien
            // 
            this.TimKiemNhanVien.Name = "TimKiemNhanVien";
            this.TimKiemNhanVien.Size = new System.Drawing.Size(180, 22);
            this.TimKiemNhanVien.Text = "Tìm kiếm nhân viên";
            this.TimKiemNhanVien.Click += new System.EventHandler(this.TimKiemNhanVien_Click);
            // 
            // mnuChucNang
            // 
            this.mnuChucNang.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuBaoCao});
            this.mnuChucNang.Name = "mnuChucNang";
            this.mnuChucNang.Size = new System.Drawing.Size(77, 20);
            this.mnuChucNang.Text = "Chức năng";
            // 
            // mnuBaoCao
            // 
            this.mnuBaoCao.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuBaoCaoNhanVien,
            this.mnuBaoCaoLuongNV});
            this.mnuBaoCao.Name = "mnuBaoCao";
            this.mnuBaoCao.Size = new System.Drawing.Size(119, 22);
            this.mnuBaoCao.Text = "Báo cáo ";
            // 
            // mnuBaoCaoNhanVien
            // 
            this.mnuBaoCaoNhanVien.Name = "mnuBaoCaoNhanVien";
            this.mnuBaoCaoNhanVien.Size = new System.Drawing.Size(205, 22);
            this.mnuBaoCaoNhanVien.Text = "Báo cáo nhân viên";
            this.mnuBaoCaoNhanVien.Click += new System.EventHandler(this.mnuBaoCaoNhanVien_Click);
            // 
            // mnuBaoCaoLuongNV
            // 
            this.mnuBaoCaoLuongNV.Name = "mnuBaoCaoLuongNV";
            this.mnuBaoCaoLuongNV.Size = new System.Drawing.Size(205, 22);
            this.mnuBaoCaoLuongNV.Text = "Báo cáo lương nhân viên";
            this.mnuBaoCaoLuongNV.Click += new System.EventHandler(this.mnuBaoCaoLuongNV_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::QLNS_CNPM.Properties.Resources.gsot_chennai_office;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(711, 462);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HỆ THỐNG QUẢN LÝ NHÂN SỰ";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuTaiKhoan;
        private System.Windows.Forms.ToolStripMenuItem mnuDangXuat;
        private System.Windows.Forms.ToolStripMenuItem mnuQLNguoiDung;
        private System.Windows.Forms.ToolStripMenuItem mnuQuanLy;
        private System.Windows.Forms.ToolStripMenuItem mnuBoPhan;
        private System.Windows.Forms.ToolStripMenuItem mnuPhongBan;
        private System.Windows.Forms.ToolStripMenuItem mnuHoSoNhanVien;
        private System.Windows.Forms.ToolStripMenuItem mnuLuongCongTy;
        private System.Windows.Forms.ToolStripMenuItem mnuDanhMuc;
        private System.Windows.Forms.ToolStripMenuItem TimKiemNhanVien;
        private System.Windows.Forms.ToolStripMenuItem mnuChucNang;
        private System.Windows.Forms.ToolStripMenuItem mnuBaoCao;
        private System.Windows.Forms.ToolStripMenuItem mnuBaoCaoNhanVien;
        private System.Windows.Forms.ToolStripMenuItem mnuBaoCaoLuongNV;
    }
}
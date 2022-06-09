
namespace QLNS_CNPM
{
    partial class frmTimKiemNV
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtThongTin = new System.Windows.Forms.TextBox();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.dtgTimKiemNV = new System.Windows.Forms.DataGridView();
            this.rdbMaNV = new System.Windows.Forms.RadioButton();
            this.rdbCCCD = new System.Windows.Forms.RadioButton();
            this.btnALL = new System.Windows.Forms.Button();
            this.rdbTenNV = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dtgTimKiemNV)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(96, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập thông tin:";
            // 
            // txtThongTin
            // 
            this.txtThongTin.Location = new System.Drawing.Point(224, 21);
            this.txtThongTin.Name = "txtThongTin";
            this.txtThongTin.Size = new System.Drawing.Size(255, 20);
            this.txtThongTin.TabIndex = 1;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiem.Location = new System.Drawing.Point(547, 15);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(88, 29);
            this.btnTimKiem.TabIndex = 2;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // dtgTimKiemNV
            // 
            this.dtgTimKiemNV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgTimKiemNV.Location = new System.Drawing.Point(12, 88);
            this.dtgTimKiemNV.Name = "dtgTimKiemNV";
            this.dtgTimKiemNV.Size = new System.Drawing.Size(681, 341);
            this.dtgTimKiemNV.TabIndex = 3;
            // 
            // rdbMaNV
            // 
            this.rdbMaNV.AutoSize = true;
            this.rdbMaNV.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbMaNV.Location = new System.Drawing.Point(100, 59);
            this.rdbMaNV.Name = "rdbMaNV";
            this.rdbMaNV.Size = new System.Drawing.Size(108, 23);
            this.rdbMaNV.TabIndex = 4;
            this.rdbMaNV.TabStop = true;
            this.rdbMaNV.Text = "Mã nhân viên";
            this.rdbMaNV.UseVisualStyleBackColor = true;
            this.rdbMaNV.CheckedChanged += new System.EventHandler(this.rdbMaNV_CheckedChanged);
            // 
            // rdbCCCD
            // 
            this.rdbCCCD.AutoSize = true;
            this.rdbCCCD.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbCCCD.Location = new System.Drawing.Point(254, 59);
            this.rdbCCCD.Name = "rdbCCCD";
            this.rdbCCCD.Size = new System.Drawing.Size(71, 23);
            this.rdbCCCD.TabIndex = 5;
            this.rdbCCCD.TabStop = true;
            this.rdbCCCD.Text = "CCCD";
            this.rdbCCCD.UseVisualStyleBackColor = true;
            this.rdbCCCD.CheckedChanged += new System.EventHandler(this.rdbCCCD_CheckedChanged);
            // 
            // btnALL
            // 
            this.btnALL.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnALL.Location = new System.Drawing.Point(522, 53);
            this.btnALL.Name = "btnALL";
            this.btnALL.Size = new System.Drawing.Size(113, 29);
            this.btnALL.TabIndex = 6;
            this.btnALL.Text = "Hiển thị tất cả";
            this.btnALL.UseVisualStyleBackColor = true;
            this.btnALL.Click += new System.EventHandler(this.btnALL_Click);
            // 
            // rdbTenNV
            // 
            this.rdbTenNV.AutoSize = true;
            this.rdbTenNV.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbTenNV.Location = new System.Drawing.Point(369, 59);
            this.rdbTenNV.Name = "rdbTenNV";
            this.rdbTenNV.Size = new System.Drawing.Size(110, 23);
            this.rdbTenNV.TabIndex = 7;
            this.rdbTenNV.TabStop = true;
            this.rdbTenNV.Text = "Tên nhân viên";
            this.rdbTenNV.UseVisualStyleBackColor = true;
            this.rdbTenNV.CheckedChanged += new System.EventHandler(this.rdbTenNV_CheckedChanged);
            // 
            // frmTimKiemNV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(705, 441);
            this.Controls.Add(this.rdbTenNV);
            this.Controls.Add(this.btnALL);
            this.Controls.Add(this.rdbCCCD);
            this.Controls.Add(this.rdbMaNV);
            this.Controls.Add(this.dtgTimKiemNV);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.txtThongTin);
            this.Controls.Add(this.label1);
            this.Name = "frmTimKiemNV";
            this.Text = "TimKiemNV";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dtgTimKiemNV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtThongTin;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.DataGridView dtgTimKiemNV;
        private System.Windows.Forms.RadioButton rdbMaNV;
        private System.Windows.Forms.RadioButton rdbCCCD;
        private System.Windows.Forms.Button btnALL;
        private System.Windows.Forms.RadioButton rdbTenNV;
    }
}
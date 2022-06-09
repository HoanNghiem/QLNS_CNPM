
namespace QLNS_CNPM
{
    partial class frmBaoCaoLuongNV
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.tblHoSoNVBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSetBaoCaoLuong = new QLNS_CNPM.DataSetBaoCaoLuong();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbMaBoPhan = new System.Windows.Forms.ComboBox();
            this.tblBoPhanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new QLNS_CNPM.DataSet1();
            this.tblHoSoNVTableAdapter = new QLNS_CNPM.DataSetBaoCaoLuongTableAdapters.tblHoSoNVTableAdapter();
            this.tblBoPhanTableAdapter = new QLNS_CNPM.DataSet1TableAdapters.tblBoPhanTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.tblHoSoNVBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetBaoCaoLuong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblBoPhanBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // tblHoSoNVBindingSource
            // 
            this.tblHoSoNVBindingSource.DataMember = "tblHoSoNV";
            this.tblHoSoNVBindingSource.DataSource = this.DataSetBaoCaoLuong;
            // 
            // DataSetBaoCaoLuong
            // 
            this.DataSetBaoCaoLuong.DataSetName = "DataSetBaoCaoLuong";
            this.DataSetBaoCaoLuong.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            reportDataSource1.Name = "DatasetBaoCaoLuongNV";
            reportDataSource1.Value = this.tblHoSoNVBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "QLNS_CNPM.BaoCaoLuongNV.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(1, 68);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(703, 371);
            this.reportViewer1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 19);
            this.label2.TabIndex = 5;
            this.label2.Text = "Mã bộ phận:";
            // 
            // cmbMaBoPhan
            // 
            this.cmbMaBoPhan.DataSource = this.tblBoPhanBindingSource;
            this.cmbMaBoPhan.DisplayMember = "MaBoPhan";
            this.cmbMaBoPhan.FormattingEnabled = true;
            this.cmbMaBoPhan.Location = new System.Drawing.Point(104, 22);
            this.cmbMaBoPhan.Name = "cmbMaBoPhan";
            this.cmbMaBoPhan.Size = new System.Drawing.Size(134, 21);
            this.cmbMaBoPhan.TabIndex = 4;
            this.cmbMaBoPhan.SelectedIndexChanged += new System.EventHandler(this.cmbMaBoPhan_SelectedIndexChanged);
            // 
            // tblBoPhanBindingSource
            // 
            this.tblBoPhanBindingSource.DataMember = "tblBoPhan";
            this.tblBoPhanBindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblHoSoNVTableAdapter
            // 
            this.tblHoSoNVTableAdapter.ClearBeforeFill = true;
            // 
            // tblBoPhanTableAdapter
            // 
            this.tblBoPhanTableAdapter.ClearBeforeFill = true;
            // 
            // frmBaoCaoLuongNV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(705, 441);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbMaBoPhan);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frmBaoCaoLuongNV";
            this.Text = "frmBaoCaoLuongNV";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmBaoCaoLuongNV_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tblHoSoNVBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetBaoCaoLuong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblBoPhanBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbMaBoPhan;
        private System.Windows.Forms.BindingSource tblHoSoNVBindingSource;
        private DataSetBaoCaoLuong DataSetBaoCaoLuong;
        private DataSetBaoCaoLuongTableAdapters.tblHoSoNVTableAdapter tblHoSoNVTableAdapter;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource tblBoPhanBindingSource;
        private DataSet1TableAdapters.tblBoPhanTableAdapter tblBoPhanTableAdapter;
    }
}
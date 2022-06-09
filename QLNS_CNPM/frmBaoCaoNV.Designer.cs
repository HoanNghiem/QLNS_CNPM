
namespace QLNS_CNPM
{
    partial class frmBaoCaoNV
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
            this.DataSetBaoCao = new QLNS_CNPM.DataSetBaoCao();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.cmbMaBoPhan = new System.Windows.Forms.ComboBox();
            this.tblBoPhanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new QLNS_CNPM.DataSet1();
            this.label2 = new System.Windows.Forms.Label();
            this.tblHoSoNVTableAdapter = new QLNS_CNPM.DataSetBaoCaoTableAdapters.tblHoSoNVTableAdapter();
            this.tblBoPhanTableAdapter = new QLNS_CNPM.DataSet1TableAdapters.tblBoPhanTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.tblHoSoNVBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetBaoCao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblBoPhanBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // tblHoSoNVBindingSource
            // 
            this.tblHoSoNVBindingSource.DataMember = "tblHoSoNV";
            this.tblHoSoNVBindingSource.DataSource = this.DataSetBaoCao;
            // 
            // DataSetBaoCao
            // 
            this.DataSetBaoCao.DataSetName = "DataSetBaoCao";
            this.DataSetBaoCao.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            reportDataSource1.Name = "DataSetBaoCao";
            reportDataSource1.Value = this.tblHoSoNVBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "QLNS_CNPM.BaoCaoNV.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 64);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.ServerReport.ReportServerUrl = new System.Uri("", System.UriKind.Relative);
            this.reportViewer1.Size = new System.Drawing.Size(711, 398);
            this.reportViewer1.TabIndex = 0;
            // 
            // cmbMaBoPhan
            // 
            this.cmbMaBoPhan.DataSource = this.tblBoPhanBindingSource;
            this.cmbMaBoPhan.DisplayMember = "MaBoPhan";
            this.cmbMaBoPhan.FormattingEnabled = true;
            this.cmbMaBoPhan.Location = new System.Drawing.Point(104, 20);
            this.cmbMaBoPhan.Name = "cmbMaBoPhan";
            this.cmbMaBoPhan.Size = new System.Drawing.Size(134, 21);
            this.cmbMaBoPhan.TabIndex = 2;
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "Mã bộ phận:";
            // 
            // tblHoSoNVTableAdapter
            // 
            this.tblHoSoNVTableAdapter.ClearBeforeFill = true;
            // 
            // tblBoPhanTableAdapter
            // 
            this.tblBoPhanTableAdapter.ClearBeforeFill = true;
            // 
            // frmBaoCaoNV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 462);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbMaBoPhan);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frmBaoCaoNV";
            this.Text = "Báo cáo nhân viên";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmBaoCaoNV_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tblHoSoNVBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetBaoCao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblBoPhanBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.ComboBox cmbMaBoPhan;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource tblHoSoNVBindingSource;
        private DataSetBaoCao DataSetBaoCao;
        private DataSetBaoCaoTableAdapters.tblHoSoNVTableAdapter tblHoSoNVTableAdapter;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource tblBoPhanBindingSource;
        private DataSet1TableAdapters.tblBoPhanTableAdapter tblBoPhanTableAdapter;
    }
}


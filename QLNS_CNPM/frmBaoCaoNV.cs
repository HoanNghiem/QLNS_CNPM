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
    public partial class frmBaoCaoNV : Form
    {
        public frmBaoCaoNV()
        {
            InitializeComponent();
        }

        private void frmBaoCaoNV_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.tblBoPhan' table. You can move, or remove it, as needed.
            this.tblBoPhanTableAdapter.Fill(this.dataSet1.tblBoPhan);

            this.reportViewer1.RefreshReport();
        }

        private void cmbMaBoPhan_SelectedIndexChanged(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DataSetBaoCao.tblHoSoNV' table. You can move, or remove it, as needed.
            this.tblHoSoNVTableAdapter.Fill(this.DataSetBaoCao.tblHoSoNV,cmbMaBoPhan.Text);

            this.reportViewer1.RefreshReport();

        }
    }
}

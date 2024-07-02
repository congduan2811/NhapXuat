using NhapXuatMT.Common;
using NhapXuatMT.Data;
using NhapXuatMT.IO;
using System;
using System.Windows.Forms;

namespace NhapXuatMT.UI
{
    public partial class frmPhieuNhap : Form
    {
        private IPHIEUNHAPRepository _PHIEUNHAPRepository { get; set; }
        private ICHITIETPHIEUNHAPRepository _CHITIETPHIEUNHAPRepository { get; set; }

        public frmPhieuNhap()
        {
            _PHIEUNHAPRepository = new SQLPHIEUNHAPRepository(VariableSession.ConnectString);
            _CHITIETPHIEUNHAPRepository = new SQLCHITIETPHIEUNHAPRepository(VariableSession.ConnectString);
            InitializeComponent();
        }

        private void frmPhieuNhap_Load(object sender, EventArgs e)
        {
            dgrvDsNhap.DataSource = _PHIEUNHAPRepository.GetAll();
            dgrvDsNhap.Columns["CHITIETPHIEUNHAPs"].Visible = false;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            var frm = new frmPhieuNhapChiTiet();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                dgrvDsNhap.DataSource = _PHIEUNHAPRepository.GetAll();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgrvDsNhap.CurrentRow == null) return;

            var auditOrder = (PHIEUNHAP)dgrvDsNhap.CurrentRow.DataBoundItem;

            if (auditOrder.IDPHIEUNHAP > 0)
            {
                _PHIEUNHAPRepository.Delete(auditOrder.IDPHIEUNHAP);
                frmPhieuNhap_Load(null, null);
            }
            else
            {
                MessageBox.Show("Không có dữ liệu để xóa");
            }
        }

        private void dgrvDsNhap_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (dgrvDsNhap.CurrentRow == null) return;

            var auditOrder = (PHIEUNHAP)dgrvDsNhap.CurrentRow.DataBoundItem;

            if (auditOrder.IDPHIEUNHAP > 0)
            {
                var frm = new frmPhieuNhapChiTiet(auditOrder.IDPHIEUNHAP);
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    dgrvDsNhap.DataSource = _PHIEUNHAPRepository.GetAll();
                }
            }
            else
            {
                MessageBox.Show("Không có dữ liệu để sửa");
            }
        }
    }
}

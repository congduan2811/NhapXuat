using NhapXuatMT.Common;
using NhapXuatMT.Data;
using NhapXuatMT.IO;
using System;
using System.Windows.Forms;

namespace NhapXuatMT.UI
{
    public partial class frmPhieuNhap : Form
    {
        private PHIEUNHAPRepository _PHIEUNHAPRepository { get; set; }
        private CHITIETPHIEUNHAPRepository _CHITIETPHIEUNHAPRepository { get; set; }

        public frmPhieuNhap()
        {
            _PHIEUNHAPRepository = new PHIEUNHAPRepository(VariableSession.db);
            _CHITIETPHIEUNHAPRepository = new CHITIETPHIEUNHAPRepository(VariableSession.db);
            InitializeComponent();
        }

        private void frmPhieuNhap_Load(object sender, EventArgs e)
        {
            dgrvDsNhap.DataSource = _PHIEUNHAPRepository.GetAll();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            var frm = new frmPhieuNhapChiTiet();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                dgrvDsNhap.DataSource = _PHIEUNHAPRepository.GetAll();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dgrvDsNhap.SelectedRows.Count > 0)
            {
                var IDPHIEUNHAP = Convert.ToInt32(dgrvDsNhap.SelectedRows[0].Cells["IDPHIEUNHAP"].Value);
                var frm = new frmPhieuNhapChiTiet(IDPHIEUNHAP);
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

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgrvDsNhap.CurrentRow == null) return;

            var auditOrder = (PHIEUNHAP)dgrvDsNhap.CurrentRow.DataBoundItem;

            if (auditOrder.IDPHIEUNHAP > 0)
            {
                _PHIEUNHAPRepository.Delete(auditOrder.IDPHIEUNHAP);

                foreach (var item in _CHITIETPHIEUNHAPRepository.GetAll(auditOrder.IDPHIEUNHAP))
                {
                    _CHITIETPHIEUNHAPRepository.Delete(item.IDCHITIETPHIEUNHAP);
                }
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

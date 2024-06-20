using NhapXuatMT.Common;
using NhapXuatMT.Data;
using NhapXuatMT.IO;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace NhapXuatMT.UI
{
    public partial class frmPhieuNhapChiTiet : Form
    {
        private int IDPHIEUNHAP { get; set; }
        private PHIEUNHAPRepository _PHIEUNHAPRepository { get; set; }
        private CHITIETPHIEUNHAPRepository _CHITIETPHIEUNHAPRepository { get; set; }
        private List<CHITIETPHIEUNHAP> cHITIETPHIEUNHAPs { get; set; }
        public frmPhieuNhapChiTiet()
        {
            InitializeComponent();
             _PHIEUNHAPRepository = new PHIEUNHAPRepository(VariableSession.db);
            _CHITIETPHIEUNHAPRepository = new CHITIETPHIEUNHAPRepository(VariableSession.db);
        }

        public frmPhieuNhapChiTiet(int IDPHIEUNHAP)
        {
            InitializeComponent();
            this.IDPHIEUNHAP = IDPHIEUNHAP;
            _PHIEUNHAPRepository = new PHIEUNHAPRepository(VariableSession.db);
            _CHITIETPHIEUNHAPRepository = new CHITIETPHIEUNHAPRepository(VariableSession.db);
        }

        private void frmPhieuNhapChiTiet_Load(object sender, EventArgs e)
        {
            PHIEUNHAP phieuNhap;
            if (IDPHIEUNHAP > 0)
            {
                phieuNhap = _PHIEUNHAPRepository.GetByID(IDPHIEUNHAP);
            }
            else
            {
                phieuNhap = new PHIEUNHAP();
            }
            txtIDPhieuNhap.Text = phieuNhap.IDPHIEUNHAP.ToString();
            dtpkNgayNhap.Value = phieuNhap.NGAYNHAP ?? DateTime.Now;
            dtpkNgayDuTru.Value = phieuNhap.NGAYDUTRU ?? DateTime.Now;
            txtNVgiao.Text = phieuNhap.TENNHANVIENGIAO;
            txtNCC.Text = phieuNhap.TENNHACUNGCAP;
            txtNguoiLapPhieu.Text = phieuNhap.NGUOILAPPHIEU;

            ////
            if (IDPHIEUNHAP > 0)
            {
                cHITIETPHIEUNHAPs = _CHITIETPHIEUNHAPRepository.GetAll(IDPHIEUNHAP);
            }
            else
                cHITIETPHIEUNHAPs = new List<CHITIETPHIEUNHAP>();

            dgrvChiTietPhieuNhap.DataSource = cHITIETPHIEUNHAPs;

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            var frm = new frmPhieuNhapDetails();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                cHITIETPHIEUNHAPs.Add(frm.cHITIETPHIEUNHAP);
            }
            dgrvChiTietPhieuNhap.DataSource = null;
            dgrvChiTietPhieuNhap.DataSource = cHITIETPHIEUNHAPs;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            PHIEUNHAP phieuNhap = new PHIEUNHAP();
            List<CHITIETPHIEUNHAP> phieuNhapChiTiets = new List<CHITIETPHIEUNHAP>();

            phieuNhap.NGAYNHAP = dtpkNgayNhap.Value;
            phieuNhap.NGAYDUTRU = dtpkNgayDuTru.Value;
            phieuNhap.TENNHANVIENGIAO = txtNVgiao.Text;
            phieuNhap.TENNHACUNGCAP = txtNCC.Text;
            phieuNhap.NGUOILAPPHIEU = txtNguoiLapPhieu.Text;

            _PHIEUNHAPRepository.Insert(phieuNhap);
            foreach (var item in cHITIETPHIEUNHAPs)
            {
                item.IDPHIEUNHAP = phieuNhap.IDPHIEUNHAP;
                _CHITIETPHIEUNHAPRepository.Insert(item);
            }

            this.DialogResult = DialogResult.OK;
        }
    }
}

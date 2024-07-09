using NhapXuatMT.Common;
using NhapXuatMT.Data;
using NhapXuatMT.IO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;
using CsvHelper;
using System.Configuration;

namespace NhapXuatMT.UI
{
    public partial class frmPhieuNhapChiTiet : Form
    {
        public bool isFlagDataCSV = bool.Parse(ConfigurationManager.AppSettings["IsFlagDataCSV"]);

        public bool IsFlagDataCSV { get; set; } = true;


        private int IDPHIEUNHAP { get; set; }
        private IPHIEUNHAPRepository _PHIEUNHAPRepository { get; set; }
        private ICHITIETPHIEUNHAPRepository _CHITIETPHIEUNHAPRepository { get; set; }
        private List<CHITIETPHIEUNHAP> cHITIETPHIEUNHAPs { get; set; }
        public frmPhieuNhapChiTiet()
        {
           

            InitializeComponent();

            if (isFlagDataCSV)
            {

                _PHIEUNHAPRepository = new CSVPHIEUNHAPRepository(VariableSession.Root);
                _CHITIETPHIEUNHAPRepository = new CSVCHITIETPHIEUNHAPRepository(VariableSession.Root);
            }
            else
            {
                _PHIEUNHAPRepository = new CSVPHIEUNHAPRepository(VariableSession.ConnectString);
                _CHITIETPHIEUNHAPRepository = new CSVCHITIETPHIEUNHAPRepository(VariableSession.ConnectString);
            }

            // _PHIEUNHAPRepository = new CSVPHIEUNHAPRepository(VariableSession.Root);
            //_CHITIETPHIEUNHAPRepository = new CSVCHITIETPHIEUNHAPRepository(VariableSession.Root);
        }

        public frmPhieuNhapChiTiet(int IDPHIEUNHAP)
        {
           
            InitializeComponent();
            if (isFlagDataCSV)
            {

                _PHIEUNHAPRepository = new CSVPHIEUNHAPRepository(VariableSession.Root);
                _CHITIETPHIEUNHAPRepository = new CSVCHITIETPHIEUNHAPRepository(VariableSession.Root);
            }
            else
            {
                _PHIEUNHAPRepository = new CSVPHIEUNHAPRepository(VariableSession.ConnectString);
                _CHITIETPHIEUNHAPRepository = new CSVCHITIETPHIEUNHAPRepository(VariableSession.ConnectString);
            }

            this.IDPHIEUNHAP = IDPHIEUNHAP;
            //_PHIEUNHAPRepository = new CSVPHIEUNHAPRepository(VariableSession.Root);
            //_CHITIETPHIEUNHAPRepository = new CSVCHITIETPHIEUNHAPRepository(VariableSession.Root);
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
            var frm = new frmPhieuNhapDetails(IDPHIEUNHAP);
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

            if(IDPHIEUNHAP > 0)
            {
                phieuNhap.IDPHIEUNHAP = IDPHIEUNHAP;
                _PHIEUNHAPRepository.Edit(phieuNhap);
            }
            else
            {
                _PHIEUNHAPRepository.Insert(phieuNhap);
            }
            
            foreach (var item in cHITIETPHIEUNHAPs)
            {
                item.IDPHIEUNHAP = phieuNhap.IDPHIEUNHAP;
                if(item.IDCHITIETPHIEUNHAP > 0)
                {
                    _CHITIETPHIEUNHAPRepository.Edit(item);
                }
                else
                {
                    _CHITIETPHIEUNHAPRepository.Insert(item);
                }
            }

            this.DialogResult = DialogResult.OK;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dgrvChiTietPhieuNhap_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtNVgiao_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

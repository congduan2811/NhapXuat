using NhapXuatMT.Common;
using NhapXuatMT.Data;
using NhapXuatMT.IO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace NhapXuatMT.UI
{
    public partial class frmPhieuNhapChiTiet : Form
    {
        private int IDPHIEUNHAP { get; set; }
        private List<CHITIETPHIEUNHAP> cHITIETPHIEUNHAPs { get; set; }
        private string connectionString = @"Data Source= LAPTOP-LVS9DHPM\SQLEXPRESS;Initial Catalog=NHAPXUATMAYTINH;Integrated Security=True";
        //private int IDPHIEUNHAP { get; set; }
        //private PHIEUNHAPRepository _PHIEUNHAPRepository { get; set; }
        //private CHITIETPHIEUNHAPRepository _CHITIETPHIEUNHAPRepository { get; set; }
        //private List<CHITIETPHIEUNHAP> cHITIETPHIEUNHAPs { get; set; }
        public frmPhieuNhapChiTiet()
        {
            InitializeComponent();
            // _PHIEUNHAPRepository = new PHIEUNHAPRepository(VariableSession.db);
            //_CHITIETPHIEUNHAPRepository = new CHITIETPHIEUNHAPRepository(VariableSession.db);
        }

        //public frmPhieuNhapChiTiet(int IDPHIEUNHAP)
        //{
        //    InitializeComponent();
        //    this.IDPHIEUNHAP = IDPHIEUNHAP;
        //    _PHIEUNHAPRepository = new PHIEUNHAPRepository(VariableSession.db);
        //    _CHITIETPHIEUNHAPRepository = new CHITIETPHIEUNHAPRepository(VariableSession.db);
        //}
        public frmPhieuNhapChiTiet(int IDPHIEUNHAP)
        {
            InitializeComponent();
            this.IDPHIEUNHAP = IDPHIEUNHAP;
        }
        private void frmPhieuNhapChiTiet_Load(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand("SELECT * FROM PHIEUNHAP WHERE IDPHIEUNHAP = @IDPHIEUNHAP", connection))
                {
                    command.Parameters.AddWithValue("@IDPHIEUNHAP", IDPHIEUNHAP);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            PHIEUNHAP phieuNhap = new PHIEUNHAP();

                            phieuNhap.IDPHIEUNHAP = (int)reader["IDPHIEUNHAP"];
                            txtIDPhieuNhap.Text = phieuNhap.IDPHIEUNHAP.ToString();
                        }
                    }
                }

                if (IDPHIEUNHAP > 0)
                {
                    using (SqlCommand command = new SqlCommand("SELECT * FROM CHITIETPHIEUNHAP WHERE IDPHIEUNHAP = @IDPHIEUNHAP", connection))
                    {
                        command.Parameters.AddWithValue("@IDPHIEUNHAP", IDPHIEUNHAP);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            cHITIETPHIEUNHAPs = new List<CHITIETPHIEUNHAP>();

                            while (reader.Read())
                            {
                                CHITIETPHIEUNHAP chitietPhieuNhap = new CHITIETPHIEUNHAP();

                                chitietPhieuNhap.IDCHITIETPHIEUNHAP = (int)reader["IDCHITIETPHIEUNHAP"];
                                chitietPhieuNhap.IDPHIEUNHAP = (int)reader["IDPHIEUNHAP"];
                                // Set other properties of chitietPhieuNhap

                                cHITIETPHIEUNHAPs.Add(chitietPhieuNhap);
                            }
                        }
                    }
                }
            }

            dgrvChiTietPhieuNhap.DataSource = cHITIETPHIEUNHAPs;
            //PHIEUNHAP phieuNhap;
            //if (IDPHIEUNHAP > 0)
            //{
            //    phieuNhap = _PHIEUNHAPRepository.GetByID(IDPHIEUNHAP);
            //}
            //else
            //{
            //    phieuNhap = new PHIEUNHAP();
            //}
            //txtIDPhieuNhap.Text = phieuNhap.IDPHIEUNHAP.ToString();
            //dtpkNgayNhap.Value = phieuNhap.NGAYNHAP ?? DateTime.Now;
            //dtpkNgayDuTru.Value = phieuNhap.NGAYDUTRU ?? DateTime.Now;
            //txtNVgiao.Text = phieuNhap.TENNHANVIENGIAO;
            //txtNCC.Text = phieuNhap.TENNHACUNGCAP;
            //txtNguoiLapPhieu.Text = phieuNhap.NGUOILAPPHIEU;

            //////
            //if (IDPHIEUNHAP > 0)
            //{
            //    cHITIETPHIEUNHAPs = _CHITIETPHIEUNHAPRepository.GetAll(IDPHIEUNHAP);
            //}
            //else
            //    cHITIETPHIEUNHAPs = new List<CHITIETPHIEUNHAP>();

            //dgrvChiTietPhieuNhap.DataSource = cHITIETPHIEUNHAPs;

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
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                PHIEUNHAP phieuNhap = new PHIEUNHAP();

                phieuNhap.IDPHIEUNHAP = IDPHIEUNHAP;
                if (IDPHIEUNHAP > 0)
                {
                    using (SqlCommand command = new SqlCommand(@"UPDATE PHIEUNHAP SET
                                NGAYNHAP=@NGAYNHAP,
                                NGAYDUTRU=@NGAYDUTRU,
                                TENNHANVIENGIAO=@TENNHANVIENGIAO,
                                TENNHACUNGCAP=@TENNHACUNGCAP,
                                NGUOILAPPHIEU=@NGUOILAPPHIEU
                                WHERE IDPHIEUNHAP = @IDPHIEUNHAP", connection))
                    {
                        command.Parameters.AddWithValue("@IDPHIEUNHAP", IDPHIEUNHAP);
                        command.Parameters.AddWithValue("@NGAYNHAP", dtpkNgayNhap.Value);
                        command.Parameters.AddWithValue("@NGAYDUTRU", dtpkNgayDuTru.Value);
                        command.Parameters.AddWithValue("@TENNHANVIENGIAO", txtNVgiao.Text);
                        command.Parameters.AddWithValue("@TENNHACUNGCAP", txtNCC.Text);
                        command.Parameters.AddWithValue("@NGUOILAPPHIEU", txtNguoiLapPhieu.Text);
                        command.ExecuteNonQuery();
                    }
                }
                

                foreach (var item in cHITIETPHIEUNHAPs)
                {
                    item.IDPHIEUNHAP = phieuNhap.IDPHIEUNHAP;

                    if (item.IDCHITIETPHIEUNHAP > 0)
                    {
                        using (SqlCommand command = new SqlCommand("UPDATE CHITIETPHIEUNHAP SET TENSANPHAM = @TENSANPHAM,IDSANPHAM=@IDSANPHAM,DONVITINH=@DONVITINH,SOLUONGDUTRU=@SOLUONGDUTRU,SOLUONGTHUCTE=@SOLUONGTHUCTE WHERE IDCHITIETPHIEUNHAP = @IDCHITIETPHIEUNHAP", connection))
                        {
                            command.Parameters.AddWithValue("@IDCHITIETPHIEUNHAP", item.IDCHITIETPHIEUNHAP);
                            command.Parameters.AddWithValue("@IDPHIEUNHAP", IDPHIEUNHAP);
                            command.Parameters.AddWithValue("@TENSANPHAM", dtpkNgayNhap.Value);
                            command.Parameters.AddWithValue("@IDSANPHAM", dtpkNgayDuTru.Value);
                            command.Parameters.AddWithValue("@DONVITINH", txtNVgiao.Text);
                            command.Parameters.AddWithValue("@SOLUONGDUTRU", txtNCC.Text);
                            command.Parameters.AddWithValue("@SOLUONGTHUCTE", txtNguoiLapPhieu.Text);

                            command.ExecuteNonQuery();
                        }
                    }
                    else
                    {
                        using (SqlCommand command = new SqlCommand("INSERT INTO CHITIETPHIEUNHAP (TENSANPHAM, IDSANPHAM, DONVITINH, SOLUONGDUTRU, SOLUONGTHUCTE) VALUES (@TENSANPHAM, @IDSANPHAM, @DONVITINH, @SOLUONGDUTRU, @SOLUONGTHUCTE", connection))
                        {
                           
                            command.ExecuteNonQuery();
                        }
                    }
                }
            }

            this.DialogResult = DialogResult.OK;

            //PHIEUNHAP phieuNhap = new PHIEUNHAP();
            //List<CHITIETPHIEUNHAP> phieuNhapChiTiets = new List<CHITIETPHIEUNHAP>();

            //phieuNhap.NGAYNHAP = dtpkNgayNhap.Value;
            //phieuNhap.NGAYDUTRU = dtpkNgayDuTru.Value;
            //phieuNhap.TENNHANVIENGIAO = txtNVgiao.Text;
            //phieuNhap.TENNHACUNGCAP = txtNCC.Text;
            //phieuNhap.NGUOILAPPHIEU = txtNguoiLapPhieu.Text;

            //if(IDPHIEUNHAP > 0)
            //{
            //    phieuNhap.IDPHIEUNHAP = IDPHIEUNHAP;
            //    _PHIEUNHAPRepository.Edit(phieuNhap);
            //}
            //else
            //{
            //    _PHIEUNHAPRepository.Insert(phieuNhap);
            //}

            //foreach (var item in cHITIETPHIEUNHAPs)
            //{
            //    item.IDPHIEUNHAP = phieuNhap.IDPHIEUNHAP;
            //    if(item.IDCHITIETPHIEUNHAP > 0)
            //    {
            //        _CHITIETPHIEUNHAPRepository.Edit(item);
            //    }
            //    else
            //    {
            //        _CHITIETPHIEUNHAPRepository.Insert(item);
            //    }
            //}

            //this.DialogResult = DialogResult.OK;
        }

        private void dgrvChiTietPhieuNhap_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

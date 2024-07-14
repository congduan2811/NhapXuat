using NhapXuatMT.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NhapXuatMT.UI
{
    public partial class fmThongke : Form
    {
        private readonly Model1_db _dbContext;
        public fmThongke()
        {
            InitializeComponent();
            _dbContext = new Model1_db();
        }

       
        private void SUM()
        {
            DateTime ngayBatDau = dtp1.Value;
            DateTime ngayKetThuc = dtp2.Value;

            var totalQuantity = _dbContext.PHIEUNHAPs
                .Where(pn => pn.NGAYDUTRU >= ngayBatDau && pn.NGAYNHAP <= ngayKetThuc)
                .SelectMany(pn => pn.CHITIETPHIEUNHAPs)
                .Sum(ctpn => ctpn.SOLUONGTHUCTE);

            txtTongSL.Text = totalQuantity.ToString();
        }
        private void grpthongke_Enter(object sender, EventArgs e)
        {

        }

        private void fmThongke_Load(object sender, EventArgs e)
        {

        }

        private void btnThongke_Click_1(object sender, EventArgs e)
        {
            DateTime ngayBatDau = dtp1.Value;
            DateTime ngayKetThuc = dtp2.Value;
            if (ngayBatDau > ngayKetThuc)
            {
                MessageBox.Show("Ngày bắt đầu không được lớn hơn ngày kết thúc.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                if (rdbPN.Checked)
                {

                    var statistics = _dbContext.PHIEUNHAPs
                    .Where(pn => pn.NGAYDUTRU >= ngayBatDau && pn.NGAYNHAP <= ngayKetThuc)
                    .SelectMany(pn => pn.CHITIETPHIEUNHAPs)
                    .GroupBy(ctpn => new { ctpn.IDSANPHAM, ctpn.TENSANPHAM, ctpn.PHIEUNHAP.NGAYNHAP, ctpn.PHIEUNHAP.IDPHIEUNHAP, ctpn.PHIEUNHAP.NGUOILAPPHIEU, ctpn.PHIEUNHAP.TENNHACUNGCAP })
                    .Select(g => new
                    {
                        IDPHIEUNHAP = g.Key.IDPHIEUNHAP,
                        IDSANPHAM = g.Key.IDSANPHAM,
                        TENSANPHAM = g.Key.TENSANPHAM,
                        NhaCungCap = g.Key.TENNHACUNGCAP,
                        SoLuong = g.Sum(ctpn => ctpn.SOLUONGDUTRU),

                        NguoiLapPhieu = g.Key.NGUOILAPPHIEU,
                        NgayNhap = g.Key.NGAYNHAP,


                    }).ToList();

                    dgvTK.DataSource = statistics;
                    SUM();
                }
                else
                {
                    MessageBox.Show("chưa tích!");
                }
            }
        }
    }
}

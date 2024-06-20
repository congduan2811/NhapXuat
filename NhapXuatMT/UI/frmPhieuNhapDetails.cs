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
    public partial class frmPhieuNhapDetails : Form
    {
        public CHITIETPHIEUNHAP cHITIETPHIEUNHAP { get; set; }
        public frmPhieuNhapDetails()
        {
            InitializeComponent();
            cHITIETPHIEUNHAP = new CHITIETPHIEUNHAP();
        }

        private void btnThemCTPN_Click(object sender, EventArgs e)
        {
            cHITIETPHIEUNHAP.TENSANPHAM = txtTenSP.Text;
            cHITIETPHIEUNHAP.IDSANPHAM = Convert.ToInt32(txtIDSP.Text);
            cHITIETPHIEUNHAP.DONVITINH = txtDVT.Text;
            cHITIETPHIEUNHAP.SOLUONGDUTRU = Convert.ToInt32(txtSLDT.Text);
            cHITIETPHIEUNHAP.SOLUONGTHUCTE = Convert.ToInt32(txtSLTT.Text);

            this.DialogResult = DialogResult.OK;
        }
    }
}

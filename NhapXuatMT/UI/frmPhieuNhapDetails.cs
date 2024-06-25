using NhapXuatMT.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
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
        private string connectionString = ConfigurationManager.ConnectionStrings["Model1"].ToString();
        //public CHITIETPHIEUNHAP cHITIETPHIEUNHAP { get; set; }
        public frmPhieuNhapDetails()
        {
            InitializeComponent();
            cHITIETPHIEUNHAP = new CHITIETPHIEUNHAP();
        }

        public frmPhieuNhapDetails(int IDPHIEUNHAP)
        {
            InitializeComponent();
            cHITIETPHIEUNHAP = new CHITIETPHIEUNHAP() {IDPHIEUNHAP = IDPHIEUNHAP };
        }

        private void btnThemCTPN_Click(object sender, EventArgs e)
        {

            cHITIETPHIEUNHAP.TENSANPHAM = txtTenSP.Text;
            cHITIETPHIEUNHAP.IDSANPHAM = Convert.ToInt32(txtIDSP.Text);
            cHITIETPHIEUNHAP.DONVITINH = txtDVT.Text;
            cHITIETPHIEUNHAP.SOLUONGDUTRU = Convert.ToInt32(txtSLDT.Text);
            cHITIETPHIEUNHAP.SOLUONGTHUCTE = Convert.ToInt32(txtSLTT.Text);


            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                if (cHITIETPHIEUNHAP.IDCHITIETPHIEUNHAP > 0)
                {
                    using (SqlCommand command = new SqlCommand("UPDATE CHITIETPHIEUNHAP SET IDPHIEUNHAP=@IDPHIEUNHAP, TENSANPHAM = @TENSANPHAM, IDSANPHAM = @IDSANPHAM, DONVITINH = @DONVITINH, SOLUONGDUTRU = @SOLUONGDUTRU, SOLUONGTHUCTE = @SOLUONGTHUCTE WHERE IDCHITIETPHIEUNHAP = @IDCHITIETPHIEUNHAP", connection))
                    {
                        //command.Parameters.AddWithValue("@IDCHITIETPHIEUNHAP", cHITIETPHIEUNHAP.IDCHITIETPHIEUNHAP);
                        command.Parameters.AddWithValue("@IDPHIEUNHAP", cHITIETPHIEUNHAP.IDPHIEUNHAP);
                        command.Parameters.AddWithValue("@TENSANPHAM", cHITIETPHIEUNHAP.TENSANPHAM);
                        command.Parameters.AddWithValue("@IDSANPHAM", cHITIETPHIEUNHAP.IDSANPHAM);
                        command.Parameters.AddWithValue("@DONVITINH", cHITIETPHIEUNHAP.DONVITINH);
                        command.Parameters.AddWithValue("@SOLUONGDUTRU", cHITIETPHIEUNHAP.SOLUONGDUTRU);
                        command.Parameters.AddWithValue("@SOLUONGTHUCTE", cHITIETPHIEUNHAP.SOLUONGTHUCTE);

                        command.ExecuteNonQuery();
                    }
                }
                else
                {
                    using (SqlCommand command = new SqlCommand("INSERT INTO CHITIETPHIEUNHAP (IDPHIEUNHAP,TENSANPHAM, IDSANPHAM, DONVITINH, SOLUONGDUTRU, SOLUONGTHUCTE) VALUES (@IDPHIEUNHAP,@TENSANPHAM, @IDSANPHAM, @DONVITINH, @SOLUONGDUTRU, @SOLUONGTHUCTE)", connection))
                    {

                        command.Parameters.AddWithValue("@IDPHIEUNHAP", cHITIETPHIEUNHAP.IDPHIEUNHAP);
                        command.Parameters.AddWithValue("@TENSANPHAM", cHITIETPHIEUNHAP.TENSANPHAM);
                        command.Parameters.AddWithValue("@IDSANPHAM", cHITIETPHIEUNHAP.IDSANPHAM);
                        command.Parameters.AddWithValue("@DONVITINH", cHITIETPHIEUNHAP.DONVITINH);
                        command.Parameters.AddWithValue("@SOLUONGDUTRU", cHITIETPHIEUNHAP.SOLUONGDUTRU);
                        command.Parameters.AddWithValue("@SOLUONGTHUCTE", cHITIETPHIEUNHAP.SOLUONGTHUCTE);

                        command.ExecuteNonQuery();
                    }
                }
            }

            this.DialogResult = DialogResult.OK;

            //cHITIETPHIEUNHAP.TENSANPHAM = txtTenSP.Text;
            //cHITIETPHIEUNHAP.IDSANPHAM = Convert.ToInt32(txtIDSP.Text);
            //cHITIETPHIEUNHAP.DONVITINH = txtDVT.Text;
            //cHITIETPHIEUNHAP.SOLUONGDUTRU = Convert.ToInt32(txtSLDT.Text);
            //cHITIETPHIEUNHAP.SOLUONGTHUCTE = Convert.ToInt32(txtSLTT.Text);

            //this.DialogResult = DialogResult.OK;
        }

        private void frmPhieuNhapDetails_Load(object sender, EventArgs e)
        {
            txtIDCTPN.Text = (cHITIETPHIEUNHAP.IDPHIEUNHAP??0).ToString();
        }

        private void txtSLTT_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDVT_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

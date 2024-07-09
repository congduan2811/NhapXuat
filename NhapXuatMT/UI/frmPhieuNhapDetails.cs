using NhapXuatMT.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
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
        public static string link = @"Data Source=LAPTOP-LVS9DHPM\SQLEXPRESS;Initial Catalog=NHAPXUATMAYTINH;Integrated Security=True";

        public CHITIETPHIEUNHAP cHITIETPHIEUNHAP { get; set; }
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
            cHITIETPHIEUNHAP.TENSANPHAM = cbTenSanPham.Text;
            cHITIETPHIEUNHAP.IDSANPHAM = Convert.ToInt32(txtIDSP.Text);
            cHITIETPHIEUNHAP.DONVITINH = txtDVT.Text;
            cHITIETPHIEUNHAP.SOLUONGDUTRU = Convert.ToInt32(txtSLDT.Text);
            cHITIETPHIEUNHAP.SOLUONGTHUCTE = Convert.ToInt32(txtSLTT.Text);

            this.DialogResult = DialogResult.OK;
        }

        private void frmPhieuNhapDetails_Load(object sender, EventArgs e)
        {
            txtIDCTPN.Text = (cHITIETPHIEUNHAP.IDPHIEUNHAP??0).ToString();


            LoadCB();
        }

        public void LoadCB()
        {
            using (SqlConnection connection = new SqlConnection(link))
            {
                connection.Open();
                string sql = "select ID, TenSanPham, DonViTinh from SanPham  ";
                SqlCommand command = new SqlCommand(sql, connection);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    cbTenSanPham.Items.Add(reader["TenSanPham"]);
                       


                }
                cbTenSanPham.SelectedIndexChanged += (sender, e) =>
                {

                    int selectedIndex = cbTenSanPham.SelectedIndex;
                    if(selectedIndex >=0 && selectedIndex < cbTenSanPham.Items.Count)
                    {
                        txtIDSP.Text = selectedIndex.ToString();
                        using (SqlConnection connections = new SqlConnection(link))
                        {
                            connections.Open();
                            string sqls = "SELECT DonViTinh FROM SanPham WHERE TenSanPham = @SelectedProduct";
                            SqlCommand commands = new SqlCommand(sqls, connections);
                            commands.Parameters.AddWithValue("@SelectedProduct", cbTenSanPham.SelectedItem.ToString());

                            SqlDataReader readers = commands.ExecuteReader();
                            if (readers.Read())
                            {
                                txtDVT.Text = readers["DonViTinh"].ToString();
                            }
                            readers.Close();

                        }
                      
                    }
                };
            }
        }

    }
}

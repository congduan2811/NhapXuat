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
        
        private List<NV> sanPhamList = new List<NV>();

      
        private void PopulateComboBoxes()
        {
            try
            {

            
            using (var context = new Model1_db())
            {
                sanPhamList = context.NVs.ToList();
            }
            cbID.Items.Clear();
            cbTenSanPham.Items.Clear();
                txtDVT.Text = "";


            foreach (var sanPham in sanPhamList)
            {
                cbID.Items.Add(sanPham.IDSANPHAM);
                cbTenSanPham.Items.Add(sanPham.TENSANPHAM);
                txtDVT.Text=(sanPham.DONVITINH);
            }

            cbID.SelectedIndex = 0;
            cbTenSanPham.SelectedIndex = 0;
                txtDVT.Text = "";
        }


            catch (Exception ex)
            {
               
                MessageBox.Show("An error occurred while populating the ComboBoxes: " + ex.Message);
            }
        }

      







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
            cHITIETPHIEUNHAP.TENSANPHAM = cbTenSanPham.SelectedItem.ToString();
            cHITIETPHIEUNHAP.IDSANPHAM = Convert.ToInt32(cbID.SelectedItem.ToString());
            cHITIETPHIEUNHAP.DONVITINH = txtDVT.Text.ToString();
            cHITIETPHIEUNHAP.SOLUONGDUTRU = Convert.ToInt32(txtSLDT.Text);
            cHITIETPHIEUNHAP.SOLUONGTHUCTE = Convert.ToInt32(txtSLTT.Text);

            this.DialogResult = DialogResult.OK;
        }

        private void frmPhieuNhapDetails_Load(object sender, EventArgs e)
        {
            txtIDCTPN.Text = (cHITIETPHIEUNHAP.IDPHIEUNHAP??0).ToString();



            PopulateComboBoxes();
        }

     

        private void txtDVT_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbID_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedID = (int)cbID.SelectedItem;

         
            NV selectedSanPham = sanPhamList.Find(sp => sp.IDSANPHAM == selectedID);

          
            cbTenSanPham.SelectedItem = selectedSanPham.TENSANPHAM;
            txtDVT.Text = selectedSanPham.DONVITINH;
        }

        private void cbTenSanPham_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedTenSP = cbTenSanPham.SelectedItem.ToString();
            NV selectedID = sanPhamList.Find(sp => sp.TENSANPHAM == selectedTenSP);
            cbID.SelectedItem = selectedID.IDSANPHAM;
            txtDVT.Text = selectedID.DONVITINH;
        }
    }
}

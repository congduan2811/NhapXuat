using NhapXuatMT.Common;
using NhapXuatMT.Data;
using NhapXuatMT.IO;
using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace NhapXuatMT.UI
{
    public partial class frmPhieuNhap : Form
    {

        private string _connectionString = ConfigurationManager.ConnectionStrings["Model1"].ToString();
        private PHIEUNHAPRepository _PHIEUNHAPRepository;
        private frmPhieuNhapChiTiet frmPhieuNhapChiTiet;
        //private PHIEUNHAPRepository _PHIEUNHAPRepository { get; set; }
        private CHITIETPHIEUNHAPRepository _CHITIETPHIEUNHAPRepository { get; set; }

        public frmPhieuNhap()
        {
            InitializeComponent();
            _PHIEUNHAPRepository = new PHIEUNHAPRepository(_connectionString);
            _CHITIETPHIEUNHAPRepository = new CHITIETPHIEUNHAPRepository(_connectionString);
            //_PHIEUNHAPRepository = new PHIEUNHAPRepository(VariableSession.db);
            //_CHITIETPHIEUNHAPRepository = new CHITIETPHIEUNHAPRepository(VariableSession.db);

        }

        private void frmPhieuNhap_Load(object sender, EventArgs e)
        {
    
            dgrvDsNhap.DataSource = _PHIEUNHAPRepository.GetAll();
            dgrvDsNhap.Columns["CHITIETPHIEUNHAPs"].Visible = false;
        }
        private void LoadPurchaseOrdersFromDatabase()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(_connectionString))
                {
                    connection.Open();
                    string query = "SELECT * FROM PHIEUNHAP";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    DataTable data = new DataTable();
                    adapter.Fill(data);
                    dgrvDsNhap.DataSource = data;
                    if(dgrvDsNhap.Columns["CHITIETPHIEUNHAPs"] != null)
                    dgrvDsNhap.Columns["CHITIETPHIEUNHAPs"].Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading purchase orders: {ex.Message}");
            }
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            using (var frmChiTietPhieuNhap = new frmPhieuNhapChiTiet())

            {
                if (frmChiTietPhieuNhap.ShowDialog() == DialogResult.OK)
                {
                    LoadPurchaseOrdersFromDatabase();
                }
            }
            //var frm = new frmPhieuNhapChiTiet();
            //if (frm.ShowDialog() == DialogResult.OK)
            //{
            //    dgrvDsNhap.DataSource = _PHIEUNHAPRepository.GetAll();
            //}
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgrvDsNhap.CurrentRow == null) return;

            int purchaseOrderId = (int)dgrvDsNhap.CurrentRow.Cells["IDPHIEUNHAP"].Value;

            try
            {
                using (SqlConnection connection = new SqlConnection(_connectionString))
                {
                    connection.Open();
                    string query = "DELETE FROM PHIEUNHAP WHERE IDPHIEUNHAP = @PurchaseOrderId";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@PurchaseOrderId", purchaseOrderId);
                    command.ExecuteNonQuery();
                }
                dgrvDsNhap.DataSource = _PHIEUNHAPRepository;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error deleting purchase order: {ex.Message}");
            }
            //if (dgrvDsNhap.CurrentRow == null) return;

            //var auditOrder = (PHIEUNHAP)dgrvDsNhap.CurrentRow.DataBoundItem;

            //if (auditOrder.IDPHIEUNHAP > 0)
            //{
            //    _PHIEUNHAPRepository.Delete(auditOrder.IDPHIEUNHAP);
            //    frmPhieuNhap_Load(null, null);
            //}
            //else
            //{
            //    MessageBox.Show("Không có dữ liệu để xóa");
            //}
        }

        private void dgrvDsNhap_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (dgrvDsNhap.CurrentRow == null) return;

            int purchaseOrderId = (int)dgrvDsNhap.CurrentRow.Cells["IDPHIEUNHAP"].Value;

            var frm = new frmPhieuNhapChiTiet(purchaseOrderId);
            if (frm.ShowDialog() == DialogResult.OK)
                NewMethod();

            //if (dgrvDsNhap.CurrentRow == null) return;

            //var auditOrder = (PHIEUNHAP)dgrvDsNhap.CurrentRow.DataBoundItem;

            //if (auditOrder.IDPHIEUNHAP > 0)
            //{
            //    var frm = new frmPhieuNhapChiTiet(auditOrder.IDPHIEUNHAP);
            //    if (frm.ShowDialog() == DialogResult.OK)
            //    {
            //        dgrvDsNhap.DataSource = _PHIEUNHAPRepository.GetAll();
            //    }
            //}
            //else
            //{
            //    MessageBox.Show("Không có dữ liệu để sửa");
            //}
        }

        private void NewMethod()
        {
            dgrvDsNhap.DataSource = _PHIEUNHAPRepository.GetAll();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dgrvDsNhap_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

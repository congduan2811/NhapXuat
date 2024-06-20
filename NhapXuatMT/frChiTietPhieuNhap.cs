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

namespace NhapXuatMT
{
    public partial class frChiTietPhieuNhap : Form
    {
        public string connectionString = @"Data Source= LAPTOP-LVS9DHPM\SQLEXPRESS;Initial Catalog=NHAPXUATMAYTINH;Integrated Security=True";
       
        public frChiTietPhieuNhap()
        {
            InitializeComponent();
            DisPlayDGVR();
            
        }
        public void DisPlayDGVR()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string selectQuery = "SELECT * FROM CHiTietPhieuNhap";
                SqlCommand command = new SqlCommand(selectQuery, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                dgrvChiTietPhieuNhap.DataSource = dataTable;
                connection.Close();
            }
        }
        private void frChiTietPhieuNhap_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'nHAPXUATMAYTINHDataSet.CHITIETPHIEUNHAP' table. You can move, or remove it, as needed.
            this.cHITIETPHIEUNHAPTableAdapter.Fill(this.nHAPXUATMAYTINHDataSet.CHITIETPHIEUNHAP);

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        public void LoadData()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string selectQuery = "SELECT * FROM CHiTietPhieuNhap";
                SqlCommand command = new SqlCommand(selectQuery, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                dgrvChiTietPhieuNhap.DataSource = dataTable;
                connection.Close();
            }
        }
   
        private void btnThem_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            try
            {
                connection.Open();

            
                string sql = "INSERT INTO PHIEUNHAP (IDPHIEUNHAP, NGAYNHAP, NGAYDUTRU, TENNHANVIENGIAO, TENNHACUNGCAP, NGUOILAPPHIEU) " +
                             "VALUES (@ID, @NgayNhap, @NgayDuTru, @TenNhanVienGiao, @TenNhaCungCap, @NguoiLapPhieu)";
                SqlCommand command = new SqlCommand(sql, connection);
                command.Parameters.AddWithValue("@ID", int.Parse(txtIDPhieuNhap.Text)); 
                command.Parameters.AddWithValue("@NgayNhap", dtpkNgayNhap.Value); 
                command.Parameters.AddWithValue("@NgayDuTru", dtpkNgayDuTru.Value);
                command.Parameters.AddWithValue("@TenNhanVienGiao", txtNVgiao.Text);
                command.Parameters.AddWithValue("@TenNhaCungCap", txtNCC.Text);
                command.Parameters.AddWithValue("@NguoiLapPhieu", txtNguoiLapPhieu.Text);       
                int rowsAffected = command.ExecuteNonQuery();

                MessageBox.Show("Thêm thành công !", "Thông báo");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error inserting data: " + ex.Message, "Lỗi");
            }
            finally
            {
                connection.Close();
            }
            frChiTietPhieuNhapThem frThem = new frChiTietPhieuNhapThem();
            frThem.ShowDialog();
          
        }

        private void btnThemCTPN_Click(object sender, EventArgs e)
        {

        }
    }
}

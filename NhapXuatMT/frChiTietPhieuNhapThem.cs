using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace NhapXuatMT
{
    public partial class frChiTietPhieuNhapThem : Form
    {
        public string connectionString = @"Data Source= LAPTOP-LVS9DHPM\SQLEXPRESS;Initial Catalog=NHAPXUATMAYTINH;Integrated Security=True";

        public frChiTietPhieuNhapThem()
        {
            InitializeComponent();
            LoadData();
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

        private void btnThemCTPN_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            try
            {
                connection.Open();
                string sql = "INSERT INTO ChiTietPhieuNhap (IDCHITIETPHIEUXUAT,IDPHIEUNHAP, TENSANPHAM, IDSANPHAM, DONVITINH, SOLUONGDUTRU, SOLUONGTHUCTE) " +
                             "VALUES (@IDCTPN,@ID, @TSP, @ISP, @DVT, @SLDT, @SLTT)";
                SqlCommand command = new SqlCommand(sql, connection);
                command.Parameters.AddWithValue("@IDCTPN", int.Parse(txtIDCTPN.Text));
                command.Parameters.AddWithValue("@ID", int.Parse(txtPN.Text));
                command.Parameters.AddWithValue("@TSP", txtTenSP.Text);
                command.Parameters.AddWithValue("@ISP", txtIDSP.Text);
                command.Parameters.AddWithValue("@DVT", txtDVT.Text);
                command.Parameters.AddWithValue("@SLDT", txtSLDT.Text);
                command.Parameters.AddWithValue("@SLTT", txtSLTT.Text);
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
        }

        private void frChiTietPhieuNhapThem_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'nHAPXUATMAYTINHDataSet2.CHITIETPHIEUNHAP' table. You can move, or remove it, as needed.
            this.cHITIETPHIEUNHAPTableAdapter1.Fill(this.nHAPXUATMAYTINHDataSet2.CHITIETPHIEUNHAP);
            // TODO: This line of code loads data into the 'nHAPXUATMAYTINHDataSet1.CHITIETPHIEUNHAP' table. You can move, or remove it, as needed.
            this.cHITIETPHIEUNHAPTableAdapter.Fill(this.nHAPXUATMAYTINHDataSet1.CHITIETPHIEUNHAP);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

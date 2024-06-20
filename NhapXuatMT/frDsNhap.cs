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
    public partial class frDsNhap : Form
    {
        public string connectionString = @"Data Source= LAPTOP-LVS9DHPM\SQLEXPRESS;Initial Catalog=NHAPXUATMAYTINH;Integrated Security=True";
        public frDsNhap()
        {
            InitializeComponent();
            DisPlayDGVR();
        }
        public void DisPlayDGVR()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string selectQuery = "SELECT * FROM PhieuNhap";
                SqlCommand command = new SqlCommand(selectQuery, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                dgrvDsNhap.DataSource = dataTable;
                connection.Close();
            }
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
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
                dgrvDsNhap.DataSource = dataTable;
                connection.Close();
            }
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dgrvDsNhap.SelectedRows.Count > 0)
            {
                int idPhieuNhap = Convert.ToInt32(dgrvDsNhap.SelectedRows[0].Cells["IDPHIEUNHAP"].Value);
                string maPhieuNhap = dgrvDsNhap.SelectedRows[0].Cells["MAPHIEUNHAP"].Value.ToString();
                DateTime ngayNhap = Convert.ToDateTime(dgrvDsNhap.SelectedRows[0].Cells["NGAYNHAP"].Value);
                DateTime ngayDuTru = Convert.ToDateTime(dgrvDsNhap.SelectedRows[0].Cells["NGAYDUTRU"].Value);
                string tenNhanVien = dgrvDsNhap.SelectedRows[0].Cells["TENNHANVIENGIAO"].Value.ToString();
                string tenNhaCungCap = dgrvDsNhap.SelectedRows[0].Cells["TENNHACUNGCAP"].Value.ToString();
                string nguoiLapPhieu = dgrvDsNhap.SelectedRows[0].Cells["NGUOILAPPHIEU"].Value.ToString();
                string connectionString = "YourConnectionString";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "UPDATE PHIEUNHAP SET IDPHIEUNHAP = @MaPhieuNhap, NGAYNHAP = @NgayNhap, NGAYDUTRU = @NgayDuTru, TENNHANVIENGIAO = @TenNhanVien, TENNHACUNGCAP = @TenNhaCungCap, NGUOILAPPHIEU = @NguoiLapPhieu WHERE IDPHIEUNHAP = @IdPhieuNhap";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@MaPhieuNhap", maPhieuNhap);
                        command.Parameters.AddWithValue("@NgayNhap", ngayNhap);
                        command.Parameters.AddWithValue("@NgayDuTru", ngayDuTru);
                        command.Parameters.AddWithValue("@TenNhanVien", tenNhanVien);
                        command.Parameters.AddWithValue("@TenNhaCungCap", tenNhaCungCap);
                        command.Parameters.AddWithValue("@NguoiLapPhieu", nguoiLapPhieu);
                        command.Parameters.AddWithValue("@IdPhieuNhap", idPhieuNhap);

                        command.ExecuteNonQuery();
                    }

                    connection.Close();
                }

                MessageBox.Show("Đã lưu thay đổi.", "Thông báo");
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một dòng để sửa.", "Thông báo");
            }
            LoadData();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            frChiTietPhieuNhap frCTPN = new frChiTietPhieuNhap();
            frCTPN.ShowDialog();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
           
           try
            {
                if (dgrvDsNhap.SelectedRows.Count > 0)
                {
                    int selectedRowIndex = dgrvDsNhap.SelectedRows[0].Index;
                    int id = Convert.ToInt32(dgrvDsNhap.Rows[selectedRowIndex].Cells["IDPHIEUNHAP"].Value);           
                    using (var connection = new SqlConnection(connectionString))
                    {
                        connection.Open();

                        string sql = "DELETE FROM PHIEUNHAP WHERE IDPHIEUNHAP = @ID";
                        SqlCommand command = new SqlCommand(sql, connection);
                        command.Parameters.AddWithValue("@ID", id);

                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Xóa thành công !", "Thông báo");
                        }
                        else
                        {
                            MessageBox.Show("Lỗi không xóa được !", "Thông báo");
                        }
                    }
                    LoadData();
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting data: " + ex.Message, "Lỗi");
            }
           
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
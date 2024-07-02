using NhapXuatMT.Data;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace NhapXuatMT.IO
{
    public class SQLCHITIETPHIEUNHAPRepository : ICHITIETPHIEUNHAPRepository
    {
        public string connectString { get; set; }
        public SQLCHITIETPHIEUNHAPRepository(string connectString)
        {
            this.connectString = connectString;
        }

        public bool Delete(int IDCHITIETPHIEUNHAP)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectString))
                {
                    connection.Open();
                    string query = "DELETE FROM CHITIETPHIEUNHAP WHERE IDCHITIETPHIEUNHAP = @PurchaseOrderId";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@PurchaseOrderId", IDCHITIETPHIEUNHAP);
                    command.ExecuteNonQuery();
                }
            }
            catch
            {

            }
            return true;
        }

        public bool Edit(CHITIETPHIEUNHAP item)
        {
            using (SqlConnection connection = new SqlConnection(connectString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand("UPDATE CHITIETPHIEUNHAP SET TENSANPHAM = @TENSANPHAM,IDSANPHAM=@IDSANPHAM,DONVITINH=@DONVITINH," +
                            "SOLUONGDUTRU=@SOLUONGDUTRU,SOLUONGTHUCTE=@SOLUONGTHUCTE WHERE IDCHITIETPHIEUNHAP = @IDCHITIETPHIEUNHAP", connection))
                {

                    command.Parameters.AddWithValue("@TENSANPHAM", item.TENSANPHAM);
                    command.Parameters.AddWithValue("@IDSANPHAM", item.IDSANPHAM);
                    command.Parameters.AddWithValue("@DONVITINH", item.DONVITINH);
                    command.Parameters.AddWithValue("@SOLUONGDUTRU", item.SOLUONGDUTRU);
                    command.Parameters.AddWithValue("@SOLUONGTHUCTE", item.SOLUONGTHUCTE);
                    command.Parameters.AddWithValue("@IDCHITIETPHIEUNHAP", item.IDCHITIETPHIEUNHAP);
                    command.ExecuteNonQuery();

                }
            }
            return true;
        }

        public List<CHITIETPHIEUNHAP> GetAll(int IDPHIEUNHAP)
        {
            var cHITIETPHIEUNHAPs = new List<CHITIETPHIEUNHAP>();
            using (SqlConnection connection = new SqlConnection(connectString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand("SELECT * FROM CHITIETPHIEUNHAP WHERE IDPHIEUNHAP = @IDPHIEUNHAP", connection))
                {
                    command.Parameters.AddWithValue("@IDPHIEUNHAP", IDPHIEUNHAP);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            CHITIETPHIEUNHAP chitietPhieuNhap = new CHITIETPHIEUNHAP();
                            chitietPhieuNhap.IDCHITIETPHIEUNHAP = (int)reader["IDCHITIETPHIEUNHAP"];
                            chitietPhieuNhap.IDPHIEUNHAP = (int)reader["IDPHIEUNHAP"];
                            chitietPhieuNhap.TENSANPHAM = (string)reader["TENSANPHAM"];
                            chitietPhieuNhap.IDSANPHAM = (int)reader["IDSANPHAM"];
                            chitietPhieuNhap.DONVITINH = (string)reader["DONVITINH"];
                            chitietPhieuNhap.SOLUONGDUTRU = (int)reader["SOLUONGDUTRU"];
                            chitietPhieuNhap.SOLUONGTHUCTE = (int)reader["SOLUONGTHUCTE"];
                            cHITIETPHIEUNHAPs.Add(chitietPhieuNhap);
                        }
                    }
                }
            }
            return cHITIETPHIEUNHAPs;
        }

        public CHITIETPHIEUNHAP GetByID(int IDCHITIETPHIEUNHAP)
        {
            var cHITIETPHIEUNHAP = new CHITIETPHIEUNHAP();
            using (SqlConnection connection = new SqlConnection(connectString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand("SELECT * FROM CHITIETPHIEUNHAP WHERE IDCHITIETPHIEUNHAP = @IDCHITIETPHIEUNHAP", connection))
                {
                    command.Parameters.AddWithValue("@IDCHITIETPHIEUNHAP", IDCHITIETPHIEUNHAP);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            cHITIETPHIEUNHAP.IDCHITIETPHIEUNHAP = (int)reader["IDCHITIETPHIEUNHAP"];
                            cHITIETPHIEUNHAP.IDPHIEUNHAP = (int)reader["IDPHIEUNHAP"];
                            cHITIETPHIEUNHAP.TENSANPHAM = (string)reader["TENSANPHAM"];
                            cHITIETPHIEUNHAP.IDSANPHAM = (int)reader["IDSANPHAM"];
                            cHITIETPHIEUNHAP.DONVITINH = (string)reader["DONVITINH"];
                            cHITIETPHIEUNHAP.SOLUONGDUTRU = (int)reader["SOLUONGDUTRU"];
                            cHITIETPHIEUNHAP.SOLUONGTHUCTE = (int)reader["SOLUONGTHUCTE"];
                        }
                    }
                }
            }
            return cHITIETPHIEUNHAP;
        }

        public bool Insert(CHITIETPHIEUNHAP item)
        {
            using (SqlConnection connection = new SqlConnection(connectString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand("INSERT INTO CHITIETPHIEUNHAP " +
                            "(IDPHIEUNHAP, TENSANPHAM, IDSANPHAM, DONVITINH, SOLUONGDUTRU, SOLUONGTHUCTE)" +
                            " VALUES (@IDPHIEUNHAP, @TENSANPHAM, @IDSANPHAM, @DONVITINH, @SOLUONGDUTRU, @SOLUONGTHUCTE)", connection))
                {
                    command.Parameters.AddWithValue("@IDPHIEUNHAP", item.IDPHIEUNHAP);
                    command.Parameters.AddWithValue("@TENSANPHAM", item.TENSANPHAM);
                    command.Parameters.AddWithValue("@IDSANPHAM", item.IDSANPHAM);
                    command.Parameters.AddWithValue("@DONVITINH", item.DONVITINH);
                    command.Parameters.AddWithValue("@SOLUONGDUTRU", item.SOLUONGDUTRU);
                    command.Parameters.AddWithValue("@SOLUONGTHUCTE", item.SOLUONGTHUCTE);
                    command.ExecuteNonQuery();
                }
            }
            return true;
        }
    }
}

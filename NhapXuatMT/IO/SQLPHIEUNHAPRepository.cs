using NhapXuatMT.Data;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace NhapXuatMT.IO
{
    public class SQLPHIEUNHAPRepository : IPHIEUNHAPRepository
    {
        private string connectString { get; set; }
        public SQLPHIEUNHAPRepository(string connectString)
        {
            this.connectString = connectString;
        }
        public bool Delete(int IDPHIEUNHAP)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectString))
                {
                    connection.Open();
                    string query = "DELETE FROM PHIEUNHAP WHERE IDPHIEUNHAP = @PurchaseOrderId";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@PurchaseOrderId", IDPHIEUNHAP);
                    command.ExecuteNonQuery();
                }
            }
            catch
            {

            }
            return true;
        }

        public bool Edit(PHIEUNHAP item)
        {
            using (SqlConnection connection = new SqlConnection(connectString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(@"UPDATE PHIEUNHAP SET
                                NGAYNHAP=@NGAYNHAP,
                                NGAYDUTRU=@NGAYDUTRU,
                                TENNHANVIENGIAO=@TENNHANVIENGIAO,
                                TENNHACUNGCAP=@TENNHACUNGCAP,
                                NGUOILAPPHIEU=@NGUOILAPPHIEU
                                WHERE IDPHIEUNHAP = @IDPHIEUNHAP", connection))
                {
                    command.Parameters.AddWithValue("@IDPHIEUNHAP", item.IDPHIEUNHAP);
                    command.Parameters.AddWithValue("@NGAYNHAP", item.NGAYNHAP);
                    command.Parameters.AddWithValue("@NGAYDUTRU", item.NGAYDUTRU);
                    command.Parameters.AddWithValue("@TENNHANVIENGIAO", item.TENNHANVIENGIAO);
                    command.Parameters.AddWithValue("@TENNHACUNGCAP", item.TENNHACUNGCAP);
                    command.Parameters.AddWithValue("@NGUOILAPPHIEU", item.NGUOILAPPHIEU);
                    command.ExecuteNonQuery();
                }
            }
            return true;
        }

        public List<PHIEUNHAP> GetAll()
        {
            List<PHIEUNHAP> phieunhaps = new List<PHIEUNHAP>();

            using (SqlConnection connection = new SqlConnection(connectString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand("SELECT * FROM PHIEUNHAP", connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            PHIEUNHAP phieunhap = new PHIEUNHAP
                            {
                                IDPHIEUNHAP = Convert.ToInt32(reader["IDPHIEUNHAP"]),
                                NGAYDUTRU = Convert.ToDateTime(reader["NGAYDUTRU"]),
                                NGAYNHAP = Convert.ToDateTime(reader["NGAYNHAP"]),
                                NGUOILAPPHIEU = reader["NGUOILAPPHIEU"].ToString(),
                                TENNHACUNGCAP = reader["TENNHACUNGCAP"].ToString(),
                                TENNHANVIENGIAO = reader["TENNHANVIENGIAO"].ToString()
                            };

                            phieunhaps.Add(phieunhap);
                        }
                    }
                }
            }

            return phieunhaps;
        }

        public PHIEUNHAP GetByID(int IDPHIEUNHAP)
        {
            PHIEUNHAP phieunhap = null;

            using (SqlConnection connection = new SqlConnection(connectString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand("SELECT * FROM PHIEUNHAP WHERE IDPHIEUNHAP = @IDPHIEUNHAP", connection))
                {
                    command.Parameters.AddWithValue("@IDPHIEUNHAP", IDPHIEUNHAP);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            phieunhap = new PHIEUNHAP
                            {
                                IDPHIEUNHAP = Convert.ToInt32(reader["IDPHIEUNHAP"]),
                                NGAYDUTRU = Convert.ToDateTime(reader["NGAYDUTRU"]),
                                NGAYNHAP = Convert.ToDateTime(reader["NGAYNHAP"]),
                                NGUOILAPPHIEU = reader["NGUOILAPPHIEU"].ToString(),
                                TENNHACUNGCAP = reader["TENNHACUNGCAP"].ToString(),
                                TENNHANVIENGIAO = reader["TENNHANVIENGIAO"].ToString()
                            };
                        }
                    }
                }
            }

            return phieunhap;
        }

        public bool Insert(PHIEUNHAP item)
        {
            using (SqlConnection connection = new SqlConnection(connectString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(@"INSERT INTO PHIEUNHAP(
                        NGAYNHAP,
                        NGAYDUTRU,
                        TENNHANVIENGIAO,
                        TENNHACUNGCAP,
                        NGUOILAPPHIEU)
                        VALUES(@NGAYNHAP,
                        @NGAYDUTRU,
                        @TENNHANVIENGIAO,
                        @TENNHACUNGCAP,
                        @NGUOILAPPHIEU)", connection))
                {
                    command.Parameters.AddWithValue("@NGAYNHAP", item.NGAYNHAP);
                    command.Parameters.AddWithValue("@NGAYDUTRU", item.NGAYDUTRU);
                    command.Parameters.AddWithValue("@TENNHANVIENGIAO", item.TENNHANVIENGIAO);
                    command.Parameters.AddWithValue("@TENNHACUNGCAP", item.TENNHACUNGCAP);
                    command.Parameters.AddWithValue("@NGUOILAPPHIEU", item.NGUOILAPPHIEU);
                    command.ExecuteNonQuery();
                }

                using (SqlCommand command = new SqlCommand(@"SELECT MAX(IDPHIEUNHAP) IDPHIEUNHAP FROM PHIEUNHAP", connection))
                {
                    var dr = command.ExecuteReader();
                    if (dr.Read())
                    {
                        item.IDPHIEUNHAP = Convert.ToInt32(dr["IDPHIEUNHAP"]);
                    }
                }
            }
            return true;
        }
    }
}

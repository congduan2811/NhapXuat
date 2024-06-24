using NhapXuatMT.Data;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace NhapXuatMT.IO
{
    public class PHIEUNHAPRepository : IPHIEUNHAPRepository
    {
        private string _connectionString;
        //private Model1 db;

        //private CHITIETPHIEUNHAPRepository _CHITIETPHIEUNHAPRepository { get; set; }

        //private Model1 Db { get; set; }
        //private CHITIETPHIEUNHAPRepository _CHITIETPHIEUNHAPRepository { get; set; }
        //public PHIEUNHAPRepository(Model1 db)
        //{
        //    this.db = db;
        //    _CHITIETPHIEUNHAPRepository = new CHITIETPHIEUNHAPRepository(this.db);
        //}

        public PHIEUNHAPRepository(string connectionString)
        {
            _connectionString = connectionString;
            //_CHITIETPHIEUNHAPRepository = new CHITIETPHIEUNHAPRepository(connectionString);
            //_connectionString = connectionString;
        }

        public bool Delete(int IDPHIEUNHAP)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand("DELETE FROM PHIEUNHAP WHERE IDPHIEUNHAP = @IDPHIEUNHAP", connection))
                {
                    command.Parameters.AddWithValue("@IDPHIEUNHAP", IDPHIEUNHAP);
                    command.ExecuteNonQuery();
                }

                return true;
            }
        }

        //public PHIEUNHAPRepository(Model1 db)
        //{
        //    this.db = db;
        //}

        //public bool Delete(int IDPHIEUNHAP)
        //{
        //    
        //    //var oldPhieuNhap = GetByID(IDPHIEUNHAP);
        //    //if (oldPhieuNhap != null && oldPhieuNhap.IDPHIEUNHAP > 0)
        //    //{
        //    //    var transaction = db.Database.BeginTransaction();
        //    //    try
        //    //    {
        //    //        foreach (var item in _CHITIETPHIEUNHAPRepository.GetAll(oldPhieuNhap.IDPHIEUNHAP))
        //    //        {
        //    //            _CHITIETPHIEUNHAPRepository.Delete(item.IDCHITIETPHIEUNHAP);
        //    //        }
        //    //        db.PHIEUNHAPs.Remove(oldPhieuNhap);
        //    //        db.SaveChanges();

        //    //        transaction.Commit();
        //    //    }
        //    //    catch
        //    //    {
        //    //        transaction.Rollback();
        //    //    }
        //    //    return true;
        //    //}
        //    //return false;
        //}

        public bool Edit(PHIEUNHAP item)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand("UPDATE PHIEUNHAP SET NGAYDUTRU = @NGAYDUTRU, NGAYNHAP = @NGAYNHAP, NGUOILAPPHIEU = @NGUOILAPPHIEU, TENNHACUNGCAP = @TENNHACUNGCAP, TENNHANVIENGIAO = @TENNHANVIENGIAO WHERE IDPHIEUNHAP = @IDPHIEUNHAP", connection))
                {
                    command.Parameters.AddWithValue("@NGAYDUTRU", item.NGAYDUTRU);
                    command.Parameters.AddWithValue("@NGAYNHAP", item.NGAYNHAP);
                    command.Parameters.AddWithValue("@NGUOILAPPHIEU", item.NGUOILAPPHIEU);
                    command.Parameters.AddWithValue("@TENNHACUNGCAP", item.TENNHACUNGCAP);
                    command.Parameters.AddWithValue("@TENNHANVIENGIAO", item.TENNHANVIENGIAO);
                    command.Parameters.AddWithValue("@IDPHIEUNHAP", item.IDPHIEUNHAP);
                    command.ExecuteNonQuery();
                }

                return true;
            }
        }

        public List<PHIEUNHAP> GetAll()
        {
            List<PHIEUNHAP> phieunhaps = new List<PHIEUNHAP>();

            using (SqlConnection connection = new SqlConnection(_connectionString))
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

            using (SqlConnection connection = new SqlConnection(_connectionString))
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
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand("INSERT INTO PHIEUNHAP (NGAYDUTRU, NGAYNHAP, NGUOILAPPHIEU, TENNHACUNGCAP, TENNHANVIENGIAO) VALUES (@NGAYDUTRU, @NGAYNHAP, @NGUOILAPPHIEU, @TENNHACUNGCAP, @TENNHANVIENGIAO)", connection))
                {
                    command.Parameters.AddWithValue("@NGAYDUTRU", item.NGAYDUTRU);
                    command.Parameters.AddWithValue("@NGAYNHAP", item.NGAYNHAP);
                    command.Parameters.AddWithValue("@NGUOILAPPHIEU", item.NGUOILAPPHIEU);
                    command.Parameters.AddWithValue("@TENNHACUNGCAP", item.TENNHACUNGCAP);
                    command.Parameters.AddWithValue("@TENNHANVIENGIAO", item.TENNHANVIENGIAO);
                    command.ExecuteNonQuery();
                }

                return true;
            }
        }






        //public List<PHIEUNHAP> GetAll()
        //{
        //    return db.PHIEUNHAPs.ToList();
        //}

        //public PHIEUNHAP GetByID(int IDPHIEUNHAP)
        //{
        //    return db.PHIEUNHAPs.FirstOrDefault(x => x.IDPHIEUNHAP.Equals(IDPHIEUNHAP));
        //}

        //public bool Insert(PHIEUNHAP item)
        //{
        //    db.PHIEUNHAPs.Add(item);
        //    return db.SaveChanges() > 0;
        //}
    }

    //var oldPhieuNhap = GetByID(item.IDPHIEUNHAP);
    //if(oldPhieuNhap != null && oldPhieuNhap.IDPHIEUNHAP > 0)
    //{
    //    oldPhieuNhap.NGAYDUTRU = item.NGAYDUTRU;
    //    oldPhieuNhap.NGAYNHAP = item.NGAYNHAP;
    //    oldPhieuNhap.NGUOILAPPHIEU = item.NGUOILAPPHIEU;
    //    oldPhieuNhap.TENNHACUNGCAP = item.TENNHACUNGCAP;
    //    oldPhieuNhap.TENNHANVIENGIAO = item.TENNHANVIENGIAO;
    //    db.SaveChanges();
    //    return true;
    //}
    //return false;
}




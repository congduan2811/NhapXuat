using NhapXuatMT.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NhapXuatMT.IO
{
    public class CHITIETPHIEUNHAPRepository : ICHITIETPHIEUNHAPRepository
    {
        private string connectionString;

        private Model1 db { get; set; }
        public CHITIETPHIEUNHAPRepository(Model1 db)
        {
            this.db = db;
        }

        public CHITIETPHIEUNHAPRepository(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public bool Delete(int IDCHITIETPHIEUNHAP)
        {
            var oldPhieuNhap = GetByID(IDCHITIETPHIEUNHAP);
            if (oldPhieuNhap != null && oldPhieuNhap.IDPHIEUNHAP > 0)
            {
                db.CHITIETPHIEUNHAPs.Remove(oldPhieuNhap);
                db.SaveChanges();
                return true;
            }
            return false;
        }

        public bool Edit(CHITIETPHIEUNHAP item)
        {
            var oldPhieuNhap = GetByID(item.IDCHITIETPHIEUNHAP);
            if (oldPhieuNhap != null && oldPhieuNhap.IDPHIEUNHAP > 0)
            {
                oldPhieuNhap.IDSANPHAM = item.IDSANPHAM;
                oldPhieuNhap.DONVITINH = item.DONVITINH;
                oldPhieuNhap.SOLUONGDUTRU = item.SOLUONGDUTRU;
                oldPhieuNhap.SOLUONGTHUCTE = item.SOLUONGTHUCTE;
                oldPhieuNhap.TENSANPHAM = item.TENSANPHAM;
                db.SaveChanges();
                return true;
            }
            return false;
        }

        public List<CHITIETPHIEUNHAP> GetAll(int IDPHIEUNHAP)
        {
            return db.CHITIETPHIEUNHAPs.Where(x=>x.IDPHIEUNHAP == IDPHIEUNHAP).ToList();
        }

        public CHITIETPHIEUNHAP GetByID(int IDCHITIETPHIEUNHAP)
        {
            return db.CHITIETPHIEUNHAPs.FirstOrDefault(x => x.IDCHITIETPHIEUNHAP.Equals(IDCHITIETPHIEUNHAP));
        }

        public bool Insert(CHITIETPHIEUNHAP item)
        {
            db.CHITIETPHIEUNHAPs.Add(item);
            return db.SaveChanges() > 0;
        }
    }
}

using NhapXuatMT.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NhapXuatMT.IO
{
    public class PHIEUNHAPRepository : IPHIEUNHAPRepository
    {
        private Model1 db { get; set; }
        private CHITIETPHIEUNHAPRepository _CHITIETPHIEUNHAPRepository { get; set; }
        public PHIEUNHAPRepository(Model1 db)
        {
            this.db = db;
            _CHITIETPHIEUNHAPRepository = new CHITIETPHIEUNHAPRepository(this.db);
        }
        public bool Delete(int IDPHIEUNHAP)
        {
            var oldPhieuNhap = GetByID(IDPHIEUNHAP);
            if (oldPhieuNhap != null && oldPhieuNhap.IDPHIEUNHAP > 0)
            {
                var transaction = db.Database.BeginTransaction();
                try
                {
                    foreach (var item in _CHITIETPHIEUNHAPRepository.GetAll(oldPhieuNhap.IDPHIEUNHAP))
                    {
                        _CHITIETPHIEUNHAPRepository.Delete(item.IDCHITIETPHIEUNHAP);
                    }
                    db.PHIEUNHAPs.Remove(oldPhieuNhap);
                    db.SaveChanges();

                    transaction.Commit();
                }
                catch
                {
                    transaction.Rollback();
                }                
                return true;
            }
            return false;
        }

        public bool Edit(PHIEUNHAP item)
        {
            var oldPhieuNhap = GetByID(item.IDPHIEUNHAP);
            if(oldPhieuNhap != null && oldPhieuNhap.IDPHIEUNHAP > 0)
            {
                oldPhieuNhap.NGAYDUTRU = item.NGAYDUTRU;
                oldPhieuNhap.NGAYNHAP = item.NGAYNHAP;
                oldPhieuNhap.NGUOILAPPHIEU = item.NGUOILAPPHIEU;
                oldPhieuNhap.TENNHACUNGCAP = item.TENNHACUNGCAP;
                oldPhieuNhap.TENNHANVIENGIAO = item.TENNHANVIENGIAO;
                db.SaveChanges();
                return true;
            }
            return false;
        }

        public List<PHIEUNHAP> GetAll()
        {
            return db.PHIEUNHAPs.ToList();
        }

        public PHIEUNHAP GetByID(int IDPHIEUNHAP)
        {
            return db.PHIEUNHAPs.FirstOrDefault(x => x.IDPHIEUNHAP.Equals(IDPHIEUNHAP));
        }

        public bool Insert(PHIEUNHAP item)
        {
            db.PHIEUNHAPs.Add(item);
            return db.SaveChanges() > 0;
        }
    }
}

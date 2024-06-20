using NhapXuatMT.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NhapXuatMT.IO
{
    public interface ICHITIETPHIEUNHAPRepository
    {
        List<CHITIETPHIEUNHAP> GetAll(int IDPHIEUNHAP);
        CHITIETPHIEUNHAP GetByID(int IDCHITIETPHIEUNHAP);
        bool Insert(CHITIETPHIEUNHAP item);
        bool Edit(CHITIETPHIEUNHAP item);
        bool Delete(int IDCHITIETPHIEUNHAP);
    }
}

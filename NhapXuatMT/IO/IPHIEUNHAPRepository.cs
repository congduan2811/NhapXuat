using NhapXuatMT.Data;
using System.Collections.Generic;

namespace NhapXuatMT.IO
{
    interface IPHIEUNHAPRepository
    {
        List<PHIEUNHAP> GetAll();
        PHIEUNHAP GetByID(int IDPHIEUNHAP);
        bool Insert(PHIEUNHAP item);
        bool Edit(PHIEUNHAP item);
        bool Delete(int IDPHIEUNHAP);
    }
}

using CsvHelper;
using CsvHelper.Configuration;
using NhapXuatMT.Data;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;

namespace NhapXuatMT.IO
{
    public class CSVCHITIETPHIEUNHAPRepository : ICHITIETPHIEUNHAPRepository
    {
        public string root { get; set; }
        private CsvConfiguration configuration { get; set; }
        private string fileName { get; set; }
        public CSVCHITIETPHIEUNHAPRepository(string root)
        {
            this.root = root;
            configuration = new CsvConfiguration(CultureInfo.InvariantCulture);
            fileName = Path.Combine(root, nameof(CHITIETPHIEUNHAP) + ".csv");
            if (!Directory.Exists(this.root))
            {
                Directory.CreateDirectory(this.root);
            }
        }
        public bool Delete(int IDCHITIETPHIEUNHAP)
        {
            var isExistFile = File.Exists(fileName);
            if (!isExistFile)
            {
                return false;
            }

            var phieuNhaps = GetAll();
            foreach (CHITIETPHIEUNHAP phieuNhap in phieuNhaps)
            {
                if (IDCHITIETPHIEUNHAP == phieuNhap.IDCHITIETPHIEUNHAP)
                {
                    phieuNhaps.Remove(phieuNhap);
                }
            }
            File.Delete(fileName);
            using (var fs = File.Open(fileName, FileMode.Append))
            {
                using (var writer = new StreamWriter(fs, Encoding.UTF8))
                using (var csv = new CsvWriter(writer, configuration))
                {
                    csv.WriteHeader(typeof(CHITIETPHIEUNHAP));

                    foreach (CHITIETPHIEUNHAP phieuNhap in phieuNhaps)
                    {
                        csv.NextRecord();
                        csv.WriteRecord(phieuNhap);
                    }
                }
            }
            return true;
        }

        public bool Edit(CHITIETPHIEUNHAP item)
        {
            var isExistFile = File.Exists(fileName);
            if (!isExistFile)
            {
                return false;
            }

            var phieuNhaps = GetAll();
            foreach (CHITIETPHIEUNHAP phieuNhap in phieuNhaps)
            {
                if (item.IDCHITIETPHIEUNHAP == phieuNhap.IDCHITIETPHIEUNHAP)
                {
                    phieuNhap.IDPHIEUNHAP = item.IDPHIEUNHAP;
                    phieuNhap.IDSANPHAM = item.IDSANPHAM;
                    phieuNhap.SOLUONGDUTRU = item.SOLUONGDUTRU;
                    phieuNhap.SOLUONGTHUCTE = item.SOLUONGTHUCTE;
                    phieuNhap.TENSANPHAM = item.TENSANPHAM;
                }
            }
            File.Delete(fileName);
            using (var fs = File.Open(fileName, FileMode.Append))
            {
                using (var writer = new StreamWriter(fs, Encoding.UTF8))
                using (var csv = new CsvWriter(writer, configuration))
                {
                    csv.WriteHeader(typeof(CHITIETPHIEUNHAP));

                    foreach (CHITIETPHIEUNHAP phieuNhap in phieuNhaps)
                    {
                        csv.NextRecord();
                        csv.WriteRecord(phieuNhap);
                    }
                }
            }
            return true;
        }

        public List<CHITIETPHIEUNHAP> GetAll(int IDPHIEUNHAP)
        {
            List<CHITIETPHIEUNHAP> output = new List<CHITIETPHIEUNHAP>();
            if (!File.Exists(fileName))
            {
                return output;
            }
            using (var fs = File.Open(fileName, FileMode.Open, FileAccess.Read, FileShare.Read))
            {
                using (var textReader = new StreamReader(fs, Encoding.UTF8))
                using (var csv = new CsvReader(textReader, configuration))
                {
                    foreach (var item in csv.GetRecords<CHITIETPHIEUNHAP>())
                    {
                        if (item.IDPHIEUNHAP == IDPHIEUNHAP)
                            output.Add(item);
                    }
                }
            }
            return output;
        }

        public CHITIETPHIEUNHAP GetByID(int IDCHITIETPHIEUNHAP)
        {
            var output = new CHITIETPHIEUNHAP();
            if (!File.Exists(fileName))
            {
                return output;
            }
            using (var fs = File.Open(fileName, FileMode.Open, FileAccess.Read, FileShare.Read))
            {
                using (var textReader = new StreamReader(fs, Encoding.UTF8))
                using (var csv = new CsvReader(textReader, configuration))
                {
                    foreach (var item in csv.GetRecords<CHITIETPHIEUNHAP>())
                    {
                        if (item.IDCHITIETPHIEUNHAP == IDCHITIETPHIEUNHAP)
                        {
                            output = item;
                            break;
                        }
                    }
                }
            }
            return output;
        }

        public bool Insert(CHITIETPHIEUNHAP item)
        {
            var isExistFile = File.Exists(fileName);
            if (!isExistFile)
            {
                item.IDCHITIETPHIEUNHAP = 1;
            }
            else
            {
                item.IDCHITIETPHIEUNHAP = GetAll().Count + 1;
            }
            using (var fs = File.Open(fileName, FileMode.Append))
            {
                using (var writer = new StreamWriter(fs, Encoding.UTF8))
                using (var csv = new CsvWriter(writer, configuration))
                {
                    if (!isExistFile)
                    {
                        csv.WriteHeader(typeof(CHITIETPHIEUNHAP));
                    }
                    csv.NextRecord();
                    csv.WriteRecord(item);
                }
            }
            return true;
        }
        public List<CHITIETPHIEUNHAP> GetAll()
        {
            List<CHITIETPHIEUNHAP> output = new List<CHITIETPHIEUNHAP>();
            if (!File.Exists(fileName))
            {
                return output;
            }
            using (var fs = File.Open(fileName, FileMode.Open, FileAccess.Read, FileShare.Read))
            {
                using (var textReader = new StreamReader(fs, Encoding.UTF8))
                using (var csv = new CsvReader(textReader, configuration))
                {
                    foreach (var item in csv.GetRecords<CHITIETPHIEUNHAP>())
                    {
                        output.Add(item);
                    }
                }
            }
            return output;
        }
    }
}

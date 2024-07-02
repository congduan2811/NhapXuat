using CsvHelper;
using CsvHelper.Configuration;
using NhapXuatMT.Data;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;

namespace NhapXuatMT.IO
{
    public class CSVPHIEUNHAPRepository : IPHIEUNHAPRepository
    {
        private CsvConfiguration configuration { get; set; }
        private string root { get; set; }
        private string fileName { get; set; }
        public CSVPHIEUNHAPRepository(string root)
        {
            this.root = root;
            configuration = new CsvConfiguration(CultureInfo.InvariantCulture);
            fileName = Path.Combine(root, nameof(PHIEUNHAP) + ".csv");
            if (!Directory.Exists(this.root))
            {
                Directory.CreateDirectory(this.root);
            }
        }
        public bool Delete(int IDPHIEUNHAP)
        {
            var isExistFile = File.Exists(fileName);
            if (!isExistFile)
            {
                return false;
            }

            var phieuNhaps = GetAll();
            foreach (PHIEUNHAP phieuNhap in phieuNhaps)
            {
                if (IDPHIEUNHAP == phieuNhap.IDPHIEUNHAP)
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
                    csv.WriteHeader(typeof(PHIEUNHAP));

                    foreach (PHIEUNHAP phieuNhap in phieuNhaps)
                    {
                        csv.NextRecord();
                        csv.WriteRecord(phieuNhap);
                    }
                }
            }
            return true;
        }

        public bool Edit(PHIEUNHAP item)
        {
            var isExistFile = File.Exists(fileName);
            if (!isExistFile)
            {
                return false;
            }

            var phieuNhaps = GetAll();
            foreach (PHIEUNHAP phieuNhap in phieuNhaps)
            {
                if (item.IDPHIEUNHAP == phieuNhap.IDPHIEUNHAP)
                {
                    phieuNhap.NGAYDUTRU = item.NGAYDUTRU;
                    phieuNhap.NGAYNHAP = item.NGAYNHAP;
                    phieuNhap.NGUOILAPPHIEU = item.NGUOILAPPHIEU;
                    phieuNhap.TENNHACUNGCAP = item.TENNHACUNGCAP;
                    phieuNhap.TENNHANVIENGIAO = item.TENNHANVIENGIAO;
                }
            }
            File.Delete(fileName);
            using (var fs = File.Open(fileName, FileMode.Append))
            {
                using (var writer = new StreamWriter(fs, Encoding.UTF8))
                using (var csv = new CsvWriter(writer, configuration))
                {
                    csv.WriteHeader(typeof(PHIEUNHAP));

                    foreach (PHIEUNHAP phieuNhap in phieuNhaps)
                    {
                        csv.NextRecord();
                        csv.WriteRecord(phieuNhap);
                    }
                }
            }
            return true;
        }

        public List<PHIEUNHAP> GetAll()
        {
            List<PHIEUNHAP> output = new List<PHIEUNHAP>();
            if (!File.Exists(fileName))
            {
                return output;
            }

            using (var fs = File.Open(fileName, FileMode.Open, FileAccess.Read, FileShare.Read))
            {
                using (var textReader = new StreamReader(fs, Encoding.UTF8))
                using (var csv = new CsvReader(textReader, configuration))
                {
                    foreach (var item in csv.GetRecords<PHIEUNHAP>())
                    {
                        output.Add(item);
                    }
                }
            }
            return output;
        }
        public PHIEUNHAP GetByID(int IDPHIEUNHAP)
        {
            var output = new PHIEUNHAP();
            if (!File.Exists(fileName))
            {
                return output;
            }
            using (var fs = File.Open(fileName, FileMode.Open, FileAccess.Read, FileShare.Read))
            {
                using (var textReader = new StreamReader(fs, Encoding.UTF8))
                using (var csv = new CsvReader(textReader, configuration))
                {
                    foreach (var item in csv.GetRecords<PHIEUNHAP>())
                    {
                        if (item.IDPHIEUNHAP == IDPHIEUNHAP)
                        {
                            output = item;
                            break;
                        }
                    }
                }
            }
            return output;
        }

        public bool Insert(PHIEUNHAP item)
        {
            var isExistFile = File.Exists(fileName);
            if (!isExistFile)
            {
                item.IDPHIEUNHAP = 1;
            }
            else
            {
                item.IDPHIEUNHAP = GetAll().Count + 1;
            }
            using (var fs = File.Open(fileName, FileMode.Append))
            {
                using (var writer = new StreamWriter(fs, Encoding.UTF8))
                using (var csv = new CsvWriter(writer, configuration))
                {
                    if (!isExistFile)
                    {
                        csv.WriteHeader(typeof(PHIEUNHAP));
                    }
                    csv.NextRecord();
                    csv.WriteRecord(item);
                }
            }
            return true;
        }
    }
}

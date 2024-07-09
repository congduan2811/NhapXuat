using NhapXuatMT.Data;
using System.Configuration;
using System.IO;

namespace NhapXuatMT.Common
{
    public class VariableSession
    {
        private static Model1_db _db { get; set; }
        public static Model1_db db
        {
            get
            {
                if (_db == null)
                {
                    _db = new Model1_db();
                }
                return _db;
            }
        }

        public static string ConnectString
        {
            get
            {
                return ConfigurationManager.ConnectionStrings["Model1"].ToString();
            }
        }
        public static string Root
        {
            get
            {
                return Path.Combine(Directory.GetCurrentDirectory(), "CSV"); 
            }
        }
    }
}

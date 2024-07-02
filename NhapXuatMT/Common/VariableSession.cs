using NhapXuatMT.Data;
using System.Configuration;

namespace NhapXuatMT.Common
{
    public class VariableSession
    {
        private static Model1 _db { get; set; }
        public static Model1 db
        {
            get
            {
                if (_db == null)
                {
                    _db = new Model1();
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
    }
}

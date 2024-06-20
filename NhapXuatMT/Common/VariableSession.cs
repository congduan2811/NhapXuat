using NhapXuatMT.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NhapXuatMT.Common
{
    public class VariableSession
    {
        private static Model1 _db { get; set; }
        public static Model1 db
        {
            get
            {
                if(_db == null)
                {
                    _db = new Model1();
                }
                return _db;
            }
        }
    }
}

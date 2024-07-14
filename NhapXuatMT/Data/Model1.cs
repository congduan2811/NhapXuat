using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace NhapXuatMT.Data
{
    public partial class Model1_db : DbContext
    {
        public Model1_db()
            : base("name=Model1" )
        {
        }

        public virtual DbSet<CHITIETPHIEUNHAP> CHITIETPHIEUNHAPs { get; set; }
        public virtual DbSet<CHITIETPHIEUXUAT> CHITIETPHIEUXUATs { get; set; }
        public virtual DbSet<PHIEUNHAP> PHIEUNHAPs { get; set; }
        public virtual DbSet<PHIEUXUAT> PHIEUXUATs { get; set; }
        public virtual DbSet<NhaCungCap> NhaCungCaps { get; set; }
    
        public virtual DbSet<NV> NVs { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
           
        }
       
    }
}

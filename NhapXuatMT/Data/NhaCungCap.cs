namespace NhapXuatMT.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("NhaCungCap")]
    public partial class NhaCungCap
    {
        public int ID { get; set; }

        [StringLength(50)]
        public string TenNhaCungCap { get; set; }
    }
}

namespace NhapXuatMT.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("NV")]
    public partial class NV
    {
        [Key]
        public int IDSANPHAM { get; set; }

        [StringLength(50)]
        public string TENSANPHAM { get; set; }

        [StringLength(50)]
        public string NHACUNGCAP { get; set; }

        [StringLength(10)]
        public string DONVITINH { get; set; }

        [StringLength(50)]
        public string NHANVIENGIAO { get; set; }
    }
}

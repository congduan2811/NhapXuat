namespace NhapXuatMT.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PHIEUXUAT")]
    public partial class PHIEUXUAT
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PHIEUXUAT()
        {
            CHITIETPHIEUXUATs = new HashSet<CHITIETPHIEUXUAT>();
        }

        [Key]
        public int IDPHIEUXUAT { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NGAYXUAT { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NGAYDUTRU { get; set; }

        [StringLength(50)]
        public string TENNHANVIENNHAN { get; set; }

        [StringLength(50)]
        public string BOPHANNHAN { get; set; }

        [StringLength(50)]
        public string NHANVIENLAPPHIEU { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CHITIETPHIEUXUAT> CHITIETPHIEUXUATs { get; set; }
    }
}

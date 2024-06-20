namespace NhapXuatMT.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("PHIEUNHAP")]
    public partial class PHIEUNHAP
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PHIEUNHAP()
        {
            CHITIETPHIEUNHAPs = new HashSet<CHITIETPHIEUNHAP>();
        }

        [Key]
        public int IDPHIEUNHAP { get; set; }

        public DateTime? NGAYNHAP { get; set; }

        public DateTime? NGAYDUTRU { get; set; }

        [StringLength(50)]
        public string TENNHANVIENGIAO { get; set; }

        [StringLength(50)]
        public string TENNHACUNGCAP { get; set; }

        [StringLength(50)]
        public string NGUOILAPPHIEU { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CHITIETPHIEUNHAP> CHITIETPHIEUNHAPs { get; set; }
    }
}

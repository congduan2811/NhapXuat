namespace NhapXuatMT.Data
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("CHITIETPHIEUXUAT")]
    public partial class CHITIETPHIEUXUAT
    {
        [Key]
        public int IDCHITIETPHIEUXUAT { get; set; }

        public int? IDPHIEUXUAT { get; set; }

        public int? IDSANPHAM { get; set; }

        [StringLength(50)]
        public string TENSANPHAM { get; set; }

        [StringLength(50)]
        public string DONVITINH { get; set; }

        public int? SOLUONGXUAT { get; set; }

        public virtual PHIEUXUAT PHIEUXUAT { get; set; }
    }
}

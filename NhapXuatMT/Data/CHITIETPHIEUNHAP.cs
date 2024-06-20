namespace NhapXuatMT.Data
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("CHITIETPHIEUNHAP")]
    public partial class CHITIETPHIEUNHAP
    {
        [Key]
        public int IDCHITIETPHIEUNHAP { get; set; }

        public int? IDPHIEUNHAP { get; set; }

        [StringLength(50)]
        public string TENSANPHAM { get; set; }

        public int? IDSANPHAM { get; set; }

        [StringLength(50)]
        public string DONVITINH { get; set; }

        public int? SOLUONGDUTRU { get; set; }

        public int? SOLUONGTHUCTE { get; set; }

        public virtual PHIEUNHAP PHIEUNHAP { get; set; }
    }
}

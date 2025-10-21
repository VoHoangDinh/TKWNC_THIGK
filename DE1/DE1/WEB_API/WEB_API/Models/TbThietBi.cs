using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WEB_API.Models
{
    [Table("tbTHIETBI")]
    public class tbThietBi
    {
        [Key]
        [Column("MATHIETBI")]
        public int MaThietBi { get; set; }

        [Column("TENTHIETBI")]
        public string TenThietBi { get; set; }

        [Column("DONVITINH")]
        public string? DonViTinh { get; set; }

        [Column("SOLUONG")]
        public int? SoLuong { get; set; }

        [Column("DONGIA")]
        public decimal? DonGia { get; set; }

        [Column("HINHANH")]
        public string? HinhAnh { get; set; }

        [Column("MOTA")]
        public string? MoTa { get; set; }

        [Column("MANHOM")]
        public int? MaNhom { get; set; }
    }
}

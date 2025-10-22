using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WEB_API.Models // Namespace đúng
{
    [Table("tbMENU")]
    public class tbMenu
    {
        [Key]
        public int IDMON { get; set; }
        public string TENMON { get; set; }
        public string? DONVITINH { get; set; }
        public decimal? DONGIA { get; set; }
        public int? SOLUONG { get; set; }
        public string? HINHANH { get; set; }
        public string? MOTA { get; set; }
        public int? IDDANHMUC { get; set; }
    }
}
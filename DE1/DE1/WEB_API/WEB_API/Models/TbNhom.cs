using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WEB_API.Models
{
    // [Table("tbNHOM")] ánh xạ lớp này với bảng tbNHOM trong SQL Server
    [Table("tbNHOM")]
    public class tbNhom
    {
        // [Key] xác định đây là khóa chính
        [Key]
        [Column("MANHOM")]
        public int MaNhom { get; set; }

        [Column("TENNHOM")]
        public string TenNhom { get; set; }
    }
}

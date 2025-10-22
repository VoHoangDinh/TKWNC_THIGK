using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WEB_API.Models // Namespace đúng
{
    [Table("tbDANHMUC")]
    public class tbDanhMuc
    {
        [Key]
        public int IDDANHMUC { get; set; }
        public string TENDANHMUC { get; set; }
    }
}
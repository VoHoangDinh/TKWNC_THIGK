namespace WEB_APP.Models // Namespace đúng
{
    public class MenuViewModel
    {
        public int IDMON { get; set; }
        public string TENMON { get; set; }
        public decimal? DONGIA { get; set; }
        public string HINHANH { get; set; }
        public string MOTA { get; set; }
        public int? SOLUONG { get; set; } // Thêm số lượng
        public int IDDANHMUC { get; set; }
    }
}
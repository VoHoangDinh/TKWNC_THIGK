using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WEB_APP.Models
{
    public class ThietBiViewModel
    {
        public int MATHIETBI { get; set; }
        public string TENTHIETBI { get; set; }
        public string DONVITINH { get; set; }
        public int? SOLUONG { get; set; }
        public decimal? DONGIA { get; set; }
        public string HINHANH { get; set; }
        public string MOTA { get; set; }
        public int? MANHOM { get; set; }
    }
}
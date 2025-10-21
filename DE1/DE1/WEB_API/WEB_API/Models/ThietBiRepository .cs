using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using WEB_API.Data;

namespace WEB_API.Models
{
    public class ThietBiRepository : IThietBiRepository
    {
        private readonly DataContext _context;
        public ThietBiRepository(DataContext context) { _context = context; }

        public async Task<tbThietBi> GetThietBiById(int maThietBi)
        {
            var param = new SqlParameter("@MaThietBi", maThietBi);

            // Bước 1: Thực thi Stored Procedure và lấy toàn bộ kết quả về dưới dạng danh sách
            var results = await _context.tbTHIETBI
                .FromSqlRaw("EXEC sp_Get_ThietBi_ById @MaThietBi", param)
                .ToListAsync();

            // Bước 2: Lấy phần tử đầu tiên từ danh sách kết quả (đã ở trên client)
            // Dùng FirstOrDefault() bình thường, không có Async
            return results.FirstOrDefault();
        }

        public async Task<IEnumerable<tbThietBi>> GetThietBiByNhom(int maNhom)
        {
            var param = new SqlParameter("@MaNhom", maNhom);
            return await _context.tbTHIETBI
                .FromSqlRaw("EXEC sp_Get_ThietBi_ByNhom @MaNhom", param)
                .ToListAsync();
        }
    }
}
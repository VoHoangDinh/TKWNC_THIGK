using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;
using WEB_API.Data; // Using DataContext

namespace WEB_API.Models // Namespace đúng
{
    public class DanhMucRepository : IDanhMucRepository
    {
        private readonly DataContext _context;
        public DanhMucRepository(DataContext context) { _context = context; }

        public async Task<IEnumerable<tbDanhMuc>> GetAllDanhMucAsync()
        {
            // Dùng DbSet DanhMucResults để gọi SP
            return await _context.DanhMucResults.FromSqlRaw("EXEC sp_GetAll_DanhMuc").ToListAsync();
        }
    }
}
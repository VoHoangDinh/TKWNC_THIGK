using Microsoft.EntityFrameworkCore;
using WEB_API.Data;

namespace WEB_API.Models
{
    public class NhomRepository : INhomRepository
    {
        private readonly DataContext _context;
        public NhomRepository(DataContext context) { _context = context; }

        public async Task<IEnumerable<tbNhom>> GetAllNhom()
        {
            return await _context.tbNHOM.FromSqlRaw("EXEC sp_GetAll_Nhom").ToListAsync();
        }
    }
}
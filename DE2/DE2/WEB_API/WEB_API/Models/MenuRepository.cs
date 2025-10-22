using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WEB_API.Data; // Using DataContext

namespace WEB_API.Models // Namespace đúng
{
    public class MenuRepository : IMenuRepository
    {
        private readonly DataContext _context;
        public MenuRepository(DataContext context) { _context = context; }

        public async Task<IEnumerable<tbMenu>> GetMenuByDanhMucAsync(int idDanhMuc)
        {
            var param = new SqlParameter("@IdDanhMuc", idDanhMuc);
            // Dùng DbSet MenuResults để gọi SP
            return await _context.MenuResults.FromSqlRaw("EXEC sp_Get_Menu_ByDanhMuc @IdDanhMuc", param).ToListAsync();
        }

        public async Task<tbMenu?> GetMonByIdAsync(int idMon)
        {
            var param = new SqlParameter("@IdMon", idMon);
            // Dùng DbSet MenuResults để gọi SP và lấy FirstOrDefault
            var results = await _context.MenuResults.FromSqlRaw("EXEC sp_Get_Mon_ById @IdMon", param).ToListAsync();
            return results.FirstOrDefault();
        }
    }
}
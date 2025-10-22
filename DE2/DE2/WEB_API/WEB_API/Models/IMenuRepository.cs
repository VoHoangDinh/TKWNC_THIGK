using System.Collections.Generic;
using System.Threading.Tasks;

namespace WEB_API.Models // Namespace đúng
{
    public interface IMenuRepository
    {
        Task<IEnumerable<tbMenu>> GetMenuByDanhMucAsync(int idDanhMuc);
        Task<tbMenu?> GetMonByIdAsync(int idMon);
    }
}
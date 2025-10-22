using System.Collections.Generic;
using System.Threading.Tasks;

namespace WEB_API.Models // Namespace đúng
{
    public interface IDanhMucRepository
    {
        Task<IEnumerable<tbDanhMuc>> GetAllDanhMucAsync();
    }
}
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using WEB_API.Models; // Namespace đúng

namespace WEB_API.Controllers // Namespace đúng
{
    [ApiController]
    [Route("api/[controller]")]
    public class DanhMucController : ControllerBase
    {
        private readonly IDanhMucRepository _danhMucRepo;
        public DanhMucController(IDanhMucRepository danhMucRepo) { _danhMucRepo = danhMucRepo; }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var danhMucs = await _danhMucRepo.GetAllDanhMucAsync();
            return Ok(danhMucs);
        }
    }
}
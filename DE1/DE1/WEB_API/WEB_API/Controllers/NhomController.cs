using Microsoft.AspNetCore.Mvc;
using WEB_API.Models;

namespace WEB_API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class NhomController : ControllerBase
    {
        private readonly INhomRepository _nhomRepo;
        public NhomController(INhomRepository nhomRepo) { _nhomRepo = nhomRepo; }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            return Ok(await _nhomRepo.GetAllNhom());
        }
    }
}
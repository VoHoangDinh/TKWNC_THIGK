using Microsoft.AspNetCore.Mvc;
using WEB_API.Models;

namespace WEB_API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ThietBiController : ControllerBase
    {
        private readonly IThietBiRepository _thietBiRepo;
        public ThietBiController(IThietBiRepository thietBiRepo) { _thietBiRepo = thietBiRepo; }

        [HttpGet("TheoNhom/{maNhom}")]
        public async Task<IActionResult> GetByNhom(int maNhom)
        {
            return Ok(await _thietBiRepo.GetThietBiByNhom(maNhom));
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var thietBi = await _thietBiRepo.GetThietBiById(id);
            if (thietBi == null) return NotFound();
            return Ok(thietBi);
        }
    }
}
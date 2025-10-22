using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using WEB_API.Models; // Namespace đúng

namespace WEB_API.Controllers // Namespace đúng
{
    [ApiController]
    [Route("api/[controller]")]
    public class MenuController : ControllerBase
    {
        private readonly IMenuRepository _menuRepo;
        public MenuController(IMenuRepository menuRepo) { _menuRepo = menuRepo; }

        [HttpGet("TheoDanhMuc/{idDanhMuc}")]
        public async Task<IActionResult> GetByDanhMuc(int idDanhMuc)
        {
            var menus = await _menuRepo.GetMenuByDanhMucAsync(idDanhMuc);
            return Ok(menus);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var mon = await _menuRepo.GetMonByIdAsync(id);
            if (mon == null) return NotFound();
            return Ok(mon);
        }
    }
}
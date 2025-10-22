using System.Collections.Generic;
using System.Configuration;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Mvc;
using WEB_APP.Models; // Namespace đúng

namespace WEB_APP.Controllers // Namespace đúng
{
    public class MenuController : Controller
    {
        private readonly string _apiBaseUrl = ConfigurationManager.AppSettings["ApiBaseUrl"];

        private HttpClient GetHttpClient()
        {
            var client = new HttpClient { BaseAddress = new System.Uri(_apiBaseUrl) };
            return client;
        }

        // Action hiển thị danh sách món ăn theo danh mục
        public async Task<ActionResult> Index(int idDanhMuc) // Đổi tên tham số cho khớp với đề bài
        {
            IEnumerable<MenuViewModel> menuList;
            using (var client = GetHttpClient())
            {
                HttpResponseMessage result = await client.GetAsync($"api/Menu/TheoDanhMuc/{idDanhMuc}");
                if (result.IsSuccessStatusCode)
                {
                    menuList = await result.Content.ReadAsAsync<IEnumerable<MenuViewModel>>();
                }
                else
                {
                    menuList = new List<MenuViewModel>();
                }
            }
            return View(menuList);
        }

        // Action hiển thị chi tiết món ăn
        public async Task<ActionResult> Detail(int id) // 'id' là quy ước chuẩn cho route mặc định
        {
            MenuViewModel monAn;
            using (var client = GetHttpClient())
            {
                HttpResponseMessage result = await client.GetAsync($"api/Menu/{id}");
                if (result.IsSuccessStatusCode)
                {
                    monAn = await result.Content.ReadAsAsync<MenuViewModel>();
                }
                else
                {
                    monAn = null;
                }
            }
            if (monAn == null) return HttpNotFound();
            return View(monAn);
        }
    }
}
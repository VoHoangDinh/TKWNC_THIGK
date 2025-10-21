using System.Collections.Generic;
using System.Configuration;
using System.Net.Http;
using System.Threading.Tasks; // Thêm using này
using System.Web.Mvc;
using WEB_APP.Models;

namespace WEB_APP.Controllers
{
    public class ThietBiController : Controller
    {
        private readonly string _apiBaseUrl = ConfigurationManager.AppSettings["ApiBaseUrl"];

        // Chuyển sang async Task<ActionResult>
        public async Task<ActionResult> Index(int maNhom)
        {
            IEnumerable<ThietBiViewModel> thietBiList;
            using (var client = new HttpClient())
            {
                client.BaseAddress = new System.Uri(_apiBaseUrl);
                // Dùng await thay cho .Wait() và .Result
                HttpResponseMessage result = await client.GetAsync($"api/ThietBi/TheoNhom/{maNhom}");

                if (result.IsSuccessStatusCode)
                {
                    // Dùng await
                    thietBiList = await result.Content.ReadAsAsync<IEnumerable<ThietBiViewModel>>();
                }
                else
                {
                    thietBiList = new List<ThietBiViewModel>();
                }
            }
            return View(thietBiList);
        }

        // Chuyển sang async Task<ActionResult>
        public async Task<ActionResult> Detail(int id)
        {
            ThietBiViewModel thietBi;
            using (var client = new HttpClient())
            {
                client.BaseAddress = new System.Uri(_apiBaseUrl);
                // Dùng await
                HttpResponseMessage result = await client.GetAsync($"api/ThietBi/{id}");

                if (result.IsSuccessStatusCode)
                {
                    // Dùng await
                    thietBi = await result.Content.ReadAsAsync<ThietBiViewModel>();
                }
                else
                {
                    thietBi = null;
                }
            }
            return View(thietBi);
        }
    }
}
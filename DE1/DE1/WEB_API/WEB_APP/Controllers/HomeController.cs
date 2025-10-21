using System.Collections.Generic;
using System.Configuration;
using System.Net.Http;
using System.Threading.Tasks; // Thêm using này
using System.Web.Mvc;
using WEB_APP.Models;

namespace WEB_APP.Controllers
{
    public class HomeController : Controller
    {
        private readonly string _apiBaseUrl = ConfigurationManager.AppSettings["ApiBaseUrl"];

        public ActionResult Index()
        {
            return View();
        }

        // ChildAction không thể là async, nên chúng ta giữ nguyên cách cũ cho menu
        [ChildActionOnly]
        public ActionResult NhomMenu()
        {
            IEnumerable<NhomViewModel> nhomList;
            using (var client = new HttpClient())
            {
                client.BaseAddress = new System.Uri(_apiBaseUrl);
                var responseTask = client.GetAsync("api/Nhom");
                responseTask.Wait(); // Bắt buộc phải đợi ở đây vì là ChildAction

                var result = responseTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    var readTask = result.Content.ReadAsAsync<IEnumerable<NhomViewModel>>();
                    readTask.Wait();
                    nhomList = readTask.Result;
                }
                else
                {
                    nhomList = new List<NhomViewModel>();
                }
            }
            return PartialView("_NhomMenu", nhomList);
        }
    }
}
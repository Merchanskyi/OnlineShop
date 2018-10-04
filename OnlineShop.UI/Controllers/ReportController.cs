using System.Diagnostics;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using OnlineShop.UI.Models;
using OnlineShop.UI.Services;

namespace OnlineShop.UI.Controllers
{
    public class ReportController : Controller
    {
        private readonly IHttpProductProvider _httpProductProvider;

        public ReportController(IHttpProductProvider httpProductProvider)
        {
            _httpProductProvider = httpProductProvider;
        }

        public async Task<ActionResult> Index()
        {
            return View(await _httpProductProvider.GetAllAsync());
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public ActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
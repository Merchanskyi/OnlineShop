using Microsoft.AspNetCore.Mvc;
using OnlineShop.Models;
using OnlineShop.UI.Models;
using OnlineShop.UI.Services;
using System;
using System.Diagnostics;
using System.Threading.Tasks;

namespace OnlineShop.UI.Controllers
{
    public class ProductsController : Controller
    {
        private readonly IHttpProductProvider _httpProductProvider;

        public ProductsController(IHttpProductProvider httpProductProvider)
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

        public ActionResult Create()
        {
            ViewData["Message"] = "Your create page.";

            return View();
        }

        [HttpPost]
        public async Task<ActionResult> Create(Product product)
        {
            if (!ModelState.IsValid)
            {
                return View(product);
            }

            await _httpProductProvider.AddAsync(product);

            return RedirectToAction("index");
        }

        [HttpPost]
        public async Task<ActionResult> Delete(Guid id)
        {
            await _httpProductProvider.DeleteAsync(id);

            return RedirectToAction("index");
        }

        public async Task<ActionResult> Update(Guid id)
        {
            return View(await _httpProductProvider.GetAsync(id));
        }

        [HttpPost]
        public async Task<ActionResult> Update(Product product)
        {
            if (!ModelState.IsValid)
            {
                return View(product);
            }

            await _httpProductProvider.UpdateAsync(product);

            return RedirectToAction("index");
        }
    }
}

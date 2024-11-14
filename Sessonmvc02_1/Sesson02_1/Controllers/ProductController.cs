using Microsoft.AspNetCore.Mvc;
using Sesson02_1.Models;

namespace Sesson02_1.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult GetActionResult()
        {
            return View("Products");
        }
        public IActionResult GetProduct()
        {
            Product p = new Product
            {
                ProductId = 1,
                ProductName = "Test",
                YearRelease = 2024,
                Price = 3.144
            };
            ViewBag.Product = p;
            return View(p);
        }
    }
}

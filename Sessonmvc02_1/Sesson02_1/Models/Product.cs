using Microsoft.AspNetCore.Mvc;

namespace Sesson02_1.Models
{
    public class Product : Controller
    {
        public int ProductId { get; internal set; }
        public string ProductName { get; internal set; }
        public double Price { get; internal set; }
        public int YearRelease { get; internal set; }

        public IActionResult Index()
        {
            return View();
        }
    }
}

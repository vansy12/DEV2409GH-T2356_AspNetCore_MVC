using Microsoft.AspNetCore.Mvc;
using Sesson02_1.Models;
using System.Diagnostics;

namespace Sesson02_1.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            ViewData["messageVD"] = "Dữ liệu trong ";
            ViewBag.messageVB = "Dữ liệu trong viewbag";
            TempData["messageTD"] = "Dữ liêu lưu trong Temp";
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

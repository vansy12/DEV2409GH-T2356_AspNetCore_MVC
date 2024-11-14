using Lesson02.MVC.Models;
using Microsoft.AspNetCore.Mvc;
using System.Xml.Linq;

namespace Lesson02.MVC.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Index()
        {
            List<Account> accounts = new List<Account>
            {
                new Account()
                {
                   Id = 1,
                   Name="Hoàng Anh",
                   Email="anh@gmail.com",
                   Phone="0986456789",
                   Address="Hà Nội",
                   Avatar= Url.Content("~/Image/Avatar/1.jpg"),
                   Gender=1,
                   Bio="My name is small",
                   BirthDay= new DateTime(1998,7,15)
                },
                new Account()
                {
                   Id = 2,
                   Name="Hoàng Lan",
                   Email="anh@gmail.com",
                   Phone="0986456789",
                   Address="Hà Nội",
                   Avatar= Url.Content("~/Image/Avatar/2.jpg"),
                   Gender=2,
                   Bio="My name is small",
                   BirthDay= new DateTime(1998,7,15)
                },
                new Account()
                {
                   Id = 1,
                   Name="Hoàng Tú",
                   Email="anh@gmail.com",
                   Phone="0986456789",
                   Address="Hà Nội",
                   Avatar= Url.Content("~/Image/Avatar/3.jpg"),
                   Gender=1,
                   Bio="My name is small",
                   BirthDay= new DateTime(1998,7,15)
                },
            };
            ViewBag.Accounts = accounts; 
            return View();
        }
        public IActionResult Profile()
        {
            Account account = new Account()
            {
                Id = 1,
                Name = "Hoàng Anh",
                Email = "anh@gmail.com",
                Phone = "0986456789",
                Address = "Hà Nội",
                Avatar = Url.Content("~/Image/Avatar/1.jpg"),
                Gender = 1,
                Bio = "My name is small",
                BirthDay = new DateTime(1998, 7, 15)
            };
            ViewBag.account = account;
            return View();
        }
    }
}

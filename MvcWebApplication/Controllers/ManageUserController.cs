using Microsoft.AspNetCore.Mvc;
using MvcWebApplication.Models.MvcApp.Models;
using System;

namespace MvcWebApplication.Controllers
{
    public class ManageUserController : Controller
    {
        List<User> people = new List<User>
        {
            new User(1, "Tom", 3),
            new User(2, "Bob", 7),
            new User(3, "Sam", 8)
        };
        public IActionResult Index()
        {
            return View(User);
        }
    }
}

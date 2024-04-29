using Microsoft.AspNetCore.Mvc;
using MvcWebApplication.Models.MvcApp.Models;
using System;

namespace MvcWebApplication.Controllers
{
    public class ManageUserController : Controller
    {
        List<User> people = new List<User>
        {
            new User(1, "Tom", "dfvd"),
            new User(2, "Bob", "sfs"),
            new User(3, "Sam", "sdfvsd")
        };
        public IActionResult Index()
        {
            return View(User);
        }
    }
}

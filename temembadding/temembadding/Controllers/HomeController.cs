using System.Diagnostics;

using Microsoft.AspNetCore.Mvc;

using temembadding.Models;

namespace temembadding.Controllers
{
    public class HomeController : Controller
    {
        

        public IActionResult Index()
        {
           if (HttpContext.Session.GetString ("role")== "user")
            {
                return View();
            }
            else
            {
                return RedirectToAction("Login","Admin");
            }
        }

        public IActionResult Privacy()
        {
            return View();
        }

        
    }
}
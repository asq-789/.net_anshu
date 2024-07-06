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
        public IActionResult UserProduct()
        {
            return View();
        }
        [HttpPost]
        public IActionResult UserProduct(UserProduct user)
        {
            if (ModelState.IsValid)
            {
                return Content("Data is Correct format");
            }
            else
            {
                ViewBag.msg = "Data is invalid format";
                return View();
            }
        }


    }
}
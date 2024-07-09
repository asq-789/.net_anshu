﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

using temembadding.Models;

namespace temembadding.Controllers
{
    public class AdminController : Controller
    {
        [Authorize]
        public IActionResult Index()
        {
            return View();
        }
        //[HttpGet]
        //public IActionResult Login()
        //{
        //    return View();
        //}
        //[HttpPost]
        //public IActionResult Login(string email, string password)
        //{
        //    if(email == "admin@gmail.com" && password == "123" )
        //    {
        //        HttpContext.Session.SetString("adminemail", email);
        //        HttpContext.Session.SetString("role","admin");
        //        return RedirectToAction("Index");

        //    }
        //  else if(email == "user@gmail.com" && password == "123")
        //    {

        //        HttpContext.Session.SetString("useremail", email);
        //        HttpContext.Session.SetString("role", "user");
        //        return RedirectToAction("Index","Home");
        //    }
        //    else
        //    {
        //        return View();
        //    }
        //}
        //public IActionResult AdminLogout()
        //{
        //    HttpContext.Session.Clear();
        //    HttpContext.Session.Remove("adminemail");
        //    HttpContext.Session.Remove("role");
        //    return RedirectToAction("Login");
        //}
        //public IActionResult UserLogout()
        //{
        //    HttpContext.Session.Clear();
        //    HttpContext.Session.Remove("useremail");
        //    HttpContext.Session.Remove("role");
        //    return RedirectToAction("Login");
        //}
        public IActionResult AddProduct()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddProduct(Products product)
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

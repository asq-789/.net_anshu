using System.Security.Claims;

using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;

namespace temembadding.Controllers
{
    public class AuthController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Login(string email, string password)
        {
            bool IsAuthenticated = false;
            bool isAdmin = false;
            ClaimsIdentity identity = null;
            if (email == "admin@gmail.com" && password == "123")
            {
                identity = new ClaimsIdentity(new[]
            {
                    new Claim(ClaimTypes.Name , "Anshrah"),
                    new Claim(ClaimTypes.Role, "admin"),
            }
                , CookieAuthenticationDefaults.AuthenticationScheme);
                IsAuthenticated = true;
                isAdmin = true;
              
            }
            else if (email == "user@gmail.com" && password == "123")
            {
                identity = new ClaimsIdentity(new[]
                           {
                    new Claim(ClaimTypes.Name , "User1"),
                    new Claim(ClaimTypes.Role, "User"),
            }
                               , CookieAuthenticationDefaults.AuthenticationScheme);
                IsAuthenticated = true;
                isAdmin = false;
             
            }
            if(IsAuthenticated && isAdmin)
            {
                var principal = new ClaimsPrincipal(identity);
                var login = HttpContext.SignInAsync
                    (CookieAuthenticationDefaults.AuthenticationScheme, principal);
                return RedirectToAction("Index", "Admin");
            }
            else if (IsAuthenticated)
            {
                var principal = new ClaimsPrincipal(identity);
                var login = HttpContext.SignInAsync
   (CookieAuthenticationDefaults.AuthenticationScheme, principal);
                return RedirectToAction("Index", "Home");
            }
            else
            {
                return View();
            }

        }
        public IActionResult logout()
        {
            var login = HttpContext.SignOutAsync
                (CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction("Index", "Auth");
        }
    }

}

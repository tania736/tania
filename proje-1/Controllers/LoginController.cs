using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using System.Security.Claims;


namespace proje_1.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Authenticate(Models.Authentication input)

        {
            if (!ModelState.IsValid)
            {

            /*string u = input.username;
            string p = input.pass;
            Models.projeContext db = new Models.projeContext();
            var find = from x in db.SabtSana1 where x.Name == u && x.NationalCode == p select x;
                IList<Claim> claims = new List<Claim>()
                    {
                        new Claim(ClaimTypes.NameIdentifier,find.Id.ToString()),
                        new Claim(ClaimTypes.Name,user.UserName)
                    };



                var identity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
                var principal = new ClaimsPrincipal(identity);

                var properties = new AuthenticationProperties
                {
                    IsPersistent = true
                };
                HttpContext.SignInAsync(principal, properties);*/
                return RedirectToAction("index", "home");
       
            }
            return Redirect("/Login");
          
        }
    }
}
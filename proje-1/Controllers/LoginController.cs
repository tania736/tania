using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace proje_1.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Authenticate(Models.Authentication input)

        {
            string u = input.username;
            string p = input.pass;
            Models.projeContext db = new Models.projeContext();
            var find = from x in db.SabtSana where x.Name == u && x.NationalCode == p select x;
            return RedirectToAction("index", "home");
       
          
        }
    }
}
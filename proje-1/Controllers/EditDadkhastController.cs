using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace proje_1.Controllers
{
    public class EditDadkhastController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Register()
        {
            return View("EditDadkhast");
        }

        [HttpPost]
        public ActionResult Index(string searchString)

        {
            Models.projeContext db = new Models.projeContext();
            Models.Dadkhast1 tbl3 = new Models.Dadkhast1();
            var movies = from m in db.Dadkhast1

                         select m;

            if (!String.IsNullOrEmpty(searchString))

            {

                movies = movies.Where(s => s.CodeDadkhast.Contains(searchString));

            }

            return View(movies);

        }
    }
    }
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace proje_1.Controllers
{
    public class EditSHekvayeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Register()
        {
            return View("EditSHekvaye");
        }

        [HttpPost]
        public ActionResult Index(string searchString)

        {
            Models.projeContext db = new Models.projeContext();
            Models.Shekvaye1 tbl3 = new Models.Shekvaye1();
            var movies = from m in db.Shekvaye1

                         select m;

            if (!String.IsNullOrEmpty(searchString))

            {

                movies = movies.Where(s => s.CodeShekvaye.Contains(searchString));

            }

            return View(movies);

        }

    }
}


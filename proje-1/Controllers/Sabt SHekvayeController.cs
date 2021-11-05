using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace proje_1.Controllers
{
    public class SHekvayeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Register()
        {
            return View("SHekvaye");
        }

        [HttpPost]
        public IActionResult Authenticate(Models.Shekvaye1 input)
        {
            string NationalcodeKhahan = input.NationalcodeKhahan;
            string NationalcodeKhande = input.NationalcodeKhande;
            string NationalcodeMotale = input.NationalcodeMotale;
            string NationalcodeVakil = input.NationalcodeVakil;
            string NationalcodeNamayande = input.NationalcodeNamayande;
            string SharhShekayat = input.SharhShekayat;
            string mojavez = input.Mojavez;
            string Mozoe = input.Mozoe;
            string code = "55";

            Models.projeContext db = new Models.projeContext();
            Models.Shekvaye1 tbl3 = new Models.Shekvaye1();
            tbl3.NationalcodeKhahan = NationalcodeKhahan;
            tbl3.NationalcodeKhande = NationalcodeKhande;
            tbl3.NationalcodeMotale = NationalcodeMotale;
            tbl3.NationalcodeVakil = NationalcodeVakil;
            tbl3.NationalcodeNamayande = NationalcodeNamayande;
            tbl3.SharhShekayat = SharhShekayat;
            tbl3.Mojavez = mojavez;
            tbl3.Mozoe = Mozoe;

            tbl3.CodeShekvaye = "123456789";
            db.Shekvaye1.Add(tbl3);
            var res_id = db.SaveChanges();
            return Ok(tbl3);
        }
    }
}
    


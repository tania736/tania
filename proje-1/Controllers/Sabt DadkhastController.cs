using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace proje_1.Controllers
{
    public class DadkhastController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Register()
        {
            return View("Dadkhast");
        }
    
        [HttpPost]
        public IActionResult Authenticate(Models.Dadkhast1 input)
        {
            string NationalcodeKhahan = input.NationalcodeKhahan;
            string NationalcodeKhande = input.NationalcodeKhande;
            string NationalcodeMotale = input.NationalcodeMotale;
            string NationalcodeVakil = input.NationalcodeVakil;
            string NationalcodeNamayande = input.NationalcodeNamayande;
            string sharhdadkhast = input.SharheDadkhast;
            string mojavez = input.Mojavez;
            string khaste = input.Khasteh;
            string code = "55";

            Models.projeContext db = new Models.projeContext();
            Models.Dadkhast1 tbl2 = new Models.Dadkhast1();
            tbl2.NationalcodeKhahan = NationalcodeKhahan;
            tbl2.NationalcodeKhande = NationalcodeKhande;
            tbl2.NationalcodeMotale = NationalcodeMotale;
            tbl2.NationalcodeVakil = NationalcodeVakil;
            tbl2.NationalcodeNamayande = NationalcodeNamayande;
            tbl2.SharheDadkhast = sharhdadkhast;
            tbl2.Mojavez = mojavez;
            tbl2.Khasteh = khaste;

            tbl2.CodeDadkhast = "1234567890";


            db.Dadkhast1.Add(tbl2);

            var res_id = db.SaveChanges();

            return Ok(tbl2);



        }
        //   private int getclinet(string nationalcode)
        //  {
        //      Models.projeContext db = new Models.projeContext();
        //      var sana_db = new Models.SabtSana1();
        //     var client = db.SabtSana1.FirstOrDefault(s => s.NationalCode == nationalcode);
        //     return client.Id;
        // }


    } }





using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace proje_1.Controllers
{
    public class SabtSanaController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
           // public IActionResult random(RandomCode)
           // {
           //     return View("");
           // }
       

        public IActionResult Register()
        {
            return View("sana");
        }

        [HttpPost]

        public IActionResult Authenticate(Models.SabtSana1 input)

        {  string n = input.Name;
            string l =input.Lname;
            string np = input.NamePdar;
            string sh = input.ShomareSh;
            string national = input.NationalCode;
            string date = input.DateOfBirth;
             string job = input.Job;
            string city = input.City;
             string email = input.Email;
             string address = input.Address;
             int jobid = input.JobTypeId;
            string randomcode = input.RandomCode;



           

            Models.projeContext db = new Models.projeContext();
            Models.SabtSana1 tbl = new Models.SabtSana1();
            tbl.Name = n;
            tbl.Lname= l;
            tbl.ShomareSh = sh;
            tbl.NamePdar = np;
            tbl.City = city;

            tbl.NationalCode = national;
            tbl.DateOfBirth = date;
            tbl.Job = job;
            tbl.Email = email;
            tbl.Address = address;
            tbl.JobTypeId = jobid;
            tbl.RandomCode = randomcode;
            db.SabtSana1.Add(tbl);
            
            var res_id= db.SaveChanges();
           
            return Ok(tbl);


        }
    }
}

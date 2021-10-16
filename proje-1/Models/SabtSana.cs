using System;
using System.Collections.Generic;

namespace proje_1.Models
{
    public partial class SabtSana
    {
        public SabtSana()
        {
            DadkhastIdKhahanNavigation = new HashSet<Dadkhast>();
            DadkhastIdKhandeNavigation = new HashSet<Dadkhast>();
            DadkhastIdMotaleNavigation = new HashSet<Dadkhast>();
            DadkhastIdVakilNavigation = new HashSet<Dadkhast>();
            DadkhastIdnamayandeNavigation = new HashSet<Dadkhast>();
            ShekvayeIdKhahanNavigation = new HashSet<Shekvaye>();
            ShekvayeIdKhandeNavigation = new HashSet<Shekvaye>();
            ShekvayeIdMataleNavigation = new HashSet<Shekvaye>();
            ShekvayeIdNamayandehNavigation = new HashSet<Shekvaye>();
            ShekvayeIdVakilNavigation = new HashSet<Shekvaye>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string ShomareSh { get; set; }
        public string NationalCode { get; set; }
        public string DateOfBirth { get; set; }
        public string Job { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public int JobTypeId { get; set; }
        public int? RandomCode { get; set; }

        public JobType IdNavigation { get; set; }
        public ICollection<Dadkhast> DadkhastIdKhahanNavigation { get; set; }
        public ICollection<Dadkhast> DadkhastIdKhandeNavigation { get; set; }
        public ICollection<Dadkhast> DadkhastIdMotaleNavigation { get; set; }
        public ICollection<Dadkhast> DadkhastIdVakilNavigation { get; set; }
        public ICollection<Dadkhast> DadkhastIdnamayandeNavigation { get; set; }
        public ICollection<Shekvaye> ShekvayeIdKhahanNavigation { get; set; }
        public ICollection<Shekvaye> ShekvayeIdKhandeNavigation { get; set; }
        public ICollection<Shekvaye> ShekvayeIdMataleNavigation { get; set; }
        public ICollection<Shekvaye> ShekvayeIdNamayandehNavigation { get; set; }
        public ICollection<Shekvaye> ShekvayeIdVakilNavigation { get; set; }
    }
}

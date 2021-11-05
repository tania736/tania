using System;
using System.Collections.Generic;

namespace proje_1.Models
{
    public partial class SabtSana1
    {
        public SabtSana1()
        {
            Dadkhast1NationalcodeKhahanNavigation = new HashSet<Dadkhast1>();
            Dadkhast1NationalcodeKhandeNavigation = new HashSet<Dadkhast1>();
            Dadkhast1NationalcodeMotaleNavigation = new HashSet<Dadkhast1>();
            Dadkhast1NationalcodeNamayandeNavigation = new HashSet<Dadkhast1>();
            Dadkhast1NationalcodeVakilNavigation = new HashSet<Dadkhast1>();
            Shekvaye1NationalcodeKhahanNavigation = new HashSet<Shekvaye1>();
            Shekvaye1NationalcodeKhandeNavigation = new HashSet<Shekvaye1>();
            Shekvaye1NationalcodeMotaleNavigation = new HashSet<Shekvaye1>();
            Shekvaye1NationalcodeNamayandeNavigation = new HashSet<Shekvaye1>();
            Shekvaye1NationalcodeVakilNavigation = new HashSet<Shekvaye1>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Lname { get; set; }
        public string NamePdar { get; set; }
        public string ShomareSh { get; set; }
        public string NationalCode { get; set; }
        public string City { get; set; }
        public string DateOfBirth { get; set; }
        public string Job { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public int JobTypeId { get; set; }
        public string RandomCode { get; set; }

        public JobType JobType { get; set; }
        public ICollection<Dadkhast1> Dadkhast1NationalcodeKhahanNavigation { get; set; }
        public ICollection<Dadkhast1> Dadkhast1NationalcodeKhandeNavigation { get; set; }
        public ICollection<Dadkhast1> Dadkhast1NationalcodeMotaleNavigation { get; set; }
        public ICollection<Dadkhast1> Dadkhast1NationalcodeNamayandeNavigation { get; set; }
        public ICollection<Dadkhast1> Dadkhast1NationalcodeVakilNavigation { get; set; }
        public ICollection<Shekvaye1> Shekvaye1NationalcodeKhahanNavigation { get; set; }
        public ICollection<Shekvaye1> Shekvaye1NationalcodeKhandeNavigation { get; set; }
        public ICollection<Shekvaye1> Shekvaye1NationalcodeMotaleNavigation { get; set; }
        public ICollection<Shekvaye1> Shekvaye1NationalcodeNamayandeNavigation { get; set; }
        public ICollection<Shekvaye1> Shekvaye1NationalcodeVakilNavigation { get; set; }
    }
}

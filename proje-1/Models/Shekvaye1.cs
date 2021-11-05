using System;
using System.Collections.Generic;

namespace proje_1.Models
{
    public partial class Shekvaye1
    {
        public int? Id { get; set; }
        public string NationalcodeKhahan { get; set; }
        public string NationalcodeKhande { get; set; }
        public string NationalcodeVakil { get; set; }
        public string NationalcodeMotale { get; set; }
        public string NationalcodeNamayande { get; set; }
        public string SharhShekayat { get; set; }
        public string Mojavez { get; set; }
        public string Mozoe { get; set; }
        public string CodeShekvaye { get; set; }

        public SabtSana1 NationalcodeKhahanNavigation { get; set; }
        public SabtSana1 NationalcodeKhandeNavigation { get; set; }
        public SabtSana1 NationalcodeMotaleNavigation { get; set; }
        public SabtSana1 NationalcodeNamayandeNavigation { get; set; }
        public SabtSana1 NationalcodeVakilNavigation { get; set; }
    }
}

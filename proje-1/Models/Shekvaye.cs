using System;
using System.Collections.Generic;

namespace proje_1.Models
{
    public partial class Shekvaye
    {
        public int IdKhahan { get; set; }
        public int IdKhande { get; set; }
        public int IdVakil { get; set; }
        public int IdMatale { get; set; }
        public int? IdNamayandeh { get; set; }
        public string SharhShekayat { get; set; }
        public string Mojavez { get; set; }
        public string Mozoe { get; set; }
        public int CodeShekvaye { get; set; }

        public SabtSana IdKhahanNavigation { get; set; }
        public SabtSana IdKhandeNavigation { get; set; }
        public SabtSana IdMataleNavigation { get; set; }
        public SabtSana IdNamayandehNavigation { get; set; }
        public SabtSana IdVakilNavigation { get; set; }
    }
}

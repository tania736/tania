using System;
using System.Collections.Generic;

namespace proje_1.Models
{
    public partial class Dadkhast
    {
        public int IdKhahan { get; set; }
        public int IdKhande { get; set; }
        public int IdVakil { get; set; }
        public int IdMotale { get; set; }
        public int? Idnamayande { get; set; }
        public string SharheDadkhast { get; set; }
        public string Mojavez { get; set; }
        public string Khasteh { get; set; }
        public int CodeDadkhast { get; set; }

        public SabtSana IdKhahanNavigation { get; set; }
        public SabtSana IdKhandeNavigation { get; set; }
        public SabtSana IdMotaleNavigation { get; set; }
        public SabtSana IdVakilNavigation { get; set; }
        public SabtSana IdnamayandeNavigation { get; set; }
    }
}

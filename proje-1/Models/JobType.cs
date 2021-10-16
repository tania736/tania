using System;
using System.Collections.Generic;

namespace proje_1.Models
{
    public partial class JobType
    {
        public int JobTypeId { get; set; }
        public string JobTitle { get; set; }

        public SabtSana SabtSana { get; set; }
    }
}

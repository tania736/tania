using System;
using System.Collections.Generic;

namespace proje_1.Models
{
    public partial class JobType
    {
        public JobType()
        {
            SabtSana1 = new HashSet<SabtSana1>();
        }

        public int JobTypeId { get; set; }
        public string JobTitle { get; set; }

        public ICollection<SabtSana1> SabtSana1 { get; set; }
    }
}

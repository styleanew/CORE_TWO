using System;
using System.Collections.Generic;

namespace TWO.Models
{
    public partial class Priorities
    {
        public Priorities()
        {
            Milemarkers = new HashSet<Milemarkers>();
        }

        public byte Priorityid { get; set; }
        public byte Prioritylevel { get; set; }

        public virtual ICollection<Milemarkers> Milemarkers { get; set; }
    }
}

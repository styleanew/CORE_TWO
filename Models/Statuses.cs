using System;
using System.Collections.Generic;

namespace TWO.Models
{
    public partial class Statuses
    {
        public Statuses()
        {
            Milemarkers = new HashSet<Milemarkers>();
        }

        public byte Statusid { get; set; }
        public byte? Statuscode { get; set; }
        public string Satusdescription { get; set; }

        public virtual ICollection<Milemarkers> Milemarkers { get; set; }
    }
}

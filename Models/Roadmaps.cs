using System;
using System.Collections.Generic;

namespace TWO.Models
{
    public partial class Roadmaps
    {
        public Roadmaps()
        {
            MarkerHistory = new HashSet<MarkerHistory>();
            Milemarkers = new HashSet<Milemarkers>();
        }

        public int Roadmapid { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool Isdeleted { get; set; }
        public DateTime Createddate { get; set; }

        public virtual ICollection<MarkerHistory> MarkerHistory { get; set; }
        public virtual ICollection<Milemarkers> Milemarkers { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace TWO.Models
{
    public partial class Milemarkers
    {
        public Milemarkers()
        {
            MarkerHistory = new HashSet<MarkerHistory>();
        }

        public int Milemarkerid { get; set; }
        public int Roadmapid { get; set; }
        public string Assignedto { get; set; }
        public string Markerdescription { get; set; }
        public byte Priorityid { get; set; }
        public byte Statusid { get; set; }
        public bool Isdeleted { get; set; }
        public DateTime? Duedate { get; set; }
        public DateTime Datecreated { get; set; }

        public virtual ICollection<MarkerHistory> MarkerHistory { get; set; }
        public virtual Priorities Priority { get; set; }
        public virtual Roadmaps Roadmap { get; set; }
        public virtual Statuses Status { get; set; }
    }
}

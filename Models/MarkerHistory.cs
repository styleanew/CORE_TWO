using System;
using System.Collections.Generic;

namespace TWO.Models
{
    public partial class MarkerHistory
    {
        public int Markerhistoryid { get; set; }
        public int Roadmapid { get; set; }
        public int Milemarkerid { get; set; }
        public string Assignedto { get; set; }
        public string Markerhistorydescription { get; set; }
        public byte Priorityid { get; set; }
        public byte Statusid { get; set; }
        public bool Isdeleted { get; set; }
        public DateTime? Duedate { get; set; }
        public DateTime Datecreated { get; set; }

        public virtual Milemarkers Milemarker { get; set; }
        public virtual Roadmaps Roadmap { get; set; }
    }
}

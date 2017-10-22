using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TWO.Models
{
    public class MileMarker : IMarker
    {



        public void Initialize(IServiceProvider serviceProvider)
        {

        }

        public Boolean Complete(String n)
        {
            return true;

        }
    
    }
}

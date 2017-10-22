using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TWO.Models
{
    interface IMarker
    {
        void Initialize(IServiceProvider serviceProvider);
        Boolean Complete(String n);
        
    }
}

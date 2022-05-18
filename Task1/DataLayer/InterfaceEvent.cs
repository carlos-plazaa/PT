using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1.DataLayer
{
    public interface InterfaceEvent
    {
        InterfaceState State { get; set; }
        InterfaceUser User { get; set; }
        DateTime BuyDate { get; set; }

        
  
    }
}

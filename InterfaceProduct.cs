using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1.DataLayer
{
    public interface InterfaceProduct
    {
        int Code { get; set; }
        string Details { get; set; }
        double Price { get; set; }

       
    }
}

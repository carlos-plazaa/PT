using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1.DataLayer
{
    public interface InterfaceUser
    {
        string Name { get; set; }
        string Surname { get; set; }
        int Id { get; set; }

    }
}

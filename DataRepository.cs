using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1.DataLayer
{
    internal class DataRepository
    {
        internal DataContext DataContext { get; set; }

        internal DataRepository(DataContext dataContext)
        {
            DataContext = dataContext;
        }
        internal DataRepository()
        {
            DataContext = new DataContext();
        }
    }

}

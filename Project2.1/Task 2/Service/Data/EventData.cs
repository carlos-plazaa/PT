using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Data
{
    public class EventData
    {
        public int EventID { get; set; }
        public int ClientID { get; set; }
        public int ProductID { get; set; }
        public DateTime PurchaseDate { get; set; }
    }
}

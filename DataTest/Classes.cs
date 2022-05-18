using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task1

namespace DataTest
{
    internal class User : InterfaceUser
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public string Surname { get; set; }

        public User(int Id, string name, string surname)
        {
            ID = Id;
            Name = name;
            Surname = surname;

        }

    }


    internal class Product : InterfaceProduct
    {
        public int Code { get; set; }
        public string Details { get; set; }
        public float Price { get; set; }

        public Product(int code, string details, float price)
        {
            Code = code;
            Details = details;
            Price = price;

        }

    }

    internal class State  : InterfaceState
    {
        public InterfaceProduct Product { get; set; }

        public State(InterfaceProduct product)
        {
            Product = product;

        }
    }
}

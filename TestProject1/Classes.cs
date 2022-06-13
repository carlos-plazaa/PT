using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task1.DataLayer;

namespace TestProject1
{
        internal class User : InterfaceUser
        {
            public int Id { get; set; }
            public string Name { get; set; }

            public string Surname { get; set; }

            public User(int id, string name, string surname)
            {
                Id = id;
                Name = name;
                Surname = surname;

            }

        }


        internal class Product : InterfaceProduct
        {
            public int Code { get; set; }
            public string Details { get; set; }
            public double Price { get; set; }

            public Product(int code, string details, double price)
            {
                Code = code;
                Details = details;
                Price = price;

            }

        }

        internal class State : InterfaceState
        {
            public InterfaceProduct Product { get; set; }

            public State(InterfaceProduct product)
            {
                Product = product;

            }
        }

        internal class EventBuy : InterfaceEvent
        {
            public InterfaceState State { get; set; }
            public InterfaceUser User { get; set; }
            public DateTime BuyDate { get; set; }
            public EventBuy(InterfaceState state, InterfaceUser user)
            {
                State = state;
                User = user;
            }
        }

        internal class EventReturn : InterfaceEvent
        {
            public InterfaceState State { get; set; }
            public InterfaceUser User { get; set; }
            public DateTime BuyDate { get; set; }
            public EventReturn(InterfaceState state, InterfaceUser user)
            {
                State = state;
                User = user;
            }
        }
    }


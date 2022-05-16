using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1.DataLayer
{
    internal class DataContext
    {
        private List<InterfaceEvent> events = new List<InterfaceEvent>();
        private List<InterfaceState> states = new List<InterfaceState>();
        private List<InterfaceProduct> products = new List<InterfaceProduct>();
        private List<InterfaceUser> users = new List<InterfaceUser>();


        //User
        public void AddUser(InterfaceUser user)
        {
            users.Add(user);
        }

        public void DeleteUser(InterfaceUser user)
        {
            users.Remove(user);
        }

        public List<InterfaceUser> GetUsers()
        {
            return users;
        }

        public InterfaceUser GetUser(int id)
        {
            return users.Find(user => user.Id == id);

        }

        //Event
        public void AddEvent(InterfaceEvent InterfaceEvent)
        {
            events.Add(InterfaceEvent);
        }
        public void DeleteEvent(InterfaceEvent InterfaceEvent)
        {
            events.Remove(InterfaceEvent);
        }
        public List<InterfaceEvent> GetEvents()
        {
            return events;
        }


        //Products
        public void AddProduct(InterfaceProduct product)
        {
            products.Add(product);
        }
        public void DeleteProduct(InterfaceProduct product)
        {
            products.Remove(product);
        }
        public List<InterfaceProduct> GetProducts()
        {
            return products;

        }
        public InterfaceProduct GetProduct(int code)
        {
            return products[code];
        }


        //State
        public void AddState(InterfaceState state)
        {
            states.Add(state);
        }
        public void DeleteState(InterfaceState state)
        {
            states.Remove(state);
        }
        public List<InterfaceState> GetStates()
        {
            return states;

        }
    }
}






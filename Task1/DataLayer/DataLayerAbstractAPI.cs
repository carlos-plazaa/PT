using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1.DataLayer
{
    public abstract class DataLayerAbstractAPI
    {
        public static DataLayerAbstractAPI DataLayerImplementation()
        {
            return new DataLayerConcrete();
        }


        //User
        public abstract void AddUser(InterfaceUser user);
        public abstract void DeleteUser(InterfaceUser user);
        public abstract InterfaceUser GetUser(int id);
        public abstract List<InterfaceUser> GetUsers();


        //Event
        public abstract void AddEvent(InterfaceEvent InterfaceEvent);
        public abstract void DeleteEvent(InterfaceEvent InterfaceEvent);
        public abstract List<InterfaceEvent> GetEvents();



        //State
        public abstract void AddState(InterfaceState state);
        public abstract void DeleteState(InterfaceState state);
        public abstract List<InterfaceState> GetStates();



        //Product
        public abstract void AddProduct(InterfaceProduct product);
        public abstract void DeleteProduct(InterfaceProduct product);
        public abstract InterfaceProduct GetProduct(int code);
        public abstract List<InterfaceProduct> GetProducts();







        public static DataLayerAbstractAPI CreateLayer()
        {
            return new DataLayerConcrete();
        }
        public static DataLayerAbstractAPI CreateLayer(InterfaceGenerator contentGenerator)
        {
            return contentGenerator.Create();
        }
        private class DataLayerConcrete : DataLayerAbstractAPI
        {
            private DataRepository repository;
            public DataLayerConcrete()
            {
                repository = new DataRepository();
            }



            //User
            public override void AddUser(InterfaceUser user)
            {
                repository.DataContext.AddUser(user);
            }
            public override void DeleteUser(InterfaceUser user)
            {
                repository.DataContext.DeleteUser(user);

            }
            public override List<InterfaceUser> GetUsers()
            {
                return repository.DataContext.GetUsers();
            }

            public override InterfaceUser GetUser(int id)
            {
                return repository.DataContext.GetUser(id);
            }



            //Event
            public override void AddEvent(InterfaceEvent InterfaceEvent)
            {
                repository.DataContext.AddEvent(InterfaceEvent);
            }
            public override void DeleteEvent(InterfaceEvent InterfaceEvent)
            {
                repository.DataContext.DeleteEvent(InterfaceEvent);

            }
            public override List<InterfaceEvent> GetEvents()
            {
                return repository.DataContext.GetEvents();
            }



            //State
            public override void AddState(InterfaceState state)
            {
                repository.DataContext.AddState(state);
            }
            public override void DeleteState(InterfaceState state)
            {
                repository.DataContext.DeleteState(state);

            }
            public override List<InterfaceState> GetStates()
            {
                return repository.DataContext.GetStates();
            }




            //Product
            public override void AddProduct(InterfaceProduct product)
            {
                repository.DataContext.AddProduct(product);
            }
            public override void DeleteProduct(InterfaceProduct product)
            {
                repository.DataContext.DeleteProduct(product);

            }
            public override List<InterfaceProduct> GetProducts()
            {
                return repository.DataContext.GetProducts();
            }
            public override InterfaceProduct GetProduct(int code)
            {
                return repository.DataContext.GetProduct(code);
            }
        }
    }
}


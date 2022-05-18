using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task1.DataLayer;

namespace TestProject1
{
    class Generator : InterfaceGenerator
    {
        public DataLayerAbstractAPI Create()
        {

            DataLayerAbstractAPI dataLayerAbstractAPI = DataLayerAbstractAPI.CreateLayer();


            InterfaceUser user1 = new User(09088461, "Carlos", "Plaza");

            dataLayerAbstractAPI.AddUser(user1);



            InterfaceProduct product1 = new Product(01, "Tv", 655);

            InterfaceProduct product2 = new Product(02, "Smartphone", 232);

            dataLayerAbstractAPI.AddProduct(product1);

            dataLayerAbstractAPI.AddProduct(product2);



            InterfaceState state1 = new State(product1);

            dataLayerAbstractAPI.AddState(state1);




            InterfaceEvent eventBuy1 = new EventBuy(state1, user1);

            dataLayerAbstractAPI.AddEvent(eventBuy1);



            return dataLayerAbstractAPI;

        }
    }
}

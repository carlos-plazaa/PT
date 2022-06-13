using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DataTest
{
    class Generator : InterfaceGenerator
    {
        public DataLayerAbstractAPI dataLayerAbstractAPI = DataLayerAbstractAPI.CreateLayer()
        {


        InterfaceUser user1 = new Client("Carlos", "Plaza", 09098461);

        dataLayerAbstractAPI.AddUser(user1);



        InterfaceProduct product1 = new Product(01, "Tv", 655);

        InterfaceProduct product2 = new Product(02, "Smartphone", 232);

        dataLayerAbstractAPI.AddProduct(product1);
            
        dataLayerAbstractAPI.AddProduct(product2);


        
        InterfaceState state1 = new State(product1);

        dataLayerAbstractAPI.AddState(state1);


        return dataLayerAbstractAPI;

        }

    }
}

using Microsoft.VisualStudio.TestTools.UnitTesting;
using 

namespace DataTest
{
    [TestClass]
    public class UnitTest1
    {
        private Generator generator;
        private DataLayerAbstractAPI datalayer;

        [TestInitialize]
        public void Testinitialize()
        {
            generator = new Generator();
            dataLayer = DataLayerAbstractAPI.CreateLayer(generator);
            generator.Create();


        }


        [TestMethod]
        public void AddUserTest()
        {
            InterfaceUser user = new User("Carlos", "Plaza", 09098461y);
            datalayer.AddUser(user);
        }

        [TestMethod]
        
        public void AddProductTest()
        {
            InterfaceProduct product = new Product(10, "radio", 100);
            datalayer.AddProduct(product);

        }
    }
}
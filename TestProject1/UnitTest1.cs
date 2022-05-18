using Microsoft.VisualStudio.TestTools.UnitTesting;
using Task1.DataLayer;
using TestProject1;


namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        private Generator generator;
        private DataLayerAbstractAPI dataLayer;

        [TestInitialize]
        public void Testinitialize()
        {
            generator = new Generator();
            dataLayer = DataLayerAbstractAPI.CreateLayer(generator);
            generator.Create();


        }

        //User Test

        [TestMethod]
        public void AddUserTest()
        {
            InterfaceUser user = new User(02345678, "Javier", "Fernandez");
            dataLayer.AddUser(user);
            Assert.AreEqual(dataLayer.GetUsers().Count, 2);
        }

        public void DeleteUserTest()
        {
            dataLayer.DeleteUser(dataLayer.GetUser(1));
            Assert.AreEqual(dataLayer.GetUsers().Count, 1);
        }

        public void GetUserTest()
        {
            InterfaceUser user = dataLayer.GetUser(09098461);
            Assert.AreEqual("Carlos", user.Name);
        }

        [TestMethod]

        public void AddProductTest()
        {
            InterfaceProduct product = new Product(10, "radio", 100);
            dataLayer.AddProduct(product);
            Assert.AreEqual(dataLayer.GetProducts().Count, 3);

        }


        public void DeleteProductTest()
        {
            dataLayer.DeleteProduct(dataLayer.GetProduct(2));
            Assert.AreEqual(dataLayer.GetProducts().Count, 1);

        }


        public void GetProductTest()
        {
            InterfaceProduct product = dataLayer.GetProduct(0);
            Assert.AreEqual("Smartphone", product.Details);

        }
    }
}
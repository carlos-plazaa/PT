using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task1.DataLayer;

namespace Task1.Logic
{
    internal class Service
    {
        private DataLayerAbstractAPI dataLayer;

        internal Service(DataLayerAbstractAPI dataLayer)
        {
            this.dataLayer = dataLayer;
        }

        //Client 

        internal void AddUser(int id, string name, string surname)
        {
            InterfaceUser user = dataLayer.GetUser(id);

            if (user != null)
            {
                throw new Exception("User with id already exists");
            }

            InterfaceUser newUser = new User(id, name, surname);
            dataLayer.AddUser(newUser);
        }
        internal void DeleteUser(int id)
        {
            InterfaceUser userToRemove = dataLayer.GetUser(id);

            if (userToRemove == null)
            {
                throw new Exception("User with id does not exist");
            }

            dataLayer.DeleteUser(userToRemove);
        }

        internal InterfaceUser GetUser(int id)
        {
            InterfaceUser user = dataLayer.GetUser(id);

            if (user == null)
            {
                throw new Exception("User with id does not exist");
            }

            return user;
        }

        internal List<InterfaceUser> GetUsers()
        {
            return dataLayer.GetUsers();
        }


        //Product

        internal void AddProduct(int code, string details, double price)
        {

            InterfaceProduct product = new Product(code, details, price);
            dataLayer.AddProduct(product);
        }
        internal void DeleteProduct(int code)
        {
            InterfaceProduct productToRemove = dataLayer.GetProduct(code);

            if (productToRemove != null)
            {
                throw new Exception("User with id does not exist");
            }

            dataLayer.DeleteProduct(productToRemove);
        }

        //Product actions

        internal void BuyProduct(int productCode, int UserId)
        {
            InterfaceProduct product = dataLayer.GetProduct(productCode);
            InterfaceUser user = dataLayer.GetUser(UserId);

            if (product == null)
            {
                throw new Exception("Product with code does not exist");
            }

            if (user == null)
            {
                throw new Exception("User with id does not exist");
            }
        }

        internal void ReturnProduct(InterfaceProduct product, int UserId)
        {
            InterfaceUser user = dataLayer.GetUser(UserId);

            if (product == null)
            {
                throw new Exception("Product with code does not exist");
            }

            if (user == null)
            {
                throw new Exception("User with id does not exist");
            }
        }

    }
}

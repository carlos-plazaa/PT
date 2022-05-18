using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task1.DataLayer;

namespace Task1.Logic
{
    public abstract class LogicAPI
    {
        //User
        public abstract void AddUser(int id, string name, string surname);
        public abstract void DeleteUser(int id);
        public abstract List<InterfaceUser> GetUsers();
        public abstract InterfaceUser GetUser(int id);

        //
        public abstract void BuyProduct(int productCode, int userCode);
        public abstract void ReturnProduct(InterfaceProduct product, int userCode);

        //
        public abstract void AddProduct(int code, string details, double price);
        public abstract void DeleteProduct(int code);


        public static LogicAPI CreateLayer(DataLayerAbstractAPI contentGenerator = default)
        {
            return new LogicLayer(contentGenerator ?? DataLayerAbstractAPI.CreateLayer());
        }

        private class LogicLayer : LogicAPI
        {
            private Service service;
            private DataLayerAbstractAPI dataLayer;
            public LogicLayer(DataLayerAbstractAPI dataLayer)
            {
                this.dataLayer = dataLayer;
                service = new Service(this.dataLayer);
            }

            public override void AddUser(int id, string name, string surname)
            {
                service.AddUser(id, name, surname);
            }

            public override void DeleteUser(int id)
            {
                service.DeleteUser(id);
            }
            public override List<InterfaceUser> GetUsers()
            {
                return service.GetUsers();
            }

            public override InterfaceUser GetUser(int id)
            {
                return service.GetUser(id);
            }

            public override void BuyProduct(int productCode, int UserId)
            {
                service.BuyProduct(productCode, UserId);

            }

            public override void ReturnProduct(InterfaceProduct product, int UserId)
            {
                service.ReturnProduct(product, UserId);

            }

            public override void AddProduct(int code, string details, double price)
            {
                service.AddProduct(code, details, price);
            }
            public override void DeleteProduct(int code)
            {
                service.DeleteProduct(code);
            }



        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Entities;
using ServicePatern;
using Data.Infrastructure;

namespace Service
{
    public class ShoppingCartService : Service<ShoppingCart>, IShoppingCartService
    {
        public static IDatabaseFactory dbFactory = new DatabaseFactory();
        public static IUnitOfWork ut = new UnitOfWork(dbFactory);
        public ShoppingCartService() : base(ut)
        {

        }

        public void setIdPanier()
        {
            IClientService AS = new ClientService();

            List<Client> ListClient = new List<Client>();
            foreach (var item in AS.GetAll())
            {
                Client A = new Client();
                A.id = item.id;

                ListClient.Add(A);
            }

            var req = from i in ListClient  select i.id;
            int lastId = req.Max();

            Client WithCart = AS.GetById(lastId);
            WithCart.idPanier = WithCart.id;


            AS.Update(WithCart);
            AS.Commit();
           
        }
    }
}

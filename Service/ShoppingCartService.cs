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
    }
}

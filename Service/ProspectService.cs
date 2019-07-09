using Data.Infrastructure;
using Domain.Entities;
using ServicePatern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public class ProspectService : Service<Prospect>, IProspectService
    {
        public static IDatabaseFactory dbFactory = new DatabaseFactory();
        public static IUnitOfWork ut = new UnitOfWork(dbFactory);
        public ProspectService() : base(ut)
        {

        }
    }
}

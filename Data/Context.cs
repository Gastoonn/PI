using Data.Configurations;
using Data.Conventions;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class Context : DbContext
    {
        public Context() : base("name=BD") //BD le meme que le nom dans name="" de <connection string> dans Web.config
        {

        }

        public DbSet<Client> Adherants { get; set; }
        public DbSet<Invoice> Invoice { get; set; }
        public DbSet<Pack> Pack { get; set; }
        public DbSet<Product> Product { get; set; }
        public DbSet<Quotation> Quotation { get; set; }
        public DbSet<Reclamation> Reclamation { get; set; }
        public DbSet<ShoppingCart> ShoppingCart { get; set; }
        public DbSet<Stock> Stock { get; set; }
        public DbSet<Store> Store { get; set; }
        public DbSet<User> User { get; set; }



        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            // Ajouter  les Conventions et configurations qui ont été créées ici : 
            //Conventions :
             modelBuilder.Conventions.Add(new DateTimeConvention());
            //Configuration :
             modelBuilder.Configurations.Add(new StockConfiguration());

            //Table per Type
           // modelBuilder.Entity<Livre>().ToTable("LivreTpt");
           // modelBuilder.Entity<CD>().ToTable("CdTpt");

            //Table per concrete Type
            //modelBuilder.Entity<Livre>()
            //    .Map(g => {
            //        g.MapInheritedProperties();
            //        g.ToTable("LivreTpc");
            //    });

            //modelBuilder.Entity<CD>()
            //    .Map(h => {
            //        h.MapInheritedProperties();
            //        h.ToTable("CdTpc");
            //    });

        }



    }
}

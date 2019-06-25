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

       // public DbSet<Adherant> Adherants { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            // Ajouter  les Conventions et configurations qui ont été créées ici : 
            //Conventions :
           // modelBuilder.Conventions.Add(new KeyConvention());
            //Configuration :
           // modelBuilder.Configurations.Add(new EmpruntConfiguration());

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

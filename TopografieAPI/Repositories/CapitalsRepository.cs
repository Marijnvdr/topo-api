using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using TopografieAPI.Entities;

namespace TopografieAPI.Repositories
{
    public class CapitalsRepository : DbContext
    {
        public CapitalsRepository()
            : base("DefaultConnection")
        {

        }
        // code to create and initialize the database for the first time

        static CapitalsRepository()
        {
            Database.SetInitializer<CapitalsRepository>(new CapitalsDbInitializer());
            using (var db = new CapitalsRepository())
            {
                db.Database.Initialize(false);
            }
        }

        public DbSet<CapitalEntity> Capitals { get; set; }
    }

    // code to create and initialize the database for the first time

    public class CapitalsDbInitializer : DropCreateDatabaseIfModelChanges<CapitalsRepository>
    {
        protected override void Seed(CapitalsRepository context)
        {
            context.Capitals.Add(new CapitalEntity { CapitalId = 1, Name = "Amsterdam", Country = "Nederland", Continent = "Europa" });
            context.Capitals.Add(new CapitalEntity { CapitalId = 2, Name = "Brussel", Country = "België", Continent = "Europa" });
            context.Capitals.Add(new CapitalEntity { CapitalId = 3, Name = "Parijs", Country = "Frankrijk", Continent = "Europa" });
            context.Capitals.Add(new CapitalEntity { CapitalId = 4, Name = "Madrid", Country = "Spanje", Continent = "Europa" });
            context.Capitals.Add(new CapitalEntity { CapitalId = 5, Name = "Lissabon", Country = "Portugal", Continent = "Europa" });
            context.Capitals.Add(new CapitalEntity { CapitalId = 6, Name = "Caïro", Country = "Egypte", Continent = "Afrika" });
            context.Capitals.Add(new CapitalEntity { CapitalId = 7, Name = "Canberra", Country = "Australië", Continent = "Oceanië" });
            base.Seed(context);
        }
    }
}
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using TopografieAPI.Entities;

namespace TopografieAPI.Repositories
{
    public class NatureElementsRepository : DbContext
    {
        // code to create and initialize the database for the first time
        /*
        static NatureElementsRepository()
        {
            Database.SetInitializer<NatureElementsRepository>(new DbInitializer());
            using (var db = new NatureElementsRepository())
            {
                db.Database.Initialize(false);
            }             
        }
        */
        public DbSet<Nature> NatureElements { get; set; }
    }

    // code to create and initialize the database for the first time
    /*
    public class DbInitializer : DropCreateDatabaseAlways<NatureElementsRepository>
    {
        protected override void Seed(NatureElementsRepository context)
        {
            context.NatureElements.Add(new Nature { NatureId = 1, Name = "Alpen", Category = 1 });
            context.NatureElements.Add(new Nature { NatureId = 2, Name = "Kilimanjaro", Category = 1 });
            base.Seed(context);
        }
    }
    */ 
}
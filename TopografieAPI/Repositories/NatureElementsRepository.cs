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
        public NatureElementsRepository()
            : base("DefaultConnection")
        {

        }
        // code to create and initialize the database for the first time
        
        static NatureElementsRepository()
        {
            Database.SetInitializer<NatureElementsRepository>(new NatureElementsDbInitializer());
            using (var db = new NatureElementsRepository())
            {
                db.Database.Initialize(false);
            }             
        }
        
        public DbSet<NatureEntity> NatureElements { get; set; }
    }

    // code to create and initialize the database for the first time

    public class NatureElementsDbInitializer : DropCreateDatabaseIfModelChanges<NatureElementsRepository>
    {
        protected override void Seed(NatureElementsRepository context)
        {
            context.NatureElements.Add(new NatureEntity { NatureId = 1, Name = "GreatBarierReef", Category = 1 });
            context.NatureElements.Add(new NatureEntity { NatureId = 2, Name = "GreatLakes", Category = 1 });
            base.Seed(context);
        }
    }
    
}
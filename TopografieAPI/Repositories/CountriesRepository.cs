using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using TopografieAPI.Entities;

namespace TopografieAPI.Repositories
{
    public class CountriesRepository : DbContext
    {
        public CountriesRepository()
            : base("DefaultConnection")
        {

        }
        // code to create and initialize the database for the first time

        static CountriesRepository()
        {
            Database.SetInitializer<CountriesRepository>(new CountriesDbInitializer());
            using (var db = new CountriesRepository())
            {
                db.Database.Initialize(false);
            }
        }

        public DbSet<CountryEntity> Countries { get; set; }
    }

    // code to create and initialize the database for the first time

    public class CountriesDbInitializer : DropCreateDatabaseIfModelChanges<CountriesRepository>
    {
        protected override void Seed(CountriesRepository context)
        {
            context.Countries.Add(new CountryEntity { CountryId = 1, Name = "Iceland", Name_nl = "Ijsland", Region = "150", SubRegion = "154", Code = "IS" });
            context.Countries.Add(new CountryEntity { CountryId = 2, Name = "Norway", Name_nl = "Noorwegen", Region = "150", SubRegion = "154", Code = "NO" });
            context.Countries.Add(new CountryEntity { CountryId = 3, Name = "Sweden", Name_nl = "Zweden", Region = "150", SubRegion = "154", Code = "SE" });
            context.Countries.Add(new CountryEntity { CountryId = 4, Name = "Finland", Name_nl = "Finland", Region = "150", SubRegion = "154", Code = "FI" });
            context.Countries.Add(new CountryEntity { CountryId = 5, Name = "Russia", Name_nl = "Rusland", Region = "150", SubRegion = "151", Code = "RU" });
            context.Countries.Add(new CountryEntity { CountryId = 6, Name = "Ireland", Name_nl = "Ierland", Region = "150", SubRegion = "154", Code = "IE" });
            context.Countries.Add(new CountryEntity { CountryId = 7, Name = "Great Britain", Name_nl = "Verenigd Koninkrijk", Region = "150", SubRegion = "154", Code = "GB" });
            context.Countries.Add(new CountryEntity { CountryId = 8, Name = "Netherlands", Name_nl = "Nederland", Region = "150", SubRegion = "155", Code = "NL" });
            context.Countries.Add(new CountryEntity { CountryId = 9, Name = "Belgium", Name_nl = "België", Region = "150", SubRegion = "155", Code = "BE" });
            context.Countries.Add(new CountryEntity { CountryId = 10, Name = "Luxembourg", Name_nl = "Luxemburg", Region = "150", SubRegion = "155", Code = "LU" });
            context.Countries.Add(new CountryEntity { CountryId = 11, Name = "Germany", Name_nl = "Duitsland", Region = "150", SubRegion = "155", Code = "DE" });
            context.Countries.Add(new CountryEntity { CountryId = 12, Name = "Denmark", Name_nl = "Denemarken", Region = "150", SubRegion = "154", Code = "DK" });
            context.Countries.Add(new CountryEntity { CountryId = 13, Name = "Estonia", Name_nl = "Estland", Region = "150", SubRegion = "154", Code = "EE" });
            context.Countries.Add(new CountryEntity { CountryId = 14, Name = "Latvia", Name_nl = "Letland", Region = "150", SubRegion = "154", Code = "LV" });
            context.Countries.Add(new CountryEntity { CountryId = 15, Name = "Lithuania", Name_nl = "Litouwen", Region = "150", SubRegion = "154", Code = "LT" });
            context.Countries.Add(new CountryEntity { CountryId = 16, Name = "Poland", Name_nl = "Polen", Region = "150", SubRegion = "151", Code = "PL" });
            context.Countries.Add(new CountryEntity { CountryId = 17, Name = "Belarus", Name_nl = "Wit-Rusland", Region = "150", SubRegion = "151", Code = "BY" });
            context.Countries.Add(new CountryEntity { CountryId = 18, Name = "Ukraine", Name_nl = "Oekraïne", Region = "150", SubRegion = "151", Code = "UA" });
            context.Countries.Add(new CountryEntity { CountryId = 19, Name = "Czech Republic", Name_nl = "Tsjechië", Region = "150", SubRegion = "151", Code = "CZ" });
            context.Countries.Add(new CountryEntity { CountryId = 20, Name = "Slovakia", Name_nl = "Slowakije", Region = "150", SubRegion = "151", Code = "SK" });
            context.Countries.Add(new CountryEntity { CountryId = 21, Name = "Portugal", Name_nl = "Portugal", Region = "150", SubRegion = "039", Code = "PT" });
            context.Countries.Add(new CountryEntity { CountryId = 22, Name = "Spain", Name_nl = "Spanje", Region = "150", SubRegion = "039", Code = "ES" });
            context.Countries.Add(new CountryEntity { CountryId = 23, Name = "France", Name_nl = "Frankrijk", Region = "150", SubRegion = "155", Code = "FR" });
            context.Countries.Add(new CountryEntity { CountryId = 24, Name = "Switzerland", Name_nl = "Zwitserland", Region = "150", SubRegion = "155", Code = "CH" });
            context.Countries.Add(new CountryEntity { CountryId = 25, Name = "Italy", Name_nl = "Italië", Region = "150", SubRegion = "039", Code = "IT" });
            context.Countries.Add(new CountryEntity { CountryId = 26, Name = "Austria", Name_nl = "Oostenrijk", Region = "150", SubRegion = "155", Code = "AT" });
            context.Countries.Add(new CountryEntity { CountryId = 27, Name = "Hungary", Name_nl = "Hongarije", Region = "150", SubRegion = "151", Code = "HU" });
            context.Countries.Add(new CountryEntity { CountryId = 28, Name = "Romania", Name_nl = "Roemenië", Region = "150", SubRegion = "151", Code = "RO" });
            context.Countries.Add(new CountryEntity { CountryId = 29, Name = "Moldova", Name_nl = "Moldavië", Region = "150", SubRegion = "151", Code = "MD" });
            context.Countries.Add(new CountryEntity { CountryId = 30, Name = "Slovenia", Name_nl = "Slovenië", Region = "150", SubRegion = "039", Code = "SI" });
            context.Countries.Add(new CountryEntity { CountryId = 31, Name = "Croatia", Name_nl = "Kroatië", Region = "150", SubRegion = "039", Code = "HR" });
            context.Countries.Add(new CountryEntity { CountryId = 32, Name = "Bosnia and Herzegovina", Name_nl = "Bosnië en Herzegovina", Region = "150", SubRegion = "039", Code = "BA" });
            context.Countries.Add(new CountryEntity { CountryId = 33, Name = "Serbia", Name_nl = "Servië", Region = "150", SubRegion = "039", Code = "RS" });
            context.Countries.Add(new CountryEntity { CountryId = 34, Name = "Albania", Name_nl = "Albanië", Region = "150", SubRegion = "039", Code = "AL" });
            context.Countries.Add(new CountryEntity { CountryId = 35, Name = "Macedonia", Name_nl = "Macedonië", Region = "150", SubRegion = "039", Code = "MK" });
            context.Countries.Add(new CountryEntity { CountryId = 36, Name = "Bulgaria", Name_nl = "Bulgarije", Region = "150", SubRegion = "151", Code = "BG" });
            context.Countries.Add(new CountryEntity { CountryId = 37, Name = "Greece", Name_nl = "Griekenland", Region = "150", SubRegion = "039", Code = "GR" });
            context.Countries.Add(new CountryEntity { CountryId = 38, Name = "Malta", Name_nl = "Malta", Region = "150", SubRegion = "039", Code = "MT" });
            context.Countries.Add(new CountryEntity { CountryId = 39, Name = "Egypt", Name_nl = "Egypte", Region = "002", SubRegion = "015", Code = "EG" });
            context.Countries.Add(new CountryEntity { CountryId = 40, Name = "Australia", Name_nl = "Australië", Region = "009", SubRegion = "053", Code = "AU" });

            base.Seed(context);
        }
    }
}
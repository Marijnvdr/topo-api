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
            context.Countries.Add(new CountryEntity { CountryId = 1, Name = "Iceland", Name_nl = "Ijsland", Region = "150", SubRegion = "154", Code = "IS", ShowSubRegion = false, DifficultyLevel = 2 });
            context.Countries.Add(new CountryEntity { CountryId = 2, Name = "Norway", Name_nl = "Noorwegen", Region = "150", SubRegion = "154", Code = "NO", ShowSubRegion = false, DifficultyLevel = 2 });
            context.Countries.Add(new CountryEntity { CountryId = 3, Name = "Sweden", Name_nl = "Zweden", Region = "150", SubRegion = "154", Code = "SE", ShowSubRegion = false, DifficultyLevel = 2 });
            context.Countries.Add(new CountryEntity { CountryId = 4, Name = "Finland", Name_nl = "Finland", Region = "150", SubRegion = "154", Code = "FI", ShowSubRegion = false, DifficultyLevel = 2 });
            context.Countries.Add(new CountryEntity { CountryId = 5, Name = "Russia", Name_nl = "Rusland", Region = "150", SubRegion = "151", Code = "RU", ShowSubRegion = false, DifficultyLevel = 0 });
            context.Countries.Add(new CountryEntity { CountryId = 6, Name = "Ireland", Name_nl = "Ierland", Region = "150", SubRegion = "154", Code = "IE", ShowSubRegion = false, DifficultyLevel = 2 });
            context.Countries.Add(new CountryEntity { CountryId = 7, Name = "Great Britain", Name_nl = "Verenigd Koninkrijk", Region = "150", SubRegion = "154", Code = "GB", ShowSubRegion = false, DifficultyLevel = 0 });
            context.Countries.Add(new CountryEntity { CountryId = 8, Name = "Netherlands", Name_nl = "Nederland", Region = "150", SubRegion = "155", Code = "NL", ShowSubRegion = false, DifficultyLevel = 1 });
            context.Countries.Add(new CountryEntity { CountryId = 9, Name = "Belgium", Name_nl = "België", Region = "150", SubRegion = "155", Code = "BE", ShowSubRegion = false, DifficultyLevel = 2 });
            context.Countries.Add(new CountryEntity { CountryId = 10, Name = "Luxembourg", Name_nl = "Luxemburg", Region = "150", SubRegion = "155", Code = "LU", ShowSubRegion = true, DifficultyLevel = 2 });
            context.Countries.Add(new CountryEntity { CountryId = 11, Name = "Germany", Name_nl = "Duitsland", Region = "150", SubRegion = "155", Code = "DE", ShowSubRegion = false, DifficultyLevel = 0 });
            context.Countries.Add(new CountryEntity { CountryId = 12, Name = "Denmark", Name_nl = "Denemarken", Region = "150", SubRegion = "154", Code = "DK", ShowSubRegion = false, DifficultyLevel = 1 });
            context.Countries.Add(new CountryEntity { CountryId = 13, Name = "Estonia", Name_nl = "Estland", Region = "150", SubRegion = "154", Code = "EE", ShowSubRegion = false, DifficultyLevel = 3 });
            context.Countries.Add(new CountryEntity { CountryId = 14, Name = "Latvia", Name_nl = "Letland", Region = "150", SubRegion = "154", Code = "LV", ShowSubRegion = false, DifficultyLevel = 3 });
            context.Countries.Add(new CountryEntity { CountryId = 15, Name = "Lithuania", Name_nl = "Litouwen", Region = "150", SubRegion = "154", Code = "LT", ShowSubRegion = false, DifficultyLevel = 3 });
            context.Countries.Add(new CountryEntity { CountryId = 16, Name = "Poland", Name_nl = "Polen", Region = "150", SubRegion = "151", Code = "PL", ShowSubRegion = false, DifficultyLevel = 2 });
            context.Countries.Add(new CountryEntity { CountryId = 17, Name = "Belarus", Name_nl = "Wit-Rusland", Region = "150", SubRegion = "151", Code = "BY", ShowSubRegion = false, DifficultyLevel = 2 });
            context.Countries.Add(new CountryEntity { CountryId = 18, Name = "Ukraine", Name_nl = "Oekraïne", Region = "150", SubRegion = "151", Code = "UA", ShowSubRegion = false, DifficultyLevel = 2 });
            context.Countries.Add(new CountryEntity { CountryId = 19, Name = "Czech Republic", Name_nl = "Tsjechië", Region = "150", SubRegion = "151", Code = "CZ", ShowSubRegion = false, DifficultyLevel = 2 });
            context.Countries.Add(new CountryEntity { CountryId = 20, Name = "Slovakia", Name_nl = "Slowakije", Region = "150", SubRegion = "151", Code = "SK", ShowSubRegion = false, DifficultyLevel = 2 });
            context.Countries.Add(new CountryEntity { CountryId = 21, Name = "Portugal", Name_nl = "Portugal", Region = "150", SubRegion = "039", Code = "PT", ShowSubRegion = false, DifficultyLevel = 1 });
            context.Countries.Add(new CountryEntity { CountryId = 22, Name = "Spain", Name_nl = "Spanje", Region = "150", SubRegion = "039", Code = "ES", ShowSubRegion = false, DifficultyLevel = 0 });
            context.Countries.Add(new CountryEntity { CountryId = 23, Name = "France", Name_nl = "Frankrijk", Region = "150", SubRegion = "155", Code = "FR", ShowSubRegion = false, DifficultyLevel = 0 });
            context.Countries.Add(new CountryEntity { CountryId = 24, Name = "Switzerland", Name_nl = "Zwitserland", Region = "150", SubRegion = "155", Code = "CH", ShowSubRegion = false, DifficultyLevel = 1 });
            context.Countries.Add(new CountryEntity { CountryId = 25, Name = "Italy", Name_nl = "Italië", Region = "150", SubRegion = "039", Code = "IT", ShowSubRegion = false, DifficultyLevel = 0 });
            context.Countries.Add(new CountryEntity { CountryId = 26, Name = "Austria", Name_nl = "Oostenrijk", Region = "150", SubRegion = "155", Code = "AT", ShowSubRegion = false, DifficultyLevel = 2 });
            context.Countries.Add(new CountryEntity { CountryId = 27, Name = "Hungary", Name_nl = "Hongarije", Region = "150", SubRegion = "151", Code = "HU", ShowSubRegion = false, DifficultyLevel = 2 });
            context.Countries.Add(new CountryEntity { CountryId = 28, Name = "Romania", Name_nl = "Roemenië", Region = "150", SubRegion = "151", Code = "RO", ShowSubRegion = false, DifficultyLevel = 2 });
            context.Countries.Add(new CountryEntity { CountryId = 29, Name = "Moldova", Name_nl = "Moldavië", Region = "150", SubRegion = "151", Code = "MD", ShowSubRegion = false, DifficultyLevel = 3 });
            context.Countries.Add(new CountryEntity { CountryId = 30, Name = "Slovenia", Name_nl = "Slovenië", Region = "150", SubRegion = "039", Code = "SI", ShowSubRegion = false, DifficultyLevel = 3 });
            context.Countries.Add(new CountryEntity { CountryId = 31, Name = "Croatia", Name_nl = "Kroatië", Region = "150", SubRegion = "039", Code = "HR", ShowSubRegion = false, DifficultyLevel = 2 });
            context.Countries.Add(new CountryEntity { CountryId = 32, Name = "Bosnia and Herzegovina", Name_nl = "Bosnië en Herzegovina", Region = "150", SubRegion = "039", Code = "BA", ShowSubRegion = false, DifficultyLevel = 3 });
            context.Countries.Add(new CountryEntity { CountryId = 33, Name = "Serbia", Name_nl = "Servië", Region = "150", SubRegion = "039", Code = "RS", ShowSubRegion = false, DifficultyLevel = 3 });
            context.Countries.Add(new CountryEntity { CountryId = 34, Name = "Albania", Name_nl = "Albanië", Region = "150", SubRegion = "039", Code = "AL", ShowSubRegion = false, DifficultyLevel = 3 });
            context.Countries.Add(new CountryEntity { CountryId = 35, Name = "Macedonia", Name_nl = "Macedonië", Region = "150", SubRegion = "039", Code = "MK", ShowSubRegion = false, DifficultyLevel = 3 });
            context.Countries.Add(new CountryEntity { CountryId = 36, Name = "Bulgaria", Name_nl = "Bulgarije", Region = "150", SubRegion = "151", Code = "BG", ShowSubRegion = false, DifficultyLevel = 2 });
            context.Countries.Add(new CountryEntity { CountryId = 37, Name = "Greece", Name_nl = "Griekenland", Region = "150", SubRegion = "039", Code = "GR", ShowSubRegion = false, DifficultyLevel = 1 });
            context.Countries.Add(new CountryEntity { CountryId = 38, Name = "Malta", Name_nl = "Malta", Region = "150", SubRegion = "039", Code = "MT", ShowSubRegion = true, DifficultyLevel = 3 });
            context.Countries.Add(new CountryEntity { CountryId = 39, Name = "Colombia", Name_nl = "Colombia", Region = "019", SubRegion = "005", Code = "CO", ShowSubRegion = true, DifficultyLevel = 2 });
            context.Countries.Add(new CountryEntity { CountryId = 40, Name = "Venezuela", Name_nl = "Venezuela", Region = "019", SubRegion = "005", Code = "VE", ShowSubRegion = true, DifficultyLevel = 2 });
            context.Countries.Add(new CountryEntity { CountryId = 41, Name = "Guyana", Name_nl = "Guyana", Region = "019", SubRegion = "005", Code = "GY", ShowSubRegion = true, DifficultyLevel = 3 });
            context.Countries.Add(new CountryEntity { CountryId = 42, Name = "Suriname", Name_nl = "Suriname", Region = "019", SubRegion = "005", Code = "SR", ShowSubRegion = true, DifficultyLevel = 3 });
            context.Countries.Add(new CountryEntity { CountryId = 43, Name = "French Guiana", Name_nl = "Frans-Guyana", Region = "019", SubRegion = "005", Code = "GF", ShowSubRegion = true, DifficultyLevel = 3 });
            context.Countries.Add(new CountryEntity { CountryId = 44, Name = "Ecuador", Name_nl = "Ecuador", Region = "019", SubRegion = "005", Code = "EC", ShowSubRegion = true, DifficultyLevel = 2 });
            context.Countries.Add(new CountryEntity { CountryId = 45, Name = "Peru", Name_nl = "Peru", Region = "019", SubRegion = "005", Code = "PE", ShowSubRegion = true, DifficultyLevel = 2 });
            context.Countries.Add(new CountryEntity { CountryId = 46, Name = "Brazil", Name_nl = "Brazilië", Region = "019", SubRegion = "005", Code = "BR", ShowSubRegion = false, DifficultyLevel = 0 });
            context.Countries.Add(new CountryEntity { CountryId = 47, Name = "Bolivia", Name_nl = "Bolivia", Region = "019", SubRegion = "005", Code = "BO", ShowSubRegion = true, DifficultyLevel = 2 });
            context.Countries.Add(new CountryEntity { CountryId = 48, Name = "Chile", Name_nl = "Chili", Region = "019", SubRegion = "005", Code = "CL", ShowSubRegion = true, DifficultyLevel = 1 });
            context.Countries.Add(new CountryEntity { CountryId = 49, Name = "Argentina", Name_nl = "Argentinië", Region = "019", SubRegion = "005", Code = "AR", ShowSubRegion = true, DifficultyLevel = 0 });
            context.Countries.Add(new CountryEntity { CountryId = 50, Name = "Paraguay", Name_nl = "Paraguay", Region = "019", SubRegion = "005", Code = "PY", ShowSubRegion = true, DifficultyLevel = 2 });
            context.Countries.Add(new CountryEntity { CountryId = 51, Name = "Uruguay", Name_nl = "Uruguay", Region = "019", SubRegion = "005", Code = "UY", ShowSubRegion = true, DifficultyLevel = 2 });
            context.Countries.Add(new CountryEntity { CountryId = 52, Name = "Falkland Islands", Name_nl = "Falkland eilanden", Region = "019", SubRegion = "005", Code = "FK", ShowSubRegion = true, DifficultyLevel = 3 });
            context.Countries.Add(new CountryEntity { CountryId = 53, Name = "Canada", Name_nl = "Canada", Region = "019", SubRegion = "021", Code = "CA", ShowSubRegion = false, DifficultyLevel = 0 });
            context.Countries.Add(new CountryEntity { CountryId = 54, Name = "Greenland", Name_nl = "Groenland", Region = "019", SubRegion = "021", Code = "GL", ShowSubRegion = false, DifficultyLevel = 1 });
            context.Countries.Add(new CountryEntity { CountryId = 55, Name = "United States", Name_nl = "Verenigde Staten", Region = "019", SubRegion = "021", Code = "US", ShowSubRegion = false, DifficultyLevel = 0 });
            context.Countries.Add(new CountryEntity { CountryId = 56, Name = "Mexico", Name_nl = "Mexico", Region = "019", SubRegion = "013", Code = "MX", ShowSubRegion = true, DifficultyLevel = 0 });
            context.Countries.Add(new CountryEntity { CountryId = 57, Name = "Belize", Name_nl = "Belize", Region = "019", SubRegion = "013", Code = "BZ", ShowSubRegion = true, DifficultyLevel = 3 });
            context.Countries.Add(new CountryEntity { CountryId = 58, Name = "Guatemala", Name_nl = "Guatemala", Region = "019", SubRegion = "013", Code = "GT", ShowSubRegion = true, DifficultyLevel = 2 });
            context.Countries.Add(new CountryEntity { CountryId = 59, Name = "El Salvador", Name_nl = "El Salvador", Region = "019", SubRegion = "013", Code = "SV", ShowSubRegion = true, DifficultyLevel = 2 });
            context.Countries.Add(new CountryEntity { CountryId = 60, Name = "Costa Rica", Name_nl = "Costa Rica", Region = "019", SubRegion = "013", Code = "CR", ShowSubRegion = true, DifficultyLevel = 2 });
            context.Countries.Add(new CountryEntity { CountryId = 61, Name = "Honduras", Name_nl = "Honduras", Region = "019", SubRegion = "013", Code = "HN", ShowSubRegion = true, DifficultyLevel = 2 });
            context.Countries.Add(new CountryEntity { CountryId = 62, Name = "Nicaragua", Name_nl = "Nicaragua", Region = "019", SubRegion = "013", Code = "NI", ShowSubRegion = true, DifficultyLevel = 2 });
            context.Countries.Add(new CountryEntity { CountryId = 63, Name = "Panama", Name_nl = "Panama", Region = "019", SubRegion = "013", Code = "PA", ShowSubRegion = true, DifficultyLevel = 2 });
            context.Countries.Add(new CountryEntity { CountryId = 64, Name = "Cuba", Name_nl = "Cuba", Region = "019", SubRegion = "029", Code = "CU", ShowSubRegion = true, DifficultyLevel = 2 });
            context.Countries.Add(new CountryEntity { CountryId = 65, Name = "Jamaica", Name_nl = "Jamaica", Region = "019", SubRegion = "029", Code = "JM", ShowSubRegion = true, DifficultyLevel = 3 });
            context.Countries.Add(new CountryEntity { CountryId = 66, Name = "Bahamas", Name_nl = "Bahama's", Region = "019", SubRegion = "029", Code = "BS", ShowSubRegion = true, DifficultyLevel = 3 });
            context.Countries.Add(new CountryEntity { CountryId = 67, Name = "Haiti", Name_nl = "Haïti", Region = "019", SubRegion = "029", Code = "HT", ShowSubRegion = true, DifficultyLevel = 3 });
            context.Countries.Add(new CountryEntity { CountryId = 68, Name = "Dominican Republic", Name_nl = "Dominicaanse Republiek", Region = "019", SubRegion = "029", Code = "DO", ShowSubRegion = true, DifficultyLevel = 3 });
            context.Countries.Add(new CountryEntity { CountryId = 69, Name = "Puerto Rico", Name_nl = "Puerto Rico", Region = "019", SubRegion = "029", Code = "PR", ShowSubRegion = true, DifficultyLevel = 3 });
            context.Countries.Add(new CountryEntity { CountryId = 70, Name = "Virgin Islands", Name_nl = "Maagdeneilanden", Region = "019", SubRegion = "029", Code = "VI", ShowSubRegion = true, DifficultyLevel = 4 });
            context.Countries.Add(new CountryEntity { CountryId = 71, Name = "Saint Martin", Name_nl = "Sint Maarten", Region = "019", SubRegion = "029", Code = "SX", ShowSubRegion = true, DifficultyLevel = 4 });
            context.Countries.Add(new CountryEntity { CountryId = 72, Name = "Anguilla", Name_nl = "Anguilla", Region = "019", SubRegion = "029", Code = "AI", ShowSubRegion = true, DifficultyLevel = 4 });
            context.Countries.Add(new CountryEntity { CountryId = 73, Name = "Bonaire", Name_nl = "Bonaire", Region = "019", SubRegion = "029", Code = "BQ", ShowSubRegion = true, DifficultyLevel = 4 });
            context.Countries.Add(new CountryEntity { CountryId = 74, Name = "Antigua and Barbuda", Name_nl = "Antigua en Barbuda", Region = "019", SubRegion = "029", Code = "AG", ShowSubRegion = true, DifficultyLevel = 4 });
            context.Countries.Add(new CountryEntity { CountryId = 75, Name = "Saint Kitts and Nevis", Name_nl = "Saint Kitts en Nevis", Region = "019", SubRegion = "029", Code = "KN", ShowSubRegion = true, DifficultyLevel = 4 });                        
            context.Countries.Add(new CountryEntity { CountryId = 76, Name = "Morocco", Name_nl = "Marokko", Region = "002", SubRegion = "015", Code = "MA", ShowSubRegion = true, DifficultyLevel = 1 });
            context.Countries.Add(new CountryEntity { CountryId = 77, Name = "Algeria", Name_nl = "Algerije", Region = "002", SubRegion = "015", Code = "DZ", ShowSubRegion = true, DifficultyLevel = 1 });
            context.Countries.Add(new CountryEntity { CountryId = 78, Name = "Tunisia", Name_nl = "Tunesië", Region = "002", SubRegion = "015", Code = "TN", ShowSubRegion = true, DifficultyLevel = 1 });
            context.Countries.Add(new CountryEntity { CountryId = 79, Name = "Libya", Name_nl = "Libië", Region = "002", SubRegion = "015", Code = "LY", ShowSubRegion = true, DifficultyLevel = 1 });
            context.Countries.Add(new CountryEntity { CountryId = 80, Name = "Egypt", Name_nl = "Egypte", Region = "002", SubRegion = "015", Code = "EG", ShowSubRegion = true, DifficultyLevel = 1 });
            context.Countries.Add(new CountryEntity { CountryId = 81, Name = "Sudan", Name_nl = "Sudan", Region = "002", SubRegion = "015", Code = "SD", ShowSubRegion = true, DifficultyLevel = 3 });
            context.Countries.Add(new CountryEntity { CountryId = 82, Name = "Chad", Name_nl = "Tsjaad", Region = "002", SubRegion = "017", Code = "TD", ShowSubRegion = true, DifficultyLevel = 3 });
            context.Countries.Add(new CountryEntity { CountryId = 83, Name = "Niger", Name_nl = "Niger", Region = "002", SubRegion = "011", Code = "NE", ShowSubRegion = true, DifficultyLevel = 4 });
            context.Countries.Add(new CountryEntity { CountryId = 84, Name = "Mali", Name_nl = "Mali", Region = "002", SubRegion = "011", Code = "ML", ShowSubRegion = true, DifficultyLevel = 4 });
            context.Countries.Add(new CountryEntity { CountryId = 85, Name = "Mauritania", Name_nl = "Mauritanië", Region = "002", SubRegion = "011", Code = "MR", ShowSubRegion = true, DifficultyLevel = 4 });
            context.Countries.Add(new CountryEntity { CountryId = 86, Name = "Western Sahara", Name_nl = "West Sahara", Region = "002", SubRegion = "015", Code = "EH", ShowSubRegion = true, DifficultyLevel = 4 });
            context.Countries.Add(new CountryEntity { CountryId = 87, Name = "Senegal", Name_nl = "Senegal", Region = "002", SubRegion = "011", Code = "SN", ShowSubRegion = true, DifficultyLevel = 4 });
            context.Countries.Add(new CountryEntity { CountryId = 88, Name = "Gambia", Name_nl = "Gambia", Region = "002", SubRegion = "011", Code = "GM", ShowSubRegion = true, DifficultyLevel = 4 });
            context.Countries.Add(new CountryEntity { CountryId = 89, Name = "Guinea-Bissau", Name_nl = "Guinee Bissau", Region = "002", SubRegion = "011", Code = "GW", ShowSubRegion = true, DifficultyLevel = 4 });
            context.Countries.Add(new CountryEntity { CountryId = 90, Name = "Guinea", Name_nl = "Guinee", Region = "002", SubRegion = "011", Code = "GN", ShowSubRegion = true, DifficultyLevel = 4 });
            context.Countries.Add(new CountryEntity { CountryId = 91, Name = "Sierra Leone", Name_nl = "Sierra Leone", Region = "002", SubRegion = "011", Code = "SL", ShowSubRegion = true, DifficultyLevel = 4 });
            context.Countries.Add(new CountryEntity { CountryId = 92, Name = "Liberia", Name_nl = "Liberia", Region = "002", SubRegion = "011", Code = "LR", ShowSubRegion = true, DifficultyLevel = 4 });
            context.Countries.Add(new CountryEntity { CountryId = 93, Name = "Côte d'Ivoire", Name_nl = "Ivoorkust", Region = "002", SubRegion = "011", Code = "CI", ShowSubRegion = true, DifficultyLevel = 3 });
            context.Countries.Add(new CountryEntity { CountryId = 94, Name = "Burkina Faso", Name_nl = "Burkina Faso", Region = "002", SubRegion = "011", Code = "BF", ShowSubRegion = true, DifficultyLevel = 4 });
            context.Countries.Add(new CountryEntity { CountryId = 95, Name = "Ghana", Name_nl = "Ghana", Region = "002", SubRegion = "011", Code = "GH", ShowSubRegion = true, DifficultyLevel = 3 });
            context.Countries.Add(new CountryEntity { CountryId = 96, Name = "Togo", Name_nl = "Togo", Region = "002", SubRegion = "011", Code = "TG", ShowSubRegion = true, DifficultyLevel = 4 });
            context.Countries.Add(new CountryEntity { CountryId = 97, Name = "Benin", Name_nl = "Benin", Region = "002", SubRegion = "011", Code = "BJ", ShowSubRegion = true, DifficultyLevel = 4 });
            context.Countries.Add(new CountryEntity { CountryId = 98, Name = "Nigeria", Name_nl = "Nigeria", Region = "002", SubRegion = "011", Code = "NG", ShowSubRegion = true, DifficultyLevel = 2 });
            context.Countries.Add(new CountryEntity { CountryId = 99, Name = "Cameroon", Name_nl = "Kameroen", Region = "002", SubRegion = "017", Code = "CM", ShowSubRegion = true, DifficultyLevel = 3 });
            context.Countries.Add(new CountryEntity { CountryId = 100, Name = "Central African Republic", Name_nl = "Centraal Afrika", Region = "002", SubRegion = "017", Code = "CF", ShowSubRegion = true, DifficultyLevel = 3 });
            context.Countries.Add(new CountryEntity { CountryId = 101, Name = "Ethiopia", Name_nl = "Ethiopië", Region = "002", SubRegion = "014", Code = "ET", ShowSubRegion = true, DifficultyLevel = 2 });
            context.Countries.Add(new CountryEntity { CountryId = 102, Name = "Eritrea", Name_nl = "Eritrea", Region = "002", SubRegion = "014", Code = "ER", ShowSubRegion = true, DifficultyLevel = 3 });
            context.Countries.Add(new CountryEntity { CountryId = 103, Name = "Djibouti", Name_nl = "Djibouti", Region = "002", SubRegion = "014", Code = "DJ", ShowSubRegion = true, DifficultyLevel = 4 });
            context.Countries.Add(new CountryEntity { CountryId = 104, Name = "Somalia", Name_nl = "Somalië", Region = "002", SubRegion = "014", Code = "SO", ShowSubRegion = true, DifficultyLevel = 4 });
            context.Countries.Add(new CountryEntity { CountryId = 105, Name = "Kenya", Name_nl = "Kenya", Region = "002", SubRegion = "014", Code = "KE", ShowSubRegion = true, DifficultyLevel = 2 });
            context.Countries.Add(new CountryEntity { CountryId = 106, Name = "Uganda", Name_nl = "Uganda", Region = "002", SubRegion = "014", Code = "UG", ShowSubRegion = true, DifficultyLevel = 3 });
            context.Countries.Add(new CountryEntity { CountryId = 107, Name = "Rwanda", Name_nl = "Rwanda", Region = "002", SubRegion = "014", Code = "RW", ShowSubRegion = true, DifficultyLevel = 4 });
            context.Countries.Add(new CountryEntity { CountryId = 108, Name = "Burundi", Name_nl = "Burundi", Region = "002", SubRegion = "014", Code = "BI", ShowSubRegion = true, DifficultyLevel = 4 });
            context.Countries.Add(new CountryEntity { CountryId = 109, Name = "Tanzania", Name_nl = "Tanzania", Region = "002", SubRegion = "014", Code = "TZ", ShowSubRegion = true, DifficultyLevel = 2 });
            context.Countries.Add(new CountryEntity { CountryId = 110, Name = "the Democratic Republic of the Congo", Name_nl = "Zaire", Region = "002", SubRegion = "017", Code = "CD", ShowSubRegion = true, DifficultyLevel = 3 });
            context.Countries.Add(new CountryEntity { CountryId = 111, Name = "Congo", Name_nl = "Kongo", Region = "002", SubRegion = "017", Code = "CG", ShowSubRegion = true, DifficultyLevel = 3 });
            context.Countries.Add(new CountryEntity { CountryId = 112, Name = "Equatorial Guinea", Name_nl = "Equatoriaal Guinea", Region = "002", SubRegion = "017", Code = "GQ", ShowSubRegion = true, DifficultyLevel = 4 });
            context.Countries.Add(new CountryEntity { CountryId = 113, Name = "Gabon", Name_nl = "Gabon", Region = "002", SubRegion = "017", Code = "GA", ShowSubRegion = true, DifficultyLevel = 4 });
            context.Countries.Add(new CountryEntity { CountryId = 114, Name = "Angola", Name_nl = "Angola", Region = "002", SubRegion = "017", Code = "AO", ShowSubRegion = true, DifficultyLevel = 4 });
            context.Countries.Add(new CountryEntity { CountryId = 115, Name = "Zambia", Name_nl = "Zambia", Region = "002", SubRegion = "014", Code = "ZM", ShowSubRegion = true, DifficultyLevel = 4 });
            context.Countries.Add(new CountryEntity { CountryId = 116, Name = "Malawi", Name_nl = "Malawi", Region = "002", SubRegion = "014", Code = "MW", ShowSubRegion = true, DifficultyLevel = 4 });
            context.Countries.Add(new CountryEntity { CountryId = 117, Name = "Mozambique", Name_nl = "Mozambique", Region = "002", SubRegion = "014", Code = "MZ", ShowSubRegion = true, DifficultyLevel = 4 });
            context.Countries.Add(new CountryEntity { CountryId = 118, Name = "Zimbabwe", Name_nl = "Zimbabwe", Region = "002", SubRegion = "014", Code = "ZW", ShowSubRegion = true, DifficultyLevel = 4 });
            context.Countries.Add(new CountryEntity { CountryId = 119, Name = "Botswana", Name_nl = "Botswana", Region = "002", SubRegion = "018", Code = "BW", ShowSubRegion = true, DifficultyLevel = 4 });
            context.Countries.Add(new CountryEntity { CountryId = 120, Name = "Namibia", Name_nl = "Namibië", Region = "002", SubRegion = "018", Code = "NA", ShowSubRegion = true, DifficultyLevel = 4 });
            context.Countries.Add(new CountryEntity { CountryId = 121, Name = "South Africa", Name_nl = "Zuid-Afrika", Region = "002", SubRegion = "018", Code = "ZA", ShowSubRegion = false, DifficultyLevel = 1 });
            context.Countries.Add(new CountryEntity { CountryId = 122, Name = "Lesotho", Name_nl = "Lesotho", Region = "002", SubRegion = "018", Code = "LS", ShowSubRegion = true, DifficultyLevel = 3 });
            context.Countries.Add(new CountryEntity { CountryId = 123, Name = "Swaziland", Name_nl = "Swaziland", Region = "002", SubRegion = "018", Code = "SZ", ShowSubRegion = true, DifficultyLevel = 3 });
            context.Countries.Add(new CountryEntity { CountryId = 124, Name = "Madagascar", Name_nl = "Madagascar", Region = "002", SubRegion = "014", Code = "MG", ShowSubRegion = true, DifficultyLevel = 1 });
            context.Countries.Add(new CountryEntity { CountryId = 125, Name = "Mauritius", Name_nl = "Mauritius", Region = "002", SubRegion = "014", Code = "MU", ShowSubRegion = true, DifficultyLevel = 3 });
            context.Countries.Add(new CountryEntity { CountryId = 126, Name = "Seychelles", Name_nl = "Seychellen", Region = "002", SubRegion = "014", Code = "SC", ShowSubRegion = true, DifficultyLevel = 3 });
            context.Countries.Add(new CountryEntity { CountryId = 127, Name = "Georgia", Name_nl = "Georgië", Region = "142", SubRegion = "145", Code = "GE", ShowSubRegion = false, DifficultyLevel = 4 });
            context.Countries.Add(new CountryEntity { CountryId = 128, Name = "Azerbaijan", Name_nl = "Azerbaidzjan", Region = "142", SubRegion = "145", Code = "AZ", ShowSubRegion = false, DifficultyLevel = 4 });
            context.Countries.Add(new CountryEntity { CountryId = 129, Name = "Armenia", Name_nl = "Armenië", Region = "142", SubRegion = "145", Code = "AM", ShowSubRegion = false, DifficultyLevel = 4 });
            context.Countries.Add(new CountryEntity { CountryId = 130, Name = "Turkey", Name_nl = "Turkije", Region = "142", SubRegion = "145", Code = "TR", ShowSubRegion = false, DifficultyLevel = 0 });
            context.Countries.Add(new CountryEntity { CountryId = 131, Name = "Cyprus", Name_nl = "Cyprus", Region = "142", SubRegion = "145", Code = "CY", ShowSubRegion = true, DifficultyLevel = 1 });
            context.Countries.Add(new CountryEntity { CountryId = 132, Name = "Syria", Name_nl = "Syrië", Region = "142", SubRegion = "145", Code = "SY", ShowSubRegion = false, DifficultyLevel = 2 });
            context.Countries.Add(new CountryEntity { CountryId = 133, Name = "Lebanon", Name_nl = "Libanon", Region = "142", SubRegion = "145", Code = "LB", ShowSubRegion = false, DifficultyLevel = 3 });
            context.Countries.Add(new CountryEntity { CountryId = 134, Name = "Israel", Name_nl = "Israël", Region = "142", SubRegion = "145", Code = "IL", ShowSubRegion = false, DifficultyLevel = 3 });
            context.Countries.Add(new CountryEntity { CountryId = 135, Name = "Jordan", Name_nl = "Jordanië", Region = "142", SubRegion = "145", Code = "JO", ShowSubRegion = false, DifficultyLevel = 3 });
            context.Countries.Add(new CountryEntity { CountryId = 136, Name = "Saudi Arabia", Name_nl = "Saudi-Arabië", Region = "142", SubRegion = "145", Code = "SA", ShowSubRegion = false, DifficultyLevel = 0 });
            context.Countries.Add(new CountryEntity { CountryId = 137, Name = "Yemen", Name_nl = "Jemen", Region = "142", SubRegion = "145", Code = "YE", ShowSubRegion = false, DifficultyLevel = 4 });
            context.Countries.Add(new CountryEntity { CountryId = 138, Name = "Oman", Name_nl = "Oman", Region = "142", SubRegion = "145", Code = "OM", ShowSubRegion = false, DifficultyLevel = 4 });
            context.Countries.Add(new CountryEntity { CountryId = 139, Name = "United Arab Emirates", Name_nl = "Verenigde Arabische Emiraten", Region = "142", SubRegion = "145", Code = "AE", ShowSubRegion = false, DifficultyLevel = 4 });
            context.Countries.Add(new CountryEntity { CountryId = 140, Name = "Kuwait", Name_nl = "Koeweit", Region = "142", SubRegion = "145", Code = "KW", ShowSubRegion = false, DifficultyLevel = 3 });
            context.Countries.Add(new CountryEntity { CountryId = 141, Name = "Iraq", Name_nl = "Irak", Region = "142", SubRegion = "145", Code = "IQ", ShowSubRegion = false, DifficultyLevel = 2 });
            context.Countries.Add(new CountryEntity { CountryId = 142, Name = "Iran", Name_nl = "Iran", Region = "142", SubRegion = "034", Code = "IR", ShowSubRegion = false, DifficultyLevel = 3 });
            context.Countries.Add(new CountryEntity { CountryId = 143, Name = "Turkmenistan", Name_nl = "Turkmenistan", Region = "142", SubRegion = "143", Code = "TM", ShowSubRegion = false, DifficultyLevel = 4 });
            context.Countries.Add(new CountryEntity { CountryId = 144, Name = "Uzbekistan", Name_nl = "Oezbekistan", Region = "142", SubRegion = "143", Code = "UZ", ShowSubRegion = false, DifficultyLevel = 4 });
            context.Countries.Add(new CountryEntity { CountryId = 145, Name = "Kazakhstan", Name_nl = "Kazachstan", Region = "142", SubRegion = "143", Code = "KZ", ShowSubRegion = false, DifficultyLevel = 4 });
            context.Countries.Add(new CountryEntity { CountryId = 146, Name = "Singapore", Name_nl = "Singapore", Region = "142", SubRegion = "035", Code = "SG", ShowSubRegion = true, DifficultyLevel = 3 });
            context.Countries.Add(new CountryEntity { CountryId = 147, Name = "Kyrgyzstan", Name_nl = "Kirgizië", Region = "142", SubRegion = "143", Code = "KG", ShowSubRegion = false, DifficultyLevel = 4 });
            context.Countries.Add(new CountryEntity { CountryId = 148, Name = "Tajikistan", Name_nl = "Tadzjikistan", Region = "142", SubRegion = "143", Code = "TJ", ShowSubRegion = false, DifficultyLevel = 4 });
            context.Countries.Add(new CountryEntity { CountryId = 149, Name = "Afghanistan", Name_nl = "Afganistan", Region = "142", SubRegion = "034", Code = "AF", ShowSubRegion = false, DifficultyLevel = 2 });
            context.Countries.Add(new CountryEntity { CountryId = 150, Name = "Pakistan", Name_nl = "Pakistan", Region = "142", SubRegion = "034", Code = "PK", ShowSubRegion = false, DifficultyLevel = 3 });
            context.Countries.Add(new CountryEntity { CountryId = 151, Name = "India", Name_nl = "India", Region = "142", SubRegion = "034", Code = "IN", ShowSubRegion = false, DifficultyLevel = 0 });
            context.Countries.Add(new CountryEntity { CountryId = 152, Name = "Sri Lanka", Name_nl = "Sri Lanka", Region = "142", SubRegion = "034", Code = "LK", ShowSubRegion = false, DifficultyLevel = 1 });
            context.Countries.Add(new CountryEntity { CountryId = 153, Name = "Maldives", Name_nl = "Malediven", Region = "142", SubRegion = "034", Code = "MV", ShowSubRegion = true, DifficultyLevel = 3 });
            context.Countries.Add(new CountryEntity { CountryId = 154, Name = "Bangladesh", Name_nl = "Bangladesh", Region = "142", SubRegion = "034", Code = "BD", ShowSubRegion = false, DifficultyLevel = 4 });
            context.Countries.Add(new CountryEntity { CountryId = 155, Name = "Nepal", Name_nl = "Nepal", Region = "142", SubRegion = "034", Code = "NP", ShowSubRegion = false, DifficultyLevel = 3 });
            context.Countries.Add(new CountryEntity { CountryId = 156, Name = "Bhutan", Name_nl = "Bhutan", Region = "142", SubRegion = "034", Code = "BT", ShowSubRegion = false, DifficultyLevel = 4 });
            context.Countries.Add(new CountryEntity { CountryId = 157, Name = "China", Name_nl = "China", Region = "142", SubRegion = "030", Code = "CN", ShowSubRegion = false, DifficultyLevel = 0 });
            context.Countries.Add(new CountryEntity { CountryId = 158, Name = "Mongolia", Name_nl = "Mongolië", Region = "142", SubRegion = "030", Code = "MN", ShowSubRegion = false, DifficultyLevel = 2 });
            context.Countries.Add(new CountryEntity { CountryId = 159, Name = "North Korea", Name_nl = "Noord-Korea", Region = "142", SubRegion = "030", Code = "KP", ShowSubRegion = false, DifficultyLevel = 2 });
            context.Countries.Add(new CountryEntity { CountryId = 160, Name = "South Korea", Name_nl = "Zuid-Korea", Region = "142", SubRegion = "030", Code = "KR", ShowSubRegion = false, DifficultyLevel = 1 });
            context.Countries.Add(new CountryEntity { CountryId = 161, Name = "Japan", Name_nl = "Japan", Region = "142", SubRegion = "030", Code = "JP", ShowSubRegion = false, DifficultyLevel = 0 });
            context.Countries.Add(new CountryEntity { CountryId = 162, Name = "Taiwan", Name_nl = "Taiwan", Region = "142", SubRegion = "030", Code = "TW", ShowSubRegion = false, DifficultyLevel = 2 });
            context.Countries.Add(new CountryEntity { CountryId = 163, Name = "Philippines", Name_nl = "Filipijnen", Region = "142", SubRegion = "035", Code = "PH", ShowSubRegion = false, DifficultyLevel = 1 });
            context.Countries.Add(new CountryEntity { CountryId = 164, Name = "Indonesia", Name_nl = "Indonesië", Region = "142", SubRegion = "035", Code = "ID", ShowSubRegion = false, DifficultyLevel = 0 });
            context.Countries.Add(new CountryEntity { CountryId = 165, Name = "Malaysia", Name_nl = "Maleisië", Region = "142", SubRegion = "035", Code = "MY", ShowSubRegion = false, DifficultyLevel = 2 });
            context.Countries.Add(new CountryEntity { CountryId = 166, Name = "Vietnam", Name_nl = "Vietnam", Region = "142", SubRegion = "035", Code = "VN", ShowSubRegion = false, DifficultyLevel = 1 });
            context.Countries.Add(new CountryEntity { CountryId = 167, Name = "Laos", Name_nl = "Laos", Region = "142", SubRegion = "035", Code = "LA", ShowSubRegion = false, DifficultyLevel = 3 });
            context.Countries.Add(new CountryEntity { CountryId = 168, Name = "Cambodia", Name_nl = "Cambodja", Region = "142", SubRegion = "035", Code = "KH", ShowSubRegion = false, DifficultyLevel = 3 });
            context.Countries.Add(new CountryEntity { CountryId = 169, Name = "Thailand", Name_nl = "Thailand", Region = "142", SubRegion = "035", Code = "TH", ShowSubRegion = false, DifficultyLevel = 1 });
            context.Countries.Add(new CountryEntity { CountryId = 170, Name = "Myanmar", Name_nl = "Myanmar", Region = "142", SubRegion = "035", Code = "MM", ShowSubRegion = false, DifficultyLevel = 4 });
            context.Countries.Add(new CountryEntity { CountryId = 171, Name = "Australia", Name_nl = "Australië", Region = "009", SubRegion = "053", Code = "AU", ShowSubRegion = false, DifficultyLevel = 0 });
            context.Countries.Add(new CountryEntity { CountryId = 172, Name = "New Zealand", Name_nl = "Nieuw-Zeeland", Region = "009", SubRegion = "053", Code = "NZ", ShowSubRegion = false, DifficultyLevel = 0 });
            context.Countries.Add(new CountryEntity { CountryId = 173, Name = "Papua New Guinea", Name_nl = "Papoea-Nieuw-Guinea", Region = "009", SubRegion = "054", Code = "PG", ShowSubRegion = false, DifficultyLevel = 3 });

            base.Seed(context);
        }
    }
}
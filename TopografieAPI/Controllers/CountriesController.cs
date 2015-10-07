using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Hosting;
using System.Web.Http;
using System.Web.Http.Cors;
using System.Xml.Linq;
using TopografieAPI.Models;
using TopografieAPI.Repositories;

namespace TopografieAPI.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class CountriesController : ApiController
    {
        private const int MaxCountryId = 77;

        // GET: api/Countries
        public IEnumerable<Country> Get()
        {
            var countries = new List<Country>();

            var db = new CountriesRepository();
            for (int i = 1; i <= MaxCountryId; i++)
            {
                countries.Add(GetCountry(db, i));
            }
            return countries;

            // return new string[] { "value1", "value2" };
        }

        // GET: api/Countries/5
        public Country Get(int id)
        {
            var db = new CountriesRepository();
            return GetCountry(db, id);
        }

        private Country GetCountry(CountriesRepository db, int id)
        {
            var country = db.Countries.Where(x => x.CountryId == id).FirstOrDefault();

            if (country == null)
                return new Country { Name = "NOT_FOUND", Name_nl = "NOT_FOUND", Region = "", SubRegion = "", Code = "", ShowSubRegion = false, DifficultyLevel = 0 };

            return new Country
            {
                Name = country.Name,
                Name_nl = country.Name_nl,
                Region = country.Region,
                SubRegion = country.SubRegion,
                Code = country.Code,
                ShowSubRegion = country.ShowSubRegion,
                DifficultyLevel = country.DifficultyLevel
            };
        }

    }
}

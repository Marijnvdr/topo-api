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
using TopografieAPI.Entities;

namespace TopografieAPI.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class CountriesController : ApiController
    {
        private const int MaxCountryId = 173;

        // GET: api/Countries
        public IEnumerable<Country> Get(int offset, int limit, string searchTerm)
        {
            var countries = new List<Country>();

            var db = new CountriesRepository();

            var list = (limit > 0) ? db.Countries.OrderBy(c => c.CountryId).Skip(offset).Take(limit) : db.Countries;

            foreach (var item in list)
            {
                countries.Add(MapCountry(item));
            }

            return countries;
        }

        // GET: api/Countries/5
        public Country Get(int id)
        {
            var db = new CountriesRepository();

            var countryEntity = db.Countries.Where(x => x.CountryId == id).FirstOrDefault();

            return MapCountry(countryEntity);
        }

        private Country MapCountry(CountryEntity countryEntity)
        {
            if (countryEntity == null)
                return new Country { Name = "NOT_FOUND", Name_nl = "NOT_FOUND", Region = "", SubRegion = "", Code = "", ShowSubRegion = false, DifficultyLevel = 0 };

            return new Country
            {
                Id = countryEntity.CountryId.ToString(),
                Name = countryEntity.Name,
                Name_nl = countryEntity.Name_nl,
                Region = countryEntity.Region,
                SubRegion = countryEntity.SubRegion,
                Code = countryEntity.Code,
                ShowSubRegion = countryEntity.ShowSubRegion,
                DifficultyLevel = countryEntity.DifficultyLevel
            };
        }



    }
}

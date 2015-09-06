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

namespace TopografieAPI.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class CountriesController : ApiController
    {
        private const int MaxCountryId = 40;

        // GET: api/Countries
        public IEnumerable<Country> Get()
        {
            var countries = new List<Country>();

            XElement root = XElement.Load(HostingEnvironment.MapPath("~/App_Data/CountriesData.xml"));
            for (int i = 1; i <= MaxCountryId; i++)
            {
                countries.Add(GetCountry(root, i));
            }
            return countries;

            // return new string[] { "value1", "value2" };
        }

        // GET: api/Countries/5
        public Country Get(int id)
        {
            XElement root = XElement.Load(HostingEnvironment.MapPath("~/App_Data/CountriesData.xml"));
            return GetCountry(root, id);
        }

        private Country GetCountry(XElement root, int id)
        {
            IEnumerable<XElement> countries =
              from el in root.Elements("Country")
              where (string)el.Element("Id") == id.ToString()
              select el;
            var country = countries.FirstOrDefault();
            if (country == null)
                return new Country { Name = "NOT_FOUND", Name_nl = "NOT_FOUND", Region = "", SubRegion = "", Code = "" };

            return new Country
            {
                Name = (string)country.Element("Name"),
                Name_nl = (string)country.Element("Name_nl"),
                Region = (string)country.Element("Region"),
                SubRegion = (string)country.Element("SubRegion"),
                Code = (string)country.Element("Code")
            };
        }

    }
}

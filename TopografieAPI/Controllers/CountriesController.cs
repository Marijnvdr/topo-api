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
        public CountryViewModel Get(int id)
        {

            XElement root = XElement.Load(HostingEnvironment.MapPath("~/App_Data/CountriesData.xml"));
            IEnumerable<XElement> countries =
              from el in root.Elements("Country")
              where (string)el.Element("Id") == id.ToString()
              select el;
            var country = countries.FirstOrDefault();
            if (country != null)
                return new CountryViewModel { Name = (string)country.Element("Name"), Name_nl = (string)country.Element("Name_nl"), Region = (string)country.Element("Region") };
            else
                return new CountryViewModel { Name = "NOT_FOUND", Name_nl = "NOT_FOUND", Region = "" };
        }
    }
}

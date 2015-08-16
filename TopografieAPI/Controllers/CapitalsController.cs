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
    public class CapitalsController : ApiController
    {
        // GET api/topo/5
        public CapitalViewModel Get(int id)
        {
            
            XElement root = XElement.Load(HostingEnvironment.MapPath("~/App_Data/CapitalsData.xml"));
            IEnumerable<XElement> capitals =
              from el in root.Elements("Capital")
              where (string)el.Element("Id") == id.ToString()
              select el;
            var capital = capitals.FirstOrDefault();
            if (capital != null)
                return new CapitalViewModel { Name = (string)capital.Element("Name") , Country = (string)capital.Element("Country"), Continent = (string)capital.Element("Continent") };
            else
                return new CapitalViewModel { Name = "NOT_FOUND", Continent = "", Country = "" };
        }

    }
}

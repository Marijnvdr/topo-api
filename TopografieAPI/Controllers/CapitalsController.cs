using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using TopografieAPI.Models;

namespace TopografieAPI.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class CapitalsController : ApiController
    {
        // GET api/topo/5
        public CapitalViewModel Get(int id)
        {
            if (id < 2)
            {
                return new CapitalViewModel { /*Id = id.ToString(),*/ Name = "Amsterdam", Continent = "Europa", Country = "Nederland" };
            }
            else
                return new CapitalViewModel { /*Id = id.ToString(),*/ Name = "Parijs", Continent = "Europa", Country = "Frankrijk" };
        }

    }
}

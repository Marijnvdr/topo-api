using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TopografieAPI.Models
{
    public class Country
    {
        public string Name { get; set; }

        public string Name_nl { get; set; }

        public string Region { get; set; }

        public string SubRegion { get; set; }

        public string Code { get; set; }

        public bool ShowSubRegion { get; set; }

        public int DifficultyLevel { get; set; }
    }
}
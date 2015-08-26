using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TopografieAPI.Models
{
    public class QuestionCountryViewModel
    {
        public Country Answer { get; set; }

        public Country[] Choices { get; set; }
    }
}
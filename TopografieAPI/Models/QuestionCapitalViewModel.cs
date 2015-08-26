using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TopografieAPI.Models
{
    public class QuestionCapitalViewModel
    {
        public Capital Answer { get; set; }

        public Capital[] Choices { get; set; }
    }
}
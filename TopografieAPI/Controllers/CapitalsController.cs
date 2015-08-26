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
        private const int MaxCapitalId = 5;

        // GET api/topo/5
        public Capital Get(int id)
        {
            var list = new List<int>() { id };
            var capitals = GetCapitals(list);
            return capitals[0];
        }

        public QuestionCapitalViewModel GetQuestion()
        {
            Random random = new Random();

            List<int> answers = new List<int>();

            // Get answer to question
            var answerId = random.Next(1, MaxCapitalId);
            answers.Add(answerId);

            // Get multiple choice answers
            for (int i = 0; i < 3; i++)
            {
                var id = GetRandomUniqueId(random, answers);
                answers.Add(id);
            }
            var capitals = GetCapitals(answers);

            return  new QuestionCapitalViewModel() { Answer = capitals[0], Choices = capitals };
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id">Answer to the question</param>
        /// <param name="count">Random other answers</param>
        /// <returns></returns>
        private Capital[] GetCapitals(List<int> ids)
        {
            var capitals = new Capital[ids.Count];
            XElement root = XElement.Load(HostingEnvironment.MapPath("~/App_Data/CapitalsData.xml"));
            int i = 0;
            foreach (var id in ids)
            {
                capitals[i] = GetCapital(root, id);
                i++;
            }
            return capitals;
        }

        private Capital GetCapital(XElement root, int id)
        {
            IEnumerable<XElement> capitals =
              from el in root.Elements("Capital")
              where (string)el.Element("Id") == id.ToString()
              select el;
            var capital = capitals.FirstOrDefault();
            if (capital != null)
                return new Capital { Name = (string)capital.Element("Name"), Country = (string)capital.Element("Country"), Continent = (string)capital.Element("Continent") };
            else
                return new Capital { Name = "NOT_FOUND", Continent = "", Country = "" };
        }

        private int GetRandomUniqueId(Random random, List<int> excludeAnswers)
        {
            bool unique = false;
            int answerId = 0;
 
            while (!unique)            
            {
                answerId = random.Next(1, MaxCapitalId);
                unique = !excludeAnswers.Contains(answerId);
            }
            return answerId;
        }
    }
}

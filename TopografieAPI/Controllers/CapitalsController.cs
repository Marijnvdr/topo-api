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
    public class CapitalsController : ApiController
    {
        private const int MaxCapitalId = 7;

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
            var db = new CapitalsRepository();
            int i = 0;
            foreach (var id in ids)
            {
                capitals[i] = GetCapital(db, id);
                i++;
            }
            return capitals;
        }

        private Capital GetCapital(CapitalsRepository db, int id)
        {
            var capital = db.Capitals.Where(x => x.CapitalId == id).FirstOrDefault();
            if (capital == null)
                return new Capital { Name = "NOT_FOUND", Continent = "", Country = "" };

            return new Capital
            {
                Name = capital.Name,
                Country = capital.Country,
                Continent = capital.Continent
            };
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

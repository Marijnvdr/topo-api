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
    public class QuestionCapitalsController : ApiController
    {
        private const int MaxCapitalId = 7;
        private const int NumberOfChoices = 4;

        public QuestionCapitalViewModel Get()
        {
            Random random = new Random();

            List<int> answers = new List<int>();

            // Get answer to question
            var answerId = random.Next(1, MaxCapitalId+1);
            answers.Add(answerId);

            // Get multiple choice answers
            for (int i = 0; i < NumberOfChoices - 1; i++)
            {
                var id = GetRandomUniqueId(random, answers);
                answers.Add(id);
            }
            var capitals = GetCapitals(answers);

            var shuffeledCapitals = GetShuffeledCapitals(random, capitals);

            return new QuestionCapitalViewModel() { Answer = capitals[0], Choices = shuffeledCapitals };
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
                answerId = random.Next(1, MaxCapitalId + 1);
                unique = !excludeAnswers.Contains(answerId);
            }
            return answerId;
        }

        private Capital[] GetShuffeledCapitals(Random random, Capital[] capitals)
        {
            List<int> shuffeled = new List<int>();
            for (int i = 0; i < NumberOfChoices; i++)
            {
                shuffeled.Add(i);
            }
            // Now shuffel
            for (int i = NumberOfChoices; i > 1; i--)
            {
                int k = random.Next(0, i);
                int value = shuffeled[k];
                shuffeled[k] = shuffeled[i - 1];
                shuffeled[i - 1] = value;
            }

            var shuffeledCapitals = new Capital[NumberOfChoices];
            var t = 0;
            foreach (var c in shuffeled)
            {
                shuffeledCapitals[t] = capitals[c];
                t++;
            }
            return shuffeledCapitals;
        }
    }
}

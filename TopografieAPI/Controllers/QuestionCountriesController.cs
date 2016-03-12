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
using TopografieAPI.Entities;

namespace TopografieAPI.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class QuestionCountriesController : ApiController
    {
        private const int MaxCountryId = 173;
        private const int NumberOfChoices = 8;

        public QuestionCountryViewModel Get(int difficultyLevel, string excludeList)
        {
            var excludeCountries = new List<int>();
            if (excludeList != null)
            {
                string[] ar = excludeList.Split(new[] { "," }, StringSplitOptions.RemoveEmptyEntries);
                foreach (var item in ar)
                {
                    excludeCountries.Add(int.Parse(item));
                }
            }

            // ToDo: Take excludeList into account.

            var db = new CountriesRepository();

            var countries = db.Countries.Where(x => x.DifficultyLevel == difficultyLevel).ToArray();

            Random random = new Random();

            List<int> answers = new List<int>();

            // Get answer to question
            var cntry = GetRandomUniqueCountry(random, countries, excludeCountries, true);
            var answerId = cntry.CountryId;
            answers.Add(answerId);
            var region = cntry.Region;
            var subRegion = cntry.SubRegion;

            // Try to get 4 answers from the same region
            var countriesSameSubRegion = db.Countries.Where(x => x.Region == region &&
                                                                 x.SubRegion == subRegion).ToArray();
            if (countriesSameSubRegion.Length <= 4)
            {
                foreach (var c in countriesSameSubRegion)
                {
                    if (c.CountryId != answerId)
                    answers.Add(c.CountryId);
                }
            }
            else
            {
                for (int i = 0; i < 4; i++)
                {
                    var country = GetRandomUniqueCountry(random, countriesSameSubRegion, answers);
                    if (country != null)
                    {
                        answers.Add(country.CountryId);
                    }                    
                }
            }
            // Get other multiple choice answers
            var allCountries = db.Countries.ToArray();
            var answerCount = NumberOfChoices - answers.Count;
            int y= 0;
            while (y < answerCount)
            {
                var country = GetRandomUniqueCountry(random, allCountries, answers);
                if (country != null)
                {
                    answers.Add(country.CountryId);
                    y++;
                }                
            }

            var questionCountries = GetCountries(answers);

            var shuffeledCountries = GetShuffeledCountries(random, questionCountries);

            return new QuestionCountryViewModel() { Answer = questionCountries[0], Choices = shuffeledCountries };
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id">Answer to the question</param>
        /// <param name="count">Random other answers</param>
        /// <returns></returns>
        private Country[] GetCountries(List<int> ids)
        {
            var countries = new Country[ids.Count];
            var db = new CountriesRepository();
            int i = 0;
            foreach (var id in ids)
            {
                countries[i] = GetCountry(db, id);
                i++;
            }
            return countries;
        }

        private Country GetCountry(CountriesRepository db, int id)
        {            
            var country = db.Countries.Where(x => x.CountryId == id).FirstOrDefault();

            if (country == null)
                return new Country { Name = "NOT_FOUND", Name_nl = "NOT_FOUND", Region = "", SubRegion = "", Code = "", ShowSubRegion = false, DifficultyLevel = 0 };

            return new Country
            {
                Id = country.CountryId.ToString(),
                Name = country.Name,
                Name_nl = country.Name_nl,
                Region = country.Region,
                SubRegion = country.SubRegion,
                Code = country.Code,
                ShowSubRegion = country.ShowSubRegion,
                DifficultyLevel = country.DifficultyLevel
            };
        }

        private CountryEntity GetRandomUniqueCountry(Random random, CountryEntity[] countries, List<int> excludeAnswers, bool forceAnswer = false)
        {
            bool unique = false;
            int answerId = -1;
            int tryMax = 100;
            int i = 1;
            CountryEntity country = null; 

            while (!unique && i < tryMax)
            {
                var answerIndex = random.Next(0, countries.Length);
                country = countries[answerIndex];
                answerId = countries[answerIndex].CountryId;
                unique = !excludeAnswers.Contains(answerId);
                i++;
            }

            if (!unique && !forceAnswer)
            {
                answerId = -1;
                country = null;
            }
            return country;
        }

        private Country[] GetShuffeledCountries(Random random, Country[] countries)
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

            var shuffeledCountries = new Country[NumberOfChoices];
            var t = 0;
            foreach (var c in shuffeled)
            {
                shuffeledCountries[t] = countries[c];
                t++;
            }
            return shuffeledCountries;
        }
    }
}

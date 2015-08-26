﻿using System;
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
    public class QuestionCountriesController : ApiController
    {
        private const int MaxCountryId = 7;
        private const int NumberOfChoices = 4;

        public QuestionCountryViewModel Get()
        {
            Random random = new Random();

            List<int> answers = new List<int>();

            // Get answer to question
            var answerId = random.Next(1, MaxCountryId + 1);
            answers.Add(answerId);

            // Get multiple choice answers
            for (int i = 0; i < NumberOfChoices - 1; i++)
            {
                var id = GetRandomUniqueId(random, answers);
                answers.Add(id);
            }
            var countries = GetCountries(answers);

            var shuffeledCountries = GetShuffeledCountries(random, countries);

            return new QuestionCountryViewModel() { Answer = countries[0], Choices = shuffeledCountries };
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
            XElement root = XElement.Load(HostingEnvironment.MapPath("~/App_Data/CountriesData.xml"));
            int i = 0;
            foreach (var id in ids)
            {
                countries[i] = GetCountry(root, id);
                i++;
            }
            return countries;
        }

        private Country GetCountry(XElement root, int id)
        {
            IEnumerable<XElement> countries =
              from el in root.Elements("Country")
              where (string)el.Element("Id") == id.ToString()
              select el;
            var country = countries.FirstOrDefault();
            if (country != null)
                return new Country { Name = (string)country.Element("Name"), Name_nl = (string)country.Element("Name_nl"), Region = (string)country.Element("Region") };
            else
                return new Country { Name = "NOT_FOUND", Name_nl = "NOT_FOUND", Region = "" };
        }

        private int GetRandomUniqueId(Random random, List<int> excludeAnswers)
        {
            bool unique = false;
            int answerId = 0;

            while (!unique)
            {
                answerId = random.Next(1, MaxCountryId + 1);
                unique = !excludeAnswers.Contains(answerId);
            }
            return answerId;
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
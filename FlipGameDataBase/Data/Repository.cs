﻿using System;
using System.Diagnostics;
using FlipGameDataBase.Models;
using FlipGameDataBase.Data.Temps;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;


namespace FlipGameDataBase.Data
{
    public class Repository
    {
        /// <summary>
        /// Private method that returns a database context.
        /// Only to be used within repository
        /// </summary>
        /// <returns>An instance of the Context class.</returns>
        static Context GetContext()
        {
            var context = new Context();
            context.Database.Log = (message) => Debug.WriteLine(message);
            return context;
        }
        /// <summary>
        /// Adds Person to database
        /// </summary>
        /// <param name="person"></param>
        public static void AddPerson(Person person)
        {
            using (Context context = GetContext())
            {
                context.People.Add(person);
                context.SaveChanges();
            }
        }
        /// <summary>
        /// Adds Match to database
        /// </summary>
        /// <param name="match"></param>
        public static void AddMatch(Match match)
        {
            using (Context context = GetContext())
            {
                context.Matches.Add(match);
                context.SaveChanges();
            }
        }
        /// <summary>
        /// Adds PersonsScore to database
        /// </summary>
        /// <param name="personsScore"></param>
        public static void AddPersonsScore(PersonsScore personsScore)
        {
            using (Context context = GetContext())
            {
                context.PersonsScores.Add(personsScore);
                context.SaveChanges();
            }
        }
        /// <summary>
        /// Searches for a persons by string name in the People table 
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public static bool SearchForPerson(string name)
        {
            using (Context context = GetContext())
            {
                var persons = context.People;
                foreach (var person in persons)
                {
                    if (name.ToLower() == person.Name.ToLower())
                    {
                        return true;
                    }
                }
            }
            return false;
        }
        /// <summary>
        /// returns a list of person with all the people in PeopleTable
        /// </summary>
        /// <returns></returns>
        public static List<Person> GetListOfPersons()
        {
            var list = new List<Person>();
            using (Context context = GetContext())
            {
                var persons = context.People;
                foreach (var person in persons)
                {
                    list.Add(person);
                }
            }
            return list;
        }
        /// <summary>
        /// Sorts a game and then adds it to the database with scorePerson aswell
        /// </summary>
        /// <param name="dict"></param>
        public static void AddGameToDataBase(Dictionary<Person, int> dict)
        {
            using (Context context = GetContext())
            {
                Match match = new Match() { PlayedOn = DateTime.Now };
                AddMatch(match);
                int count = 1;
                foreach (var score in dict.OrderBy(key => key.Value))
                {
                    PersonsScore personsScore = new PersonsScore()
                    {
                        MatchId = match.Id,
                        PersonId = score.Key.Id,
                        Score = score.Value,
                        Place = count
                    };
                    AddPersonsScore(personsScore);
                    count++;
                }
            }
        }
        /// <summary>
        /// Returns a Person
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public static Person GetPersonFromName(string name)
        {
            Person personToFind = new Person();
            using (Context context = GetContext())
            {
                var persons = context.People;
                foreach (var person in persons)
                {
                    if (name.ToLower() == person.Name.ToLower())
                    {
                        return person;
                    }
                }
            }
            return personToFind;
        }
        public static List<Temp> GetNumberOfGamesPerPlayer()
        {
            List<Temp> dict = new List<Temp>();
            using (Context context = GetContext())
            {
                var people = context.People;
                var personScores = context.PersonsScores;

                var list = from scores in personScores
                           join person in people on scores.PersonId
                           equals person.Id
                           select new
                           {
                               PersonName = person.Name,
                               Score = scores.Place
                           };


                var newList = from x in list
                              group x by x.PersonName into xGroup
                              select new
                              {
                                  SumOfGames = xGroup.Count(),
                                  Name = xGroup.Key
                              };

                foreach (var x in newList)
                {
                    Temp temp = new Temp() { Name = x.Name, SumOfGames = x.SumOfGames };
                    dict.Add(temp);
                }
            }
            return dict;
        }
        public static PlayerStatistics GetPlayerStatistics(Person person)
        {
            PlayerStatistics player = new PlayerStatistics();
            using (Context context = GetContext())
            {
                var people = context.People;
                var personScores = context.PersonsScores;
                var matches = context.Matches;

                var list = from scores in personScores
                           join x in people on scores.PersonId
                           equals x.Id
                           join y in matches on scores.MatchId
                           equals y.Id
                           select new
                           {
                               PersonName = x.Name,
                               Place = scores.Place,
                               Score = scores.Score
                           };


                var sumOfGamesList = from x in list
                                     group x by x.PersonName into xGroup
                                     select new
                                     {
                                         name = xGroup.Key,
                                         SumOfGames = xGroup.Count(),
                                         TotalScore = xGroup.Sum(c => c.Score),
                                         FirstPlace = xGroup.Count(f=>f.Place == 1),
                                         SecondPlace = xGroup.Count(f=>f.Place == 2),
                                         ThirdPlace = xGroup.Count(f=>f.Place == 3),
                                         FourthPlace = xGroup.Count(f=>f.Place == 4)
                                        
                                     };
                foreach (var x in sumOfGamesList)
                {
                    if(x.name == person.Name)
                    {
                        player.Name = x.name;
                        player.CreatedOn = person.CreatedOn;
                        player.TotalGames = x.SumOfGames;
                        player.TotScore = x.TotalScore;
                        player.FirsPlaceSum = x.FirstPlace;
                        player.SecondPlaceSum = x.SecondPlace;
                        player.ThirdPlaceSum = x.ThirdPlace;
                        player.FourthPlaceSum = x.FourthPlace;
                    }
                }
                return player;
            }
        }
    }
}
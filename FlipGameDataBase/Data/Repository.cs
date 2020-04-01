using System;
using System.Diagnostics;
using FlipGameDataBase.Models;
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
        public static void AddPerson(Person person)
        {
            using (Context context = GetContext())
            {
                context.People.Add(person);
                context.SaveChanges();
            }
        }

        public static void AddMatch(Match match)
        {
            using (Context context = GetContext())
            {
                context.Matches.Add(match);
                context.SaveChanges();
            }
        }
        public static void AddPersonsScore(PersonsScore personsScore)
        {
            using (Context context = GetContext())
            {
                context.PersonsScores.Add(personsScore);
                context.SaveChanges();
            }
        }
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
    }
}

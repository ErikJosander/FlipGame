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

    }
}

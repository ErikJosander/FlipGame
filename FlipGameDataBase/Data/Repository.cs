using System;
using System.Diagnostics;
using FlipGameDataBase.Models;


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
            using(Context context = GetContext())
            {
                context.People.Add(person);
                context.SaveChanges();
            }
        }
        public static bool SearchForPerson(string name)
        {
            using (Context context = GetContext())
            {
                foreach(var person in context.People)
                {
                    if (name.ToLower() == person.Name.ToLower())
                    {
                        return true;
                    }
                    else return false;
                }
            }
            return false;
        }

    }
}

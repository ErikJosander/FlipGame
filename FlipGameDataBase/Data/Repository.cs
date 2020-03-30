using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Data.Entity;
using System.Linq;

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
        /// Seeding Databasewith 100 Spaces if no exist return false
        /// else returns true
        /// </summary>
        /// <returns>An IList collection of ComicBook entity instances.</returns>
        public static bool SeedDatabase()
        {
            using (Context context = GetContext())
            {
                return true;
            }
        }

    }
}

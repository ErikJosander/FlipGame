using System;
using System.Collections.Generic;
using System.Data.Entity;
using FlipGameDataBase.Models;

namespace FlipGameDataBase.Data
{
    class Context : DbContext
    {
        public Context()
        {
            Database.SetInitializer(new DropCreateDatabaseIfModelChanges<Context>());
        }
        public DbSet<Person> People { get; set; }
        public DbSet<Score> Scores { get; set; }

    }
}

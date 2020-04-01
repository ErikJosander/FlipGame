using System;
using System.Collections.Generic;
using System.Data.Entity;


namespace FlipGameDataBase.Models
{
    public class Person : DbContext
    {
        public Person()
        {
            PersonsScores = new List<PersonsScore>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime CreatedOn { get; set; }
        public ICollection<PersonsScore> PersonsScores { get; set; }
    }
}

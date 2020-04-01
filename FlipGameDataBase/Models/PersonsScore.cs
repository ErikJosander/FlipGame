using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;

namespace FlipGameDataBase.Models
{
    public class PersonsScore : DbContext
    {                               
        public int Id { get; set; }
        public int PersonId { get; set; }
        [ForeignKey("PersonId")]
        public Person Person { get; set; }
        public int MatchId { get; set; }
        [ForeignKey("MatchId")]
        public Match Match { get; set; }
        public int Score { get; set; }
        public int Place { get; set; }          
    }
}

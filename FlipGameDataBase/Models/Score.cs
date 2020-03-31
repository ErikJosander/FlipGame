using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlipGameDataBase.Models
{
    public class Score
    {
        public Score()
        {
            People = new List<Person>();
        }
        public int Id { get; set; }
        public DateTime PlayedOn { get; set; }
        public ICollection<Person> People { get; set; }      
    }
}

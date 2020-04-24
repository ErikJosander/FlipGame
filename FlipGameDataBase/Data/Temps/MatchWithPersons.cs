using FlipGameDataBase.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlipGameDataBase.Data.Temps
{
    public class MatchWithPersons
    {
        public List<TempPerson> PeoplePlaceScore { get; set; } = new List<TempPerson>();
        public DateTime PlayedOn { get; set; }
    }
}

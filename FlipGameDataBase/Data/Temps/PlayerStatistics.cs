using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlipGameDataBase.Data.Temps
{
    public class PlayerStatistics
    {
        public string Name { get; set; }
        public DateTime CreatedOn { get; set; }
        public int TotalGames { get; set; }
        public int TotScore { get; set; }
        public int FirsPlaceSum { get; set; }
        public int SecondPlaceSum { get; set; }
        public int ThirdPlaceSum { get; set; }
        public int FourthPlaceSum { get; set; }
    }
}

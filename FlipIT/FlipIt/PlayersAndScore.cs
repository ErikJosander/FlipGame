using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlipIt
{
    public class PlayersAndScore
    {
        public string Name { get; set; }
        public int Score { get; set; }
        public string Display
        {
            get
            {
                var output = $"Player:{this.Name} - Score:{Score}";                   
                return output;
            }
        }
    }
}

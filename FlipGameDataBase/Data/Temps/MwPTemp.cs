using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlipGameDataBase.Data.Temps
{
    public class TempPerson
    {
        public string Name { get; set; }
        public int Place { get; set; }
        public int Score { get; set; }
        public string Display
        {
            get
            {
                var output = $"Player:{this.Name} - Place: {Place} - Score:{Score}";
                return output;
            }
        }
    }
}

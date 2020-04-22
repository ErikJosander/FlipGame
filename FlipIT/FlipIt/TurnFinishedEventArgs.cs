using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlipIt
{
    public class TurnFinishedEventArgs : EventArgs
    {
        public List<int> AvailibleNumbers { get; set; }
    }
}

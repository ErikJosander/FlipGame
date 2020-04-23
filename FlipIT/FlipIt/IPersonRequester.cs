using FlipGameDataBase.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlipIt
{
    public interface IPersonRequester
    {
        void PersonComplete(Person p);
    }
}

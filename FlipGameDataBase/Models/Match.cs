﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlipGameDataBase.Models
{
    public class Match : DbContext
    {      
        public Match()
        {
            PersonsScores = new List<PersonsScore>();
        }
        public int Id { get; set; }
        public DateTime PlayedOn { get; set; }     
        public ICollection<PersonsScore> PersonsScores { get; set; }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApplicationCore.Entities
{
    [Table(name:"MovieCrew")]
    public class MovieCrew
    {
        public int MovieId { get; set; }
        public int CrewId { get; set; }
        [MaxLength(128)]
        public string Department { get; set; }
        [MaxLength(128)]
        public string Job { get; set; }

        public Movie Movie { get; set; }
        public Crew Crew { get; set; }
    }
}

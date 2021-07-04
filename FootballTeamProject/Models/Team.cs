using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FootballTeamProject.Models
{
    public class Team
    {

        [Key]
        public int id { get; set; }
        public string Name { get; set; }
        public int Since { get; set; }
        public string Country { get; set; }
        public int Budget { get; set; }
        public int Salary { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace FootballTeamProject.Models
{
    public class Context:DbContext
    {
        public DbSet<Team> Teams { get; set; }
    }
}
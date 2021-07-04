using FootballTeamProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
namespace FootballTeamProject.Controllers
{
    public class TeamController : Controller
    {
        // GET: Team
        Context c = new Context();
        public ActionResult Index()
        {
            var t = c.Teams.ToList();
            return View(t);
        }

        [HttpGet]
        public ActionResult AddNewTeam()
        {
            return View();

        }
        [HttpPost]
        public ActionResult AddNewTeam(Team t)
        {
            c.Teams.Add(t);
            c.SaveChanges();
            return View();

        }

        public ActionResult DeleteTeam(int id)
        {
            var x = c.Teams.Find(id);
            c.Teams.Remove(x);
            c.SaveChanges();
            return View("Index");
        }

        [HttpGet]
        public ActionResult UpdateTeam(int id)
        {
            var x = c.Teams.Find(id);
            return View("UpdateTeam",x);

        }
        [HttpPost]
        public ActionResult UpdateTeam(Team t)
        {
            var x = c.Teams.Find(t.id);
            x.Name = t.Name;
            x.Since = t.Since;
            x.Country = t.Country;
            x.Budget = t.Budget;
            x.Salary = t.Salary;
            c.SaveChanges();
            return RedirectToAction("Index");

        }
        public ActionResult Me()
        {
            return View("");
        }

    }
}
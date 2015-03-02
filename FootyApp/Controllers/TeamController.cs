using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Threading.Tasks;
using System.Web.Mvc;
using FootApi.Models;
using FootyApp.Repository;

namespace FootyApp.Controllers
{
    public class TeamController : Controller
    {
        // GET: Team
        public ActionResult Index()
        {
            IEnumerable<Team> teams = FootyApi.GetLeagueTeams();
            return View(teams);
        }

        // GET: Team/Details/5
        public ActionResult Details(int id)
        {
            Team team = FootyApi.GetLeagueTeam(id);
            return View(team);
        }

        // GET: Team/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Team/Create
        [HttpPost]
        public ActionResult Create(Team team)
        {
            try
            {
                FootyApi.AddLeagueTeam(team);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Team/Edit/5
        public ActionResult Edit(int id)
        {
            Team team = FootyApi.GetLeagueTeam(id);
            return View(team);
        }

        // POST: Team/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, Team team)
        {
            try
            {
                FootyApi.UpdateLeagueTeam(team);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Team/Delete/5
        public ActionResult Delete(int id)
        {
            Team team = FootyApi.GetLeagueTeam(id);
            return View(team);
        }

         //POST: Team/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, Team team)
        {
            try
            {
                FootyApi.DeleteLeagueTeam(id);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}

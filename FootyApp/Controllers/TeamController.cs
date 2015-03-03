using System.Collections.Generic;
using System.Web.Mvc;
using FootyApi.Models;
using FootyApp.Repository;

namespace FootyApp.Controllers
{
    public class TeamController : Controller
    {
        // GET: Team
        public ActionResult Index()
        {
            IEnumerable<Team> teams = FootyApiService.GetLeagueTeams();
            return View(teams);
        }

        // GET: Team/Details/5
        public ActionResult Details(int id)
        {
            Team team = FootyApiService.GetLeagueTeam(id);
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
                FootyApiService.AddLeagueTeam(team);

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
            Team team = FootyApiService.GetLeagueTeam(id);
            return View(team);
        }

        // POST: Team/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, Team team)
        {
            try
            {
                FootyApiService.UpdateLeagueTeam(team);

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
            Team team = FootyApiService.GetLeagueTeam(id);
            return View(team);
        }

         //POST: Team/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, Team team)
        {
            try
            {
                FootyApiService.DeleteLeagueTeam(id);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}

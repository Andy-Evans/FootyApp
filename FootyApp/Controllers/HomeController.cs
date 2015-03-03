using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using FootyApi.Models;


namespace FootyApp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult League()
        {
            ViewBag.Message = "Your League Page.";
//            AddLeageTeam();
//            GetLeagueTeams();
            return View();
        }

        [HttpPost]
        public ActionResult Create()
        {
            ViewBag.Message = "Your League Page.";
            //            AddLeageTeam();
            //            GetLeagueTeams();
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        private static async Task GetLeagueTeams()
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:55031/");
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                // HTTP GET
                HttpResponseMessage response = await client.GetAsync("api/league");
                if (response.IsSuccessStatusCode)
                {
                    var teams = await response.Content.ReadAsAsync<IEnumerable<Team>>();

                    var count = teams.Count();
                }

//                // HTTP POST
//                var gizmo = new Product() {Name = "Gizmo", Price = 100, Category = "Widget"};
//                response = await client.PostAsJsonAsync("api/products", gizmo);
//                if (response.IsSuccessStatusCode)
//                {
//                    Uri gizmoUrl = response.Headers.Location;
//
//                    // HTTP PUT
//                    gizmo.Price = 80; // Update price
//                    response = await client.PutAsJsonAsync(gizmoUrl, gizmo);
//
//                    // HTTP DELETE
//                    response = await client.DeleteAsync(gizmoUrl);
//                }
            }
        }

        private static async Task AddLeageTeam()
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:55031/");
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                // HTTP POST
                var gizmo = new Team{Id = 1,Name = "Gizmo",PostCode= "abc 123"};
                HttpResponseMessage response = await client.PostAsJsonAsync("api/league", gizmo);
            }
        }
    }
}
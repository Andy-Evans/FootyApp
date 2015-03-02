using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Web;
using FootApi.Models;
using Newtonsoft.Json;

namespace FootyApp.Repository
{
    public class FootyApi
    {
        public static IEnumerable<Team> GetLeagueTeams()
        {
            using (WebClient webClient = new WebClient())
            {
                return JsonConvert.DeserializeObject<List<Team>>(
                    webClient.DownloadString("http://localhost:55031/api/league"));
            }
        }

        public static async Task<HttpResponseMessage> AddLeagueTeam(Team team)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:55031/");
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                // HTTP POST
                HttpResponseMessage response = await client.PostAsJsonAsync("api/league", team);

                return response;
            }
        }

        public static async Task<HttpResponseMessage> DeleteLeagueTeam(int id)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:55031/");

                // HTTP POST
                HttpResponseMessage response = await client.DeleteAsync("api/league/" + id);

                return response;
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
            //                    response = await client.DeleteAsync("http://localhost:55031/api/league/"+id);
            //                }
        }

        internal static Team GetLeagueTeam(int id)
        {
            using (WebClient webClient = new WebClient())
            {
                return JsonConvert.DeserializeObject<Team>(
                    webClient.DownloadString("http://localhost:55031/api/league/" + id));
            }
        }

        public static async Task<HttpResponseMessage> UpdateLeagueTeam(Team team)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:55031/");
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                // HTTP PUT
                HttpResponseMessage response = await client.PutAsJsonAsync("api/league/" + team.Id, team);

                return response;
            }
        }
    }
}
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
        private const string webapi = "http://localhost:55031/";

        public static IEnumerable<Team> GetLeagueTeams()
        {
            using (WebClient webClient = new WebClient())
            {
                return JsonConvert.DeserializeObject<List<Team>>(
                    webClient.DownloadString(webapi + "api/league"));
            }
        }

        public static async Task<HttpResponseMessage> AddLeagueTeam(Team team)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(webapi);
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
                client.BaseAddress = new Uri(webapi);

                // HTTP POST
                HttpResponseMessage response = await client.DeleteAsync("api/league/" + id);

                return response;
            }
        }

        internal static Team GetLeagueTeam(int id)
        {
            using (WebClient webClient = new WebClient())
            {
                return JsonConvert.DeserializeObject<Team>(
                    webClient.DownloadString(webapi + "api/league/" + id));
            }
        }

        public static async Task<HttpResponseMessage> UpdateLeagueTeam(Team team)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(webapi);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                // HTTP PUT
                HttpResponseMessage response = await client.PutAsJsonAsync("api/league/" + team.Id, team);

                return response;
            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Web;
using System.Web.ApplicationServices;
using System.Web.Compilation;
using FootApi.Models;
using Newtonsoft.Json;

namespace FootyApp.Repository
{
    public class FootyApi
    {
        private static string GetFootyApiUrl()
        {
            return System.Configuration.ConfigurationManager.AppSettings["FootyAppWebApi"];
        }

        public static IEnumerable<Team> GetLeagueTeams()
        {
            using (WebClient webClient = new WebClient())
            {
                return JsonConvert.DeserializeObject<List<Team>>(
                    webClient.DownloadString(GetFootyApiUrl() + "api/league"));
            }
        }

        public static async Task<HttpResponseMessage> AddLeagueTeam(Team team)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(GetFootyApiUrl());
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
                client.BaseAddress = new Uri(GetFootyApiUrl());

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
                    webClient.DownloadString(GetFootyApiUrl() + "api/league/" + id));
            }
        }

        public static async Task<HttpResponseMessage> UpdateLeagueTeam(Team team)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(GetFootyApiUrl());
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                // HTTP PUT
                HttpResponseMessage response = await client.PutAsJsonAsync("api/league/" + team.Id, team);

                return response;
            }
        }
    }
}
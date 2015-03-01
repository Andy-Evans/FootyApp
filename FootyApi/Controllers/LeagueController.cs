using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Web.Http;
using FootApi.Models;

namespace FootApi.Controllers
{
    public class LeagueController : ApiController
    {
        // GET: api/league
        [HttpGet]
        public IEnumerable<Team> GetAllTeams()
        {
            return new LeagueRepository().GetAllTeams();
        }

        // GET: api/league/5
        [HttpGet]
        public HttpResponseMessage GetTeam(int teamId)
        {
            var team = new LeagueRepository().GetTeam(teamId);
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, team);
            return response;
        }

        // POST: api/league
        [HttpPost]
        public void AddNewTeamToLeague(Team team)
        {
            new LeagueRepository().Add(team);
        }

        // PUT: api/league/5
        [HttpPut]
        public void UpdateTeamInLeague(int id, [FromBody]Team team)
        {
            new LeagueRepository().Update(team);
        }

        // DELETE: api/league/5
        [HttpDelete]
        public void DeleteTeam(int teamId)
        {
            new LeagueRepository().Delete(teamId);
        }
    }
}

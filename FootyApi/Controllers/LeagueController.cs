using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using FootApi.Controllers;
using FootyApi.Models;

namespace FootyApi.Controllers
{
    public class LeagueController : ApiController
    {
        // GET: api/league
        [HttpGet]
        [Route("api/league")]
        public IEnumerable<Team> GetAllTeams()
        {
            return new LeagueRepository().GetAllTeams();
        }

        // POST: api/league
        [HttpPost]
        [Route("api/league")]
        public void AddNewTeamToLeague(Team team)
        {
            new LeagueRepository().Add(team);
        }

        // GET: api/league/5
        [HttpGet]
        [Route("api/league/{teamId}")]
        public HttpResponseMessage GetTeam(int teamId)
        {
            var team = new LeagueRepository().GetTeam(teamId);
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, team);
            return response;
        }

        // PUT: api/league/5
        [HttpPut]
        [Route("api/league/{teamId}")]
        public void UpdateTeamInLeague(int teamId, [FromBody]Team team)
        {
            team.Id = teamId;
            new LeagueRepository().Update(team);
        }

        // DELETE: api/league/5
        [HttpDelete]
        [Route("api/league/{teamId}")]
        public void DeleteTeam(int teamId)
        {
            new LeagueRepository().Delete(teamId);
        }
    }
}

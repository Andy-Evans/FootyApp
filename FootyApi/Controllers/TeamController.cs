using System.Net;
using System.Net.Http;
using System.Web.Http;
using FootApi.Controllers;
using FootyApi.Domain;
using FootyApi.Models;

namespace FootyApi.Controllers
{
    public class TeamController : ApiController
    {
        // GET: api/league/5/team
        [HttpGet]
        [Route("api/league/{teamId}/team")]
        public HttpResponseMessage GetTeamPlayers(int teamId)
        {
            var httpResponseMessage = Request.CreateResponse(HttpStatusCode.OK, new[]
            {
                new LeagueService().GetTeamPlayers(teamId)
            });

            return httpResponseMessage;
        }
//
//        // GET: api/league/5/team/5
//        [HttpGet]
//        public string GetPlayer(int teamId, int playerId)
//        {
//            return "value";
//        }
//
        // POST: api/Team/5/Player
        [Route("api/league/{teamId}/team")]
        public void Post(int teamId, [FromBody]Player player)
        {
            new LeagueService().AddPlayerToTeam(teamId, player);
        }
//
//        // PUT: api/Team/5/Player/5
//        public void Put(int id, [FromBody]string value)
//        {
//        }
//
//        // DELETE: api/Team/5
//        public void Delete(int id)
//        {
//        }
    }
}

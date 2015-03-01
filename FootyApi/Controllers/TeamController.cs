using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using FootApi.Models;

namespace FootApi.Controllers
{
    public class TeamController : ApiController
    {
        // GET: api/league/5/team
        [HttpGet]
        public HttpResponseMessage GetTeamPlayers(int teamId)
        {
            var httpResponseMessage = Request.CreateResponse(HttpStatusCode.OK, new []
            {
                new Player(1,"Thomas","Andrews",new DateTime(2010,2,20)),
                new Player(2,"Simon","Jones",new DateTime(2009,4,2)),
                new Player(3,"Fred","Parker",new DateTime(2010,6,5)),
                new Player(4,"Charles","Smith",new DateTime(2008,1,2)),
                new Player(5,"William","Chester",new DateTime(2009,11,15))
            });

            return httpResponseMessage;
        }

        // GET: api/league/5/team/5
        [HttpGet]
        public string GetPlayer(int teamId, int playerId)
        {
            return "value";
        }

        // POST: api/Team/5/Player
        public void Post(int teamId, [FromBody]Player player)
        {
            new LeagueRepository().AddPlayerToTeam(teamId, player);
        }

        // PUT: api/Team/5/Player/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Team/5
        public void Delete(int id)
        {
        }
    }
}

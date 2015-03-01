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
        // GET: api/Team
        public IEnumerable<Team> Get()
        {
            return new Team[] { new Team(1,"Tarvin AFC",1), new Team(2, "Sandbach",2)};
        }

        // GET: api/Team/5
        public Team Get(int id)
        {
            return new Team(1, "Tarvin AFC", 4);
        }

        // POST: api/Team
        public void Post([FromBody]Team team)
        {
            new TeamRepository().Add(team);
        }

        // PUT: api/Team/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Team/5
        public void Delete(int id)
        {
        }
    }

    public interface ITeamRepository
    {
        void Add(Team team);
    }

    public class TeamRepository : ITeamRepository
    {
        public void Add(Team team)
        {
            throw new NotImplementedException();
        }
    }
}

using System.Collections.Generic;
using FootApi.Models;

namespace FootApi.Controllers
{
    public class LeagueRepository
    {
        private static League league;

        public LeagueRepository()
        {
            if (league == null)
                league = new League();
        }

        public int Add(Team team)
        {
            return league.AddTeam(team);
        }

        public void Update(Team team)
        {
            league.UpdateTeam(team);
        }

        public void Delete(int teamId)
        {
            league.DeleteTeam(teamId);
        }

        public IEnumerable<Team> GetAllTeams()
        {
            return league.GetAllTeams();
        }

        public object GetTeam(int teamId)
        {
            return league.GetTeam(teamId);
        }

        public void AddPlayerToTeam(int teamId, Player player)
        {
        }
    }
}
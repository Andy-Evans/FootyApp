using System.Collections.Generic;
using System.Linq;
using FootApi.Models;

namespace FootApi.Controllers
{
    public class League
    {
        private List<Team> teams;

        public League()
        {
            if (teams == null)
                teams = new List<Team>();
        }

        public int AddTeam(Team team)
        {
            team = new Team
            {
                Id = teams.Count + 1,
                Name = team.Name,
                PostCode = team.PostCode,
                PitchType = team.PitchType,
                ContactName = team.ContactName,
                ContactNumber = team.ContactNumber
            };
         
            teams.Add(team);
            return team.Id;
        }

        public void UpdateTeam(Team team)
        {
            var teamInList = teams.Find(f => f.Id == team.Id);
            teams.Remove(teamInList);
            teams.Add(team);
        }

        public IEnumerable<Team> GetAllTeams()
        {
            return teams;
        }

        public void DeleteTeam(int teamId)
        {
            var teamToRemove = teams.Find(team => team.Id == teamId);

            if (teamToRemove != null)
            {
                teams.Remove(teamToRemove);
            }
        }

        public Team GetTeam(int teamId)
        {
            return teams.FirstOrDefault(team => team.Id == teamId);
        }
    }
}
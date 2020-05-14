using SkarbKibica.API.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SkarbKibica.API.Services
{
    public interface ITeamRepository
    {
        IEnumerable<Team> GetTeams();
        Team GetTeam(int TeamId);
        void AddTeam(Team team);
        void UpdateTeam(Team team);
        void DeleteTeam(Team team);
    }
}

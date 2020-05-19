using SkarbKibica.API.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SkarbKibica.API.Services
{
    public interface ITeamSquadsRepository
    {
        IEnumerable<TeamSquad> GetTeamSquads();
        TeamSquad GetTeamSquad(int teamSquadId);
        void AddTeamSquad(TeamSquad teamSquad);
        void UpdateTeamSquad(TeamSquad teamSquad);
        void DeleteTeamSquad(TeamSquad teamSquad);
        void Compleate();
    }
}

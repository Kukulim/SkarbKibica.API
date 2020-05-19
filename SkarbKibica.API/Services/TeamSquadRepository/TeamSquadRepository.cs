using SkarbKibica.API.DbContexts;
using SkarbKibica.API.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SkarbKibica.API.Services
{
    public class TeamSquadRepository : ITeamSquadsRepository
    {
        private readonly SkarbKibicaDbContext context;

        public TeamSquadRepository(SkarbKibicaDbContext _context)
        {
            context = _context;
        }
        public void AddTeamSquad(TeamSquad teamSquad)
        {
            throw new NotImplementedException();
        }

        public void Compleate()
        {
            throw new NotImplementedException();
        }

        public void DeleteTeamSquad(TeamSquad teamSquad)
        {
            throw new NotImplementedException();
        }

        public TeamSquad GetTeamSquad(int teamSquadId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TeamSquad> GetTeamSquads(int teamId)
        {
            throw new NotImplementedException();
        }

        public void UpdateTeamSquad(TeamSquad teamSquad)
        {
            throw new NotImplementedException();
        }
    }
}

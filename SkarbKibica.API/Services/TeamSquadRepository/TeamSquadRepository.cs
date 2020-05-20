using Microsoft.EntityFrameworkCore;
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
        public void AddTeamSquad(int teamId, TeamSquad teamSquad)
        {
            if (teamSquad == null)
            {
                throw new ArgumentNullException(nameof(teamSquad));
            }
            teamSquad.TeamId = teamId;
            context.TeamSquads.Add(teamSquad);
        }

        public void Compleate()
        {
            context.SaveChanges();
        }

        public void DeleteTeamSquad(TeamSquad teamSquad)
        {
            context.TeamSquads.Remove(teamSquad);
        }

        public TeamSquad GetTeamSquad(int teamId, int teamSquadId)
        {
            return context.TeamSquads.Where(t => t.TeamId == teamId && t.Id == teamSquadId).FirstOrDefault();
        }

        public IEnumerable<TeamSquad> GetTeamSquads(int teamId)
        {
            return context.TeamSquads.Where(t => t.TeamId == teamId).ToList();
        }

        public void UpdateTeamSquad(TeamSquad teamSquad)
        {
            context.Entry(teamSquad).State = EntityState.Modified;
        }
    }
}

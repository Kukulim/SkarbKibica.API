using Microsoft.EntityFrameworkCore;
using SkarbKibica.API.DbContexts;
using SkarbKibica.API.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SkarbKibica.API.Services
{
    public class TeamRepository : ITeamRepository
    {
        private readonly SkarbKibicaDbContext context;

        public TeamRepository(SkarbKibicaDbContext _context)
        {
            this.context = _context;
        }

        public void AddTeam(Team team)
        {
            context.Teams.Add(team);
        }

        public void Compleate()
        {
            context.SaveChanges();
        }

        public void DeleteTeam(Team team)
        {
            throw new NotImplementedException();
        }

        public Team GetTeam(int TeamId)
        {
            return context.Teams.Include(s => s.Stadium).Where(t => t.Id == TeamId).FirstOrDefault();
        }

        public IEnumerable<Team> GetTeams()
        {
            return context.Teams.Include(s => s.Stadium).OrderBy(t => t.Name).ToList();
        }

        public void UpdateTeam(Team team)
        {
            context.Entry(team).State = EntityState.Modified;
        }
    }
}
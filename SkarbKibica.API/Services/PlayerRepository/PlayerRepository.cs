using Microsoft.EntityFrameworkCore;
using SkarbKibica.API.DbContexts;
using SkarbKibica.API.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SkarbKibica.API.Services
{
    public class PlayerRepository : IPlayerRepository
    {
        private readonly SkarbKibicaDbContext context;

        public PlayerRepository(SkarbKibicaDbContext _context)
        {
            context = _context;
        }
        public void AddPlayer(int teamSquadId, Player player)
        {
            if (player == null)
            {
                throw new ArgumentNullException(nameof(player));
            }
            player.TeamSquadId = teamSquadId;
            context.Players.Add(player);
        }

        public void Compleate()
        {
            context.SaveChanges();
        }

        public void DeletePlayer(Player player)
        {
            if (player == null)
            {
                throw new ArgumentNullException(nameof(player));
            }
            context.Players.Remove(player);
        }

        public Player GetPlayer(int teamSquadId, int playerId)
        {
            return context.Players.Where(p => p.Id == playerId && p.TeamSquadId == teamSquadId).FirstOrDefault();
        }

        public IEnumerable<Player> GetPlayers(int teamSquadId)
        {
            return context.Players.Where(p => p.TeamSquadId == teamSquadId).ToList();
        }

        public void UpdatePlayer(Player player)
        {
            context.Entry(player).State = EntityState.Modified;
        }
    }
}

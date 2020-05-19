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
        public void AddPlayer(Player Player)
        {
            throw new NotImplementedException();
        }

        public void Compleate()
        {
            throw new NotImplementedException();
        }

        public void DeletePlayer(Player Player)
        {
            throw new NotImplementedException();
        }

        public Player GetPlayer(int PlayerId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Player> GetPlayers()
        {
            throw new NotImplementedException();
        }

        public void UpdatePlayer(Player Player)
        {
            throw new NotImplementedException();
        }
    }
}

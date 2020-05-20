using SkarbKibica.API.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SkarbKibica.API.Services
{
    public interface IPlayerRepository
    {
        IEnumerable<Player> GetPlayers(int teamSquadId);
        Player GetPlayer(int teamSquadId, int playerId);
        void AddPlayer(int teamSquadId, Player player);
        void UpdatePlayer(Player player);
        void DeletePlayer(Player player);
        void Compleate();
    }
}

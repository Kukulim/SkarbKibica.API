using SkarbKibica.API.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SkarbKibica.API.Services
{
    interface IPlayerRepository
    {
        IEnumerable<Player> GetPlayers();
        Player GetPlayer(int PlayerId);
        void AddPlayer(Player Player);
        void UpdatePlayer(Player Player);
        void DeletePlayer(Player Player);
        void Compleate();
    }
}

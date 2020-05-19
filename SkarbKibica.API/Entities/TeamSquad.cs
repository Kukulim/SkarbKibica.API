using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SkarbKibica.API.Entities
{
    public class TeamSquad
    {
        public int Id { get; set; }

        public int Season { get; set; }

        public int TeamId { get; set; }

        public ICollection<Player> Players { get; set; }
            = new List<Player>();

    }
}

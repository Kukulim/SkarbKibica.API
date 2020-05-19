using SkarbKibica.API.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SkarbKibica.API.Dtos.TeamSquadsDtos
{
    public class TeamSquadDto
    {
        public int Id { get; set; }
        public int Season { get; set; }

        public int TeamId { get; set; }
    }
}

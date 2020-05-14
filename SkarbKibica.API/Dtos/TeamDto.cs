using SkarbKibica.API.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SkarbKibica.API.Dtos
{
    public class TeamDto
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public int Created { get; set; }

        public string ClubColors { get; set; }

        public StadiumDto Stadium { get; set; }
    }
}

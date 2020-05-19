using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SkarbKibica.API.Entities
{
    public class TeamSquad
    {
        [Key]
        public int Id { get; set; }

        public int Season { get; set; }
        [Required]
        public int TeamId { get; set; }

        public Team Team { get; set; }

        public ICollection<Player> Players { get; set; }
            = new List<Player>();

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SkarbKibica.API.Dtos.PlayerDtos
{
    public class PlayerCreationDto
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
    }
}

using System.ComponentModel.DataAnnotations;

namespace SkarbKibica.API.Dtos
{
    public class TeamCreationDto
    {
        [Required]
        [MaxLength(100)]
        public string Name { get; set; }

        [Required]
        public int Created { get; set; }

        [Required]
        [MaxLength(50)]
        public string ClubColors { get; set; }

        public StadiumCreationDto Stadium { get; set; }
    }
}